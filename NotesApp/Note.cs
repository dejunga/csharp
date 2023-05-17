namespace NotesApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Note
    {
        public Note() { }
        public Note(string name, string content) {
            Name = name; 
            Content = content; 
        }
        public int? Id { get; set; }

        public string Content { get; set; }

        public string Name { get; set; }

        public override string ToString() {
            return $"{Name} ({Content.Length} znakova)";
        }
    }
}
