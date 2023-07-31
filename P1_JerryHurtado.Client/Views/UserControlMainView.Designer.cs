namespace P1_JerryHurtado.Client.Views
{
    partial class UserControlMainView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            topPanel = new Panel();
            label1 = new Label();
            bottomPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(40, 41, 66);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(987, 61);
            topPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(338, 15);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 0;
            label1.Text = "Cliente REST UNED";
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(40, 41, 66);
            bottomPanel.Controls.Add(label4);
            bottomPanel.Controls.Add(label3);
            bottomPanel.Controls.Add(label2);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 601);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(987, 46);
            bottomPanel.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(340, 14);
            label4.Name = "label4";
            label4.Size = new Size(306, 19);
            label4.TabIndex = 3;
            label4.Text = "Desarrollado por Jerry Hurtado © 2023.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(761, -40);
            label3.Name = "label3";
            label3.Size = new Size(306, 19);
            label3.TabIndex = 2;
            label3.Text = "Desarrollado por Jerry Hurtado © 2023.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(1152, -90);
            label2.Name = "label2";
            label2.Size = new Size(306, 19);
            label2.TabIndex = 1;
            label2.Text = "Desarrollado por Jerry Hurtado © 2023.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 41, 66);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.client_mainView;
            pictureBox1.Location = new Point(0, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UserControlMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 41, 66);
            Controls.Add(pictureBox1);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Name = "UserControlMainView";
            Size = new Size(987, 647);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label label1;
        private Panel bottomPanel;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
