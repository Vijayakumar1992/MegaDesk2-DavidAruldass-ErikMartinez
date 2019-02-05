namespace MegaDesk_3_DavidAruldass
{
    partial class SearchQuotes
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(469, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetime,
            this.customerName,
            this.widthColumn,
            this.depthColumn,
            this.drawersColumn,
            this.surfaceArea,
            this.deliveryType,
            this.totalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(1, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Date/Time";
            this.datetime.Name = "datetime";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            // 
            // widthColumn
            // 
            this.widthColumn.HeaderText = "Width";
            this.widthColumn.Name = "widthColumn";
            // 
            // depthColumn
            // 
            this.depthColumn.HeaderText = "Depth";
            this.depthColumn.Name = "depthColumn";
            // 
            // drawersColumn
            // 
            this.drawersColumn.HeaderText = "Drawers";
            this.drawersColumn.Name = "drawersColumn";
            // 
            // surfaceArea
            // 
            this.surfaceArea.HeaderText = "Surface Area";
            this.surfaceArea.Name = "surfaceArea";
            // 
            // deliveryType
            // 
            this.deliveryType.HeaderText = "Delivery Type";
            this.deliveryType.Name = "deliveryType";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Label label1;
    }
}