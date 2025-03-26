// See https://aka.ms/new-console-template for more information
using modul6_103022300109;

class Video {
    static void Main()
    {
        SayaTubeVideo film1 = new SayaTubeVideo("Review Film GrandTurismo oleh Reja");
        SayaTubeVideo film2 = new SayaTubeVideo("Review Film Chi : Chikyuu oleh Reja");
        SayaTubeVideo film3 = new SayaTubeVideo("rer");
        SayaTubeVideo film4 = new SayaTubeVideo("Review Film John Wick oleh Reja");
        SayaTubeVideo film5 = new SayaTubeVideo("Review Film Monster Hunter oleh Reja");
        SayaTubeVideo film6 = new SayaTubeVideo("Review Film Kimi No Nawa oleh Reja");
        SayaTubeVideo film7 = new SayaTubeVideo("Review Film Black Clover oleh Reja");
        SayaTubeVideo film8 = new SayaTubeVideo("Review Film I want to eat your pankreas oleh Reja");
        SayaTubeVideo film9 = new SayaTubeVideo("Review Film Conjuring oleh Reja");
        SayaTubeVideo film10 = new SayaTubeVideo("Review Film One Piece oleh Reja");

        SayaTubeUser pengguna = new SayaTubeUser("Reja Indra Maulana");

        pengguna.AddVideo(film1);
        pengguna.AddVideo(film2);
        pengguna.AddVideo(film3);
        pengguna.AddVideo(film4);
        pengguna.AddVideo(film5);
        pengguna.AddVideo(film6);
        pengguna.AddVideo(film7);
        pengguna.AddVideo(film8);
        pengguna.AddVideo(film9);
        pengguna.AddVideo(film10);

        film1.increasePlayCount(1000);

        for (int i = 0; i < 10; i++)
        {
            film4.increasePlayCount(1);
        }
        pengguna.printAllVideoPlayCount();
    }
}
