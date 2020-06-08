using DieselElcatKgUpper.Data;
using System;
using System.Threading;

namespace DieselElcatKgUpper.Classes
{
    public class UpWorker
    {
        public event Action ListChanged;
        private static UpWorker _instance = null;
        public Thread currentThread;
        public bool isPause { get; set; } = true;
        public bool isWork { get; set; } = true;

        public static UpWorker GetInstance()
        {
            if (_instance == null)
                _instance = new UpWorker();
            return _instance;
        }

        private UpWorker()
        {
            currentThread = new Thread(process);
            currentThread.Start();
        }

        private void process()
        {
            while (isWork)
            {
                if (isPause) continue;
                Thread.Sleep(1000);


                foreach (UpRecord item in UpRecordManager.GetInstance().UpRecords)
                {
                    double mins = DateTime.Now.Subtract(item.LastUpdate).TotalMinutes;
                    int set = 24 * 60 + 1;

                    if (mins >= set)
                    {
                        using (IUpper upper = new DieselUpper())
                        {
                            try
                            {
                                upper.Login(AccountManager.GetInstance().Account.Login, AccountManager.GetInstance().Account.Password);
                                upper.Up(item.ThemeUrl);
                                upper.Logout();
                                item.Result = "OK";
                            }
                            catch (Exception ex)
                            {
                                item.Result = $"FAIL {ex.Message}";
                            }
                            finally
                            {
                                item.LastUpdate = DateTime.Now;
                                UpRecordManager.GetInstance().Save();
                                ListChanged?.Invoke();
                            }
                        }
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        internal void Abort()
        {
            isPause = true;

        }
    }
}
