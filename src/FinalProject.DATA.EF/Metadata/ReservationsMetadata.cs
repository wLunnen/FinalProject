using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.DATA.EF
{
    public class ReservationsMetadata
    {
        [Required]
        [Display(Name = "Reservations Id")]
        public int ReservationsId { get; set; }
        [Required]
        [Display(Name = "Owner Asset Id")]
        public int OwnerAssetsId { get; set; }
        [Required]
        [Display(Name = "Locations Id")]
        public int LocationsId { get; set; }
        [Required]
        [Display(Name = "Reservations Date")]
        public System.DateTime ReservationsDate { get; set; }
        [Required]
        [Display(Name = "Locations")]
        public virtual Location Locations { get; set; }
        [Required]
        [Display(Name = "Owner Asset")]
        public virtual OwnerAsset OwnerAssets { get; set; }
    }
    [MetadataType(typeof(ReservationsMetadata))]
    public partial class Reservation
    {
    }
}
