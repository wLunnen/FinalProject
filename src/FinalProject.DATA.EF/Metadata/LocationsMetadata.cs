using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.DATA.EF
{
    public class LocationsMetadata
    {
        [Required]
        [Display(Name = "Locations Id")]
        public int LocationsId { get; set; }
        [Required]
        [Display(Name = "Locations Name")]
        public string LocationsName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Required]
        [Display(Name = "Reservations Limit")]
        public byte ReservationsLimit { get; set; }

    }
    [MetadataType(typeof(LocationsMetadata))]
    public partial class Location
    {
    }
}
