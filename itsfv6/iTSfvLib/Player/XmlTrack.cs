﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

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

        public string Band
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

        public DateTime DateAdded { get; private set; }

        public DateTime ModificationDate { get; private set; }

        public DateTime ReleaseDate { get; private set; }

        public List<XmlArtwork> Artwork { get; private set; }

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

        public XmlTrack(string fp)
        {
            Artwork = new List<XmlArtwork>();
            Location = fp;
            UpdateInfoFromFile(fp);
        }

        public string GetAlbumKey()
        {
            if (!string.IsNullOrEmpty(this.Band) && !string.IsNullOrEmpty(this.Tags.Album))
            {
                return string.Format("{0} - {1}", this.Tags.Album, this.Band);
            }
            return ConstantStrings.UnknownAlbum;
        }

        public string GetDiscKey()
        {
            if (!string.IsNullOrEmpty(this.Band) && !string.IsNullOrEmpty(this.Tags.Album))
            {
                return string.Format("{0} Disc {1} - {2}", this.Tags.Album, Tags.Disc.ToString("000"), this.Band);
            }

            return string.Format("{0} Disc {1} - {2}", ConstantStrings.UnknownDisc, Tags.Disc.ToString("000"), ConstantStrings.UnknownArtist);
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
                using (TagLib.File f = TagLib.File.Create(Location, TagLib.ReadStyle.Average))
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
                    f.Save();
                }
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error writing tags to file", ex);
            }
        }
    }
}