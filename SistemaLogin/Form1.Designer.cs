namespace SistemaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_BoasVindas = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_BoasVindas
            // 
            this.label_BoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.label_BoasVindas.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BoasVindas.Location = new System.Drawing.Point(12, 113);
            this.label_BoasVindas.Name = "label_BoasVindas";
            this.label_BoasVindas.Size = new System.Drawing.Size(584, 148);
            this.label_BoasVindas.TabIndex = 0;
            this.label_BoasVindas.Text = "Tela Inicial";
            this.label_BoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.SystemColors.Info;
            this.btnHint.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(57, 315);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(156, 70);
            this.btnHint.TabIndex = 1;
            this.btnHint.Text = "Exibir\r\nDica\r\n";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(250, 315);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(90, 51);
            this.labelHint.TabIndex = 2;
            this.labelHint.Text = "Dica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 449);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.label_BoasVindas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BoasVindas;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label labelHint;
    }
}

