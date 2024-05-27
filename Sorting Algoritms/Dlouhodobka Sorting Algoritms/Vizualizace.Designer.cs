namespace Dlouhodobka_Sorting_Algoritms
{
    partial class Vizualizace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizace));
            this.lb_porovnani = new System.Windows.Forms.Label();
            this.lb_prvky = new System.Windows.Forms.Label();
            this.lb_zapisu = new System.Windows.Forms.Label();
            this.lb_cas = new System.Windows.Forms.Label();
            this.trbr_speed = new System.Windows.Forms.TrackBar();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbr_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_porovnani
            // 
            this.lb_porovnani.AutoSize = true;
            this.lb_porovnani.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.lb_porovnani.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_porovnani.Location = new System.Drawing.Point(616, 7);
            this.lb_porovnani.Name = "lb_porovnani";
            this.lb_porovnani.Size = new System.Drawing.Size(167, 17);
            this.lb_porovnani.TabIndex = 1;
            this.lb_porovnani.Text = "Number of comparisons ??";
            // 
            // lb_prvky
            // 
            this.lb_prvky.AutoSize = true;
            this.lb_prvky.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.lb_prvky.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_prvky.Location = new System.Drawing.Point(3, 7);
            this.lb_prvky.Name = "lb_prvky";
            this.lb_prvky.Size = new System.Drawing.Size(147, 17);
            this.lb_prvky.TabIndex = 2;
            this.lb_prvky.Text = "Number of elements: ??";
            // 
            // lb_zapisu
            // 
            this.lb_zapisu.AutoSize = true;
            this.lb_zapisu.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.lb_zapisu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_zapisu.Location = new System.Drawing.Point(845, 7);
            this.lb_zapisu.Name = "lb_zapisu";
            this.lb_zapisu.Size = new System.Drawing.Size(134, 17);
            this.lb_zapisu.TabIndex = 3;
            this.lb_zapisu.Text = "Number of entries: ??";
            // 
            // lb_cas
            // 
            this.lb_cas.AutoSize = true;
            this.lb_cas.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.lb_cas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_cas.Location = new System.Drawing.Point(192, 7);
            this.lb_cas.Name = "lb_cas";
            this.lb_cas.Size = new System.Drawing.Size(102, 17);
            this.lb_cas.TabIndex = 4;
            this.lb_cas.Text = "Elapsed time: ??";
            // 
            // trbr_speed
            // 
            this.trbr_speed.Location = new System.Drawing.Point(6, 26);
            this.trbr_speed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trbr_speed.Maximum = 100;
            this.trbr_speed.Name = "trbr_speed";
            this.trbr_speed.Size = new System.Drawing.Size(203, 45);
            this.trbr_speed.TabIndex = 6;
            this.trbr_speed.ValueChanged += new System.EventHandler(this.trbr_speed_ValueChanged);
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(213, 37);
            this.tb_speed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(68, 20);
            this.tb_speed.TabIndex = 7;
            this.tb_speed.TextChanged += new System.EventHandler(this.tb_speed_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pause (1).png");
            this.imageList1.Images.SetKeyName(1, "play (1).png");
            // 
            // pb_close
            // 
            this.pb_close.Image = global::Dlouhodobka_Sorting_Algoritms.Properties.Resources.cross;
            this.pb_close.Location = new System.Drawing.Point(394, 12);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(64, 64);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 9;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pb_start
            // 
            this.pb_start.Image = global::Dlouhodobka_Sorting_Algoritms.Properties.Resources.play__1_;
            this.pb_start.Location = new System.Drawing.Point(498, 12);
            this.pb_start.Name = "pb_start";
            this.pb_start.Size = new System.Drawing.Size(64, 64);
            this.pb_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_start.TabIndex = 8;
            this.pb_start.TabStop = false;
            this.pb_start.Click += new System.EventHandler(this.pb_start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lb_prvky);
            this.panel1.Controls.Add(this.lb_zapisu);
            this.panel1.Controls.Add(this.pb_start);
            this.panel1.Controls.Add(this.lb_porovnani);
            this.panel1.Controls.Add(this.pb_close);
            this.panel1.Controls.Add(this.trbr_speed);
            this.panel1.Controls.Add(this.tb_speed);
            this.panel1.Controls.Add(this.lb_cas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 86);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Vizualizace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1013, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vizualizace";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Vizualizace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbr_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_porovnani;
        private System.Windows.Forms.Label lb_prvky;
        private System.Windows.Forms.Label lb_zapisu;
        private System.Windows.Forms.Label lb_cas;
        private System.Windows.Forms.TrackBar trbr_speed;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel panel1;
    }
}