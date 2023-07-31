namespace P1_JerryHurtado.Client.Views
{
    partial class OrderView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelTop = new Panel();
            groupBoxServerInfo = new GroupBox();
            btnDisconnect = new Button();
            btnConnect = new Button();
            label1 = new Label();
            labelCustomerName = new Label();
            textBoxCustomerId = new TextBox();
            labelConnectionStatus = new Label();
            label5 = new Label();
            tabControlOrder = new TabControl();
            tabPageOrderList = new TabPage();
            groupBoxOrders = new GroupBox();
            label7 = new Label();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewOrder = new DataGridView();
            btnAddNewOrder = new Button();
            tabPageOrderAddNew = new TabPage();
            btnSendOrder = new Button();
            label6 = new Label();
            btnCancel = new Button();
            btnPrepareOrder = new Button();
            groupBoxExtraList = new GroupBox();
            dataGridViewExtraList = new DataGridView();
            groupBoxDish = new GroupBox();
            dataGridViewDishList = new DataGridView();
            panel1 = new Panel();
            groupBoxDishRestaurant = new GroupBox();
            label3 = new Label();
            comboBoxDishCategory = new ComboBox();
            label2 = new Label();
            btnSelectRestaurant = new Button();
            comboBoxRestaurant = new ComboBox();
            label4 = new Label();
            panelTop.SuspendLayout();
            groupBoxServerInfo.SuspendLayout();
            tabControlOrder.SuspendLayout();
            tabPageOrderList.SuspendLayout();
            groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            tabPageOrderAddNew.SuspendLayout();
            groupBoxExtraList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtraList).BeginInit();
            groupBoxDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishList).BeginInit();
            panel1.SuspendLayout();
            groupBoxDishRestaurant.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(40, 41, 66);
            panelTop.Controls.Add(groupBoxServerInfo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(966, 206);
            panelTop.TabIndex = 6;
            // 
            // groupBoxServerInfo
            // 
            groupBoxServerInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxServerInfo.Controls.Add(btnDisconnect);
            groupBoxServerInfo.Controls.Add(btnConnect);
            groupBoxServerInfo.Controls.Add(label1);
            groupBoxServerInfo.Controls.Add(labelCustomerName);
            groupBoxServerInfo.Controls.Add(textBoxCustomerId);
            groupBoxServerInfo.Controls.Add(labelConnectionStatus);
            groupBoxServerInfo.Controls.Add(label5);
            groupBoxServerInfo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxServerInfo.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxServerInfo.Location = new Point(13, 12);
            groupBoxServerInfo.Margin = new Padding(4, 3, 4, 3);
            groupBoxServerInfo.Name = "groupBoxServerInfo";
            groupBoxServerInfo.Padding = new Padding(4, 3, 4, 3);
            groupBoxServerInfo.Size = new Size(940, 170);
            groupBoxServerInfo.TabIndex = 1;
            groupBoxServerInfo.TabStop = false;
            groupBoxServerInfo.Text = "Conexión con el servidor";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisconnect.BackColor = Color.FromArgb(56, 58, 89);
            btnDisconnect.Cursor = Cursors.Hand;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisconnect.ForeColor = Color.FromArgb(189, 147, 249);
            btnDisconnect.Location = new Point(791, 82);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(123, 49);
            btnDisconnect.TabIndex = 16;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnect.BackColor = Color.FromArgb(56, 58, 89);
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnect.ForeColor = Color.FromArgb(189, 147, 249);
            btnConnect.Location = new Point(649, 82);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(123, 49);
            btnConnect.TabIndex = 15;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 5;
            label1.Text = "Identificador:";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomerName.ForeColor = Color.FromArgb(189, 147, 249);
            labelCustomerName.Location = new Point(9, 141);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(97, 21);
            labelCustomerName.TabIndex = 0;
            labelCustomerName.Text = "Info cliente";
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(160, 92);
            textBoxCustomerId.Margin = new Padding(4, 3, 4, 3);
            textBoxCustomerId.MaxLength = 15;
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(158, 27);
            textBoxCustomerId.TabIndex = 4;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(160, 51);
            labelConnectionStatus.Margin = new Padding(4, 0, 4, 0);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(127, 21);
            labelConnectionStatus.TabIndex = 1;
            labelConnectionStatus.Text = "Desconectado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 0;
            label5.Text = "Estado:";
            // 
            // tabControlOrder
            // 
            tabControlOrder.Controls.Add(tabPageOrderList);
            tabControlOrder.Controls.Add(tabPageOrderAddNew);
            tabControlOrder.Dock = DockStyle.Fill;
            tabControlOrder.Location = new Point(0, 206);
            tabControlOrder.Name = "tabControlOrder";
            tabControlOrder.SelectedIndex = 0;
            tabControlOrder.Size = new Size(966, 554);
            tabControlOrder.TabIndex = 7;
            // 
            // tabPageOrderList
            // 
            tabPageOrderList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageOrderList.Controls.Add(groupBoxOrders);
            tabPageOrderList.Location = new Point(4, 24);
            tabPageOrderList.Name = "tabPageOrderList";
            tabPageOrderList.Padding = new Padding(3);
            tabPageOrderList.Size = new Size(958, 526);
            tabPageOrderList.TabIndex = 0;
            tabPageOrderList.Text = "Lista de Pedidos";
            // 
            // groupBoxOrders
            // 
            groupBoxOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOrders.Controls.Add(label7);
            groupBoxOrders.Controls.Add(btnSearch);
            groupBoxOrders.Controls.Add(textBoxSearch);
            groupBoxOrders.Controls.Add(dataGridViewOrder);
            groupBoxOrders.Controls.Add(btnAddNewOrder);
            groupBoxOrders.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxOrders.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxOrders.Location = new Point(8, 27);
            groupBoxOrders.Name = "groupBoxOrders";
            groupBoxOrders.Size = new Size(941, 479);
            groupBoxOrders.TabIndex = 15;
            groupBoxOrders.TabStop = false;
            groupBoxOrders.Text = "Mis pedidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(189, 147, 249);
            label7.Location = new Point(38, 46);
            label7.Name = "label7";
            label7.Size = new Size(163, 17);
            label7.TabIndex = 17;
            label7.Text = "Buscar por Id de pedido";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(56, 58, 89);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(189, 147, 249);
            btnSearch.Location = new Point(465, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 32);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(38, 68);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(407, 27);
            textBoxSearch.TabIndex = 15;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AllowUserToDeleteRows = false;
            dataGridViewOrder.AllowUserToResizeRows = false;
            dataGridViewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOrder.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewOrder.BorderStyle = BorderStyle.None;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrder.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewOrder.Location = new Point(38, 113);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewOrder.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewOrder.RowTemplate.Height = 25;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrder.Size = new Size(710, 342);
            dataGridViewOrder.TabIndex = 1;
            // 
            // btnAddNewOrder
            // 
            btnAddNewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewOrder.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewOrder.Cursor = Cursors.Hand;
            btnAddNewOrder.FlatStyle = FlatStyle.Flat;
            btnAddNewOrder.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewOrder.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewOrder.Location = new Point(795, 89);
            btnAddNewOrder.Name = "btnAddNewOrder";
            btnAddNewOrder.Size = new Size(123, 49);
            btnAddNewOrder.TabIndex = 13;
            btnAddNewOrder.Text = "Agregar pedido";
            btnAddNewOrder.UseVisualStyleBackColor = false;
            // 
            // tabPageOrderAddNew
            // 
            tabPageOrderAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageOrderAddNew.Controls.Add(btnSendOrder);
            tabPageOrderAddNew.Controls.Add(label6);
            tabPageOrderAddNew.Controls.Add(btnCancel);
            tabPageOrderAddNew.Controls.Add(btnPrepareOrder);
            tabPageOrderAddNew.Controls.Add(groupBoxExtraList);
            tabPageOrderAddNew.Controls.Add(groupBoxDish);
            tabPageOrderAddNew.Controls.Add(panel1);
            tabPageOrderAddNew.Controls.Add(label4);
            tabPageOrderAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageOrderAddNew.Location = new Point(4, 24);
            tabPageOrderAddNew.Name = "tabPageOrderAddNew";
            tabPageOrderAddNew.Padding = new Padding(3);
            tabPageOrderAddNew.Size = new Size(958, 526);
            tabPageOrderAddNew.TabIndex = 1;
            tabPageOrderAddNew.Text = "Agregar nuevo";
            // 
            // btnSendOrder
            // 
            btnSendOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSendOrder.BackColor = Color.FromArgb(56, 58, 89);
            btnSendOrder.Cursor = Cursors.Hand;
            btnSendOrder.FlatStyle = FlatStyle.Flat;
            btnSendOrder.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendOrder.ForeColor = Color.FromArgb(189, 147, 249);
            btnSendOrder.Location = new Point(678, 477);
            btnSendOrder.Name = "btnSendOrder";
            btnSendOrder.Size = new Size(123, 32);
            btnSendOrder.TabIndex = 24;
            btnSendOrder.Text = "Realizar pedido";
            btnSendOrder.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(189, 147, 249);
            label6.Location = new Point(12, 468);
            label6.Name = "label6";
            label6.Size = new Size(378, 16);
            label6.TabIndex = 23;
            label6.Text = "*Seleccione los platos y/o extras para preparar el pedido.";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(56, 58, 89);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancel.Location = new Point(822, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 32);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPrepareOrder
            // 
            btnPrepareOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrepareOrder.BackColor = Color.FromArgb(56, 58, 89);
            btnPrepareOrder.Cursor = Cursors.Hand;
            btnPrepareOrder.FlatStyle = FlatStyle.Flat;
            btnPrepareOrder.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrepareOrder.ForeColor = Color.FromArgb(189, 147, 249);
            btnPrepareOrder.Location = new Point(532, 477);
            btnPrepareOrder.Name = "btnPrepareOrder";
            btnPrepareOrder.Size = new Size(123, 32);
            btnPrepareOrder.TabIndex = 21;
            btnPrepareOrder.Text = "Preparar pedido";
            btnPrepareOrder.UseVisualStyleBackColor = false;
            // 
            // groupBoxExtraList
            // 
            groupBoxExtraList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxExtraList.Controls.Add(dataGridViewExtraList);
            groupBoxExtraList.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxExtraList.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxExtraList.Location = new Point(483, 186);
            groupBoxExtraList.Name = "groupBoxExtraList";
            groupBoxExtraList.Size = new Size(463, 274);
            groupBoxExtraList.TabIndex = 20;
            groupBoxExtraList.TabStop = false;
            groupBoxExtraList.Text = "Extras";
            // 
            // dataGridViewExtraList
            // 
            dataGridViewExtraList.AllowUserToAddRows = false;
            dataGridViewExtraList.AllowUserToDeleteRows = false;
            dataGridViewExtraList.AllowUserToResizeRows = false;
            dataGridViewExtraList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewExtraList.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewExtraList.BorderStyle = BorderStyle.None;
            dataGridViewExtraList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewExtraList.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewExtraList.Dock = DockStyle.Fill;
            dataGridViewExtraList.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewExtraList.Location = new Point(3, 23);
            dataGridViewExtraList.Name = "dataGridViewExtraList";
            dataGridViewExtraList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewExtraList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewExtraList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewExtraList.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewExtraList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewExtraList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewExtraList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewExtraList.RowTemplate.Height = 25;
            dataGridViewExtraList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExtraList.Size = new Size(457, 248);
            dataGridViewExtraList.TabIndex = 10;
            // 
            // groupBoxDish
            // 
            groupBoxDish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxDish.Controls.Add(dataGridViewDishList);
            groupBoxDish.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDish.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxDish.Location = new Point(14, 186);
            groupBoxDish.Name = "groupBoxDish";
            groupBoxDish.Size = new Size(463, 274);
            groupBoxDish.TabIndex = 17;
            groupBoxDish.TabStop = false;
            groupBoxDish.Text = "Platos";
            // 
            // dataGridViewDishList
            // 
            dataGridViewDishList.AllowUserToAddRows = false;
            dataGridViewDishList.AllowUserToDeleteRows = false;
            dataGridViewDishList.AllowUserToResizeRows = false;
            dataGridViewDishList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDishList.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishList.BorderStyle = BorderStyle.None;
            dataGridViewDishList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewDishList.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDishList.Dock = DockStyle.Fill;
            dataGridViewDishList.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishList.Location = new Point(3, 23);
            dataGridViewDishList.Name = "dataGridViewDishList";
            dataGridViewDishList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewDishList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDishList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishList.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDishList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewDishList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDishList.RowTemplate.Height = 25;
            dataGridViewDishList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDishList.Size = new Size(457, 248);
            dataGridViewDishList.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxDishRestaurant);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 175);
            panel1.TabIndex = 18;
            // 
            // groupBoxDishRestaurant
            // 
            groupBoxDishRestaurant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDishRestaurant.Controls.Add(label3);
            groupBoxDishRestaurant.Controls.Add(comboBoxDishCategory);
            groupBoxDishRestaurant.Controls.Add(label2);
            groupBoxDishRestaurant.Controls.Add(btnSelectRestaurant);
            groupBoxDishRestaurant.Controls.Add(comboBoxRestaurant);
            groupBoxDishRestaurant.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDishRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxDishRestaurant.Location = new Point(14, 3);
            groupBoxDishRestaurant.Name = "groupBoxDishRestaurant";
            groupBoxDishRestaurant.Size = new Size(931, 156);
            groupBoxDishRestaurant.TabIndex = 17;
            groupBoxDishRestaurant.TabStop = false;
            groupBoxDishRestaurant.Text = "Información para pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(16, 82);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 18;
            label3.Text = "Categoría de plato:";
            // 
            // comboBoxDishCategory
            // 
            comboBoxDishCategory.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxDishCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDishCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDishCategory.ForeColor = Color.Gainsboro;
            comboBoxDishCategory.FormattingEnabled = true;
            comboBoxDishCategory.Location = new Point(188, 82);
            comboBoxDishCategory.Name = "comboBoxDishCategory";
            comboBoxDishCategory.Size = new Size(275, 25);
            comboBoxDishCategory.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(71, 42);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 0;
            label2.Text = "Restaurante:";
            // 
            // btnSelectRestaurant
            // 
            btnSelectRestaurant.BackColor = Color.FromArgb(56, 58, 89);
            btnSelectRestaurant.Cursor = Cursors.Hand;
            btnSelectRestaurant.FlatStyle = FlatStyle.Flat;
            btnSelectRestaurant.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            btnSelectRestaurant.Location = new Point(479, 33);
            btnSelectRestaurant.Name = "btnSelectRestaurant";
            btnSelectRestaurant.Size = new Size(123, 32);
            btnSelectRestaurant.TabIndex = 16;
            btnSelectRestaurant.Text = "Cargar datos";
            btnSelectRestaurant.UseVisualStyleBackColor = false;
            // 
            // comboBoxRestaurant
            // 
            comboBoxRestaurant.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxRestaurant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurant.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRestaurant.ForeColor = Color.Gainsboro;
            comboBoxRestaurant.FormattingEnabled = true;
            comboBoxRestaurant.Location = new Point(188, 36);
            comboBoxRestaurant.Name = "comboBoxRestaurant";
            comboBoxRestaurant.Size = new Size(275, 25);
            comboBoxRestaurant.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(14, 1226);
            label4.Name = "label4";
            label4.Size = new Size(322, 21);
            label4.TabIndex = 13;
            label4.Text = "Seleccione los platos que quiere asignar.";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 760);
            Controls.Add(tabControlOrder);
            Controls.Add(panelTop);
            Name = "OrderView";
            Text = "OrderView";
            panelTop.ResumeLayout(false);
            groupBoxServerInfo.ResumeLayout(false);
            groupBoxServerInfo.PerformLayout();
            tabControlOrder.ResumeLayout(false);
            tabPageOrderList.ResumeLayout(false);
            groupBoxOrders.ResumeLayout(false);
            groupBoxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            tabPageOrderAddNew.ResumeLayout(false);
            tabPageOrderAddNew.PerformLayout();
            groupBoxExtraList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtraList).EndInit();
            groupBoxDish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishList).EndInit();
            panel1.ResumeLayout(false);
            groupBoxDishRestaurant.ResumeLayout(false);
            groupBoxDishRestaurant.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelCustomerName;
        private TabControl tabControlOrder;
        private TabPage tabPageOrderList;
        private Button btnAddNewOrder;
        private DataGridView dataGridViewOrder;
        private TabPage tabPageOrderAddNew;
        private Label label4;
        private ComboBox comboBoxRestaurant;
        private DataGridView dataGridViewDishList;
        private Label label2;
        private GroupBox groupBoxServerInfo;
        private Label label1;
        private TextBox textBoxCustomerId;
        private Label labelConnectionStatus;
        private Label label5;
        private Button btnDisconnect;
        private Button btnConnect;
        private GroupBox groupBoxOrders;
        private GroupBox groupBoxDishRestaurant;
        private GroupBox groupBoxDish;
        private Button btnSelectRestaurant;
        private Label label3;
        private ComboBox comboBoxDishCategory;
        private GroupBox groupBoxExtraList;
        private DataGridView dataGridViewExtraList;
        private Button btnCancel;
        private Button btnPrepareOrder;
        private Label label6;
        private Button btnSendOrder;
        private Label label7;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private Panel panel1;
    }
}