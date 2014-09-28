using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kubizam.Models
{
    public class Country
    {
        [Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Region> Regions { get; set; }   
    }

    public class Region
    {
        [Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RegionId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }
    }
}