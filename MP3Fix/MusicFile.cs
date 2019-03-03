using System;
using TagLib;
using System.IO;

namespace MP3Fix {
    class MusicFile {
        string filePath;

        public MusicFile(string filePath) {
            this.filePath = filePath;
        }

        public string Path() {
           
            return filePath;
        }

        public string Artist() {
            string[] splitPath = filePath.Split('\\');
            return splitPath[2];
        }

        public string Album() {
            string[] splitPath = filePath.Split('\\');
            return splitPath[3];
        }

        public int Track() {
            TagLib.File currentFile = TagLib.File.Create(filePath);
            if (currentFile.Tag.Track != 0)
                return (int) currentFile.Tag.Track;
            else {
                string x = "";
                foreach (char c in Path.GetFileNameWithoutExtension(filePath)) {
                    if (char.IsDigit(c) && x.Length <= 2)
                        x += c;
                }
                return int.Parse(x);
            }
        }



    }
}
