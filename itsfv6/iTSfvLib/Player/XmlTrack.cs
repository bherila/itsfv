﻿using HelpersLib;
using iTSfvLib.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TagLib;

namespace iTSfvLib
{
    public class XmlTrack
    {
        #region "Read/Write Properties"

        public DateTime PlayedDate { get; set; }
        public DateTime SkippedDate { get; set; }
        public bool Compilation { get; set; }
        public bool Enabled { get; set; }
        public bool ExcludeFromShuffle { get; set; }
        public bool PartOfGaplessAlbum { get; set; }
        public bool RememberBookmark { get; set; }
        public bool Unplayed { get; set; }
        public int AlbumRating { get; set; }
        public int BPM { get; set; }
        public int BookmarkTime { get; set; }
        public int EpisodeNumber { get; set; }
        public int Finish { get; set; }
        public int PlayedCount { get; set; }
        public int Rating { get; set; }
        public int SeasonNumber { get; set; }
        public int SkippedCount { get; set; }
        public int Start { get; set; }
        public int VolumeAdjustment { get; set; }
        public string Category { get; set; }
        public string Comment { get; set; }
        public string Composer { get; set; }
        public string Description { get; set; }
        public string EQ { get; set; }
        public string Grouping { get; set; }
        public string Location { get; set; }
        public string LongDescription { get; set; }
        public string Lyrics { get; set; }
        public string Show { get; set; }
        public string SortComposer { get; set; }
        public string SortName { get; set; }
        public string SortShow { get; set; }
        public string URL { get; set; }

        #endregion "Read/Write Properties"

        #region "Read Only Properties"

        public string AlbumArtist
        {
            get
            {
                if (Tags.AlbumArtists.Length > 0)
                    return string.Join("/", Tags.AlbumArtists);

                return Artist;
            }
        }

        public string Artist
        {
            get
            {
                if (Tags.Performers.Length > 0)
                    return string.Join("/", Tags.Performers);

                return string.Empty;
            }
        }

        public string Genre
        {
            get
            {
                if (Tags.Genres.Length > 0)
                    return string.Join("/", Tags.Genres);

                return string.Empty;
            }
        }

        public DateTime DateAdded { get; private set; }
        public DateTime ModificationDate { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public List<XmlArtwork> Artwork
        {
            get
            {
                if (Tags.Pictures.Length > 0)
                {
                    List<XmlArtwork> artworks = new List<XmlArtwork>();
                    foreach (Picture pic in Tags.Pictures)
                    {
                        artworks.Add(new XmlArtwork(pic));
                    }

                    return artworks;
                }
                return null;
            }
        }
        public bool Podcast { get; private set; }
        public int BitRate { get; private set; }
        public int Duration { get; private set; }
        public int Index { get; private set; }
        public int PlayOrderIndex { get; private set; }
        public int SampleRate { get; private set; }
        public int Size { get; private set; }
        public int Size64High { get; private set; }
        public int Size64Low { get; private set; }
        public int TrackDatabaseID { get; private set; }
        public int playlistID { get; private set; }
        public int sourceID { get; private set; }
        public int trackID { get; private set; }
        public string KindAsString { get; private set; }
        public string Time { get; private set; }

        public string FileName
        {
            get
            {
                return !string.IsNullOrEmpty(Location) ? Path.GetFileName(Location) : string.Empty;
            }
        }

        #endregion "Read Only Properties"

        public TagLib.Tag Tags { get; private set; }
        public bool IsModified { get; private set; }

        public XmlTrack(string fp)
        {
            Location = fp;
            UpdateInfoFromFile(fp);
        }

        public string GetAlbumKey()
        {
            if (!string.IsNullOrEmpty(this.AlbumArtist) && !string.IsNullOrEmpty(this.Tags.Album))
            {
                return string.Format("{0} - {1}", this.Tags.Album, this.AlbumArtist);
            }
            return ConstantStrings.UnknownAlbum;
        }

        public string GetDiscKey()
        {
            if (!string.IsNullOrEmpty(this.AlbumArtist) && !string.IsNullOrEmpty(this.Tags.Album))
            {
                return string.Format("{0} Disc {1} - {2}", this.Tags.Album, Tags.Disc.ToString("000"), this.AlbumArtist);
            }

            return string.Format("{0} Disc {1} - {2}", ConstantStrings.UnknownDisc, Tags.Disc.ToString("000"), ConstantStrings.UnknownArtist);
        }

        private string CombineString(string[] array, string seperator = "/")
        {
            StringBuilder sb = new StringBuilder();
            foreach (string band in array)
            {
                if (!string.IsNullOrEmpty(band))
                {
                    sb.Append(band);
                    sb.Append(seperator);
                }
            }
            if (sb.Length > 1)
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }


        public void Play()
        {
            try
            {
                Process.Start(this.Location);
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error playing track", ex);
            }
        }

        public void UpdateInfoFromFile(string fp)
        {
            try
            {
                using (TagLib.File f = TagLib.File.Create(Location, ReadStyle.None))
                {
                    f.RemoveTags(f.TagTypes & ~f.TagTypesOnDisk);
                    this.Tags = f.Tag;
                }
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error updating info from file", ex);
            }
        }

        public void WriteTagsToFile()
        {
            try
            {
                using (TagLib.File f = TagLib.File.Create(Location))
                {
                    f.Tag.Track = Tags.Track;
                    f.Tag.TrackCount = Tags.TrackCount;
                    f.Tag.Title = Tags.Title;
                    f.Tag.AlbumArtists = Tags.AlbumArtists;
                    f.Tag.Performers = Tags.Performers;
                    f.Tag.Disc = Tags.Disc;
                    f.Tag.DiscCount = Tags.DiscCount;
                    f.Tag.Album = Tags.Album;
                    f.Tag.Genres = Tags.Genres;
                    f.Tag.Year = Tags.Year;
                    f.Tag.Pictures = Tags.Pictures;
                    f.Save();
                }
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error writing tags to file", ex);
            }
        }

        public bool AddArtwork(string fp)
        {
            if (System.IO.File.Exists(fp))
            {
                FileInfo fileInfo = new FileInfo(fp);
                fileInfo.IsReadOnly = false;
                fileInfo.Refresh();

                TagLib.Picture picture = new Picture(fp);
                TagLib.Id3v2.AttachedPictureFrame albumCoverPictFrame = new TagLib.Id3v2.AttachedPictureFrame(picture);
                albumCoverPictFrame.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                albumCoverPictFrame.Type = TagLib.PictureType.FrontCover;
                TagLib.IPicture[] pictFrames = new IPicture[1];
                pictFrames[0] = (IPicture)albumCoverPictFrame;
                this.Tags.Pictures = pictFrames;

                return IsModified = true;
            }

            return false;
        }

        public void AddArtwork(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] myBytes = ms.ToArray();
            ByteVector byteVector = new ByteVector(myBytes, myBytes.Length);
            TagLib.Picture picture = new Picture(byteVector);
            TagLib.Id3v2.AttachedPictureFrame albumCoverPictFrame = new TagLib.Id3v2.AttachedPictureFrame(picture);
            albumCoverPictFrame.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
            albumCoverPictFrame.Type = TagLib.PictureType.FrontCover;
            this.Tags.Pictures = new IPicture[1] { (IPicture)albumCoverPictFrame };

            IsModified = true;
        }

        public bool CheckMissingTags(ReportWriter report)
        {
            DebugHelper.WriteLine("Checking for missing tags in " + this.FileName);

            List<string> missingTags = new List<string>();

            if (string.IsNullOrEmpty(this.Tags.Title))
            {
                missingTags.Add("Title");
            }

            if (string.IsNullOrEmpty(this.Artist))
            {
                missingTags.Add("Artist");
            }

            if (string.IsNullOrEmpty(this.AlbumArtist))
            {
                missingTags.Add("Album Artist");
            }

            if (string.IsNullOrEmpty(this.Genre))
            {
                missingTags.Add("Genre");
            }

            if (this.Tags.Pictures.Length == 0)
            {
                missingTags.Add("Artwork");
            }

            if (this.Tags.Track == 0)
            {
                missingTags.Add("Track Number");
            }

            if (this.Tags.TrackCount == 0)
            {
                missingTags.Add("Track Count");
            }

            if (this.Tags.Disc == 0)
            {
                missingTags.Add("Disc Number");
            }

            if (this.Tags.DiscCount == 0)
            {
                missingTags.Add("Disc Count");
            }

            if (this.Tags.Year == 0)
            {
                missingTags.Add("Year");
            }

            if (missingTags.Count > 0)
            {
                report.AddTrackMissingTags(this, missingTags);
            }

            return missingTags.Count == 0;
        }

        internal void FillTrackCount(List<XmlAlbum> Albums, List<XmlDisc> Discs, ReportWriter reportWriter)
        {
            XmlDisc disc = Discs.FirstOrDefault(x => x.Key == this.GetDiscKey());
            if (disc != null)
            {
                if (this.Tags.TrackCount == 0)
                {
                    IsModified = true;
                    this.Tags.TrackCount = (uint)disc.Tracks.Count;
                }
            }

            XmlAlbum album = Albums.FirstOrDefault(x => x.Key == this.GetAlbumKey());
            if (album != null)
            {
                if (this.Tags.DiscCount == 0)
                {
                    this.Tags.DiscCount = (uint)album.Discs.Count;
                    IsModified = true;
                }

                if (this.Tags.Disc == 0 && album.Discs.Count == 1)
                {
                    this.Tags.Disc = 1; // for single disc albums you can specify DiscNumber
                    IsModified = true;
                }
            }
        }

        internal void FillAlbumArtist(List<XmlAlbum> Albums, ReportWriter reportWriter)
        {
            XmlAlbum album = Albums.FirstOrDefault(x => x.Key == this.GetAlbumKey());
            if (album != null)
            {
                if (this.Tags.AlbumArtists.Length == 0)
                {
                    this.Tags.AlbumArtists = new string[] { album.AlbumArtist };
                    IsModified = true;
                }
            }
        }

        internal void FillGenre(List<XmlDisc> Discs, ReportWriter reportWriter)
        {
            XmlDisc disc = Discs.FirstOrDefault(x => x.Key == this.GetDiscKey());
            if (disc != null)
            {
                if (this.Tags.Genres.Length == 0)
                {
                    this.Tags.Genres = new string[] { disc.Genre };
                    IsModified = true;
                }
            }
        }

        internal bool ExportArtwork(XMLSettings config)
        {
            if (this.Tags.Pictures.Length > 0)
            {
                try
                {
                    string ext = "jpg";
                    string[] mime = this.Tags.Pictures[0].MimeType.ToString().Trim().Split('/');
                    if (mime.Length > 1)
                        ext = mime[1].Replace("jpeg", "jpg");

                    string fp = Path.Combine(Path.GetDirectoryName(this.Location), config.ArtworkFileNameWithoutExtension + "." + ext);

                    using (FileStream fs = new FileStream(fp, FileMode.Create))
                    {
                        fs.Write(this.Tags.Pictures[0].Data.Data, 0, this.Tags.Pictures[0].Data.Data.Length);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    DebugHelper.WriteException(ex, "while exporting artwork");
                }
            }

            return false;
        }


        internal void EmbedArtwork(XMLSettings xMLSettings, ReportWriter reportWriter)
        {
            if (this.Tags.Pictures.Length == 0)
            {
                foreach (string fileName in xMLSettings.ArtworkLookupFileNames)
                {
                    string fp = Path.Combine(Path.GetDirectoryName(this.Location), fileName);
                    if (AddArtwork(fp))
                        break;
                }
            }
        }
    }
}