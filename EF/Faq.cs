namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Faq")]
    public partial class Faq
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
