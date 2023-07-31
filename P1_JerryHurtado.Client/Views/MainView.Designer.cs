namespace P1_JerryHurtado.Client.Views
{
    partial class MainView
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
            sideBar = new Panel();
            btnHome = new Button();
            btnOrder = new Button();
            mainPanel = new Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(56, 58, 89);
            sideBar.Controls.Add(btnHome);
            sideBar.Controls.Add(btnOrder);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(226, 804);
            sideBar.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(56, 58, 89);
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 58, 89);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 41, 66);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(189, 147, 249);
            btnHome.Location = new Point(3, 70);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 59);
            btnHome.TabIndex = 1;
            btnHome.Text = "Inicio";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(56, 58, 89);
            btnOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 58, 89);
            btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 41, 66);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.FromArgb(189, 147, 249);
            btnOrder.Location = new Point(3, 131);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 59);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Pedidos";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(40, 41, 66);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(226, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1072, 804);
            mainPanel.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 804);
            Controls.Add(mainPanel);
            Controls.Add(sideBar);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente REST UNED";
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Button btnHome;
        private Button btnOrder;
        private Panel mainPanel;
    }
}