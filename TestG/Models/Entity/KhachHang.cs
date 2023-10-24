namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            TiepNhanXes = new HashSet<TiepNhanXe>();
        }

        [Key]
        public int IDKhachHang { get; set; }

        [StringLength(50)]
        public string Tên { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(150)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiepNhanXe> TiepNhanXes { get; set; }
    }
}
