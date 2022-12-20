
namespace EmployeeMgmt1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nn = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.kk = new System.Windows.Forms.Label();
            this.LOGNBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 745);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(607, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee M S";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nn
            // 
            this.nn.AutoSize = true;
            this.nn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.nn.Location = new System.Drawing.Point(607, 341);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(172, 36);
            this.nn.TabIndex = 3;
            this.nn.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(607, 399);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(309, 34);
            this.UserName.TabIndex = 4;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(607, 527);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(309, 34);
            this.Password.TabIndex = 6;
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kk.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.kk.Location = new System.Drawing.Point(607, 464);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(155, 36);
            this.kk.TabIndex = 5;
            this.kk.Text = "Password";
            // 
            // LOGNBtn
            // 
            this.LOGNBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.LOGNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGNBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LOGNBtn.ForeColor = System.Drawing.Color.Thistle;
            this.LOGNBtn.Location = new System.Drawing.Point(655, 603);
            this.LOGNBtn.Name = "LOGNBtn";
            this.LOGNBtn.Size = new System.Drawing.Size(215, 48);
            this.LOGNBtn.TabIndex = 7;
            this.LOGNBtn.Text = "LOGN";
            this.LOGNBtn.UseVisualStyleBackColor = false;
            this.LOGNBtn.Click += new System.EventHandler(this.LOGNBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(699, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Regster";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1101, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 745);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOGNBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.nn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nn;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label kk;
        private System.Windows.Forms.Button LOGNBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

