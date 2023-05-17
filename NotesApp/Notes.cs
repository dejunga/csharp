using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp {
  // MORA SADRŽAVATI REFERENCU NA CONTEXT
  // private NotesAppContext db;

  public class Notes {
    // obrisati ovo jer ce se dohvacati iz baze
    // --- ✂ ---
    private List<Note> notes = new List<Note> {
        new Note(1, "Prva", "Ovo je bilješka"),
        new Note(2, "Druga", "Ovo je druga bilješka"),
    };
    // --- ✂ ---

    public Notes() {
      // var db = new NotesAppContext();
    }

    public IEnumerable<Note> GetNotes() {
      return
        from n in notes // db.Notes
        orderby n.Name
        select n;
    }

    public Note GetNote(int id) {
      var note =
        from n in notes // db.Notes
        where n.Id == id
        select n;

      if (!note.Any()) {
        return null;
      }

      return note.First();
    }

    public void DeleteNote(Note note) {
      // delete note code goes here
    }

    public void UpdateNote(Note note) {
      // update note code goes here
    }
  }
}
