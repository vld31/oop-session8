namespace Session7;

public class Program{
    public static void Main(){
        MusicPlayer musicPlayer = new();
       
        Playlist playlistElectronic = new();
        Playlist playlistClassicRock = new();
       
        Song songElectronic1 = new("Dead Stars", "Convenant", "EBM", 336);
        Song songElectronic2 = new("I stand alone", "Convenant", "EBM", 430);
        Song songClassicRock1 = new("Dust in the wind", "Kansas", "Classic Rock", 220);
        Song songClassicRock2 = new("Horse with no name", "America", "Classic Rock", 437);
        Song songClassicRock3 = new("Hasd", "asd", "Classic Rock", 4227);


        playlistElectronic.Name = "Electronic Playlist";
        playlistElectronic.Songs.Add(songElectronic1);
        playlistElectronic.Songs.Add(songElectronic2);
        playlistClassicRock.Songs.Add(songClassicRock1);
        playlistClassicRock.Songs.Add(songClassicRock2);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistClassicRock);
        musicPlayer.Play(playlistClassicRock);

    }
}