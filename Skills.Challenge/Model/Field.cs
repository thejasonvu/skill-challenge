using System;
using System.Collections.Generic;
using System.Text;

namespace Skills.Challenge
{
    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }
        public bool Visible { get; set; }
        public int Order { get; set; }
    }
}
