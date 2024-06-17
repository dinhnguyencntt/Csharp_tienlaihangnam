namespace Csharp_tienlaihangnam
{
    partial class Form1
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
            this.lbksotien = new System.Windows.Forms.Label();
            this.lbllaisuat = new System.Windows.Forms.Label();
            this.lblsonamgui = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.lsbkq = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.txtsonamgui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbksotien
            // 
            this.lbksotien.AutoSize = true;
            this.lbksotien.Location = new System.Drawing.Point(175, 66);
            this.lbksotien.Name = "lbksotien";
            this.lbksotien.Size = new System.Drawing.Size(50, 13);
            this.lbksotien.TabIndex = 0;
            this.lbksotien.Text = "SỐ TIỀN";
            // 
            // lbllaisuat
            // 
            this.lbllaisuat.AutoSize = true;
            this.lbllaisuat.Location = new System.Drawing.Point(164, 122);
            this.lbllaisuat.Name = "lbllaisuat";
            this.lbllaisuat.Size = new System.Drawing.Size(55, 13);
            this.lbllaisuat.TabIndex = 1;
            this.lbllaisuat.Text = "LÃI SUẤT";
            // 
            // lblsonamgui
            // 
            this.lblsonamgui.AutoSize = true;
            this.lblsonamgui.Location = new System.Drawing.Point(148, 183);
            this.lblsonamgui.Name = "lblsonamgui";
            this.lblsonamgui.Size = new System.Drawing.Size(71, 13);
            this.lblsonamgui.TabIndex = 2;
            this.lblsonamgui.Text = "SỐ NĂM GỬI";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(286, 58);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(137, 20);
            this.txtsotien.TabIndex = 3;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(148, 281);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(54, 13);
            this.lblkq.TabIndex = 6;
            this.lblkq.Text = "KẾT QUẢ";
            // 
            // lsbkq
            // 
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.Location = new System.Drawing.Point(224, 267);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(418, 121);
            this.lsbkq.TabIndex = 7;
            this.lsbkq.SelectedIndexChanged += new System.EventHandler(this.lsbkq_SelectedIndexChanged);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(595, 152);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 8;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(286, 115);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(137, 20);
            this.txtlaisuat.TabIndex = 9;
            // 
            // txtsonamgui
            // 
            this.txtsonamgui.Location = new System.Drawing.Point(286, 183);
            this.txtsonamgui.Name = "txtsonamgui";
            this.txtsonamgui.Size = new System.Drawing.Size(137, 20);
            this.txtsonamgui.TabIndex = 10;
            this.txtsonamgui.TextChanged += new System.EventHandler(this.txtsonamgui_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsonamgui);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.lblsonamgui);
            this.Controls.Add(this.lbllaisuat);
            this.Controls.Add(this.lbksotien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbksotien;
        private System.Windows.Forms.Label lbllaisuat;
        private System.Windows.Forms.Label lblsonamgui;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.ListBox lsbkq;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.TextBox txtsonamgui;
    }
}

