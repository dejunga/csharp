namespace NotesApp {
  partial class FormNotesList {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lbNotes = new System.Windows.Forms.ListBox();
      this.btnNewNote = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbNotes
      // 
      this.lbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbNotes.FormattingEnabled = true;
      this.lbNotes.Location = new System.Drawing.Point(12, 12);
      this.lbNotes.Name = "lbNotes";
      this.lbNotes.Size = new System.Drawing.Size(348, 472);
      this.lbNotes.TabIndex = 0;
      this.lbNotes.DoubleClick += new System.EventHandler(this.lbNotes_DoubleClick);
      // 
      // btnNewNote
      // 
      this.btnNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNewNote.Image = global::NotesApp.Properties.Resources.icons8_create_24;
      this.btnNewNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnNewNote.Location = new System.Drawing.Point(12, 497);
      this.btnNewNote.Name = "btnNewNote";
      this.btnNewNote.Size = new System.Drawing.Size(348, 36);
      this.btnNewNote.TabIndex = 1;
      this.btnNewNote.Text = "Nova bilješka";
      this.btnNewNote.UseVisualStyleBackColor = true;
      this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
      // 
      // FormNotesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(372, 545);
      this.Controls.Add(this.btnNewNote);
      this.Controls.Add(this.lbNotes);
      this.Name = "FormNotesList";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Notes";
      this.Load += new System.EventHandler(this.NotesList_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbNotes;
    private System.Windows.Forms.Button btnNewNote;
  }
}

