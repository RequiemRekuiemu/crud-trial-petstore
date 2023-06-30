namespace crud_trial_petstore
{
    partial class ManagementForm
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
            dgvPetList = new DataGridView();
            label1 = new Label();
            btnPriceSearch = new Button();
            label3 = new Label();
            txtMaxPrice = new TextBox();
            label4 = new Label();
            txtMinPrice = new TextBox();
            label5 = new Label();
            txtMinQuantity = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtMaxQuantity = new TextBox();
            label7 = new Label();
            btnQuantitySearch = new Button();
            txtPetId = new TextBox();
            label8 = new Label();
            btnDelete = new Button();
            btnReset = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPetList).BeginInit();
            SuspendLayout();
            // 
            // dgvPetList
            // 
            dgvPetList.AllowUserToAddRows = false;
            dgvPetList.AllowUserToDeleteRows = false;
            dgvPetList.AllowUserToResizeColumns = false;
            dgvPetList.AllowUserToResizeRows = false;
            dgvPetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetList.Location = new Point(12, 58);
            dgvPetList.Name = "dgvPetList";
            dgvPetList.ReadOnly = true;
            dgvPetList.RowHeadersWidth = 51;
            dgvPetList.RowTemplate.Height = 29;
            dgvPetList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPetList.Size = new Size(958, 230);
            dgvPetList.TabIndex = 0;
            dgvPetList.CellClick += dgvPetList_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 46);
            label1.TabIndex = 1;
            label1.Text = "MANAGEMENT";
            // 
            // btnPriceSearch
            // 
            btnPriceSearch.Location = new Point(493, 326);
            btnPriceSearch.Name = "btnPriceSearch";
            btnPriceSearch.Size = new Size(94, 29);
            btnPriceSearch.TabIndex = 7;
            btnPriceSearch.Text = "SEARCH";
            btnPriceSearch.UseVisualStyleBackColor = true;
            btnPriceSearch.Click += btnPriceSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 330);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 3;
            label3.Text = "Max";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(362, 327);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(125, 27);
            txtMaxPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 301);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 8;
            label4.Text = "Price Search";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(362, 360);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(125, 27);
            txtMinPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 363);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 9;
            label5.Text = "Min";
            // 
            // txtMinQuantity
            // 
            txtMinQuantity.Location = new Point(62, 360);
            txtMinQuantity.Name = "txtMinQuantity";
            txtMinQuantity.Size = new Size(125, 27);
            txtMinQuantity.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 363);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 15;
            label2.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 301);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 14;
            label6.Text = "Quantity Search";
            // 
            // txtMaxQuantity
            // 
            txtMaxQuantity.Location = new Point(62, 327);
            txtMaxQuantity.Name = "txtMaxQuantity";
            txtMaxQuantity.Size = new Size(125, 27);
            txtMaxQuantity.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 330);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 11;
            label7.Text = "Max";
            // 
            // btnQuantitySearch
            // 
            btnQuantitySearch.Location = new Point(193, 326);
            btnQuantitySearch.Name = "btnQuantitySearch";
            btnQuantitySearch.Size = new Size(94, 29);
            btnQuantitySearch.TabIndex = 17;
            btnQuantitySearch.Text = "SEARCH";
            btnQuantitySearch.UseVisualStyleBackColor = true;
            btnQuantitySearch.Click += btnQuantitySearch_Click;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(845, 328);
            txtPetId.Name = "txtPetId";
            txtPetId.ReadOnly = true;
            txtPetId.Size = new Size(125, 27);
            txtPetId.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(922, 301);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 19;
            label8.Text = "Pet ID";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(876, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(876, 26);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 21;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(876, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(694, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(label8);
            Controls.Add(txtPetId);
            Controls.Add(btnQuantitySearch);
            Controls.Add(txtMinQuantity);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtMaxQuantity);
            Controls.Add(label7);
            Controls.Add(txtMinPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnPriceSearch);
            Controls.Add(txtMaxPrice);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvPetList);
            Name = "ManagementForm";
            Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvPetList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPetList;
        private Label label1;
        private Button btnPriceSearch;
        private Label label3;
        private TextBox txtMaxPrice;
        private Label label4;
        private TextBox txtMinPrice;
        private Label label5;
        private TextBox txtMinQuantity;
        private Label label2;
        private Label label6;
        private TextBox txtMaxQuantity;
        private Label label7;
        private Button btnQuantitySearch;
        private TextBox txtPetId;
        private Label label8;
        private Button btnDelete;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnAdd;
    }
}