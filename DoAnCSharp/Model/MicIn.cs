using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class MicIn : IWaveProvider, IDisposable
    {
        private readonly IWaveProvider sourceWaveProvider;

        public WaveFormat WaveFormat { get { return sourceWaveProvider.WaveFormat; } }

        public int Read(byte[] buffer, int offset, int count)
        {
            var read = sourceWaveProvider.Read(buffer, offset, count);

            return read;
        }

        public void Dispose()
        {

        }

        public MicIn(IWaveProvider sourceWaveProvider)
        {
            this.sourceWaveProvider = sourceWaveProvider;
        }
    }
}
