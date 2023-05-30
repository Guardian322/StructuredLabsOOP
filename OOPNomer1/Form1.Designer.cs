namespace OOPNomer1
{
    partial class ForMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForMain));
            System.Windows.Forms.Button bPlus;
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lblcasino = new System.Windows.Forms.Label();
            this.lblbtc = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.btnOpa = new System.Windows.Forms.Button();
            this.lblStep = new System.Windows.Forms.Label();
            this.chckTxtBox = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pctrSF = new System.Windows.Forms.PictureBox();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.timeWin = new System.Windows.Forms.Label();
            this.lblcords = new System.Windows.Forms.Label();
            this.bMinus = new System.Windows.Forms.Button();
            this.lbCoordX = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbCoordY = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnSF = new System.Windows.Forms.Button();
            this.menuStrpTop = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColr = new System.Windows.Forms.Button();
            this.lblWhPaint = new System.Windows.Forms.Label();
            this.lblPaint = new System.Windows.Forms.Label();
            bPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrSF)).BeginInit();
            this.menuStrpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblcasino
            // 
            this.lblcasino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcasino.Location = new System.Drawing.Point(338, 561);
            this.lblcasino.Name = "lblcasino";
            this.lblcasino.Size = new System.Drawing.Size(171, 23);
            this.lblcasino.TabIndex = 15;
            // 
            // lblbtc
            // 
            this.lblbtc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbtc.AutoSize = true;
            this.lblbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblbtc.ForeColor = System.Drawing.Color.Orange;
            this.lblbtc.Location = new System.Drawing.Point(1235, 34);
            this.lblbtc.Name = "lblbtc";
            this.lblbtc.Size = new System.Drawing.Size(0, 18);
            this.lblbtc.TabIndex = 16;
            // 
            // chkBox
            // 
            this.chkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(12, 52);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(173, 17);
            this.chkBox.TabIndex = 37;
            this.chkBox.Text = "Создать кнопку при нажатии";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // btnOpa
            // 
            this.btnOpa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpa.AutoSize = true;
            this.btnOpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnOpa.Location = new System.Drawing.Point(290, 88);
            this.btnOpa.Name = "btnOpa";
            this.btnOpa.Size = new System.Drawing.Size(140, 55);
            this.btnOpa.TabIndex = 26;
            this.btnOpa.Text = "Опа";
            this.btnOpa.UseVisualStyleBackColor = true;
            this.btnOpa.Click += new System.EventHandler(this.btnOpa_Click);
            this.btnOpa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpa_MouseMove);
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(272, 590);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(0, 13);
            this.lblStep.TabIndex = 43;
            // 
            // chckTxtBox
            // 
            this.chckTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckTxtBox.FormattingEnabled = true;
            this.chckTxtBox.Location = new System.Drawing.Point(965, 140);
            this.chckTxtBox.Name = "chckTxtBox";
            this.chckTxtBox.Size = new System.Drawing.Size(142, 94);
            this.chckTxtBox.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(965, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pctrSF
            // 
            this.pctrSF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrSF.Image = ((System.Drawing.Image)(resources.GetObject("pctrSF.Image")));
            this.pctrSF.Location = new System.Drawing.Point(32, 303);
            this.pctrSF.Name = "pctrSF";
            this.pctrSF.Size = new System.Drawing.Size(274, 220);
            this.pctrSF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrSF.TabIndex = 42;
            this.pctrSF.TabStop = false;
            this.pctrSF.Visible = false;
            // 
            // tbDest
            // 
            this.tbDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDest.Location = new System.Drawing.Point(457, 114);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(100, 20);
            this.tbDest.TabIndex = 27;
            this.tbDest.Click += new System.EventHandler(this.btnOpa_Click);
            this.tbDest.TextChanged += new System.EventHandler(this.tbDest_TextChanged);
            // 
            // tbSource
            // 
            this.tbSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSource.Location = new System.Drawing.Point(457, 88);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(100, 20);
            this.tbSource.TabIndex = 28;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            this.tbSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSource_KeyDown);
            // 
            // tbCode
            // 
            this.tbCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCode.Location = new System.Drawing.Point(457, 140);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Шаг";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(114, 606);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timeWin
            // 
            this.timeWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeWin.AutoSize = true;
            this.timeWin.Location = new System.Drawing.Point(1221, 571);
            this.timeWin.Name = "timeWin";
            this.timeWin.Size = new System.Drawing.Size(0, 13);
            this.timeWin.TabIndex = 40;
            // 
            // bPlus
            // 
            bPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            bPlus.AutoSize = true;
            bPlus.Location = new System.Drawing.Point(216, 606);
            bPlus.Name = "bPlus";
            bPlus.Size = new System.Drawing.Size(32, 23);
            bPlus.TabIndex = 35;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = true;
            bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // lblcords
            // 
            this.lblcords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcords.AutoSize = true;
            this.lblcords.Location = new System.Drawing.Point(1221, 510);
            this.lblcords.Name = "lblcords";
            this.lblcords.Size = new System.Drawing.Size(102, 13);
            this.lblcords.TabIndex = 38;
            this.lblcords.Text = "Координаты мыши";
            // 
            // bMinus
            // 
            this.bMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bMinus.AutoSize = true;
            this.bMinus.Location = new System.Drawing.Point(254, 606);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(29, 23);
            this.bMinus.TabIndex = 34;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // lbCoordX
            // 
            this.lbCoordX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCoordX.AutoSize = true;
            this.lbCoordX.Location = new System.Drawing.Point(1235, 540);
            this.lbCoordX.Name = "lbCoordX";
            this.lbCoordX.Size = new System.Drawing.Size(13, 13);
            this.lbCoordX.TabIndex = 30;
            this.lbCoordX.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(32, 606);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add to Bar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbCoordY
            // 
            this.lbCoordY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCoordY.AutoSize = true;
            this.lbCoordY.Location = new System.Drawing.Point(1286, 540);
            this.lbCoordY.Name = "lbCoordY";
            this.lbCoordY.Size = new System.Drawing.Size(13, 13);
            this.lbCoordY.TabIndex = 31;
            this.lbCoordY.Text = "0";
            // 
            // progBar
            // 
            this.progBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progBar.Location = new System.Drawing.Point(32, 561);
            this.progBar.Maximum = 500;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(300, 23);
            this.progBar.TabIndex = 32;
            // 
            // btnForm
            // 
            this.btnForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForm.AutoSize = true;
            this.btnForm.Location = new System.Drawing.Point(12, 90);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(131, 52);
            this.btnForm.TabIndex = 47;
            this.btnForm.Text = "Открыть форму";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnSF
            // 
            this.btnSF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSF.Location = new System.Drawing.Point(128, 274);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(89, 23);
            this.btnSF.TabIndex = 48;
            this.btnSF.Text = "Показать гиф";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSf_Click);
            // 
            // menuStrpTop
            // 
            this.menuStrpTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сведенияОПрограммеToolStripMenuItem,
            this.конецToolStripMenuItem});
            this.menuStrpTop.Location = new System.Drawing.Point(0, 0);
            this.menuStrpTop.Name = "menuStrpTop";
            this.menuStrpTop.Size = new System.Drawing.Size(1356, 24);
            this.menuStrpTop.TabIndex = 49;
            this.menuStrpTop.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзПрограммыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // сведенияОПрограммеToolStripMenuItem
            // 
            this.сведенияОПрограммеToolStripMenuItem.Name = "сведенияОПрограммеToolStripMenuItem";
            this.сведенияОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.сведенияОПрограммеToolStripMenuItem.Text = "Сведения о программе";
            this.сведенияОПрограммеToolStripMenuItem.Click += new System.EventHandler(this.сведенияОПрограммеToolStripMenuItem_Click);
            // 
            // конецToolStripMenuItem
            // 
            this.конецToolStripMenuItem.Name = "конецToolStripMenuItem";
            this.конецToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.конецToolStripMenuItem.Text = "Конец";
            // 
            // btnColr
            // 
            this.btnColr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColr.AutoSize = true;
            this.btnColr.BackColor = System.Drawing.Color.White;
            this.btnColr.Location = new System.Drawing.Point(290, 178);
            this.btnColr.Name = "btnColr";
            this.btnColr.Size = new System.Drawing.Size(140, 54);
            this.btnColr.TabIndex = 46;
            this.btnColr.Text = "Поменять цвет";
            this.btnColr.UseVisualStyleBackColor = false;
            this.btnColr.Click += new System.EventHandler(this.btnColr_Click);
            // 
            // lblWhPaint
            // 
            this.lblWhPaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhPaint.AutoSize = true;
            this.lblWhPaint.Location = new System.Drawing.Point(12, 158);
            this.lblWhPaint.Name = "lblWhPaint";
            this.lblWhPaint.Size = new System.Drawing.Size(73, 13);
            this.lblWhPaint.TabIndex = 50;
            this.lblWhPaint.Text = "Счётчик paint";
            // 
            // lblPaint
            // 
            this.lblPaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaint.AutoSize = true;
            this.lblPaint.Location = new System.Drawing.Point(13, 188);
            this.lblPaint.Name = "lblPaint";
            this.lblPaint.Size = new System.Drawing.Size(13, 13);
            this.lblPaint.TabIndex = 51;
            this.lblPaint.Text = "0";
            // 
            // ForMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 703);
            this.Controls.Add(this.lblPaint);
            this.Controls.Add(this.lblWhPaint);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.btnColr);
            this.Controls.Add(this.btnOpa);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.chckTxtBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pctrSF);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.timeWin);
            this.Controls.Add(bPlus);
            this.Controls.Add(this.lblcords);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.lbCoordX);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbCoordY);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.lblbtc);
            this.Controls.Add(this.lblcasino);
            this.Controls.Add(this.menuStrpTop);
            this.MainMenuStrip = this.menuStrpTop;
            this.Name = "ForMain";
            this.Text = "Форма Зачёта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ForMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pctrSF)).EndInit();
            this.menuStrpTop.ResumeLayout(false);
            this.menuStrpTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lblcasino;
        private System.Windows.Forms.Label lblbtc;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Button btnOpa;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.CheckedListBox chckTxtBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pctrSF;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label timeWin;
        private System.Windows.Forms.Label lblcords;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Label lbCoordX;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbCoordY;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnSF;
        private System.Windows.Forms.MenuStrip menuStrpTop;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияОПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конецToolStripMenuItem;
        private System.Windows.Forms.Button btnColr;
        private System.Windows.Forms.Label lblWhPaint;
        private System.Windows.Forms.Label lblPaint;
    }
}

