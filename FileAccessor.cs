using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    class FileAccessor
    {
        StreamReader textIn;
        FileStream fileStream;
        /// <summary>
        /// Gets or sets the path to the file that is being accessed.
        /// </summary>
        public string FilePath { get; set; }


        /// <summary>
        /// Creates an instance of a fileAccesor, setting
        /// the FilePAth property to the passed value.
        /// </summary>
        /// <param name="filePath"></param>
        public FileAccessor(string filePath)
        {
            FilePath = filePath;
            fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            textIn = new StreamReader(fileStream);
        }



        /// <summary>
        /// Returns a random line from the file.
        /// </summary>
        /// <returns>Random line from a file as a string.</returns>
        public string GetRandomLine()
        {
            

            //get random word
            Random random = new Random();
            int randNum = random.Next(1, GetUpperBounds());

            //read through file to get that word
            for (int n = 0; n < randNum; n++)
            {

                textIn.ReadLine();

            }



            return textIn.ReadLine();

        }

        public int GetUpperBounds()
        {
            //cointer variable
            int fileUpperBounds = 0;
            fileStream.Position = 0;
            
            
            //loop through file until end
            //counting the number of lones
            while (!textIn.EndOfStream)
            {
                textIn.ReadLine();
                fileUpperBounds++;
            }

            fileStream.Position = 0;
            
            //Return number of lines
            return fileUpperBounds;
            
        }
    }
}
