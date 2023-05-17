using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NotesApp {
    public partial class NotesAppContext : DbContext {
        public NotesAppContext()
            : base("name=NotesAppContext") {
        }

        public virtual DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        }
    }
}
