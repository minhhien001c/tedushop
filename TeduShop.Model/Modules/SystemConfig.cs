﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Modules
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]       
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName="varchar")]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }

    }
}
