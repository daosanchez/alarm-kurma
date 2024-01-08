namespace datetime_kullanimi3
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
            this.components = new System.ComponentModel.Container();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpZaman = new System.Windows.Forms.DateTimePicker();
            this.btnKur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMesaj.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(21, 195);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(39, 36);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "....";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurdur.Location = new System.Drawing.Point(12, 111);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(136, 44);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslat.Location = new System.Drawing.Point(12, 61);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(136, 44);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = " BASLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpZaman
            // 
            this.dtpZaman.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZaman.Location = new System.Drawing.Point(178, 18);
            this.dtpZaman.Name = "dtpZaman";
            this.dtpZaman.Size = new System.Drawing.Size(165, 20);
            this.dtpZaman.TabIndex = 4;
            // 
            // btnKur
            // 
            this.btnKur.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKur.Location = new System.Drawing.Point(12, 11);
            this.btnKur.Name = "btnKur";
            this.btnKur.Size = new System.Drawing.Size(136, 44);
            this.btnKur.TabIndex = 5;
            this.btnKur.Text = "ALARMI KUR";
            this.btnKur.UseVisualStyleBackColor = true;
            this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.btnKur);
            this.Controls.Add(this.dtpZaman);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpZaman;
        private System.Windows.Forms.Button btnKur;
    }
}

