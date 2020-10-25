namespace richtext.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class fit5032_model : DbContext
    {
        public fit5032_model()
            : base("name=fit5032_model")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
}
