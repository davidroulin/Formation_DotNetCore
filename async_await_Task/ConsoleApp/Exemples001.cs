using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Program
    {
        public void TacheLongueBloquante_ThreadSleep(int dureeMs = 3000)
        {
            TimeLog("Begin - tache");

            Thread.Sleep(dureeMs);

            TimeLog("End - tache");
        }

        [InMenu]
        public void Exec_TacheLongueBloquante_ThreadSleep()
        {   
            TimeLog("Begin - caller");

            TacheLongueBloquante_ThreadSleep();
            
            TimeLog("End - caller");
        }
    }
}
