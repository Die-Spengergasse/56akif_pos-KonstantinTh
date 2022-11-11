using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class TextPost : Post
    {
        public string? Content { get; set; } = default;


        public int Length
        {
            get { return Content?.Length ?? 0; }
        }

        public override string Html { get { return $"<h1>{Title}</h1><p>{Content ?? throw new ArgumentNullException("Content war NULL!")}</p>"; } }


        public TextPost(string title) : base(title)
        {}

        public TextPost(string title, string? content) : base(title)
        {}

    }
}
