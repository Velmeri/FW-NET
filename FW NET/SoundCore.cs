using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FW_NET
{
    public static class Sound
    {
        private static readonly Dictionary<string, SoundPlayer> _sounds = new Dictionary<string, SoundPlayer>();

        public static void AddSound(string key, string soundFilePath)
        {
            SoundPlayer player = new SoundPlayer(soundFilePath);
            _sounds.Add(key, player);
        }

        public static void PlaySound(string key)
        {
            if (_sounds.TryGetValue(key, out SoundPlayer player))
            {
                player.Play();
            }
            else
            {
                throw new ArgumentException($"Sound with key '{key}' not found.");
            }
        }
    }
}
