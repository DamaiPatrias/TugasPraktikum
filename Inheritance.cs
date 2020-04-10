using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class person
    {
        public string nama { get; set; }
        public int umur { get; set; }

        public person (string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;

            Console.WriteLine("Name : {0} and Age : {1}", nama, umur);
        }
    }
    
    public class dosen : person
    {
        public string iddosen { get; set; }
        public string mkdosen { get; set; }
        public dosen(string nama, int umur, string iddosen, string mkdosen) : base(nama, umur)
        {
            this.iddosen = iddosen;
            this.mkdosen = mkdosen;

           
        }
    }
    public class mahasiswa : person
    {
        public string idmhs { get; set; }
        public string email { get; set; }
        public mahasiswa(string nama, int umur, string idmhs, string email) : base(nama, umur)
        {
            this.idmhs = idmhs;
            this.email = email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person pbaru = new person("Damai", 20);

            dosen dbaru = new dosen("Kamarudin", 35, "190302", "Pemrograman");

            mahasiswa mbaru = new mahasiswa("Damai", 20, "19.11.2602", "damai.suyana@students.amikom.ac.id");
            
            


            Console.ReadKey();

        }
    }
}
