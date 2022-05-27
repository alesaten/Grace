
namespace GraceApp
{
    partial class LogIn_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Log_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Exit_button = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.HideShowPassword_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(79, 53);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(100, 20);
            this.Login_textBox.TabIndex = 0;
            this.Login_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Login_textBox_Validating);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(79, 97);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(100, 20);
            this.Password_textBox.TabIndex = 1;
            this.Password_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Password_textBox_Validating);
            // 
            // Log_label
            // 
            this.Log_label.AutoSize = true;
            this.Log_label.Location = new System.Drawing.Point(76, 37);
            this.Log_label.Name = "Log_label";
            this.Log_label.Size = new System.Drawing.Size(84, 13);
            this.Log_label.TabIndex = 2;
            this.Log_label.Text = "Введите логин:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(76, 81);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(91, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Введите пароль:";
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(79, 136);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(100, 23);
            this.LogIn_button.TabIndex = 4;
            this.LogIn_button.Text = "Войти";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(79, 165);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(100, 23);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "eye-45.png");
            // 
            // HideShowPassword_button
            // 
            this.HideShowPassword_button.ImageIndex = 0;
            this.HideShowPassword_button.ImageList = this.imageList;
            this.HideShowPassword_button.Location = new System.Drawing.Point(185, 97);
            this.HideShowPassword_button.Name = "HideShowPassword_button";
            this.HideShowPassword_button.Size = new System.Drawing.Size(23, 20);
            this.HideShowPassword_button.TabIndex = 6;
            this.HideShowPassword_button.UseVisualStyleBackColor = true;
            this.HideShowPassword_button.Click += new System.EventHandler(this.HideShowPassword_button_Click);
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 227);
            this.Controls.Add(this.HideShowPassword_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Log_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn_Form";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Log_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button HideShowPassword_button;
    }
}

