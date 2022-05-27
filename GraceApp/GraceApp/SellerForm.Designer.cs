
namespace GraceApp
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.FormOrder_button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(203, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 347);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Timer_label);
            this.panel1.Controls.Add(this.LogOut_button);
            this.panel1.Controls.Add(this.FormOrder_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 347);
            this.panel1.TabIndex = 1;
            // 
            // LogOut_button
            // 
            this.LogOut_button.Location = new System.Drawing.Point(3, 297);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(177, 45);
            this.LogOut_button.TabIndex = 0;
            this.LogOut_button.Text = "Выход";
            this.LogOut_button.UseVisualStyleBackColor = true;
            this.LogOut_button.Click += new System.EventHandler(this.LogOut_button_Click);
            // 
            // FormOrder_button
            // 
            this.FormOrder_button.Location = new System.Drawing.Point(3, 3);
            this.FormOrder_button.Name = "FormOrder_button";
            this.FormOrder_button.Size = new System.Drawing.Size(177, 45);
            this.FormOrder_button.TabIndex = 0;
            this.FormOrder_button.Text = "Сформировать заказ";
            this.FormOrder_button.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Timer_label
            // 
            this.Timer_label.AutoSize = true;
            this.Timer_label.Location = new System.Drawing.Point(3, 281);
            this.Timer_label.Name = "Timer_label";
            this.Timer_label.Size = new System.Drawing.Size(85, 13);
            this.Timer_label.TabIndex = 4;
            this.Timer_label.Text = "Сеанс начался.";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Button FormOrder_button;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Timer_label;
    }
}