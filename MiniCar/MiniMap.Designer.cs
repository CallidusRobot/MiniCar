namespace MiniCar
{
    partial class MiniMap
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCoordinates.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordinates.Location = new System.Drawing.Point(0, 0);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(150, 150);
            this.labelCoordinates.TabIndex = 0;
            this.labelCoordinates.Text = "Start driving";
            // 
            // MiniMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelCoordinates);
            this.Name = "MiniMap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCoordinates;
    }
}
