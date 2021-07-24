using DieselElcatKgUpper.Data;
using System;
using System.Threading.Tasks;

namespace DieselElcatKgUpper.Classes
{
    public class UpWorker
    {
        public event Action ListChanged;
        private static readonly UpWorker _instance = new UpWorker();
        public bool IsPause { get; set; } = true;
        public bool IsWork { get; set; } = true;

        public static UpWorker GetInstance()
        {
            return _instance;
        }

        private UpWorker()
        {
            new Task(process).Start();
        }

        private void process()
        {
            while (IsWork)
            {
                if (IsPause) continue;
                Task.Delay(1000);


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
                        Task.Delay(1000);
                    }
                }
            }
        }
    }
}
