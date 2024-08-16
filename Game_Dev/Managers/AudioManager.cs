using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;

namespace Game_Dev.Managers
{
    public static class AudioManager
    {
        private static Dictionary<string, Song> _musicTracks = new();
        private static string _currentTrackName;
        private static SoundEffect _slashSound;
        private static SoundEffect _dyingSound;
        private static SoundEffect _PlayKeySound;

        public static void LoadContent(ContentManager content)
        {
            _musicTracks["StartScreen"] = content.Load<Song>("startscreen");
            _musicTracks["LevelMusic"] = content.Load<Song>("level");
            _slashSound = content.Load<SoundEffect>("slash");
            _dyingSound = content.Load<SoundEffect>("dying");
            _PlayKeySound = content.Load<SoundEffect>("keyGet");
        }

        public static void PlayMusic(string trackName)
        {
            if (_currentTrackName == trackName)
                return;

            if (_musicTracks.ContainsKey(trackName))
            {
                _currentTrackName = trackName;
                MediaPlayer.Play(_musicTracks[trackName]);
                MediaPlayer.Volume = 0.2f;
                MediaPlayer.IsRepeating = true;
            }
        }

        public static void PlaySlashSound()
        {
            _slashSound?.Play();
        }

        public static void PlayDyingSound()
        {
            _dyingSound?.Play();
        }

        public static void PlayKeySound()
        {
            _PlayKeySound?.Play();
        }

        public static void StopMusic()
        {
            MediaPlayer.Stop();
        }
    }
}
