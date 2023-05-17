using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp {
  public partial class FormNote : Form {
    private Note note;

    public FormNote() {
      InitializeComponent();
    }

    public FormNote(Note note) : this() {
      this.note = note;
    }

    public void ShowNote() {
      tbNoteName.Text = note.Name;
      tbNoteContent.Text = note.Content;
      Text = $"Bilješka: {note.Name}";
      tbNoteContent.Focus();
    }

    private void FormNote_Load(object sender, EventArgs e) {
      if (note != null) {
        ShowNote();
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      var result = MessageBox.Show(
        "Jeste li sigurni da želite obrisati bilješku?",
        "Brisanje bilješke",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

      if (result == DialogResult.Yes) {
        // brisanje bilješke u bazi podataka
        this.Close();
      }
    }
  }
}
