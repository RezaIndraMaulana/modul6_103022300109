using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300109
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideo;
        private String Username;

        public SayaTubeUser(String Username)
        {
            Contract.Requires(Username.Length <= 100 && Username != null);
            Debug.Assert(Username.Length <= 100 && Username != null, "Username gabole lebih dari 100 karakter atau kosong");
            this.id = id;
            this.Username = Username;
            this.uploadVideo = new List<SayaTubeVideo>();
        }

        public int getTotalVideoPlayCount()
        {
            int count = 0;
            for(int i = 0; i < uploadVideo.Count; i++)
            {
                count += uploadVideo[i].getPlayCount();
            }
            return count;
            //return uploadVideo.Count;
        }

        public void AddVideo(SayaTubeVideo video) 
        { 
            Contract.Requires(video.getPlayCount() > 25000000 && video != null);
            Debug.Assert(video.getPlayCount() < 25000000 && video != null, "Play count harus antara 1 hingga 25.000.000 atau kosong");
            uploadVideo.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User : " + Username );
            for (int i = 0; i < uploadVideo.Count; i++)
            {
                int videoNumber = i + 1;
                Console.WriteLine("Video " + videoNumber + " Judul:" + uploadVideo[i].getTitle() + " Penonton : " + uploadVideo[i].getPlayCount());
            }
            Contract.Ensures(uploadVideo.Count <= 8);
        }
    }
}
