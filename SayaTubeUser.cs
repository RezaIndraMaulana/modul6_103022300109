using System;
using System.Collections.Generic;
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
            this.id = id;
            this.Username = Username;
            this.uploadVideo = new List<SayaTubeVideo>();
        }

        public int getTotalVideoPlayCount()
        {
            return uploadVideo.Count;
        }

        public void AddVideo(SayaTubeVideo video) 
        { 
            uploadVideo.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User : " + Username );
            for (int i = 0; i < uploadVideo.Count; i++)
            {
                Console.WriteLine("Video : " + uploadVideo[i].getTitle() + " is " + uploadVideo[i].getPlayCount());
            }
        }
    }
}
