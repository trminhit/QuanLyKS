namespace QuanLyKS.All_User_Control
{
    partial class UC_Addroom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 37);
            label1.TabIndex = 0;
            label1.Text = "Thêm phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 119);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1058, 563);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1248, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 2;
            label2.Text = "Room Number";
            // 
            // txtRoomNo
            // 
            txtRoomNo.CustomizableEdges = customizableEdges1;
            txtRoomNo.DefaultText = "";
            txtRoomNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRoomNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRoomNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRoomNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRoomNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomNo.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtRoomNo.ForeColor = Color.Black;
            txtRoomNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomNo.Location = new Point(1248, 161);
            txtRoomNo.Margin = new Padding(4);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.PasswordChar = '\0';
            txtRoomNo.PlaceholderText = "";
            txtRoomNo.SelectedText = "";
            txtRoomNo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtRoomNo.Size = new Size(556, 60);
            txtRoomNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1248, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 4;
            label3.Text = "Room Type";
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.Transparent;
            txtRoomType.CustomizableEdges = customizableEdges3;
            txtRoomType.DrawMode = DrawMode.OwnerDrawFixed;
            txtRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRoomType.FocusedColor = Color.FromArgb(94, 148, 255);
            txtRoomType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomType.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomType.ForeColor = Color.Black;
            txtRoomType.ItemHeight = 30;
            txtRoomType.Items.AddRange(new object[] { "AC", "Non-AC" });
            txtRoomType.Location = new Point(1248, 299);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtRoomType.Size = new Size(556, 36);
            txtRoomType.TabIndex = 5;
            txtRoomType.SelectedIndexChanged += txtRoomType_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges5;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPrice.ForeColor = Color.Black;
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(1248, 524);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrice.Size = new Size(556, 60);
            txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1248, 485);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // txtBed
            // 
            txtBed.BackColor = Color.Transparent;
            txtBed.CustomizableEdges = customizableEdges7;
            txtBed.DrawMode = DrawMode.OwnerDrawFixed;
            txtBed.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBed.FocusedColor = Color.FromArgb(94, 148, 255);
            txtBed.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBed.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBed.ForeColor = Color.Black;
            txtBed.ItemHeight = 30;
            txtBed.Items.AddRange(new object[] { "Single", "Double", "Triple" });
            txtBed.Location = new Point(1248, 415);
            txtBed.Name = "txtBed";
            txtBed.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBed.Size = new Size(556, 36);
            txtBed.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1248, 372);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 8;
            label5.Text = "Bed";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BorderRadius = 18;
            btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnAddRoom.BorderThickness = 1;
            btnAddRoom.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnAddRoom.CheckedState.ForeColor = Color.White;
            btnAddRoom.CustomizableEdges = customizableEdges9;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.FillColor = Color.White;
            btnAddRoom.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddRoom.ForeColor = Color.Black;
            btnAddRoom.Location = new Point(1579, 626);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddRoom.Size = new Size(225, 56);
            btnAddRoom.TabIndex = 10;
            btnAddRoom.Text = "Add Room";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_Addroom
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddRoom);
            Controls.Add(txtBed);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtRoomType);
            Controls.Add(label3);
            Controls.Add(txtRoomNo);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_Addroom";
            Size = new Size(2352, 852);
            Load += UC_Addroom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Label label3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
