using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnipIt.Common.Enums;

namespace SnipIt.Common.Models
{
    public class Snippet
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Languages Language { get; set; } = Languages.None;
        public string Code { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
    }
}
