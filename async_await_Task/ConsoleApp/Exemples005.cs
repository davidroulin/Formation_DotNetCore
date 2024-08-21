using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Program
    {
        public Task TacheLongueReturnTask_TaskDelay(int dureeMs = 3000)
        {
            TimeLog($"Begin - tache (wait for {dureeMs / 1000} sec)");

            Task t = Task.Delay(dureeMs);

            t.ContinueWith(antecedent => TimeLog("End - tache"));

            return t;
        }

        [InMenu]
        public async void Exec_TacheLongueReturnTask_TaskDelay()
        {
            TimeLog("Begin - caller (do you await me? I am async, habibi)");

            Task t = TacheLongueReturnTask_TaskDelay();

            await t;

            TimeLog("End - caller (Told you I was async...)");
        }
    }
}
