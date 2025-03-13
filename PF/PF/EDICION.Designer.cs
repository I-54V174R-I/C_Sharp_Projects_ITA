namespace PF
{
    partial class EDICION
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZONAAA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "CAMBIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID :";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(95, 118);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(179, 20);
            this.ID.TabIndex = 4;
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(186, 167);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(314, 20);
            this.NOM.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NUEVO NOMBRE DE CLIENTE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ZONA :";
            // 
            // ZONAAA
            // 
            this.ZONAAA.FormattingEnabled = true;
            this.ZONAAA.Location = new System.Drawing.Point(95, 69);
            this.ZONAAA.Name = "ZONAAA";
            this.ZONAAA.Size = new System.Drawing.Size(179, 21);
            this.ZONAAA.TabIndex = 8;
            this.ZONAAA.SelectedIndexChanged += new System.EventHandler(this.ZONAAA_SelectedIndexChanged);
            // 
            // EDICION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 458);
            this.Controls.Add(this.ZONAAA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "EDICION";
            this.Text = "EDICION";
            this.Load += new System.EventHandler(this.EDICION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ZONAAA;
    }
}