namespace WinFormsWork8
{
    partial class SalesDepartment
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
            this.labelCurrencyKzt = new System.Windows.Forms.Label();
            this.labelListOfProduct = new System.Windows.Forms.Label();
            this.comboBoxProductInfo = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProductInfo = new System.Windows.Forms.ListBox();
            this.buttonStock = new System.Windows.Forms.Button();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCurrencyKzt
            // 
            this.labelCurrencyKzt.AutoSize = true;
            this.labelCurrencyKzt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrencyKzt.Location = new System.Drawing.Point(236, 84);
            this.labelCurrencyKzt.Name = "labelCurrencyKzt";
            this.labelCurrencyKzt.Size = new System.Drawing.Size(27, 20);
            this.labelCurrencyKzt.TabIndex = 2;
            this.labelCurrencyKzt.Text = "тг";
            // 
            // labelListOfProduct
            // 
            this.labelListOfProduct.AutoSize = true;
            this.labelListOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOfProduct.Location = new System.Drawing.Point(54, 9);
            this.labelListOfProduct.Name = "labelListOfProduct";
            this.labelListOfProduct.Size = new System.Drawing.Size(144, 20);
            this.labelListOfProduct.TabIndex = 7;
            this.labelListOfProduct.Text = "Список товаров";
            // 
            // comboBoxProductInfo
            // 
            this.comboBoxProductInfo.FormattingEnabled = true;
            this.comboBoxProductInfo.Location = new System.Drawing.Point(13, 40);
            this.comboBoxProductInfo.Name = "comboBoxProductInfo";
            this.comboBoxProductInfo.Size = new System.Drawing.Size(250, 21);
            this.comboBoxProductInfo.TabIndex = 8;
            this.comboBoxProductInfo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProductInfo_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(13, 75);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(217, 29);
            this.textBoxPrice.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(297, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 29);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(12, 456);
            this.textBoxTotalPrice.Multiline = true;
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(250, 29);
            this.textBoxTotalPrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "тг";
            // 
            // listBoxProductInfo
            // 
            this.listBoxProductInfo.FormattingEnabled = true;
            this.listBoxProductInfo.Location = new System.Drawing.Point(13, 163);
            this.listBoxProductInfo.Name = "listBoxProductInfo";
            this.listBoxProductInfo.Size = new System.Drawing.Size(455, 277);
            this.listBoxProductInfo.TabIndex = 13;
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.White;
            this.buttonStock.Location = new System.Drawing.Point(13, 503);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(153, 29);
            this.buttonStock.TabIndex = 14;
            this.buttonStock.Text = "<<Склад";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.ButtonStock_Click);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(13, 119);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.Size = new System.Drawing.Size(455, 38);
            this.textBoxInformation.TabIndex = 15;
            // 
            // SalesDepartment
            // 
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(480, 544);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.listBoxProductInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxProductInfo);
            this.Controls.Add(this.labelListOfProduct);
            this.Controls.Add(this.labelCurrencyKzt);
            this.Name = "SalesDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrencyKzt;
        private System.Windows.Forms.Label labelListOfProduct;
        private System.Windows.Forms.ComboBox comboBoxProductInfo;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProductInfo;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.TextBox textBoxInformation;
    }
}