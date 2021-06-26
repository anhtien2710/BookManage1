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
        [Required(ErrorMessage = "ID kh�ng ???c ?? tr?ng")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ti�u ?? kh�ng ???c ?? tr?ng")]
        [StringLength(100, ErrorMessage = "Ti�u ?? kh�ng ???c qu� 100 k� t?")]
        [Display(Name = "Ti�u ??")]
        public string Title { get; set; }

        [Required(ErrorMessage = "N?i dung kh�ng ???c ?? tr?ng")]
        [Display(Name = "N?i dung")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "T�c gi? kh�ng ???c ?? tr?ng")]
        [StringLength(30, ErrorMessage = "T�c gi? kh�ng ???c qu� 30 k� t?")]
        [Display(Name = "T�c gi?")]
        public string Author { get; set; }

        [Required(ErrorMessage = "H�nh ?nh kh�ng ???c ?? tr?ng")]
        [Display(Name = "H�nh ?nh")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Gi� kh�ng ???c ?? tr?ng")]
        [Display(Name = "Gi�")]
        [Range(1000, 1000000, ErrorMessage = "Gi� ph?i t? 1000 ??n 1000000")]
        public int? Price { get; set; }
    }
}
