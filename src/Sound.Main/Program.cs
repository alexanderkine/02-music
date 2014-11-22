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
                //waveOut.Init(new LoopingSampleProvider(new MySampleProvider()));
                waveOut.Init(new MySampleProvider());
                //waveOut.Init(new AudioFileReader("getup.wav"));
                waveOut.Play();
                Console.ReadKey(false);
            }
        }
    }
}
