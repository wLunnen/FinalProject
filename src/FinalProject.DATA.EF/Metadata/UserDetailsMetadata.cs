using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.DATA.EF
{
    public class UserDetailsMetadata
    {
        [Required]
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
    [MetadataType(typeof(UserDetailsMetadata))]
    public partial class UserDetail
    {
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
