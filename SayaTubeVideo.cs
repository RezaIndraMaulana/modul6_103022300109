using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300109
{
    class SayaTubeVideo
    {
        private int id;//inisiasi id
        private String title;//inisiasi title
        private int playCount;//inisiasi playCounty utk menghitung

        public SayaTubeVideo(String title)//konstruktor
        {
            Debug.Assert(title.Length <= 200 && title != null, "Judul Video tidak boleh lebih dari 200 karakter atau kosong");// buat debug assert agar tidak melebihi nya dan gaoble null
            Contract.Requires(title.Length <= 200 && title != null);//buat contract requires agar tidak melebihi nya dan gaoble null
            Random rand = new Random();//utk random
            this.id = rand.Next(10000, 99999);//utk membuat angka randomnya dengan 5 digit dari 10000-99999
            this.title = title;//utk judul
            this.playCount = 0;//utk total playCountnya
        }

        public void increasePlayCount(int count) 
        {
            Debug.Assert(count > 0 && count <= 25000000, "Play count harus antara 1 hingga 25.000.000");
            Contract.Requires(count > 0 && count <= 25000000);
            if (count <= 0 || count > 25000000)
            {
                throw new ArgumentException("Play count harus antara 1 hingga 10.000.000");
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }

        public String getTitle()
        {
            return title;
        }

        public int getPlayCount()
        {
            return playCount;
        }
    }
}
