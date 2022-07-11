
namespace tlumacz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePath = new System.Windows.Forms.Button();
            this.PathToRead = new System.Windows.Forms.TextBox();
            this.PathToSave = new System.Windows.Forms.TextBox();
            this.SavePath = new System.Windows.Forms.Button();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.CausesValidation = false;
            this.FilePath.Location = new System.Drawing.Point(12, 94);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(233, 23);
            this.FilePath.TabIndex = 0;
            this.FilePath.Text = "Ścieżka do odczytania pliku";
            this.FilePath.UseVisualStyleBackColor = true;
            this.FilePath.Click += new System.EventHandler(this.FilePath_Click);
            // 
            // PathToRead
            // 
            this.PathToRead.Location = new System.Drawing.Point(12, 40);
            this.PathToRead.Name = "PathToRead";
            this.PathToRead.ReadOnly = true;
            this.PathToRead.Size = new System.Drawing.Size(233, 20);
            this.PathToRead.TabIndex = 1;
            // 
            // PathToSave
            // 
            this.PathToSave.Location = new System.Drawing.Point(276, 40);
            this.PathToSave.Name = "PathToSave";
            this.PathToSave.ReadOnly = true;
            this.PathToSave.Size = new System.Drawing.Size(233, 20);
            this.PathToSave.TabIndex = 3;
            // 
            // SavePath
            // 
            this.SavePath.CausesValidation = false;
            this.SavePath.Location = new System.Drawing.Point(276, 94);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(233, 23);
            this.SavePath.TabIndex = 4;
            this.SavePath.Text = "Ścieżka do zapisu pliku";
            this.SavePath.UseVisualStyleBackColor = true;
            this.SavePath.Click += new System.EventHandler(this.SavePath_Click);
            // 
            // TranslateButton
            // 
            this.TranslateButton.CausesValidation = false;
            this.TranslateButton.Location = new System.Drawing.Point(155, 173);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(233, 23);
            this.TranslateButton.TabIndex = 5;
            this.TranslateButton.Text = "Przetłumacz plik";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ścieżka do odczytania pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ścieżka zapisu nowego pliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.PathToSave);
            this.Controls.Add(this.PathToRead);
            this.Controls.Add(this.FilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilePath;
        private System.Windows.Forms.TextBox PathToRead;
        private System.Windows.Forms.TextBox PathToSave;
        private System.Windows.Forms.Button SavePath;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

