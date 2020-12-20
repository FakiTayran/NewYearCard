
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewYearCard.Models
{
    [Table("Cards")]
    public class Card
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This card has to header")]
        [StringLength(20)]
        public string Header { get; set; }

        public string SenderName { get; set; }

        [Required]
        [StringLength(200)]
        public string MessageLine1 { get; set; }
        public string MessageLine2 { get; set; }
        public string MessageLine3 { get; set; }

        [Required(ErrorMessage = "You have to select one card from under")]
        public string PictureName { get; set; }


    }
}