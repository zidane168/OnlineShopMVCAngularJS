namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]    
    public partial class Category
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "ký tự tối đa = 50")]        
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public int? ParentID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? IsOder { get; set; }

        public bool? Status { get; set; }
    }
}
