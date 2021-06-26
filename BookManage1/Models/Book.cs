namespace BookManage1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Required(ErrorMessage = "ID không ???c ?? tr?ng")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu ?? không ???c ?? tr?ng")]
        [StringLength(100, ErrorMessage = "Tiêu ?? không ???c quá 100 ký t?")]
        [Display(Name = "Tiêu ??")]
        public string Title { get; set; }

        [Required(ErrorMessage = "N?i dung không ???c ?? tr?ng")]
        [Display(Name = "N?i dung")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tác gi? không ???c ?? tr?ng")]
        [StringLength(30, ErrorMessage = "Tác gi? không ???c quá 30 ký t?")]
        [Display(Name = "Tác gi?")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Hình ?nh không ???c ?? tr?ng")]
        [Display(Name = "Hình ?nh")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Giá không ???c ?? tr?ng")]
        [Display(Name = "Giá")]
        [Range(1000, 1000000, ErrorMessage = "Giá ph?i t? 1000 ??n 1000000")]
        public int? Price { get; set; }
    }
}
