using System;
using NAudio.Wave;

namespace Sound.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var waveOut = new WaveOut())
            {
                waveOut.Init(new MySampleProvider());
                waveOut.Play();

                Console.ReadKey(false);
            }
        }
    }
}
