using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Fundamentals
{
    // Markdown syntax
    // https://www.markdownguide.org/basic-syntax/  
    public class MarkdownFormatter
    {
        public string FormatAsBold(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException();
            }

            return $"**{content}**";
        }
    }
}
