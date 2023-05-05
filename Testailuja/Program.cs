using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Testailuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Biisin sijainti
            string musicplayerpath = @"C:\Program Files (x86)\Windows Media Player\wmplayer.exe";
            string musicfilepath = @"C:\Users\ojaeer\Desktop\Biisit\Maanantai_sessarit_5.mp3";
            
            //Kuvan sijainti
            string picturepath = @"C:\Users\ojaeer\Desktop\Biisit\rumakala.jpg";
            string pictureeditorpath = @"C:\windows\system32\mspaint.exe";


            //prosessinaloitus
            ProcessStartInfo startmusic = new ProcessStartInfo();
            ProcessStartInfo startpicture = new ProcessStartInfo();

            //määritellään filet ja ohjelma jolla avataan
            startmusic.FileName = musicplayerpath;
            startmusic.Arguments = musicfilepath;

            //Sama täällä mutta kuvan muodossa
            startpicture.FileName = pictureeditorpath;
            startpicture.Arguments = picturepath;

            List<string> vastaukset = new List<string>();
            vastaukset.Add("kyllä");
            vastaukset.Add("joo");
            vastaukset.Add("jeppis");
            vastaukset.Add("jepulis");
            vastaukset.Add("jeba");
            vastaukset.Add("juu");         
            string vastaus;
            do
            {
                Console.WriteLine("Kuunteletko ahtia?");
                vastaus = Console.ReadLine();
            } while(!vastaukset.Contains(vastaus.ToLower()));
            for (int i = 0; i < 10; i++)
            {
            //Process.start(Haluttu juttu)
            Console.WriteLine(i);
            Process.Start(startmusic);
            Process.Start(startpicture);
            }

        }
    }
}