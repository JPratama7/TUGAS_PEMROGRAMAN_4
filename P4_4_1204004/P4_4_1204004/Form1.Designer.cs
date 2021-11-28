namespace P4_4_1204004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbchar = new System.Windows.Forms.TextBox();
            this.tbregex = new System.Windows.Forms.TextBox();
            this.tbcom1 = new System.Windows.Forms.TextBox();
            this.tbcom2 = new System.Windows.Forms.TextBox();
            this.tbleng = new System.Windows.Forms.TextBox();
            this.tbupper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblower = new System.Windows.Forms.TextBox();
            this.epwarn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epbenar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epwarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epbenar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(231, 21);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(100, 20);
            this.tbnum.TabIndex = 0;
            this.tbnum.Leave += new System.EventHandler(this.tbnum_Leave);
            // 
            // tbchar
            // 
            this.tbchar.Location = new System.Drawing.Point(231, 54);
            this.tbchar.Name = "tbchar";
            this.tbchar.Size = new System.Drawing.Size(100, 20);
            this.tbchar.TabIndex = 1;
            this.tbchar.Leave += new System.EventHandler(this.tbchar_Leave);
            // 
            // tbregex
            // 
            this.tbregex.Location = new System.Drawing.Point(231, 87);
            this.tbregex.Name = "tbregex";
            this.tbregex.Size = new System.Drawing.Size(100, 20);
            this.tbregex.TabIndex = 3;
            this.tbregex.Leave += new System.EventHandler(this.tbregex_Leave);
            // 
            // tbcom1
            // 
            this.tbcom1.Location = new System.Drawing.Point(231, 120);
            this.tbcom1.Name = "tbcom1";
            this.tbcom1.Size = new System.Drawing.Size(100, 20);
            this.tbcom1.TabIndex = 4;
            this.tbcom1.Leave += new System.EventHandler(this.tbcom1_Leave);
            // 
            // tbcom2
            // 
            this.tbcom2.Location = new System.Drawing.Point(360, 120);
            this.tbcom2.Name = "tbcom2";
            this.tbcom2.Size = new System.Drawing.Size(100, 20);
            this.tbcom2.TabIndex = 5;
            this.tbcom2.Leave += new System.EventHandler(this.tbcom2_Leave);
            // 
            // tbleng
            // 
            this.tbleng.Location = new System.Drawing.Point(231, 153);
            this.tbleng.Name = "tbleng";
            this.tbleng.Size = new System.Drawing.Size(100, 20);
            this.tbleng.TabIndex = 6;
            this.tbleng.Leave += new System.EventHandler(this.tbleng_Leave);
            // 
            // tbupper
            // 
            this.tbupper.Location = new System.Drawing.Point(231, 186);
            this.tbupper.Name = "tbupper";
            this.tbupper.Size = new System.Drawing.Size(100, 20);
            this.tbupper.TabIndex = 7;
            this.tbupper.Leave += new System.EventHandler(this.tbupper_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "No. Telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Perbandingan Angka";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "nama dalam uppercase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "username dalam lowercase";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblower
            // 
            this.tblower.Location = new System.Drawing.Point(231, 219);
            this.tblower.Name = "tblower";
            this.tblower.Size = new System.Drawing.Size(100, 20);
            this.tblower.TabIndex = 17;
            this.tblower.Leave += new System.EventHandler(this.tblower_Leave);
            // 
            // epwarn
            // 
            this.epwarn.ContainerControl = this;
            this.epwarn.Icon = ((System.Drawing.Icon)(resources.GetObject("epwarn.Icon")));
            // 
            // epbenar
            // 
            this.epbenar.ContainerControl = this;
            this.epbenar.Icon = ((System.Drawing.Icon)(resources.GetObject("epbenar.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 423);
            this.Controls.Add(this.tblower);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbupper);
            this.Controls.Add(this.tbleng);
            this.Controls.Add(this.tbcom2);
            this.Controls.Add(this.tbcom1);
            this.Controls.Add(this.tbregex);
            this.Controls.Add(this.tbchar);
            this.Controls.Add(this.tbnum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epwarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epbenar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.TextBox tbchar;
        private System.Windows.Forms.TextBox tbregex;
        private System.Windows.Forms.TextBox tbcom1;
        private System.Windows.Forms.TextBox tbcom2;
        private System.Windows.Forms.TextBox tbleng;
        private System.Windows.Forms.TextBox tbupper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tblower;
        private System.Windows.Forms.ErrorProvider epwarn;
        private System.Windows.Forms.ErrorProvider epbenar;
    }
}

