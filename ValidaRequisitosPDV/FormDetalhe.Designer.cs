namespace ValidaRequisitosPDV
{
    partial class FormDetalhe
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
            this.richDetalhe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richDetalhe
            // 
            this.richDetalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richDetalhe.Location = new System.Drawing.Point(0, 0);
            this.richDetalhe.Name = "richDetalhe";
            this.richDetalhe.ReadOnly = true;
            this.richDetalhe.Size = new System.Drawing.Size(555, 366);
            this.richDetalhe.TabIndex = 0;
            this.richDetalhe.Text = "";
            this.richDetalhe.TextChanged += new System.EventHandler(this.richDetalhe_TextChanged);
            // 
            // FormDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.richDetalhe);
            this.Name = "FormDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalhe";
            this.Load += new System.EventHandler(this.FormDetalhe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richDetalhe;

    }
}