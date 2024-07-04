namespace DatumRaadas
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
            this.dtTmPckrMaiDatum = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrPontosIdo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnErtekeles = new System.Windows.Forms.Button();
            this.btnBezaras = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTmPckrMaiDatum
            // 
            this.dtTmPckrMaiDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrMaiDatum.Location = new System.Drawing.Point(53, 88);
            this.dtTmPckrMaiDatum.Name = "dtTmPckrMaiDatum";
            this.dtTmPckrMaiDatum.Size = new System.Drawing.Size(104, 20);
            this.dtTmPckrMaiDatum.TabIndex = 0;
            this.dtTmPckrMaiDatum.Value = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // dtTmPckrPontosIdo
            // 
            this.dtTmPckrPontosIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrPontosIdo.Location = new System.Drawing.Point(203, 88);
            this.dtTmPckrPontosIdo.Name = "dtTmPckrPontosIdo";
            this.dtTmPckrPontosIdo.ShowUpDown = true;
            this.dtTmPckrPontosIdo.Size = new System.Drawing.Size(82, 20);
            this.dtTmPckrPontosIdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a talalkozo ideje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a talalkozo ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "aktualis ido:";
            // 
            // btnErtekeles
            // 
            this.btnErtekeles.Location = new System.Drawing.Point(38, 253);
            this.btnErtekeles.Name = "btnErtekeles";
            this.btnErtekeles.Size = new System.Drawing.Size(75, 23);
            this.btnErtekeles.TabIndex = 5;
            this.btnErtekeles.Text = "Értékel";
            this.btnErtekeles.UseVisualStyleBackColor = true;
            this.btnErtekeles.Click += new System.EventHandler(this.btnErtekel_Click_1);
            // 
            // btnBezaras
            // 
            this.btnBezaras.Location = new System.Drawing.Point(121, 305);
            this.btnBezaras.Name = "btnBezaras";
            this.btnBezaras.Size = new System.Drawing.Size(75, 23);
            this.btnBezaras.TabIndex = 6;
            this.btnBezaras.Text = "Bezár";
            this.btnBezaras.UseVisualStyleBackColor = true;
            this.btnBezaras.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(203, 253);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 7;
            this.btnTorles.Text = "Töröl";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.BackColor = System.Drawing.Color.Transparent;
            this.lblErtekeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.Brown;
            this.lblErtekeles.Location = new System.Drawing.Point(2, 215);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(310, 23);
            this.lblErtekeles.TabIndex = 8;
            this.lblErtekeles.Text = "Ertekeles";
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Location = new System.Drawing.Point(123, 156);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(0, 13);
            this.lblTalalkozo.TabIndex = 9;
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Location = new System.Drawing.Point(123, 187);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(102, 13);
            this.lblAktualis.TabIndex = 10;
            this.lblAktualis.Text = "meg nincs megadva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 359);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnBezaras);
            this.Controls.Add(this.btnErtekeles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTmPckrPontosIdo);
            this.Controls.Add(this.dtTmPckrMaiDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Találkozó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPckrMaiDatum;
        private System.Windows.Forms.DateTimePicker dtTmPckrPontosIdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnErtekeles;
        private System.Windows.Forms.Button btnBezaras;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label lblAktualis;
    }
}

