namespace Store_Management_IT
{
    partial class Unit_Form
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
            this.lbl_Info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Fine = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Unit_Name_Txt = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Unit_Id_Txt = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 24);
            this.panel1.TabIndex = 1;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Exit_btn.Image = global::Store_Management_IT.Properties.Resources.Exit;
            this.Exit_btn.ImageActive = null;
            this.Exit_btn.Location = new System.Drawing.Point(819, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(22, 20);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Zoom = 10;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(3, 4);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(39, 16);
            this.lbl_Info.TabIndex = 22;
            this.lbl_Info.Text = "Unit ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Fine);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Unit_Name_Txt);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.Unit_Id_Txt);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(168, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Info";
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
            this.Btn_Delete.Location = new System.Drawing.Point(300, 114);
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
            this.Btn_Update.Location = new System.Drawing.Point(206, 114);
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
            this.Btn_Save.Location = new System.Drawing.Point(112, 114);
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
            // Unit_Name_Txt
            // 
            this.Unit_Name_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Name_Txt.Location = new System.Drawing.Point(169, 68);
            this.Unit_Name_Txt.Multiline = true;
            this.Unit_Name_Txt.Name = "Unit_Name_Txt";
            this.Unit_Name_Txt.Size = new System.Drawing.Size(202, 25);
            this.Unit_Name_Txt.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(76, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Unit Name :";
            // 
            // Unit_Id_Txt
            // 
            this.Unit_Id_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Id_Txt.Location = new System.Drawing.Point(169, 25);
            this.Unit_Id_Txt.Multiline = true;
            this.Unit_Id_Txt.Name = "Unit_Id_Txt";
            this.Unit_Id_Txt.Size = new System.Drawing.Size(108, 25);
            this.Unit_Id_Txt.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(105, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Unit Id :";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 201);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(821, 325);
            this.DataGridView.TabIndex = 4;
            // 
            // Unit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(845, 538);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Exit_btn;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Fine;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Update;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Save;
        private System.Windows.Forms.TextBox Unit_Name_Txt;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox Unit_Id_Txt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}