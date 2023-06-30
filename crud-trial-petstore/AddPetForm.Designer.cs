namespace crud_trial_petstore
{
    partial class AddPetForm
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
            label1 = new Label();
            txtId = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpImportDate = new DateTimePicker();
            cbbGroup = new ComboBox();
            txtErrorMsg = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 49);
            label1.Name = "label1";
            label1.Size = new Size(236, 46);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW PET";
            // 
            // txtId
            // 
            txtId.Location = new Point(161, 146);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(758, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 149);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 202);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 199);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 250);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "Import Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 304);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(161, 301);
            txtDescription.MaxLength = 100;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(258, 27);
            txtDescription.TabIndex = 9;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 251);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 197);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(523, 149);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 12;
            label8.Text = "Quantity";
            // 
            // dtpImportDate
            // 
            dtpImportDate.Enabled = false;
            dtpImportDate.ImeMode = ImeMode.Off;
            dtpImportDate.Location = new Point(161, 245);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(258, 27);
            dtpImportDate.TabIndex = 17;
            // 
            // cbbGroup
            // 
            cbbGroup.FormattingEnabled = true;
            cbbGroup.Location = new Point(594, 247);
            cbbGroup.Name = "cbbGroup";
            cbbGroup.Size = new Size(258, 28);
            cbbGroup.TabIndex = 20;
            // 
            // txtErrorMsg
            // 
            txtErrorMsg.AutoSize = true;
            txtErrorMsg.ForeColor = Color.Red;
            txtErrorMsg.Location = new Point(547, 354);
            txtErrorMsg.Name = "txtErrorMsg";
            txtErrorMsg.Size = new Size(0, 20);
            txtErrorMsg.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(594, 194);
            txtPrice.MaxLength = 20;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(258, 27);
            txtPrice.TabIndex = 22;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(594, 146);
            txtQuantity.MaxLength = 20;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(258, 27);
            txtQuantity.TabIndex = 23;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // AddPetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtErrorMsg);
            Controls.Add(cbbGroup);
            Controls.Add(dtpImportDate);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "AddPetForm";
            Text = "AddPetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpImportDate;
        private ComboBox cbbGroup;
        private Label txtErrorMsg;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}