using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp {
    // MORA SADRŽAVATI REFERENCU NA CONTEXT

    public class Notes {
        private NotesAppContext db;

        public Notes() {
            db = new NotesAppContext();
        }

        public IEnumerable<Note> GetNotes() {
            return
              from n in db.Notes
              orderby n.Name
              select n;
        }

        public Note GetNote(int id) {
            var note =
              from n in db.Notes
              where n.Id == id
              select n;

            if (!note.Any()) {
                return null;
            }

            return note.First();
        }

        public void DeleteNote(Note note) {
            var noteh =
              (from n in db.Notes
               where n.Id == note.Id
               select n).First();

            db.Notes.Remove(noteh);
            db.SaveChanges();
        }

        public void UpdateNote(Note note) {
            db.Notes.AddOrUpdate(note);
            db.SaveChanges();
            

        }
    }
}
