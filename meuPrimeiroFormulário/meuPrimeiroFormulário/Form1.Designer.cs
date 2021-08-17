
namespace meuPrimeiroFormulário
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(216, 19);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(65, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(12, 24);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(90, 13);
            this.numeroLabel.TabIndex = 1;
            this.numeroLabel.Text = "digite um número:";
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(108, 21);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(102, 20);
            this.tabuadaTextBox.TabIndex = 2;
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.Location = new System.Drawing.Point(15, 47);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(266, 212);
            this.tabuadaListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 278);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.tabuadaTextBox);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.okButton);
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

