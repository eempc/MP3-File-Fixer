using System;
using TagLib;
using System.IO;

// Music files are loaded in via their full path as the only argument. From then their meta data is accessed in various ways

namespace MP3Fix{
    class MusicFile : Form1 {
        string filePath;
        TagLib.File currentFile;

        public MusicFile(string filePath) {
            this.filePath = filePath;
            currentFile = TagLib.File.Create(filePath);
            
        }

        // Read data and preparation methods
        public string FilePath() {
            return filePath;
        }

        public string Artist() {     
            if (!string.IsNullOrEmpty(currentFile.Tag.Performers[0]))
                return currentFile.Tag.Performers[0];
            else
                return filePath.Split('\\')[2];
        }

        public string Album() {
            if (!string.IsNullOrEmpty(currentFile.Tag.Album))
                return currentFile.Tag.Album;
            else
                return filePath.Split('\\')[3];
        }

        public int Track() {
            return (int) currentFile.Tag.Track;
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

        // Writing the new file methods

    }
}
