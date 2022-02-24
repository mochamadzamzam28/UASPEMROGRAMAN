namespace sayaa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SUMBIT = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.npm = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.PS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 2;
            // 
            // SUMBIT
            // 
            this.SUMBIT.Location = new System.Drawing.Point(177, 157);
            this.SUMBIT.Name = "SUMBIT";
            this.SUMBIT.Size = new System.Drawing.Size(75, 23);
            this.SUMBIT.TabIndex = 3;
            this.SUMBIT.Text = "SUMBIT";
            this.SUMBIT.UseVisualStyleBackColor = true;
            this.SUMBIT.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(302, 157);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 4;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(231, 21);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(102, 13);
            this.input.TabIndex = 5;
            this.input.Text = "Input Mahasiswa";
            this.input.Click += new System.EventHandler(this.label1_Click);
            // 
            // npm
            // 
            this.npm.AutoSize = true;
            this.npm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npm.Location = new System.Drawing.Point(12, 60);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(34, 13);
            this.npm.TabIndex = 6;
            this.npm.Text = "NPM";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(12, 86);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(121, 13);
            this.nama.TabIndex = 7;
            this.nama.Text = "NAMA MAHASISWA";
            // 
            // PS
            // 
            this.PS.AutoSize = true;
            this.PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS.Location = new System.Drawing.Point(12, 112);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(111, 13);
            this.PS.TabIndex = 8;
            this.PS.Text = "PROGRAM STUDI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.npm);
            this.Controls.Add(this.input);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.SUMBIT);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SUMBIT;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label npm;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label PS;
    }
}

