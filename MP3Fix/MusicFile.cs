using System;
using TagLib;
using System.IO;

// Music files are loaded in via their full path as the only argument. From then their meta data is accessed in various ways

namespace MP3Fix {
    class MusicFile {
        string filePath;

        public MusicFile(string filePath) {
            this.filePath = filePath;
        }

        public string FilePath() {
           
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

        public string Title() {
            TagLib.File currentFile = TagLib.File.Create(filePath);
            if (string.IsNullOrEmpty(currentFile.Tag.Title))
                return Path.GetFileNameWithoutExtension(filePath);
            else
                return currentFile.Tag.Title;
        }

        public string OutputFileName(string delimiter, string fileExtension) {
            return Path.GetDirectoryName(filePath) + "\\" + Artist() + delimiter + Track().ToString("00") + delimiter + Title() + fileExtension;
        }

    }
}
