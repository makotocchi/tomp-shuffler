using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TompShuffler
{
    class FileShuffler
    {
        private static StringBuilder oldFile = new StringBuilder();
        private static StringBuilder newFile = new StringBuilder();

        // TODO: check if Exceptions can do the job (instead of int error codes)
        public static int shuffle(string folderAddress)
        {
            DirectoryInfo dataFolder = new DirectoryInfo(folderAddress);
            string dataFolderPath = dataFolder.FullName + "\\";
            setBuilderCapacity(dataFolderPath);
            preventNameCollision(dataFolderPath);
            List<int> order = getRandomOrder(Game.tr3FileNames.Count());
            
            //TODO: refactor this (same algorithm is being used elsewhere)
            int levelCount = Game.tr3FileNames.Count();
            int elementIndex;
            for (int i = 0; i < levelCount; i++)
            {
                elementIndex = order.ElementAt(i);
                newFile.Append(dataFolderPath + Game.tr3FileNames.ElementAt(elementIndex) + ".TR2");
                oldFile.Append(dataFolderPath + i + ".TR2");
                File.Move(oldFile.ToString(), newFile.ToString());
                clearBuilders();
            }
            
            return 0;
        }

        // use this List<int> as an index for the level files array
        private static List<int> getRandomOrder(int quantity)
        {
            Random rng = new Random();
            List<int> order = new List<int>();
            int randomNumber, counter = 0;
            do
            {
                randomNumber = rng.Next(0, quantity);
                if (!order.Contains(randomNumber))
                {
                    order.Add(randomNumber);
                    counter++;
                }
            } while (counter < quantity);
            return order;
        }

        // renames the files numerically 
        // TODO: add exception handling
        private static void preventNameCollision(string dataFolderPath)
        {
            int counter = 0;
            foreach (string levelFile in Game.tr3FileNames)
            {
                oldFile.Append(dataFolderPath + levelFile + ".TR2");
                newFile.Append(dataFolderPath + counter + ".TR2");
                File.Move(oldFile.ToString(), newFile.ToString());
                clearBuilders();
                counter++;
            }
        }

        // default capacity for the StringBuilder is 16 chars, so this makes sure the whole file path fits
        private static void setBuilderCapacity(string directory)
        {
            int directoryLength = directory.Length + 16;
            oldFile.Capacity = directoryLength;
            newFile.Capacity = directoryLength;
        }

        private static void clearBuilders()
        {
            oldFile.Clear();
            newFile.Clear();
        }
    }
}
