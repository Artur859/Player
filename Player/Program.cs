using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spotify DiArtur = new Spotify();
            Song song1 = new Song("Tatu", "dffh");
            DiArtur.addSong(song1);
            song1.play();
            



        }
    }
    public  class Spotify
    {
        List<string> _song = new List<string>();
        public void addSong(Song song)
        {
            _song.Add(song._title);

        }

        public interface IPlayer
        {


            public abstract void play();
            public abstract void stop();


            public abstract void forward();
            public abstract void backward();





        }











    }

    public class Song : Spotify.IPlayer
    {

        public string _title { get; set; }
        public string _artist { get; set; }
        int _rate { get; set; }
        public int state { get; set; }
        public Song(string title, string artist)
        {
            _title = title;
            _artist = artist;
            _rate = 5;
            state = 0;

        }

        public void play()
        {
            state = 1;
            Console.WriteLine($"Play music, stato: {state}");




        }

        public void stop()
        {
            state = 0;
            Console.WriteLine($"Stop music, stato: {state}");
        }

        public void forward()
        {
            throw new NotImplementedException();
        }

        public void backward()
        {
            throw new NotImplementedException();
        }
    }
}
