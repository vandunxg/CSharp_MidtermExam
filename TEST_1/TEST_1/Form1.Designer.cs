namespace TEST_1
{
    partial class HomePage
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
            this.cmb_CategoryID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_OnHandQuatity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ProductData = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Skip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_CategoryID
            // 
            this.cmb_CategoryID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cmb_CategoryID.FormattingEnabled = true;
            this.cmb_CategoryID.Location = new System.Drawing.Point(241, 30);
            this.cmb_CategoryID.Name = "cmb_CategoryID";
            this.cmb_CategoryID.Size = new System.Drawing.Size(244, 38);
            this.cmb_CategoryID.TabIndex = 0;
            this.cmb_CategoryID.SelectedIndexChanged += new System.EventHandler(this.cmb_CategoryID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại sách : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sách :";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductCode.Location = new System.Drawing.Point(241, 103);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(244, 37);
            this.txt_ProductCode.TabIndex = 4;
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(241, 176);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(244, 37);
            this.txt_Description.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiêu đề : ";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(816, 34);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(244, 37);
            this.txt_UnitPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá :";
            // 
            // txt_OnHandQuatity
            // 
            this.txt_OnHandQuatity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OnHandQuatity.Location = new System.Drawing.Point(816, 104);
            this.txt_OnHandQuatity.Name = "txt_OnHandQuatity";
            this.txt_OnHandQuatity.Size = new System.Drawing.Size(244, 37);
            this.txt_OnHandQuatity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng : ";
            // 
            // dgv_ProductData
            // 
            this.dgv_ProductData.AllowUserToAddRows = false;
            this.dgv_ProductData.AllowUserToDeleteRows = false;
            this.dgv_ProductData.AllowUserToResizeColumns = false;
            this.dgv_ProductData.AllowUserToResizeRows = false;
            this.dgv_ProductData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductData.Location = new System.Drawing.Point(90, 240);
            this.dgv_ProductData.Name = "dgv_ProductData";
            this.dgv_ProductData.RowHeadersWidth = 51;
            this.dgv_ProductData.RowTemplate.Height = 24;
            this.dgv_ProductData.Size = new System.Drawing.Size(970, 403);
            this.dgv_ProductData.TabIndex = 11;
            this.dgv_ProductData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductData_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(188, 691);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 43);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(351, 691);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(102, 43);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(530, 691);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(102, 43);
            this.btn_Del.TabIndex = 14;
            this.btn_Del.Text = "Xoá";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(722, 691);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 43);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Skip
            // 
            this.btn_Skip.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Skip.Location = new System.Drawing.Point(905, 691);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(102, 43);
            this.btn_Skip.TabIndex = 16;
            this.btn_Skip.Text = "Bỏ qua";
            this.btn_Skip.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 769);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ProductData);
            this.Controls.Add(this.txt_OnHandQuatity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_CategoryID);
            this.Name = "HomePage";
            this.Text = "THÔNG TIN SÁCH";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_CategoryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_OnHandQuatity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ProductData;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Skip;
    }
}

