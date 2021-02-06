namespace Store_Management_IT
{
    partial class Product_Info_Form
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Product_Id_Txt = new System.Windows.Forms.TextBox();
            this.Product_Name_Txt = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Product_Speci_Txt = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Unit_ComboBox = new System.Windows.Forms.ComboBox();
            this.Product_Quantity_Txt = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.Purchased_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Btn_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.Btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Fine = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 24);
            this.panel1.TabIndex = 0;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Exit_btn.Image = global::Store_Management_IT.Properties.Resources.Exit;
            this.Exit_btn.ImageActive = null;
            this.Exit_btn.Location = new System.Drawing.Point(975, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(22, 20);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Zoom = 10;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(85, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Project Id :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Fine);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.lbl6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Purchased_DateTimePicker);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.Product_Quantity_Txt);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.Unit_ComboBox);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.Product_Speci_Txt);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.Product_Name_Txt);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.Product_Id_Txt);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // Product_Id_Txt
            // 
            this.Product_Id_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Id_Txt.Location = new System.Drawing.Point(169, 25);
            this.Product_Id_Txt.Multiline = true;
            this.Product_Id_Txt.Name = "Product_Id_Txt";
            this.Product_Id_Txt.Size = new System.Drawing.Size(108, 25);
            this.Product_Id_Txt.TabIndex = 2;
            // 
            // Product_Name_Txt
            // 
            this.Product_Name_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name_Txt.Location = new System.Drawing.Point(169, 68);
            this.Product_Name_Txt.Multiline = true;
            this.Product_Name_Txt.Name = "Product_Name_Txt";
            this.Product_Name_Txt.Size = new System.Drawing.Size(202, 25);
            this.Product_Name_Txt.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(51, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(112, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Product Name :";
            // 
            // Product_Speci_Txt
            // 
            this.Product_Speci_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Speci_Txt.Location = new System.Drawing.Point(169, 113);
            this.Product_Speci_Txt.Multiline = true;
            this.Product_Speci_Txt.Name = "Product_Speci_Txt";
            this.Product_Speci_Txt.Size = new System.Drawing.Size(202, 72);
            this.Product_Speci_Txt.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(6, 113);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(156, 18);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Product Specification :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(120, 203);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(42, 18);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Unit :";
            // 
            // Unit_ComboBox
            // 
            this.Unit_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_ComboBox.FormattingEnabled = true;
            this.Unit_ComboBox.Location = new System.Drawing.Point(169, 204);
            this.Unit_ComboBox.Name = "Unit_ComboBox";
            this.Unit_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Unit_ComboBox.TabIndex = 8;
            // 
            // Product_Quantity_Txt
            // 
            this.Product_Quantity_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Quantity_Txt.Location = new System.Drawing.Point(168, 321);
            this.Product_Quantity_Txt.Multiline = true;
            this.Product_Quantity_Txt.Name = "Product_Quantity_Txt";
            this.Product_Quantity_Txt.Size = new System.Drawing.Size(122, 25);
            this.Product_Quantity_Txt.TabIndex = 10;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(36, 321);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(126, 18);
            this.lbl7.TabIndex = 9;
            this.lbl7.Text = "Product Quantity :";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(36, 365);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(122, 18);
            this.lbl8.TabIndex = 11;
            this.lbl8.Text = "Purchased Date :";
            // 
            // Purchased_DateTimePicker
            // 
            this.Purchased_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchased_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Purchased_DateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Purchased_DateTimePicker.Location = new System.Drawing.Point(168, 367);
            this.Purchased_DateTimePicker.Name = "Purchased_DateTimePicker";
            this.Purchased_DateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.Purchased_DateTimePicker.TabIndex = 12;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Save.BorderRadius = 0;
            this.Btn_Save.ButtonText = "Save";
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Save.Iconimage = null;
            this.Btn_Save.Iconimage_right = null;
            this.Btn_Save.Iconimage_right_Selected = null;
            this.Btn_Save.Iconimage_Selected = null;
            this.Btn_Save.IconMarginLeft = 0;
            this.Btn_Save.IconMarginRight = 0;
            this.Btn_Save.IconRightVisible = true;
            this.Btn_Save.IconRightZoom = 0D;
            this.Btn_Save.IconVisible = true;
            this.Btn_Save.IconZoom = 90D;
            this.Btn_Save.IsTab = false;
            this.Btn_Save.Location = new System.Drawing.Point(169, 420);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(88, 34);
            this.Btn_Save.TabIndex = 13;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Save.Textcolor = System.Drawing.Color.White;
            this.Btn_Save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Update.BorderRadius = 0;
            this.Btn_Update.ButtonText = "Update";
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Update.Iconimage = null;
            this.Btn_Update.Iconimage_right = null;
            this.Btn_Update.Iconimage_right_Selected = null;
            this.Btn_Update.Iconimage_Selected = null;
            this.Btn_Update.IconMarginLeft = 0;
            this.Btn_Update.IconMarginRight = 0;
            this.Btn_Update.IconRightVisible = true;
            this.Btn_Update.IconRightZoom = 0D;
            this.Btn_Update.IconVisible = true;
            this.Btn_Update.IconZoom = 90D;
            this.Btn_Update.IsTab = false;
            this.Btn_Update.Location = new System.Drawing.Point(263, 420);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Update.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Update.selected = false;
            this.Btn_Update.Size = new System.Drawing.Size(88, 34);
            this.Btn_Update.TabIndex = 14;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Update.Textcolor = System.Drawing.Color.White;
            this.Btn_Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(99, 245);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(64, 18);
            this.lbl5.TabIndex = 15;
            this.lbl5.Text = "Source :";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(85, 282);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(73, 18);
            this.lbl6.TabIndex = 17;
            this.lbl6.Text = "Location :";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.BorderRadius = 0;
            this.Btn_Delete.ButtonText = "Delete";
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Delete.Iconimage = null;
            this.Btn_Delete.Iconimage_right = null;
            this.Btn_Delete.Iconimage_right_Selected = null;
            this.Btn_Delete.Iconimage_Selected = null;
            this.Btn_Delete.IconMarginLeft = 0;
            this.Btn_Delete.IconMarginRight = 0;
            this.Btn_Delete.IconRightVisible = true;
            this.Btn_Delete.IconRightZoom = 0D;
            this.Btn_Delete.IconVisible = true;
            this.Btn_Delete.IconZoom = 90D;
            this.Btn_Delete.IsTab = false;
            this.Btn_Delete.Location = new System.Drawing.Point(357, 420);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Delete.selected = false;
            this.Btn_Delete.Size = new System.Drawing.Size(88, 34);
            this.Btn_Delete.TabIndex = 19;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Delete.Textcolor = System.Drawing.Color.White;
            this.Btn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Fine
            // 
            this.Btn_Fine.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Fine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Fine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Fine.BorderRadius = 0;
            this.Btn_Fine.ButtonText = "F";
            this.Btn_Fine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fine.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Fine.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Fine.Iconimage = null;
            this.Btn_Fine.Iconimage_right = null;
            this.Btn_Fine.Iconimage_right_Selected = null;
            this.Btn_Fine.Iconimage_Selected = null;
            this.Btn_Fine.IconMarginLeft = 0;
            this.Btn_Fine.IconMarginRight = 0;
            this.Btn_Fine.IconRightVisible = true;
            this.Btn_Fine.IconRightZoom = 0D;
            this.Btn_Fine.IconVisible = true;
            this.Btn_Fine.IconZoom = 90D;
            this.Btn_Fine.IsTab = false;
            this.Btn_Fine.Location = new System.Drawing.Point(283, 25);
            this.Btn_Fine.Name = "Btn_Fine";
            this.Btn_Fine.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Fine.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Fine.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Fine.selected = false;
            this.Btn_Fine.Size = new System.Drawing.Size(88, 25);
            this.Btn_Fine.TabIndex = 20;
            this.Btn_Fine.Text = "F";
            this.Btn_Fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Fine.Textcolor = System.Drawing.Color.White;
            this.Btn_Fine.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView);
            this.groupBox2.Location = new System.Drawing.Point(505, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 473);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 17);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(472, 448);
            this.DataGridView.TabIndex = 0;
            // 
            // Product_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Infomation";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Exit_btn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Purchased_DateTimePicker;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox Product_Quantity_Txt;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ComboBox Unit_ComboBox;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Product_Speci_Txt;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox Product_Name_Txt;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox Product_Id_Txt;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Save;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Update;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl5;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Fine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}

