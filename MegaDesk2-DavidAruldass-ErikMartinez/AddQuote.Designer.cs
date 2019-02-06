namespace MegaDesk_3_DavidAruldass
{
    partial class AddQuote   
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.widthupanddown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.depthupdown = new System.Windows.Forms.NumericUpDown();
            this.depthwarning = new System.Windows.Forms.Label();
            this.Get_NewQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Surface_Matrial = new System.Windows.Forms.ComboBox();
            this.Delivery_Time = new System.Windows.Forms.ComboBox();
            this.Num_Drawers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthupanddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(267, 272);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 30);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_click);
            // 
            // widthupanddown
            // 
            this.widthupanddown.Location = new System.Drawing.Point(42, 125);
            this.widthupanddown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthupanddown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthupanddown.Name = "widthupanddown";
            this.widthupanddown.Size = new System.Drawing.Size(85, 20);
            this.widthupanddown.TabIndex = 3;
            this.widthupanddown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthupanddown.Validating += new System.ComponentModel.CancelEventHandler(this.widthupanddown_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depth";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(130, 76);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(207, 20);
            this.CustomerName.TabIndex = 6;
            // 
            // depthupdown
            // 
            this.depthupdown.Location = new System.Drawing.Point(190, 125);
            this.depthupdown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthupdown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthupdown.Name = "depthupdown";
            this.depthupdown.Size = new System.Drawing.Size(85, 20);
            this.depthupdown.TabIndex = 7;
            this.depthupdown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthupdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthupdown_KeyPress);
            // 
            // depthwarning
            // 
            this.depthwarning.AutoSize = true;
            this.depthwarning.Location = new System.Drawing.Point(148, 155);
            this.depthwarning.Name = "depthwarning";
            this.depthwarning.Size = new System.Drawing.Size(0, 13);
            this.depthwarning.TabIndex = 8;
            // 
            // Get_NewQuote
            // 
            this.Get_NewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_NewQuote.Location = new System.Drawing.Point(130, 272);
            this.Get_NewQuote.Name = "Get_NewQuote";
            this.Get_NewQuote.Size = new System.Drawing.Size(109, 30);
            this.Get_NewQuote.TabIndex = 11;
            this.Get_NewQuote.Text = "Get Quote";
            this.Get_NewQuote.UseVisualStyleBackColor = true;
            this.Get_NewQuote.Click += new System.EventHandler(this.Get_NewQuote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delivery ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Drawers ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "NEW QUOTE";
            // 
            // Surface_Matrial
            // 
            this.Surface_Matrial.FormattingEnabled = true;
            this.Surface_Matrial.Location = new System.Drawing.Point(384, 124);
            this.Surface_Matrial.Name = "Surface_Matrial";
            this.Surface_Matrial.Size = new System.Drawing.Size(85, 21);
            this.Surface_Matrial.TabIndex = 19;
            // 
            // Delivery_Time
            // 
            this.Delivery_Time.FormattingEnabled = true;
            this.Delivery_Time.Location = new System.Drawing.Point(318, 197);
            this.Delivery_Time.Name = "Delivery_Time";
            this.Delivery_Time.Size = new System.Drawing.Size(96, 21);
            this.Delivery_Time.TabIndex = 21;
            // 
            // Num_Drawers
            // 
            this.Num_Drawers.Location = new System.Drawing.Point(119, 198);
            this.Num_Drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Num_Drawers.Name = "Num_Drawers";
            this.Num_Drawers.Size = new System.Drawing.Size(74, 20);
            this.Num_Drawers.TabIndex = 22;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.Num_Drawers);
            this.Controls.Add(this.Delivery_Time);
            this.Controls.Add(this.Surface_Matrial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Get_NewQuote);
            this.Controls.Add(this.depthwarning);
            this.Controls.Add(this.depthupdown);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthupanddown);
            this.Controls.Add(this.CancelButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthupanddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown widthupanddown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.NumericUpDown depthupdown;
        private System.Windows.Forms.Label depthwarning;
        private System.Windows.Forms.Button Get_NewQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Surface_Matrial;
        private System.Windows.Forms.ComboBox Delivery_Time;
        private System.Windows.Forms.NumericUpDown Num_Drawers;
    }
}