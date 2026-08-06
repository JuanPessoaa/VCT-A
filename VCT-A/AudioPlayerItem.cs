using System;
using System.IO;
using NAudio.Wave;

namespace VCT_A
{
    public class AudioPlayerItem : IDisposable
    {
        private WaveOutEvent outputDevice;
        private Mp3FileReader mp3Reader;
        private LoopStream loopStream;

        public void PlayFromResource(byte[] resourceBytes)
        {
            Stop();

            if (resourceBytes == null || resourceBytes.Length == 0) return;

            var memoryStream = new MemoryStream(resourceBytes);
            mp3Reader = new Mp3FileReader(memoryStream);
            loopStream = new LoopStream(mp3Reader);

            outputDevice = new WaveOutEvent();
            outputDevice.Init(loopStream);
            outputDevice.Play();
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (loopStream != null)
            {
                loopStream.Dispose();
                loopStream = null;
            }
            if (mp3Reader != null)
            {
                mp3Reader.Dispose();
                mp3Reader = null;
            }
        }

        // Método Dispose simples sem a palavra 'override'
        public void Dispose()
        {
            Stop();
        }
    }
}