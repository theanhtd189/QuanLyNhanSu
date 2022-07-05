namespace BTL_QLNS.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LUONG")]
    public partial class LUONG
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string ID_NV { get; set; }

        public double? LuongCu { get; set; }

        public double? LuongMoi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThayDoi { get; set; }
    }
}
