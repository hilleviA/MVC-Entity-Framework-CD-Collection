using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CD_Collection.Models
{
    public class Artist
    {
        [Key]
        [Display(Name = "Artist")]
        public string ArtistName { get; set; }

        
        [Display(Name = "Födelsedatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }
        

        [Display(Name = "Skivbolag")]
        public string RecordCompany { get; set; }

        [Display(Name = "Albums")]
        public ICollection<Album> Albums { get; set; }
    }
}
