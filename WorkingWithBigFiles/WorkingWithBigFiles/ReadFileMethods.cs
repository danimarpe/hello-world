using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WorkingWithBigFiles
{
    public class ReadFileMethods
    {
        private const int PART_SIZE = 1000000; //1MB aprox.

        /// <summary>
        /// It reads a file storing its whole content directly into the server's memory.
        /// It will probably cause errors when reading big files.
        /// It is bad done on purpose, just for educational reasons
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static ReadMethodResponse BadWay(HttpPostedFile file)
        {
            if (file.ContentLength > 0)
            {
                try
                {
                    byte[] buffer = new byte[file.ContentLength];

                    using (FileStream fileStream = File.Create(Config.outputFilePath))
                    {
                        file.InputStream.Read(buffer, 0, file.ContentLength); //This line will probably crash when reading big files
                        fileStream.Write(buffer, 0, file.ContentLength);
                    }
                }
                catch (Exception ex)
                {
                    return ReadMethodResponse.BadResponse(ex);
                }
                return ReadMethodResponse.GoodResponse();
            }

            return ReadMethodResponse.BadResponse();
        }

        /// <summary>
        /// It reads a file storing just 1MB in memory and then writing it to the output stream
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static ReadMethodResponse GoodWay(HttpPostedFile file)
        {
            if (file.ContentLength > 0)
            {
                try
                {
                    byte[] buffer = new byte[PART_SIZE];
                    int readingSize = PART_SIZE;
                    using (FileStream fileStream = File.Create(Config.outputFilePath))
                    {
                        while (file.InputStream.Read(buffer, 0, readingSize) > 0)
                        {
                            fileStream.Write(buffer, 0, readingSize);
                            if ((file.InputStream.Length - file.InputStream.Position) < PART_SIZE)
                                readingSize = (int)(file.InputStream.Length - file.InputStream.Position); //We can do the "int" cast: we have checked (Lenght - Position) is not bigger than 1MB
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ReadMethodResponse.BadResponse(ex);
                }
                return ReadMethodResponse.GoodResponse();
            }

            return ReadMethodResponse.BadResponse();
        }

    }
}