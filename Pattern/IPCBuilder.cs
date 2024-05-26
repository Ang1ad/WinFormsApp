using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Pattern
{
    public interface IPCBuilder
    {
        void BuildMotherboard();
        void BuildPSU();
        void BuildGPU();
        void BuildCPU();
        void BuildRAM();
        void BuildROM();
        PC GetPC();
    }
}
