using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CD_Collection.Models
{
    public class Album
    {

        public int AlbumId { get; set; }

        [Display(Name = "Albumtitel")]
        public string Title { get; set; }


        //Sätter främmande nyckel
        [Display(Name = "Artist")]
        public string ArtistName { get; set; }
        public Artist Artist { get; set; }

        public string Genre { get; set; }

        [Display(Name = "Releasedatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Antal låtar")]
        public int NumberOfTracks { get; set; }

        [Display(Name = "Speltid i minuter")]
        public int TotalPlayTime { get; set; }
    }
}
