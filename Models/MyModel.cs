using System;
using System.ComponentModel.DataAnnotations;

namespace LostintheWoods.Models
{
    public class Woods
    {
        [Key]
        public int WoodsId {get;set;}
        [Required]
        public string TrailName {get;set;}
        [MinLength(10, ErrorMessage="Description to short.")]
        public string Description {get;set;}
        [Required]
        public int TrailLength {get;set;}
        [Required]
        public int Elevation {get;set;}
        [Required]
        [Display(Name="Logitude and Latitued")]
        public int Logitude {get;set;}
        [Required]
        public int Latitude {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}