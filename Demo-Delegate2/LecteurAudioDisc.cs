using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate2
{
    delegate void PlayerAction();
    class LecteurAudioDisc
    {
        public AudioDisc currentDisc { get; set; }

        private PlayerAction _programmation = null;

        public void Play()
        {
            if (_programmation is null)
            {
                for (int i = 0; i < currentDisc.TrackTimes.Length; i++)
                {
                    int trackTime = currentDisc.TrackTimes[i];
                    Console.WriteLine($"On écoute la piste {i + 1} qui commence à {trackTime} secondes!");
                }
            }
            else { _programmation(); }
            _programmation = null;
        }

        private void Play(int trackNumber, int trackTime)
        {
            Console.WriteLine($"On écoute la piste {trackNumber} qui commence à {trackTime} secondes!");
        }

        private PlayerAction GenerateProgram(int trackNumber)
        {
            int trackTime = currentDisc.TrackTimes[trackNumber-1];
            return delegate () { Play(trackNumber, trackTime); };
        }

        public void SetProgram(int trackNumber)
        {
            _programmation += GenerateProgram(trackNumber);
        }
    }
}
