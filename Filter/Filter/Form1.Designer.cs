namespace Filter
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
            this.labelnama = new System.Windows.Forms.Label();
            this.textBoxitem = new System.Windows.Forms.TextBox();
            this.labelkategori = new System.Windows.Forms.Label();
            this.panelpilihan = new System.Windows.Forms.Panel();
            this.radioButtonminum = new System.Windows.Forms.RadioButton();
            this.radioButtonmakan = new System.Windows.Forms.RadioButton();
            this.buttoninput = new System.Windows.Forms.Button();
            this.listBoxdaftar = new System.Windows.Forms.ListBox();
            this.listBoxfilter = new System.Windows.Forms.ListBox();
            this.buttonpindah = new System.Windows.Forms.Button();
            this.buttonhapus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxminum = new System.Windows.Forms.CheckBox();
            this.checkBoxmakan = new System.Windows.Forms.CheckBox();
            this.labelfilter = new System.Windows.Forms.Label();
            this.panelpilihan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(42, 52);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(58, 13);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "Nama Item";
            // 
            // textBoxitem
            // 
            this.textBoxitem.Location = new System.Drawing.Point(156, 52);
            this.textBoxitem.Name = "textBoxitem";
            this.textBoxitem.Size = new System.Drawing.Size(100, 20);
            this.textBoxitem.TabIndex = 1;
            // 
            // labelkategori
            // 
            this.labelkategori.AutoSize = true;
            this.labelkategori.Location = new System.Drawing.Point(45, 91);
            this.labelkategori.Name = "labelkategori";
            this.labelkategori.Size = new System.Drawing.Size(46, 13);
            this.labelkategori.TabIndex = 2;
            this.labelkategori.Text = "Kategori";
            // 
            // panelpilihan
            // 
            this.panelpilihan.Controls.Add(this.radioButtonminum);
            this.panelpilihan.Controls.Add(this.radioButtonmakan);
            this.panelpilihan.Location = new System.Drawing.Point(156, 91);
            this.panelpilihan.Name = "panelpilihan";
            this.panelpilihan.Size = new System.Drawing.Size(223, 25);
            this.panelpilihan.TabIndex = 3;
            // 
            // radioButtonminum
            // 
            this.radioButtonminum.AutoSize = true;
            this.radioButtonminum.Location = new System.Drawing.Point(145, 3);
            this.radioButtonminum.Name = "radioButtonminum";
            this.radioButtonminum.Size = new System.Drawing.Size(68, 17);
            this.radioButtonminum.TabIndex = 1;
            this.radioButtonminum.Text = "Minuman";
            this.radioButtonminum.UseVisualStyleBackColor = true;
            // 
            // radioButtonmakan
            // 
            this.radioButtonmakan.AutoSize = true;
            this.radioButtonmakan.Location = new System.Drawing.Point(4, 4);
            this.radioButtonmakan.Name = "radioButtonmakan";
            this.radioButtonmakan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonmakan.TabIndex = 0;
            this.radioButtonmakan.Text = "Makanan";
            this.radioButtonmakan.UseVisualStyleBackColor = true;
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(156, 142);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(75, 23);
            this.buttoninput.TabIndex = 4;
            this.buttoninput.Text = "Input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // listBoxdaftar
            // 
            this.listBoxdaftar.FormattingEnabled = true;
            this.listBoxdaftar.Location = new System.Drawing.Point(26, 192);
            this.listBoxdaftar.Name = "listBoxdaftar";
            this.listBoxdaftar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxdaftar.Size = new System.Drawing.Size(120, 173);
            this.listBoxdaftar.TabIndex = 5;
            // 
            // listBoxfilter
            // 
            this.listBoxfilter.FormattingEnabled = true;
            this.listBoxfilter.Location = new System.Drawing.Point(344, 192);
            this.listBoxfilter.Name = "listBoxfilter";
            this.listBoxfilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxfilter.Size = new System.Drawing.Size(120, 173);
            this.listBoxfilter.TabIndex = 6;
            // 
            // buttonpindah
            // 
            this.buttonpindah.Location = new System.Drawing.Point(209, 207);
            this.buttonpindah.Name = "buttonpindah";
            this.buttonpindah.Size = new System.Drawing.Size(75, 23);
            this.buttonpindah.TabIndex = 7;
            this.buttonpindah.Text = ">";
            this.buttonpindah.UseVisualStyleBackColor = true;
            this.buttonpindah.Click += new System.EventHandler(this.buttonpindah_Click);
            // 
            // buttonhapus
            // 
            this.buttonhapus.Location = new System.Drawing.Point(209, 236);
            this.buttonhapus.Name = "buttonhapus";
            this.buttonhapus.Size = new System.Drawing.Size(75, 23);
            this.buttonhapus.TabIndex = 8;
            this.buttonhapus.Text = "X";
            this.buttonhapus.UseVisualStyleBackColor = true;
            this.buttonhapus.Click += new System.EventHandler(this.buttonhapus_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxminum);
            this.panel2.Controls.Add(this.checkBoxmakan);
            this.panel2.Controls.Add(this.labelfilter);
            this.panel2.Location = new System.Drawing.Point(187, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 100);
            this.panel2.TabIndex = 9;
            // 
            // checkBoxminum
            // 
            this.checkBoxminum.AutoSize = true;
            this.checkBoxminum.Location = new System.Drawing.Point(4, 41);
            this.checkBoxminum.Name = "checkBoxminum";
            this.checkBoxminum.Size = new System.Drawing.Size(69, 17);
            this.checkBoxminum.TabIndex = 2;
            this.checkBoxminum.Text = "Minuman";
            this.checkBoxminum.UseVisualStyleBackColor = true;
            this.checkBoxminum.CheckedChanged += new System.EventHandler(this.checkBoxminum_CheckedChanged);
            // 
            // checkBoxmakan
            // 
            this.checkBoxmakan.AutoSize = true;
            this.checkBoxmakan.Location = new System.Drawing.Point(4, 17);
            this.checkBoxmakan.Name = "checkBoxmakan";
            this.checkBoxmakan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxmakan.TabIndex = 1;
            this.checkBoxmakan.Text = "Makanan";
            this.checkBoxmakan.UseVisualStyleBackColor = true;
            this.checkBoxmakan.CheckedChanged += new System.EventHandler(this.checkBoxmakan_CheckedChanged);
            // 
            // labelfilter
            // 
            this.labelfilter.AutoSize = true;
            this.labelfilter.Location = new System.Drawing.Point(3, 0);
            this.labelfilter.Name = "labelfilter";
            this.labelfilter.Size = new System.Drawing.Size(29, 13);
            this.labelfilter.TabIndex = 0;
            this.labelfilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonhapus);
            this.Controls.Add(this.buttonpindah);
            this.Controls.Add(this.listBoxfilter);
            this.Controls.Add(this.listBoxdaftar);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.panelpilihan);
            this.Controls.Add(this.labelkategori);
            this.Controls.Add(this.textBoxitem);
            this.Controls.Add(this.labelnama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelpilihan.ResumeLayout(false);
            this.panelpilihan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.TextBox textBoxitem;
        private System.Windows.Forms.Label labelkategori;
        private System.Windows.Forms.Panel panelpilihan;
        private System.Windows.Forms.RadioButton radioButtonminum;
        private System.Windows.Forms.RadioButton radioButtonmakan;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.ListBox listBoxdaftar;
        private System.Windows.Forms.ListBox listBoxfilter;
        private System.Windows.Forms.Button buttonpindah;
        private System.Windows.Forms.Button buttonhapus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelfilter;
        private System.Windows.Forms.CheckBox checkBoxminum;
        private System.Windows.Forms.CheckBox checkBoxmakan;
    }
}

