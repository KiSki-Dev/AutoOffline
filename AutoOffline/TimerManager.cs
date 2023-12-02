using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOffline
{
    public static class TimerManager
    {
        private static List<Form> activeForms = new List<Form>();

        public static void RegisterForm(Form form)
        {
            activeForms.Add(form);
        }

        public static void UnregisterForm(Form form)
        {
            activeForms.Remove(form);
        }

        public static void StopAllTimers()
        {
            foreach (var form in activeForms)
            {
                if (form is ITimerClient timerClient)
                {
                    timerClient.StopTimer();
                }
            }
        }
    }

    public interface ITimerClient
    {
        void StartTimer(int time);
        void StopTimer();
    }
}
