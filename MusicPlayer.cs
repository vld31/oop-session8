namespace Session7;

public class MusicPlayer{
    public void Play(Playlist playlist){
        Song song = playlist.Songs[playlist.CurrentSongIndex++];
        //playlist.
        System.Console.WriteLine($"{playlist.Name} is playing {song.Title}");
    }

    public void Play(Song song){
        System.Console.WriteLine("Song is playing");
    }
}