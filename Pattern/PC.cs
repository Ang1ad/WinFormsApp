using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Pattern
{
    public class PC
    {
        public string PSU { get; set; }
        public string GPU { get; set; }
        public string CPU { get; set; }
        public string Motherboard { get; set; }
        public string RAM { get; set; }
        public string ROM { get; set; }
        public override string ToString() =>
            new StringBuilder()
                .Append(PSU)
                .Append(GPU)
                .Append(CPU)
                .Append(Motherboard)
                .Append(RAM)
                .Append(ROM)
                .ToString();
    }
}
