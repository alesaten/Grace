
namespace GraceApp
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.Supplies_button = new System.Windows.Forms.Button();
            this.LogInHistiry_button = new System.Windows.Forms.Button();
            this.FormReport_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Timer_label);
            this.panel1.Controls.Add(this.LogOut_button);
            this.panel1.Controls.Add(this.Supplies_button);
            this.panel1.Controls.Add(this.LogInHistiry_button);
            this.panel1.Controls.Add(this.FormReport_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 347);
            this.panel1.TabIndex = 0;
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
            // Supplies_button
            // 
            this.Supplies_button.Location = new System.Drawing.Point(3, 105);
            this.Supplies_button.Name = "Supplies_button";
            this.Supplies_button.Size = new System.Drawing.Size(177, 45);
            this.Supplies_button.TabIndex = 2;
            this.Supplies_button.Text = "Расходные материалы";
            this.Supplies_button.UseVisualStyleBackColor = true;
            // 
            // LogInHistiry_button
            // 
            this.LogInHistiry_button.Location = new System.Drawing.Point(3, 54);
            this.LogInHistiry_button.Name = "LogInHistiry_button";
            this.LogInHistiry_button.Size = new System.Drawing.Size(177, 45);
            this.LogInHistiry_button.TabIndex = 1;
            this.LogInHistiry_button.Text = "История входа";
            this.LogInHistiry_button.UseVisualStyleBackColor = true;
            // 
            // FormReport_button
            // 
            this.FormReport_button.Location = new System.Drawing.Point(3, 3);
            this.FormReport_button.Name = "FormReport_button";
            this.FormReport_button.Size = new System.Drawing.Size(177, 45);
            this.FormReport_button.TabIndex = 0;
            this.FormReport_button.Text = "Сформировать отчёт";
            this.FormReport_button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(203, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 347);
            this.panel2.TabIndex = 1;
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
            this.Timer_label.TabIndex = 3;
            this.Timer_label.Text = "Сеанс начался.";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorForm";
            this.Text = "Администратор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Supplies_button;
        private System.Windows.Forms.Button LogInHistiry_button;
        private System.Windows.Forms.Button FormReport_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Timer_label;
    }
}