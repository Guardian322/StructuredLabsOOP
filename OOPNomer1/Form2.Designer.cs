namespace OOPNomer1
{
    partial class Form2
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
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.btnColr = new System.Windows.Forms.Button();
            this.btnBlink = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkBox
            // 
            this.chkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(12, 12);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(173, 17);
            this.chkBox.TabIndex = 38;
            this.chkBox.Text = "Создать кнопку при нажатии";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // btnColr
            // 
            this.btnColr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColr.BackColor = System.Drawing.Color.White;
            this.btnColr.Location = new System.Drawing.Point(263, 12);
            this.btnColr.Name = "btnColr";
            this.btnColr.Size = new System.Drawing.Size(140, 54);
            this.btnColr.TabIndex = 47;
            this.btnColr.Text = "Поменять цвет";
            this.btnColr.UseVisualStyleBackColor = false;
            this.btnColr.Click += new System.EventHandler(this.btnColr_Click);
            // 
            // btnBlink
            // 
            this.btnBlink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBlink.Location = new System.Drawing.Point(657, 13);
            this.btnBlink.Name = "btnBlink";
            this.btnBlink.Size = new System.Drawing.Size(119, 53);
            this.btnBlink.TabIndex = 48;
            this.btnBlink.Text = "Blink";
            this.btnBlink.UseVisualStyleBackColor = true;
            this.btnBlink.Click += new System.EventHandler(this.btnBlink_Click);
            // 
            // lblKey
            // 
            this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblKey.Location = new System.Drawing.Point(38, 120);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(109, 90);
            this.lblKey.TabIndex = 50;
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerText
            // 
            this.timerText.Interval = 400;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpty.AutoSize = true;
            this.btnEmpty.Location = new System.Drawing.Point(435, 12);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(130, 54);
            this.btnEmpty.TabIndex = 51;
            this.btnEmpty.Text = "Бездарная Кнопка";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(872, 13);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(70, 13);
            this.lblSize.TabIndex = 52;
            this.lblSize.Text = "Счётчик Size";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 655);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnBlink);
            this.Controls.Add(this.btnColr);
            this.Controls.Add(this.chkBox);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Button btnColr;
        private System.Windows.Forms.Button btnBlink;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Label lblSize;
    }
}