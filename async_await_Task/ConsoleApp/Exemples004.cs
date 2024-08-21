using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Program
    {
        public async void TacheLongueAsyncAvecAwait_TaskDelay(int dureeMs = 3000)
        {
            TimeLog($"Begin - tache (wait for {dureeMs/1000} sec)");

            await Task.Delay(dureeMs);

            TimeLog("End - tache");
        }

        [InMenu]
        public void Exec_TacheLongueAsyncAvecAwait_TaskDelay()
        {
            TimeLog("Begin - caller");

            TacheLongueAsyncAvecAwait_TaskDelay();

            TimeLog("End - caller");
        }
    }
}
