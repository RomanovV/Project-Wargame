namespace Project_Wargame
{
    partial class Tela_Inicial
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
            this.btnTest = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblHeart = new System.Windows.Forms.Label();
            this.lblLeftHand = new System.Windows.Forms.Label();
            this.damageHeart = new System.Windows.Forms.Button();
            this.damageHeart2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCirc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(376, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Heart PV";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(376, 49);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(71, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Left Hand PV";
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.Location = new System.Drawing.Point(466, 21);
            this.lblHeart.Name = "lblHeart";
            this.lblHeart.Size = new System.Drawing.Size(35, 13);
            this.lblHeart.TabIndex = 4;
            this.lblHeart.Text = "AAAA";
            this.lblHeart.Click += new System.EventHandler(this.lblHeart_Click);
            // 
            // lblLeftHand
            // 
            this.lblLeftHand.AutoSize = true;
            this.lblLeftHand.Location = new System.Drawing.Point(469, 48);
            this.lblLeftHand.Name = "lblLeftHand";
            this.lblLeftHand.Size = new System.Drawing.Size(35, 13);
            this.lblLeftHand.TabIndex = 5;
            this.lblLeftHand.Text = "AAAA";
            this.lblLeftHand.Click += new System.EventHandler(this.lblLeftHand_Click);
            // 
            // damageHeart
            // 
            this.damageHeart.Location = new System.Drawing.Point(12, 49);
            this.damageHeart.Name = "damageHeart";
            this.damageHeart.Size = new System.Drawing.Size(144, 23);
            this.damageHeart.TabIndex = 6;
            this.damageHeart.Text = "Damage Heart";
            this.damageHeart.UseVisualStyleBackColor = true;
            this.damageHeart.Click += new System.EventHandler(this.damageHeart_Click);
            // 
            // damageHeart2
            // 
            this.damageHeart2.Location = new System.Drawing.Point(13, 79);
            this.damageHeart2.Name = "damageHeart2";
            this.damageHeart2.Size = new System.Drawing.Size(143, 23);
            this.damageHeart2.TabIndex = 7;
            this.damageHeart2.Text = "Damage Heart 2";
            this.damageHeart2.UseVisualStyleBackColor = true;
            this.damageHeart2.Click += new System.EventHandler(this.damageHeart2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Circ Sys";
            // 
            // lblCirc
            // 
            this.lblCirc.AutoSize = true;
            this.lblCirc.Location = new System.Drawing.Point(469, 79);
            this.lblCirc.Name = "lblCirc";
            this.lblCirc.Size = new System.Drawing.Size(42, 13);
            this.lblCirc.TabIndex = 9;
            this.lblCirc.Text = "AAAAA";
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.lblCirc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.damageHeart2);
            this.Controls.Add(this.damageHeart);
            this.Controls.Add(this.lblLeftHand);
            this.Controls.Add(this.lblHeart);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnTest);
            this.Name = "Tela_Inicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblHeart;
        private System.Windows.Forms.Label lblLeftHand;
        private System.Windows.Forms.Button damageHeart;
        private System.Windows.Forms.Button damageHeart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCirc;
    }
}

