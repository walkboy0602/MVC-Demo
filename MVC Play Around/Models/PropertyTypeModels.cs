using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Play_Around.Models
{
    [MetadataType(typeof(PropertyTypeModels))]
    public partial class PropertyType { }

    public class PropertyTypeModels
    {
        [Required]
        public string name { get; set; }
    }
}