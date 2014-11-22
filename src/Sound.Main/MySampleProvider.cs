using System;
using System.Diagnostics.PerformanceData;
using NAudio.Wave;

namespace Sound.Main
{
    public class MySampleProvider : ISampleProvider
    {
        private Random rnd = new Random();
        private float a = 0;
        //private int r = 0;
        private float p = 0;
        private int q = -2;
        public int Read(float[] buffer, int offset, int count)
        {
            for (int i = 0; i < count; i++)
            {
                //r++;
                
                q++;
                if (q > 100000)
                    p -= 0.0001f;
                else
                    p += 0.0001f;
                if (q > 199999)
                    q = 0;
                a += (float)((Math.PI *2 / 44100)*200) * p;
                buffer[i + offset] = (float) (Math.Sin(a*2 - 1));
            }
            //if (r > 44100)
            //    return 0;
            return count;
        }

        public WaveFormat WaveFormat { get { return WaveFormat.CreateIeeeFloatWaveFormat(44100, 1); } }
    }
}