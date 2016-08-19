using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Modules
{
    [Table("Tags")]
    public class ProductTag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName="varchar")]
        public string TagID { set; get; }

        [Key]
        public int ProductID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

    }
}
