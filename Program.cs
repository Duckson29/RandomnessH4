using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace RNGCryptoServiceProviderH4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int n = 100000000;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider() )
            {
                byte[] data = new byte[4];
                int value = 0;
                stopwatch.Start();
                for (int i = 0; i < n; i++)
                {
                    rng.GetBytes(data);
                    value = BitConverter.ToInt32(data, 0);

                }
            }
                stopwatch.Stop();
                TimeSpan time = stopwatch.Elapsed;
                Console.WriteLine("RNGCryptoServiceProvider over n(100000) total secs : " + time.TotalSeconds);
                Random ran = new Random();
                stopwatch.Reset();
                stopwatch.Start();
                for (int i = 0; i < n; i++)
                {
                    ran.Next();
                }
                stopwatch.Stop();
                Console.WriteLine("RNGCryptoServiceProvider over n(100000) total secs : " + stopwatch.Elapsed.TotalSeconds);                
            

        }
    }
}
