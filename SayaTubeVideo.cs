using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public SayaTubeVideo(int id, String title)//konstruktor
        {
            Random rand = new Random();//utk random
            this.id = rand.Next(10000, 99999);//utk membuat angka randomnya dengan 5 digit dari 10000-99999
            this.title = title;//utk judul
            this.playCount = 0;//utk total playCountnya
        }

        public void increasePlayCount(int count) 
        {
            Debug.Assert(count > 0 && count <= 10000000, "Play count harus antara 1 hingga 10.000.000");
            if (count <= 0 || count > 10000000)
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
