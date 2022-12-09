namespace AsyncSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //Thread thread3 = new Thread(Loop3);

            //thread1.Start();
            ////thread1.Join();

            //thread2.Start();
            //thread3.Start();

            //////*********************************************************

            Thread threadX = new(Inc);
            Thread threadY = new(Dec);

            threadX.Start();
            threadY.Start();
            threadX.Join();
            threadY.Join();

            Console.WriteLine(counter);
        }

        //////*********************************************************
        public static int counter;
        private static object Lock = new object();

        public static void Inc()
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (Lock)
                {
                    counter++;
                }
            }
        }
        public static void Dec()
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (Lock)
                { 
                    counter--;
                }
            }
        }

        //////*********************************************************
        public static void Loop1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                Console.Write($"A ");
            }
        }
        public static void Loop2()
        {

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1800);
                Console.Write($"B ");
            }
        }
        public static void Loop3()
        {

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1500);
                Console.Write($"C ");
            }
        }
        //////*********************************************************
    }
}