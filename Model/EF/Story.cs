namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Story")]
    public partial class Story
    {
        public long ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string CodeID { get; set; }

        [StringLength(100)]
        public string MetaTitle { get; set; }

        public long? AuthorID { get; set; }

        public int? ChapterNumber { get; set; }

        public long? CategoryID { get; set; }

        public long? CreditID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public string Detail { get; set; }

        public long? Trouble { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeyWork { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }
    }
}
