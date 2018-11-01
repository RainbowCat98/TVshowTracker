using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVshowTracker.Classes;

namespace TVshowTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ReadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        private static void ReadData()
        {
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\TV Shows", "*.csv");
            string[] lineComponens;
            string[] file;
            int ShowNumber = 0;

            foreach (var showfile in filePaths)
            {
                file = File.ReadAllLines(@showfile);
                lineComponens = file[0].Split(';');
                TVshowManager.TVshows.Add(new TVShow(lineComponens[0], lineComponens[1], lineComponens[2], lineComponens[3], showfile));

                for (int i = 1; i < file.Length; i++)
                {
                    lineComponens = file[i].Split(';');

                    if (TVshowManager.TVshows[ShowNumber].ContainsSeason(lineComponens[0]))
                    {
                        int SeasonIndex = TVshowManager.TVshows[ShowNumber].GetSeasonIndex(lineComponens[0]);
                        TVshowManager.TVshows[ShowNumber].Seasons[SeasonIndex].Episodes.Add(new Episode(lineComponens[1], bool.Parse(lineComponens[2])));
                    }
                    else
                    {
                        TVshowManager.TVshows[ShowNumber].Seasons.Add(new Season(lineComponens[0],new Episode(lineComponens[1],bool.Parse(lineComponens[2]))));
                    }                  
                }
            }
        }
    }
}
