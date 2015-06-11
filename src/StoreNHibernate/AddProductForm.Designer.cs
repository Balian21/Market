namespace StoreNHibernate
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.productLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonSelectingCategory = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 28);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(49, 13);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Продукт";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 73);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Категория";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(12, 125);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(65, 13);
            this.supplierLabel.TabIndex = 0;
            this.supplierLabel.Text = "Поставщик";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(82, 25);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(171, 20);
            this.productTextBox.TabIndex = 1;
            this.productTextBox.Text = "Новый продукт";
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(82, 122);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(171, 21);
            this.suppliersComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(370, 336);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 30);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(468, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(82, 70);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(171, 20);
            this.textBoxCategory.TabIndex = 5;
            // 
            // buttonSelectingCategory
            // 
            this.buttonSelectingCategory.Location = new System.Drawing.Point(259, 68);
            this.buttonSelectingCategory.Name = "buttonSelectingCategory";
            this.buttonSelectingCategory.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectingCategory.TabIndex = 6;
            this.buttonSelectingCategory.Text = "..";
            this.buttonSelectingCategory.UseVisualStyleBackColor = true;
            this.buttonSelectingCategory.Click += new System.EventHandler(this.buttonSelectingCategory_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Model.Category);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(468, 223);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(82, 157);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 10;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наличие";
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Location = new System.Drawing.Point(82, 196);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvailability.TabIndex = 12;
            this.textBoxAvailability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAvailability_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "руб.";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAvailability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSelectingCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.suppliersComboBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.productLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 427);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button buttonSelectingCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAvailability;
        private System.Windows.Forms.Label label3;
    }
}