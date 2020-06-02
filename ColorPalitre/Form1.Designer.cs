namespace Color_Picker
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
            this.trackBar_Red = new System.Windows.Forms.TrackBar();
            this.trackBar_Green = new System.Windows.Forms.TrackBar();
            this.trackBar_Blue = new System.Windows.Forms.TrackBar();
            this.label_Red = new System.Windows.Forms.Label();
            this.label_Green = new System.Windows.Forms.Label();
            this.label_Blue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_RedMinValue = new System.Windows.Forms.Label();
            this.label_RedMaxValue = new System.Windows.Forms.Label();
            this.label_GreenMinValue = new System.Windows.Forms.Label();
            this.label_GreenMaxValue = new System.Windows.Forms.Label();
            this.label_BlueMaxValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_BlueMinValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_Red
            // 
            this.trackBar_Red.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Red, 2);
            this.trackBar_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Red.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_Red.Location = new System.Drawing.Point(333, 5);
            this.trackBar_Red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Red.Maximum = 255;
            this.trackBar_Red.Name = "trackBar_Red";
            this.trackBar_Red.Size = new System.Drawing.Size(344, 56);
            this.trackBar_Red.TabIndex = 0;
            this.trackBar_Red.Tag = "";
            this.trackBar_Red.TickFrequency = 15;
            this.trackBar_Red.Value = 125;
            this.trackBar_Red.Scroll += new System.EventHandler(this.trackBar_Red_Scroll);
            // 
            // trackBar_Green
            // 
            this.trackBar_Green.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Green, 2);
            this.trackBar_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Green.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_Green.Location = new System.Drawing.Point(333, 137);
            this.trackBar_Green.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Green.Maximum = 255;
            this.trackBar_Green.Name = "trackBar_Green";
            this.trackBar_Green.Size = new System.Drawing.Size(344, 56);
            this.trackBar_Green.TabIndex = 2;
            this.trackBar_Green.Tag = "";
            this.trackBar_Green.TickFrequency = 15;
            this.trackBar_Green.Value = 125;
            this.trackBar_Green.Scroll += new System.EventHandler(this.trackBar_Green_Scroll);
            // 
            // trackBar_Blue
            // 
            this.trackBar_Blue.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Blue, 2);
            this.trackBar_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Blue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_Blue.Location = new System.Drawing.Point(333, 269);
            this.trackBar_Blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Blue.Maximum = 255;
            this.trackBar_Blue.Name = "trackBar_Blue";
            this.trackBar_Blue.Size = new System.Drawing.Size(344, 56);
            this.trackBar_Blue.TabIndex = 3;
            this.trackBar_Blue.Tag = "";
            this.trackBar_Blue.TickFrequency = 15;
            this.trackBar_Blue.Value = 125;
            this.trackBar_Blue.Scroll += new System.EventHandler(this.trackBar_Blue_Scroll);
            // 
            // label_Red
            // 
            this.label_Red.AutoSize = true;
            this.label_Red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Red.Location = new System.Drawing.Point(266, 0);
            this.label_Red.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(59, 66);
            this.label_Red.TabIndex = 5;
            this.label_Red.Text = "Red";
            this.label_Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Red.Click += new System.EventHandler(this.label_Red_Click);
            // 
            // label_Green
            // 
            this.label_Green.AutoSize = true;
            this.label_Green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Green.Location = new System.Drawing.Point(266, 132);
            this.label_Green.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Green.Name = "label_Green";
            this.label_Green.Size = new System.Drawing.Size(59, 66);
            this.label_Green.TabIndex = 7;
            this.label_Green.Text = "Green";
            this.label_Green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Blue
            // 
            this.label_Blue.AutoSize = true;
            this.label_Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Blue.Location = new System.Drawing.Point(266, 264);
            this.label_Blue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Blue.Name = "label_Blue";
            this.label_Blue.Size = new System.Drawing.Size(59, 66);
            this.label_Blue.TabIndex = 8;
            this.label_Blue.Text = "Blue";
            this.label_Blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.47284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.838472F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.57856F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Red, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Blue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Green, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Green, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Red, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Blue, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_RedMinValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_RedMaxValue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_GreenMinValue, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_GreenMaxValue, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_BlueMaxValue, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_BlueMinValue, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 402);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label_RedMinValue
            // 
            this.label_RedMinValue.AutoSize = true;
            this.label_RedMinValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_RedMinValue.Location = new System.Drawing.Point(333, 66);
            this.label_RedMinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RedMinValue.Name = "label_RedMinValue";
            this.label_RedMinValue.Size = new System.Drawing.Size(18, 66);
            this.label_RedMinValue.TabIndex = 12;
            this.label_RedMinValue.Text = "0";
            // 
            // label_RedMaxValue
            // 
            this.label_RedMaxValue.AutoSize = true;
            this.label_RedMaxValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_RedMaxValue.Location = new System.Drawing.Point(641, 66);
            this.label_RedMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RedMaxValue.Name = "label_RedMaxValue";
            this.label_RedMaxValue.Size = new System.Drawing.Size(36, 66);
            this.label_RedMaxValue.TabIndex = 13;
            this.label_RedMaxValue.Text = "255";
            // 
            // label_GreenMinValue
            // 
            this.label_GreenMinValue.AutoSize = true;
            this.label_GreenMinValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_GreenMinValue.Location = new System.Drawing.Point(333, 198);
            this.label_GreenMinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GreenMinValue.Name = "label_GreenMinValue";
            this.label_GreenMinValue.Size = new System.Drawing.Size(18, 66);
            this.label_GreenMinValue.TabIndex = 14;
            this.label_GreenMinValue.Text = "0";
            // 
            // label_GreenMaxValue
            // 
            this.label_GreenMaxValue.AutoSize = true;
            this.label_GreenMaxValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_GreenMaxValue.Location = new System.Drawing.Point(641, 198);
            this.label_GreenMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GreenMaxValue.Name = "label_GreenMaxValue";
            this.label_GreenMaxValue.Size = new System.Drawing.Size(36, 66);
            this.label_GreenMaxValue.TabIndex = 16;
            this.label_GreenMaxValue.Text = "255";
            // 
            // label_BlueMaxValue
            // 
            this.label_BlueMaxValue.AutoSize = true;
            this.label_BlueMaxValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_BlueMaxValue.Location = new System.Drawing.Point(641, 330);
            this.label_BlueMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BlueMaxValue.Name = "label_BlueMaxValue";
            this.label_BlueMaxValue.Size = new System.Drawing.Size(36, 72);
            this.label_BlueMaxValue.TabIndex = 17;
            this.label_BlueMaxValue.Text = "255";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(254, 254);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label_BlueMinValue
            // 
            this.label_BlueMinValue.AutoSize = true;
            this.label_BlueMinValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_BlueMinValue.Location = new System.Drawing.Point(333, 330);
            this.label_BlueMinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BlueMinValue.Name = "label_BlueMinValue";
            this.label_BlueMinValue.Size = new System.Drawing.Size(18, 72);
            this.label_BlueMinValue.TabIndex = 15;
            this.label_BlueMinValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(694, 431);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar_Red;
        private System.Windows.Forms.TrackBar trackBar_Green;
        private System.Windows.Forms.TrackBar trackBar_Blue;
        private System.Windows.Forms.Label label_Red;
        private System.Windows.Forms.Label label_Blue;
        private System.Windows.Forms.Label label_Green;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_RedMinValue;
        private System.Windows.Forms.Label label_RedMaxValue;
        private System.Windows.Forms.Label label_GreenMinValue;
        private System.Windows.Forms.Label label_BlueMinValue;
        private System.Windows.Forms.Label label_GreenMaxValue;
        private System.Windows.Forms.Label label_BlueMaxValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

