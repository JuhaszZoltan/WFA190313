namespace WFA190313
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.cbNevek = new System.Windows.Forms.ComboBox();
            this.btnUjLama = new System.Windows.Forms.Button();
            this.lblSzulEv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEv = new System.Windows.Forms.TextBox();
            this.tbIz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "kedvelt íz";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(12, 90);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(141, 32);
            this.tbNev.TabIndex = 1;
            // 
            // cbNevek
            // 
            this.cbNevek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNevek.FormattingEnabled = true;
            this.cbNevek.Location = new System.Drawing.Point(12, 12);
            this.cbNevek.Name = "cbNevek";
            this.cbNevek.Size = new System.Drawing.Size(258, 33);
            this.cbNevek.TabIndex = 2;
            // 
            // btnUjLama
            // 
            this.btnUjLama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjLama.Location = new System.Drawing.Point(12, 143);
            this.btnUjLama.Name = "btnUjLama";
            this.btnUjLama.Size = new System.Drawing.Size(435, 52);
            this.btnUjLama.TabIndex = 3;
            this.btnUjLama.Text = "Új Láma";
            this.btnUjLama.UseVisualStyleBackColor = true;
            // 
            // lblSzulEv
            // 
            this.lblSzulEv.AutoSize = true;
            this.lblSzulEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzulEv.Location = new System.Drawing.Point(316, 15);
            this.lblSzulEv.Name = "lblSzulEv";
            this.lblSzulEv.Size = new System.Drawing.Size(116, 26);
            this.lblSzulEv.TabIndex = 0;
            this.lblSzulEv.Text = " #szül. év#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(155, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "szül. év";
            // 
            // tbEv
            // 
            this.tbEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEv.Location = new System.Drawing.Point(159, 90);
            this.tbEv.Name = "tbEv";
            this.tbEv.Size = new System.Drawing.Size(141, 32);
            this.tbEv.TabIndex = 1;
            // 
            // tbIz
            // 
            this.tbIz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIz.Location = new System.Drawing.Point(306, 90);
            this.tbIz.Name = "tbIz";
            this.tbIz.Size = new System.Drawing.Size(141, 32);
            this.tbIz.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.btnUjLama);
            this.Controls.Add(this.cbNevek);
            this.Controls.Add(this.tbIz);
            this.Controls.Add(this.tbEv);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.lblSzulEv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lámák";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ComboBox cbNevek;
        private System.Windows.Forms.Button btnUjLama;
        private System.Windows.Forms.Label lblSzulEv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEv;
        private System.Windows.Forms.TextBox tbIz;
    }
}

