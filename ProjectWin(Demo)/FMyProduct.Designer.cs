namespace ProjectWin_Demo_
{
    partial class FMyProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new CustomButton.VBButton();
            this.btnRemove = new CustomButton.VBButton();
            this.btnUpdate = new CustomButton.VBButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProducts1 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts2 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts3 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts4 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts5 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts6 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts7 = new ProjectWin_Demo_.UCProducts();
            this.ucProducts8 = new ProjectWin_Demo_.UCProducts();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(900, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 686);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 686);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các sản phẩm:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 40);
            this.panel3.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 12;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(36, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm sản phẩm";
            this.btnAdd.TextColor = System.Drawing.Color.Yellow;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemove.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 12;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemove.Location = new System.Drawing.Point(36, 446);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 52);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xóa sản phẩm";
            this.btnRemove.TextColor = System.Drawing.Color.Yellow;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 12;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(36, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 52);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật thông tin sản phẩm";
            this.btnUpdate.TextColor = System.Drawing.Color.Yellow;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.flowLayoutPanel1.Controls.Add(this.ucProducts1);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts2);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts3);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts4);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts5);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts6);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts7);
            this.flowLayoutPanel1.Controls.Add(this.ucProducts8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 646);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ucProducts1
            // 
            this.ucProducts1.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts1.Location = new System.Drawing.Point(3, 3);
            this.ucProducts1.Name = "ucProducts1";
            this.ucProducts1.Size = new System.Drawing.Size(212, 320);
            this.ucProducts1.TabIndex = 0;
            // 
            // ucProducts2
            // 
            this.ucProducts2.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts2.Location = new System.Drawing.Point(221, 3);
            this.ucProducts2.Name = "ucProducts2";
            this.ucProducts2.Size = new System.Drawing.Size(212, 320);
            this.ucProducts2.TabIndex = 1;
            // 
            // ucProducts3
            // 
            this.ucProducts3.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts3.Location = new System.Drawing.Point(439, 3);
            this.ucProducts3.Name = "ucProducts3";
            this.ucProducts3.Size = new System.Drawing.Size(212, 320);
            this.ucProducts3.TabIndex = 2;
            // 
            // ucProducts4
            // 
            this.ucProducts4.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts4.Location = new System.Drawing.Point(657, 3);
            this.ucProducts4.Name = "ucProducts4";
            this.ucProducts4.Size = new System.Drawing.Size(212, 320);
            this.ucProducts4.TabIndex = 3;
            // 
            // ucProducts5
            // 
            this.ucProducts5.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts5.Location = new System.Drawing.Point(3, 329);
            this.ucProducts5.Name = "ucProducts5";
            this.ucProducts5.Size = new System.Drawing.Size(212, 320);
            this.ucProducts5.TabIndex = 4;
            // 
            // ucProducts6
            // 
            this.ucProducts6.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts6.Location = new System.Drawing.Point(221, 329);
            this.ucProducts6.Name = "ucProducts6";
            this.ucProducts6.Size = new System.Drawing.Size(212, 320);
            this.ucProducts6.TabIndex = 5;
            // 
            // ucProducts7
            // 
            this.ucProducts7.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts7.Location = new System.Drawing.Point(439, 329);
            this.ucProducts7.Name = "ucProducts7";
            this.ucProducts7.Size = new System.Drawing.Size(212, 320);
            this.ucProducts7.TabIndex = 6;
            // 
            // ucProducts8
            // 
            this.ucProducts8.BackColor = System.Drawing.Color.LightGray;
            this.ucProducts8.Location = new System.Drawing.Point(657, 329);
            this.ucProducts8.Name = "ucProducts8";
            this.ucProducts8.Size = new System.Drawing.Size(212, 320);
            this.ucProducts8.TabIndex = 7;
            // 
            // FMyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMyProduct";
            this.Text = "FMyProduct";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CustomButton.VBButton btnUpdate;
        private CustomButton.VBButton btnRemove;
        private CustomButton.VBButton btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCProducts ucProducts1;
        private UCProducts ucProducts2;
        private UCProducts ucProducts3;
        private UCProducts ucProducts4;
        private UCProducts ucProducts5;
        private UCProducts ucProducts6;
        private UCProducts ucProducts7;
        private UCProducts ucProducts8;
    }
}