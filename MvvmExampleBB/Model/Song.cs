using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleBB.Model
{
    public class Song
    {
        private string _artistName;
        private string _songTitle;

        public string ArtistName { get => this._artistName; set => this._artistName = value; }

        //public string ArtistName
        //{
        //    get { return _artistName; }
        //    set { _artistName = value; }
        //}

        public string SongTitle { get => this._songTitle; set => this._songTitle = value; }

        //public string GetSongTitle()
        //{
        //    return this._songTitle;
        //}
        //public void SetSongTitle(string value)
        //{
        //    this._songTitle = value;
        //}
    }
}
