using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pilih Menu Calculator : " + "\n");
            Console.Write("1. Penambahan" + "\n" + "2. Pengurangan" + "\n" + "3. Perkalian" + "\n" + "4. Pembagian" + "\n");
            Console.Write("Masukkan Pilihan (1, 2, 3, 4) : ");
            int pil = int.Parse(Console.ReadLine());

            if(pil == 1)
            {
                Console.Write("\n" + "Masukkan Angka ke-1 : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Angka Ke-2 : ");
                int b = int.Parse(Console.ReadLine());
                
                Console.WriteLine("\n"+ "Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if(pil == 2)
            {
                Console.Write("\n" + "Masukkan Angka ke-1 : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Angka Ke-2 : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("\n"+ "Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b)); 
            }
            else if(pil == 3)
            {
                Console.Write("\n" + "Masukkan Angka ke-1 : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Angka Ke-2 : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("\n"+ "Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if(pil == 4)
            {
                Console.Write("\n" + "Masukkan Angka ke-1 : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Angka Ke-2 : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("\n"+ "Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.Write("\n" + "Pilihan Tidak Ada Dalam Menu Calculator");
            }


            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        { 
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
