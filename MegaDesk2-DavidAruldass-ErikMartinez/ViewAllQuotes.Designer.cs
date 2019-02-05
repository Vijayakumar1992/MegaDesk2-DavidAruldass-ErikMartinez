namespace MegaDesk_3_DavidAruldass
{
    partial class ViewAllQuotes
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
            this.cancelbutton = new System.Windows.Forms.Button();
            this.quoteGrid = new System.Windows.Forms.DataGridView();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(280, 240);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(127, 39);
            this.cancelbutton.TabIndex = 0;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // quoteGrid
            // 
            this.quoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTime,
            this.customerName,
            this.widthColumn,
            this.depthColumn,
            this.drawersColumn,
            this.surfaceArea,
            this.deliveryType,
            this.totalPrice});
            this.quoteGrid.Location = new System.Drawing.Point(3, -1);
            this.quoteGrid.Name = "quoteGrid";
            this.quoteGrid.Size = new System.Drawing.Size(810, 220);
            this.quoteGrid.TabIndex = 1;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date/Time";
            this.dateTime.Name = "dateTime";
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
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.quoteGrid);
            this.Controls.Add(this.cancelbutton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.DataGridView quoteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}