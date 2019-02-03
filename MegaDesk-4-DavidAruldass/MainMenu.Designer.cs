namespace MegaDesk_3_DavidAruldass
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newquotebutton = new System.Windows.Forms.Button();
            this.viewquotesbutton = new System.Windows.Forms.Button();
            this.searchquotesbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newquotebutton
            // 
            this.newquotebutton.Location = new System.Drawing.Point(102, 61);
            this.newquotebutton.Name = "newquotebutton";
            this.newquotebutton.Size = new System.Drawing.Size(194, 53);
            this.newquotebutton.TabIndex = 0;
            this.newquotebutton.Text = "Add New Quote";
            this.newquotebutton.UseVisualStyleBackColor = true;
            this.newquotebutton.Click += new System.EventHandler(this.newquotebutton_Click);
            // 
            // viewquotesbutton
            // 
            this.viewquotesbutton.Location = new System.Drawing.Point(102, 120);
            this.viewquotesbutton.Name = "viewquotesbutton";
            this.viewquotesbutton.Size = new System.Drawing.Size(194, 49);
            this.viewquotesbutton.TabIndex = 1;
            this.viewquotesbutton.Text = "View Quotes";
            this.viewquotesbutton.UseVisualStyleBackColor = true;
            this.viewquotesbutton.Click += new System.EventHandler(this.viewquotesbutton_Click);
            // 
            // searchquotesbutton
            // 
            this.searchquotesbutton.Location = new System.Drawing.Point(102, 175);
            this.searchquotesbutton.Name = "searchquotesbutton";
            this.searchquotesbutton.Size = new System.Drawing.Size(194, 52);
            this.searchquotesbutton.TabIndex = 5;
            this.searchquotesbutton.Text = "Search Quotes";
            this.searchquotesbutton.Click += new System.EventHandler(this.searchquotesbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(102, 233);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(194, 51);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 223);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchquotesbutton);
            this.Controls.Add(this.viewquotesbutton);
            this.Controls.Add(this.newquotebutton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newquotebutton;
        private System.Windows.Forms.Button viewquotesbutton;
        private System.Windows.Forms.Button searchquotesbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

