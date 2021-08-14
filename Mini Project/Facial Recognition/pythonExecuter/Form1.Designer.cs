namespace pythonExecuter
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
            this.runB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runB
            // 
            this.runB.BackColor = System.Drawing.Color.SlateBlue;
            this.runB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.runB.Location = new System.Drawing.Point(257, 144);
            this.runB.Name = "runB";
            this.runB.Size = new System.Drawing.Size(274, 84);
            this.runB.TabIndex = 0;
            this.runB.Text = "Click me to run the Python Script";
            this.runB.UseVisualStyleBackColor = false;
            this.runB.Click += new System.EventHandler(this.runB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openB
            // 
            this.openB.Location = new System.Drawing.Point(276, 65);
            this.openB.Name = "openB";
            this.openB.Size = new System.Drawing.Size(226, 23);
            this.openB.TabIndex = 1;
            this.openB.Text = "Browse Python Scripts";
            this.openB.UseVisualStyleBackColor = true;
            this.openB.Click += new System.EventHandler(this.openB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output:-";
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Location = new System.Drawing.Point(254, 329);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(0, 17);
            this.opLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openB);
            this.Controls.Add(this.runB);
            this.Name = "Form1";
            this.Text = "pythonExecuter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label opLabel;
    }
}

