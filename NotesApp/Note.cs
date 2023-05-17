using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp {
  // OBRISITE OVU DATOTEKU JER CE BITI GENERIRANA
  // NA TEMELJU BAZE PODATAKA -> ENTITY

  public class Note {
    public Note(int id, string name, string content) {
      Id = id;
      Name = name;
      Content = content;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }

    public override string ToString() {
      return $"{Name} ({Content.Length} znakova)";
    }
  }
}
