using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CharacterCreation
{
    class CharacterCreationFileSystem
    {
        /// <summary>
        /// Save the character data to a text file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns>String array - save successful?</returns>
        public string[] SaveData(string path, string[] data) 
        {
            string[] successfullySaved = new string[2];
            try
            {
                StreamWriter writer = new StreamWriter(path);

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    writer.WriteLine(data[i]);
                }

                writer.Close();

                successfullySaved[0] = "Successfully saved";
                successfullySaved[1] = "-";
            }
            catch (IOException e)
            {
                successfullySaved[0] = "File save error!";
                successfullySaved[1] = e.Message;
            }
            catch
            {
                successfullySaved[0] = "File save error!";
                successfullySaved[1] = "unknown error";
            }

            return successfullySaved;
        }

        public string[] LoadData(string path)
        {
            string[] loadedSuccessfully = new string[2];
            try
            {
                StreamReader reader = new StreamReader(path);
            }
            catch (IOException e)
            {
                loadedSuccessfully[0] = "File load error!";
                loadedSuccessfully[1] = e.Message;
            }
            return loadedSuccessfully;
        }
    }
}
