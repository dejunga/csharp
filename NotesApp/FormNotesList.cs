using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp {
  public partial class FormNotesList : Form {
    private Notes notes;

    public FormNotesList() {
      InitializeComponent();
      notes = new Notes();
    }

    public void RefreshNotesList() {
      lbNotes.Items.Clear();
      lbNotes.Items.AddRange(notes.GetNotes().ToArray());
    }

    public void ShowNote(Note note) {
      var formNote = new FormNote(note);
      formNote.ShowDialog();
      RefreshNotesList();
    }

    private void NotesList_Load(object sender, EventArgs e) {
      RefreshNotesList();
    }

    private void lbNotes_DoubleClick(object sender, EventArgs e) {
      var note = (Note)lbNotes.SelectedItem;

      if (note != null) {
        ShowNote(note);
      }
    }

    private void btnNewNote_Click(object sender, EventArgs e) {
      ShowNote(null);
    }
  }
}
