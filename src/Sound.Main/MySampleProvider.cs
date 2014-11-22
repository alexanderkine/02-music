using System;
using NAudio.Wave;

namespace Sound.Main
{
    public class MySampleProvider : ISampleProvider
    {
        public int Read(float[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public WaveFormat WaveFormat { get { return WaveFormat.CreateIeeeFloatWaveFormat(44100, 1); } }
    }
}