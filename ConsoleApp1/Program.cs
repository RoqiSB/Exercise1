using System;

namespace Exercise1
{
    class program
    {
        private int[] a = new int[34];
        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 34)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 34 Elemen.\n");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("--------------------------------");
            for (int RS = 0; RS < n; RS++)
            {
                Console.WriteLine(a[RS]);
            }
            Console.WriteLine("");
        }
        public void sortarray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int RS = 0; RS < n - i; RS++)
                {
                    if (a[RS] > a[RS + 1])
                    {
                        int temp;
                        temp = a[RS];
                        a[RS] = a[RS + 1];
                        a[RS + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            program mylist = new program();
            mylist.read();
            mylist.sortarray();
            mylist.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}