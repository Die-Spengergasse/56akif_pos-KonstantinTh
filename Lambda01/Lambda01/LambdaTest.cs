using System;
using System.Runtime.CompilerServices;

public class LambdaTest
{
    /// <summary>
    /// Konvertiert jedes Element des übergebenen Arrays anhand der übergebenen Funktion.
    /// </summary>
    /// <param name="values">Wertearray</param>
    /// <param name="converterFunc">Funktion, die den Wert konvertiert</param>
    /// <returns>Array mit den konvertierten Werten.</returns>
    public static decimal[] Converter(decimal[] values, Func<decimal,decimal> converterFunc)
    {
        if (values == null) { return new decimal[0]; }

        decimal[] result = new decimal[values.Length];
        int i = 0;
        foreach (decimal value in values)
        {
            result[i++] = converterFunc(value);
        }
        return result;
    }

    /// <summary>
    /// Führt einen Befehl für jedes Element des übergebenen Arrays aus.
    /// </summary>
    /// <param name="values">Wertearray</param>
    /// <param name="action">Funktion, die ausgeführt wird.</param>
    public static void ForEach(decimal[] values, Action<decimal> action)
    {
        foreach (decimal value in values)
        {
            action(value);
        }
    }

    /// <summary>
    /// Führt eine übergebene Operation mit den ersten 2 Argumenten aus.
    /// </summary>
    /// <param name="x">1. Zahl</param>
    /// <param name="y">2. Zahl</param>
    /// <param name="operation">Funktion mit der arithmetischen Operation</param>
    /// <returns></returns>
    public static decimal ArithmeticOperation(decimal x, decimal y, Func<decimal,decimal,decimal> operation)
    {
        return operation(x, y);
    }

    /// <summary>
    /// Führt eine übergebene Operation mit den ersten 2 Argumenten aus. Schlägt diese Fehl, wird
    /// die Fehlermeldung der Exception der logFunction übergeben.
    /// </summary>
    /// <param name="x">1. Zahl</param>
    /// <param name="y">2. Zahl</param>
    /// <param name="operation">Funktion mit der arithmetischen Operation</param>
    /// <param name="logFunction">Funktion, die die Fehlermeldung weiterverarbeitet.</param>
    /// <returns></returns>
    public static decimal ArithmeticOperation(decimal x, decimal y,
        Func<decimal,decimal,decimal> operation,
        Action<string> logFunction)
    {
        try
        {
            return operation(x, y);
        }
        catch (Exception e)
        {
            logFunction(e.Message);
        }
        return 0;
    }


    /// <summary>
    /// Ruft die übergebene Funktion auf.
    /// </summary>
    /// <param name="command">Die Funktion, die aufgerufen werden soll.</param>
    public static void RunCommand(Action command)
    {
        command();
    }

    /// <summary>
    /// Gibt nur jene Elemente zurück, bei denen die übergebene filterFunction true liefert.
    /// </summary>
    /// <param name="values">Array von Werten.</param>
    /// <param name="filterFunction">Filterfunktion</param>
    /// <returns></returns>
    public static decimal[] Filter(decimal[] values, Func<decimal,bool> filterFunction)
    {
        List<decimal> result = new List<decimal>();
        foreach (decimal value in values)
        {
            if (filterFunction(value))
            {
                result.Add(value);
            }
        }
        return result.ToArray();
    }
}