using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.DATA.EF
{
    public class OwnerAssetsMetadata
    {
        [Required]
        [Display(Name = "Owner Asset Id")]
        public int OwnerAssetsId { get; set; }
        [Required]
        [Display(Name = "Asset Name")]
        public string AssetName { get; set; }
        [Required]
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Asset Photo")]
        public string AssetPhoto { get; set; }
        [Required]
        [Display(Name = "Special Notes")]
        public string SpecialNotes { get; set; }
        [Required]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public System.DateTime DateAdded { get; set; }
        
    }
    [MetadataType(typeof(OwnerAssetsMetadata))]
    public partial class OwnerAsset
    {
    }
}
