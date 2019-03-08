using System;
using TagLib;
using System.IO;

// Music files are loaded in via their full path as the only argument. From then their meta data is accessed in various ways
// OMG this is not how you make a class. Who wrote this crap? Oh right, it was me.
// Fixed this class up better. Leaving commented code as an example of not how to do this.

namespace MP3Fix{
    class MusicFile : Form1 {
        public string filePath, artist, album, title;
        public int trackNo;
        TagLib.File currentFile;

        // Must have file path at the minimum for TagLib to operate
        public MusicFile(string filePath) {
            this.filePath = filePath;
            this.currentFile = TagLib.File.Create(filePath); // Assuming filePath is not empty
            this.artist = currentFile.Tag.Performers[0];
            this.album = currentFile.Tag.Album;
            this.title = currentFile.Tag.Title;
            this.trackNo = (int)currentFile.Tag.Track;
        }

        public string OutputFileName(string delimiter, string fileExtension) {
            return Path.GetDirectoryName(filePath) + "\\" + artist + delimiter + trackNo.ToString("00") + delimiter + title + fileExtension;
        }

        public void WriteChanges(string newArtist, string newTrack, string newTitle, string newFilePath, string newAlbum) {
            currentFile.Tag.Album = newAlbum;
            currentFile.Tag.Title = newTitle;
            currentFile.Tag.Track = (uint) int.Parse(newTrack);
            currentFile.Tag.Performers = new string[1] { newArtist };
            currentFile.Save();
            System.IO.File.Move(filePath, newFilePath);
        }

        //string filePath;
        //TagLib.File currentFile;

        //public MusicFile(string filePath) {
        //    this.filePath = filePath;
        //    currentFile = TagLib.File.Create(filePath);

        //}

        //// Read data and preparation methods
        //public string FilePath() {
        //    return filePath;
        //}

        //public string Artist() {
        //    if (currentFile.Tag.Performers.Length != 0 && !string.IsNullOrEmpty(currentFile.Tag.Performers[0]))
        //        return currentFile.Tag.Performers[0];
        //    else
        //        return filePath.Split('\\')[2];
        //}

        //public string Album() {
        //    if (!string.IsNullOrEmpty(currentFile.Tag.Album))
        //        return currentFile.Tag.Album;
        //    else
        //        return filePath.Split('\\')[3];
        //}

        //public int Track() {
        //    if (currentFile.Tag.Track != 0)
        //        return (int) currentFile.Tag.Track;
        //    else {
        //        string x = "";
        //        foreach (char c in Path.GetFileNameWithoutExtension(filePath))
        //            if (char.IsDigit(c) && x.Length <= 2) x += c;
        //        return (x.Length > 0) ? int.Parse(x) : 99 ;
        //    }
        //}

        //public string Title() {
        //    if (!string.IsNullOrEmpty(currentFile.Tag.Title))
        //        return currentFile.Tag.Title;           
        //    else
        //        return Path.GetFileNameWithoutExtension(filePath);
        //}



        //// Writing the new file methods



    }
}
