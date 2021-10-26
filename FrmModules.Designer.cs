
namespace SMS
{
    partial class FrmModules
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
            this.cID = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mType = new System.Windows.Forms.TextBox();
            this.mName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cID
            // 
            this.cID.AutoSize = true;
            this.cID.Location = new System.Drawing.Point(362, 184);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(0, 20);
            this.cID.TabIndex = 27;
            // 
            // tID
            // 
            this.tID.Location = new System.Drawing.Point(444, 327);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(125, 27);
            this.tID.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mType
            // 
            this.mType.Location = new System.Drawing.Point(397, 282);
            this.mType.Name = "mType";
            this.mType.Size = new System.Drawing.Size(125, 27);
            this.mType.TabIndex = 24;
            // 
            // mName
            // 
            this.mName.Location = new System.Drawing.Point(380, 231);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(125, 27);
            this.mName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Teacher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // mID
            // 
            this.mID.Location = new System.Drawing.Point(369, 184);
            this.mID.Name = "mID";
            this.mID.Size = new System.Drawing.Size(125, 27);
            this.mID.TabIndex = 28;
            // 
            // FrmModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(899, 606);
            this.Controls.Add(this.mID);
            this.Controls.Add(this.cID);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mType);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModules";
            this.Text = "FrmModules";
            this.Load += new System.EventHandler(this.FrmModules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cID;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mType;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mID;
    }
}