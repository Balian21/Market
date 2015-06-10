namespace StoreNHibernate
{
    partial class EditProductForm
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonSelectingCategory = new System.Windows.Forms.Button();
            this.buttonSelectingSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChange = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(80, 26);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(486, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(14, 29);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 13);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Продукт";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(14, 70);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(60, 13);
            this.labelCategoryName.TabIndex = 1;
            this.labelCategoryName.Text = "Категория";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(14, 114);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(65, 13);
            this.labelSupplierName.TabIndex = 1;
            this.labelSupplierName.Text = "Поставщик";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(669, 306);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(103, 31);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(780, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(80, 111);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(486, 20);
            this.textBoxSupplierName.TabIndex = 4;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(80, 67);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(486, 20);
            this.textBoxCategoryName.TabIndex = 4;
            // 
            // buttonSelectingCategory
            // 
            this.buttonSelectingCategory.Location = new System.Drawing.Point(581, 64);
            this.buttonSelectingCategory.Name = "buttonSelectingCategory";
            this.buttonSelectingCategory.Size = new System.Drawing.Size(25, 25);
            this.buttonSelectingCategory.TabIndex = 5;
            this.buttonSelectingCategory.Text = "...";
            this.buttonSelectingCategory.UseVisualStyleBackColor = true;
            this.buttonSelectingCategory.Click += new System.EventHandler(this.buttonSelectingCategory_Click);
            // 
            // buttonSelectingSupplier
            // 
            this.buttonSelectingSupplier.Location = new System.Drawing.Point(581, 108);
            this.buttonSelectingSupplier.Name = "buttonSelectingSupplier";
            this.buttonSelectingSupplier.Size = new System.Drawing.Size(25, 25);
            this.buttonSelectingSupplier.TabIndex = 6;
            this.buttonSelectingSupplier.Text = "...";
            this.buttonSelectingSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectingSupplier.Click += new System.EventHandler(this.buttonSelectingSupplier_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.labelProductName);
            this.panel1.Controls.Add(this.buttonSelectingCategory);
            this.panel1.Controls.Add(this.buttonSelectingSupplier);
            this.panel1.Controls.Add(this.textBoxCategoryName);
            this.panel1.Controls.Add(this.labelCategoryName);
            this.panel1.Controls.Add(this.labelSupplierName);
            this.panel1.Controls.Add(this.textBoxSupplierName);
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 157);
            this.panel1.TabIndex = 7;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(810, 215);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 9;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(687, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 186);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 349);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать продукт";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonSelectingCategory;
        private System.Windows.Forms.Button buttonSelectingSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}