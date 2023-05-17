namespace NotesApp {
  partial class FormNote {
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
      this.tbNoteName = new System.Windows.Forms.TextBox();
      this.lblNoteName = new System.Windows.Forms.Label();
      this.lblNoteContent = new System.Windows.Forms.Label();
      this.tbNoteContent = new System.Windows.Forms.TextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbNoteName
      // 
      this.tbNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbNoteName.Location = new System.Drawing.Point(12, 31);
      this.tbNoteName.Name = "tbNoteName";
      this.tbNoteName.Size = new System.Drawing.Size(738, 20);
      this.tbNoteName.TabIndex = 0;
      // 
      // lblNoteName
      // 
      this.lblNoteName.AutoSize = true;
      this.lblNoteName.Location = new System.Drawing.Point(12, 15);
      this.lblNoteName.Name = "lblNoteName";
      this.lblNoteName.Size = new System.Drawing.Size(37, 13);
      this.lblNoteName.TabIndex = 1;
      this.lblNoteName.Text = "Naziv:";
      // 
      // lblNoteContent
      // 
      this.lblNoteContent.AutoSize = true;
      this.lblNoteContent.Location = new System.Drawing.Point(12, 67);
      this.lblNoteContent.Name = "lblNoteContent";
      this.lblNoteContent.Size = new System.Drawing.Size(45, 13);
      this.lblNoteContent.TabIndex = 3;
      this.lblNoteContent.Text = "Sadržaj:";
      // 
      // tbNoteContent
      // 
      this.tbNoteContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbNoteContent.Location = new System.Drawing.Point(12, 83);
      this.tbNoteContent.Multiline = true;
      this.tbNoteContent.Name = "tbNoteContent";
      this.tbNoteContent.Size = new System.Drawing.Size(738, 466);
      this.tbNoteContent.TabIndex = 2;
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnDelete.Image = global::NotesApp.Properties.Resources.trash__1_;
      this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDelete.Location = new System.Drawing.Point(12, 555);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(116, 47);
      this.btnDelete.TabIndex = 5;
      this.btnDelete.Text = "Obriši";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Image = global::NotesApp.Properties.Resources.diskette;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(634, 555);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(116, 47);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Pohrani";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // FormNote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(762, 610);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblNoteContent);
      this.Controls.Add(this.tbNoteContent);
      this.Controls.Add(this.lblNoteName);
      this.Controls.Add(this.tbNoteName);
      this.Name = "FormNote";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Load += new System.EventHandler(this.FormNote_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbNoteName;
    private System.Windows.Forms.Label lblNoteName;
    private System.Windows.Forms.Label lblNoteContent;
    private System.Windows.Forms.TextBox tbNoteContent;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnDelete;
  }
}