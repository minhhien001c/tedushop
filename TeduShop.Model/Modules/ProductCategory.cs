﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Modules
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tu dong tang
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
