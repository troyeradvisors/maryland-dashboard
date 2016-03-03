using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class Home
    {
        [Key]
        public int PIN { get; set; }
        [Required]
        public string City { get; set; }
        public int CountyCode { get; set; }
        [Required]
        public string CountyName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Required]
        public string Name { get; set; }
        public long Phone { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        [Required]
        public string Street { get; set; }
        public int ZipCode { get; set; }
    }
}
