namespace WFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btngroupselect = new System.Windows.Forms.Button();
            this.lbgroupnum = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lBnumberlist = new System.Windows.Forms.ListBox();
            this.lbnum7 = new System.Windows.Forms.Label();
            this.lbnum6 = new System.Windows.Forms.Label();
            this.lbnum5 = new System.Windows.Forms.Label();
            this.lbnum4 = new System.Windows.Forms.Label();
            this.lbnum3 = new System.Windows.Forms.Label();
            this.lbnum2 = new System.Windows.Forms.Label();
            this.lbnum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.Btnclose = new System.Windows.Forms.Button();
            this.Randomtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnstart);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnwrite);
            this.panel1.Controls.Add(this.btnselect);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btngroupselect);
            this.panel1.Controls.Add(this.lbgroupnum);
            this.panel1.Controls.Add(this.tb6);
            this.panel1.Controls.Add(this.tb5);
            this.panel1.Controls.Add(this.tb3);
            this.panel1.Controls.Add(this.tb4);
            this.panel1.Controls.Add(this.tb2);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Controls.Add(this.tb7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lBnumberlist);
            this.panel1.Controls.Add(this.lbnum7);
            this.panel1.Controls.Add(this.lbnum6);
            this.panel1.Controls.Add(this.lbnum5);
            this.panel1.Controls.Add(this.lbnum4);
            this.panel1.Controls.Add(this.lbnum3);
            this.panel1.Controls.Add(this.lbnum2);
            this.panel1.Controls.Add(this.lbnum1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 399);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.Location = new System.Drawing.Point(514, 272);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(87, 86);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "打印彩票";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstart.Location = new System.Drawing.Point(418, 272);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(87, 34);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "确认选号";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(418, 324);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(87, 34);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "清空选号";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnwrite.Location = new System.Drawing.Point(517, 216);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(87, 34);
            this.btnwrite.TabIndex = 5;
            this.btnwrite.Text = "手写号码";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnselect.Location = new System.Drawing.Point(325, 271);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(87, 34);
            this.btnselect.TabIndex = 5;
            this.btnselect.Text = "随机选号";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.Location = new System.Drawing.Point(325, 323);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(87, 34);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "删除选号";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btngroupselect
            // 
            this.btngroupselect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btngroupselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngroupselect.Location = new System.Drawing.Point(424, 215);
            this.btngroupselect.Name = "btngroupselect";
            this.btngroupselect.Size = new System.Drawing.Size(87, 34);
            this.btngroupselect.TabIndex = 5;
            this.btngroupselect.Text = "随机组选";
            this.btngroupselect.UseVisualStyleBackColor = true;
            this.btngroupselect.Click += new System.EventHandler(this.btngroupselect_Click);
            // 
            // lbgroupnum
            // 
            this.lbgroupnum.BackColor = System.Drawing.Color.White;
            this.lbgroupnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbgroupnum.ForeColor = System.Drawing.Color.Black;
            this.lbgroupnum.Location = new System.Drawing.Point(311, 216);
            this.lbgroupnum.Name = "lbgroupnum";
            this.lbgroupnum.Size = new System.Drawing.Size(54, 32);
            this.lbgroupnum.TabIndex = 4;
            this.lbgroupnum.Text = "组个数";
            this.lbgroupnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb6
            // 
            this.tb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb6.Location = new System.Drawing.Point(510, 164);
            this.tb6.Multiline = true;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(31, 35);
            this.tb6.TabIndex = 3;
            this.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb5
            // 
            this.tb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb5.Location = new System.Drawing.Point(473, 164);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(31, 35);
            this.tb5.TabIndex = 3;
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb3.Location = new System.Drawing.Point(399, 164);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(31, 35);
            this.tb3.TabIndex = 3;
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb4
            // 
            this.tb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb4.Location = new System.Drawing.Point(436, 164);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(31, 35);
            this.tb4.TabIndex = 3;
            this.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb2.Location = new System.Drawing.Point(362, 164);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(31, 35);
            this.tb2.TabIndex = 3;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb1.Location = new System.Drawing.Point(325, 164);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(31, 35);
            this.tb1.TabIndex = 3;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb7
            // 
            this.tb7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tb7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb7.ForeColor = System.Drawing.Color.White;
            this.tb7.Location = new System.Drawing.Point(560, 164);
            this.tb7.Multiline = true;
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(31, 35);
            this.tb7.TabIndex = 3;
            this.tb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(379, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBnumberlist
            // 
            this.lBnumberlist.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lBnumberlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lBnumberlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lBnumberlist.FormattingEnabled = true;
            this.lBnumberlist.ItemHeight = 27;
            this.lBnumberlist.Location = new System.Drawing.Point(33, 164);
            this.lBnumberlist.Name = "lBnumberlist";
            this.lBnumberlist.Size = new System.Drawing.Size(272, 193);
            this.lBnumberlist.TabIndex = 2;
            // 
            // lbnum7
            // 
            this.lbnum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbnum7.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnum7.Location = new System.Drawing.Point(529, 84);
            this.lbnum7.Name = "lbnum7";
            this.lbnum7.Size = new System.Drawing.Size(43, 47);
            this.lbnum7.TabIndex = 0;
            this.lbnum7.Text = "0";
            this.lbnum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum6
            // 
            this.lbnum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum6.Location = new System.Drawing.Point(449, 84);
            this.lbnum6.Name = "lbnum6";
            this.lbnum6.Size = new System.Drawing.Size(43, 47);
            this.lbnum6.TabIndex = 0;
            this.lbnum6.Text = "0";
            this.lbnum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum5
            // 
            this.lbnum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum5.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum5.Location = new System.Drawing.Point(369, 84);
            this.lbnum5.Name = "lbnum5";
            this.lbnum5.Size = new System.Drawing.Size(43, 47);
            this.lbnum5.TabIndex = 0;
            this.lbnum5.Text = "0";
            this.lbnum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum4
            // 
            this.lbnum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum4.Location = new System.Drawing.Point(289, 84);
            this.lbnum4.Name = "lbnum4";
            this.lbnum4.Size = new System.Drawing.Size(43, 47);
            this.lbnum4.TabIndex = 0;
            this.lbnum4.Text = "0";
            this.lbnum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum3
            // 
            this.lbnum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum3.Location = new System.Drawing.Point(209, 84);
            this.lbnum3.Name = "lbnum3";
            this.lbnum3.Size = new System.Drawing.Size(43, 47);
            this.lbnum3.TabIndex = 0;
            this.lbnum3.Text = "0";
            this.lbnum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum2
            // 
            this.lbnum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum2.Location = new System.Drawing.Point(129, 84);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(43, 47);
            this.lbnum2.TabIndex = 0;
            this.lbnum2.Text = "0";
            this.lbnum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum1
            // 
            this.lbnum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbnum1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnum1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnum1.Location = new System.Drawing.Point(49, 84);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(43, 47);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.Text = "0";
            this.lbnum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "6+1体育彩票选号器";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.BtnMax);
            this.panel2.Controls.Add(this.Btnclose);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 48);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "来玩呀，大爷";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.Location = new System.Drawing.Point(512, 7);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(36, 30);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.Text = "＿";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.ForeColor = System.Drawing.Color.White;
            this.BtnMax.Location = new System.Drawing.Point(554, 7);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(36, 30);
            this.BtnMax.TabIndex = 0;
            this.BtnMax.Text = "□";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // Btnclose
            // 
            this.Btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnclose.ForeColor = System.Drawing.Color.White;
            this.Btnclose.Location = new System.Drawing.Point(596, 7);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(36, 30);
            this.Btnclose.TabIndex = 0;
            this.Btnclose.Text = "×";
            this.Btnclose.UseVisualStyleBackColor = true;
            this.Btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Randomtimer
            // 
            this.Randomtimer.Interval = 50;
            this.Randomtimer.Tick += new System.EventHandler(this.Randomtimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(649, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6+1体育彩票选号器";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button Btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btngroupselect;
        private System.Windows.Forms.Label lbgroupnum;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lBnumberlist;
        private System.Windows.Forms.Label lbnum7;
        private System.Windows.Forms.Label lbnum6;
        private System.Windows.Forms.Label lbnum5;
        private System.Windows.Forms.Label lbnum4;
        private System.Windows.Forms.Label lbnum3;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Timer Randomtimer;
    }
}

