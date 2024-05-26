using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Pattern
{
    public class PCDirector
    {
        private IPCBuilder _builder;
        public PCDirector(IPCBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildMotherboard();
            _builder.BuildPSU();
            _builder.BuildROM();
            _builder.BuildRAM();
            _builder.BuildGPU();
            _builder.BuildCPU();
        }
    }
}
