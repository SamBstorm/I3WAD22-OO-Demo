using System;

namespace Demo_Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioDisc cd_celine_dion = new AudioDisc(0, 160, 320, 450, 720, 1240);
            LecteurAudioDisc player = new LecteurAudioDisc();
            player.currentDisc = cd_celine_dion;
            player.SetProgram(2);
            player.SetProgram(2);
            player.SetProgram(4);
            player.SetProgram(1);


            player.Play();
        }
    }
}
