using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Play_Around.Models
{
    [MetadataType(typeof(RefCategoryModel))]
    public partial class RefCategory
    {

    }

    public class RefCategoryModel
    {
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Name must be between {2} and {1} character long.")]
        public string Name { get; set; }
    }
}