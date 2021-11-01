
namespace SalesWinApp.Admin.ProductManagement
{
    partial class frmProductManagement
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbInStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(510, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(510, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(510, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(305, 64);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(157, 27);
            this.txtUnitPrice.TabIndex = 28;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(83, 110);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(125, 27);
            this.txtCategoryId.TabIndex = 27;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(305, 22);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(157, 27);
            this.txtWeight.TabIndex = 26;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(305, 110);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.ReadOnly = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(157, 27);
            this.txtUnitsInStock.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 67);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 24;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(83, 22);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(125, 27);
            this.txtProductId.TabIndex = 23;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(227, 70);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(41, 20);
            this.lbUnitPrice.TabIndex = 22;
            this.lbUnitPrice.Text = "Price";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(14, 113);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(82, 20);
            this.lbCategoryId.TabIndex = 21;
            this.lbCategoryId.Text = "CategoryId";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(227, 22);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(227, 113);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(61, 20);
            this.lbUnitsInStock.TabIndex = 19;
            this.lbUnitsInStock.Text = "In Stock";
            this.lbUnitsInStock.Click += new System.EventHandler(this.lbUnitsInStock_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name";
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(14, 22);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(24, 20);
            this.lbMemberId.TabIndex = 17;
            this.lbMemberId.Text = "ID";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(24, 185);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 29;
            this.dgvMember.Size = new System.Drawing.Size(763, 244);
            this.dgvMember.TabIndex = 16;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(640, 21);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.PlaceholderText = "Product Id...";
            this.txtSearchId.Size = new System.Drawing.Size(125, 27);
            this.txtSearchId.TabIndex = 32;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(640, 67);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PlaceholderText = "Product Name...";
            this.txtSearchName.Size = new System.Drawing.Size(125, 27);
            this.txtSearchName.TabIndex = 33;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(656, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 35;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtInStock
            // 
            this.txtInStock.Location = new System.Drawing.Point(337, 149);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(125, 27);
            this.txtInStock.TabIndex = 36;
            this.txtInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInStock.TextChanged += new System.EventHandler(this.txtInStock_TextChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(55, 152);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 37;
            this.lbPrice.Text = "Price";
            // 
            // lbInStock
            // 
            this.lbInStock.AutoSize = true;
            this.lbInStock.Location = new System.Drawing.Point(266, 152);
            this.lbInStock.Name = "lbInStock";
            this.lbInStock.Size = new System.Drawing.Size(57, 20);
            this.lbInStock.TabIndex = 38;
            this.lbInStock.Text = "InStock";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbInStock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.dgvMember);
            this.Name = "frmProductManagement";
            this.Text = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbInStock;
    }
}