namespace RADGroup8
{
    partial class Temperature
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
            this.lblC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(44, 138);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(115, 25);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "Celsius (C\')";
            this.lblC.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(204, 138);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(319, 31);
            this.textBoxC.TabIndex = 1;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(401, 413);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(122, 30);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "Convert";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(19, 227);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(140, 25);
            this.lblF.TabIndex = 0;
            this.lblF.Text = "Fahrenheit (F\')";
            this.lblF.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(60, 316);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(99, 25);
            this.lblK.TabIndex = 0;
            this.lblK.Text = "Kelvin (K)";
            this.lblK.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxF.Location = new System.Drawing.Point(204, 227);
            this.textBoxF.Multiline = true;
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(319, 31);
            this.textBoxF.TabIndex = 1;
            // 
            // textBoxK
            // 
            this.textBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxK.Location = new System.Drawing.Point(204, 316);
            this.textBoxK.Multiline = true;
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(319, 31);
            this.textBoxK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Temperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}