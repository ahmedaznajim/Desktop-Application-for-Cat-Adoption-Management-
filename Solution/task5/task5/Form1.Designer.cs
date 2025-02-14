namespace task5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.check = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.RichTextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.personal = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.Agetype = new System.Windows.Forms.ComboBox();
            this.categ = new System.Windows.Forms.ComboBox();
            this.next1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.personal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(787, 48);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(184, 23);
            this.check.TabIndex = 24;
            this.check.Text = "Check Informations";
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.MistyRose;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(725, 83);
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Size = new System.Drawing.Size(302, 368);
            this.view.TabIndex = 22;
            this.view.Text = "       \n                   \n                  Not Submit Order Yet";
            this.view.TextChanged += new System.EventHandler(this.view_TextChanged);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.confirm.Enabled = false;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.confirm.Location = new System.Drawing.Point(840, 457);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(77, 38);
            this.confirm.TabIndex = 21;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // personal
            // 
            this.personal.Controls.Add(this.address);
            this.personal.Controls.Add(this.lname);
            this.personal.Controls.Add(this.phone);
            this.personal.Controls.Add(this.fname);
            this.personal.Controls.Add(this.label7);
            this.personal.Controls.Add(this.label8);
            this.personal.Controls.Add(this.label6);
            this.personal.Controls.Add(this.label5);
            this.personal.Controls.Add(this.next2);
            this.personal.Enabled = false;
            this.personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal.Location = new System.Drawing.Point(0, 437);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(689, 207);
            this.personal.TabIndex = 19;
            this.personal.TabStop = false;
            this.personal.Text = "Personal Details";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(477, 123);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(164, 22);
            this.address.TabIndex = 23;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(477, 59);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(164, 22);
            this.lname.TabIndex = 22;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(181, 119);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(164, 22);
            this.phone.TabIndex = 21;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(181, 55);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(164, 22);
            this.fname.TabIndex = 20;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Last Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone Number  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "First Name :";
            // 
            // next2
            // 
            this.next2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.next2.Enabled = false;
            this.next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.next2.Location = new System.Drawing.Point(327, 163);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(75, 34);
            this.next2.TabIndex = 5;
            this.next2.Text = "Next";
            this.next2.UseVisualStyleBackColor = false;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.Agetype);
            this.groupBox1.Controls.Add(this.categ);
            this.groupBox1.Controls.Add(this.next1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 392);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cat Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 36);
            this.label13.TabIndex = 30;
            this.label13.Text = "Your selection will\r\n     appear here";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nots    :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(484, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Your Cat Choise";
            this.label11.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(480, 88);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(77, 20);
            this.female.TabIndex = 18;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(578, 88);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 20);
            this.male.TabIndex = 17;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(10, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 135);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(66, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Vaccines";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cat Category  :";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(256, 87);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(75, 24);
            this.type.TabIndex = 9;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.Control;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.FormattingEnabled = true;
            this.color.Location = new System.Drawing.Point(480, 44);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(184, 23);
            this.color.TabIndex = 8;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // Agetype
            // 
            this.Agetype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Agetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agetype.FormattingEnabled = true;
            this.Agetype.Items.AddRange(new object[] {
            "Days",
            "Months"});
            this.Agetype.Location = new System.Drawing.Point(162, 87);
            this.Agetype.Name = "Agetype";
            this.Agetype.Size = new System.Drawing.Size(77, 24);
            this.Agetype.TabIndex = 7;
            this.Agetype.SelectedIndexChanged += new System.EventHandler(this.Agetype_SelectedIndexChanged);
            // 
            // categ
            // 
            this.categ.BackColor = System.Drawing.SystemColors.Control;
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.FormattingEnabled = true;
            this.categ.Items.AddRange(new object[] {
            "American Bobtail Cat Bread",
            "Birman Cat Bread",
            "Munchkin "});
            this.categ.Location = new System.Drawing.Point(162, 44);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(169, 23);
            this.categ.TabIndex = 6;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.next1.Enabled = false;
            this.next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.next1.Location = new System.Drawing.Point(327, 351);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 35);
            this.next1.TabIndex = 4;
            this.next1.Text = "Next";
            this.next1.UseVisualStyleBackColor = false;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 650);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(39, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.abouteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 25);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myOrderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // myOrderToolStripMenuItem
            // 
            this.myOrderToolStripMenuItem.Name = "myOrderToolStripMenuItem";
            this.myOrderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.myOrderToolStripMenuItem.Text = "My Order";
            this.myOrderToolStripMenuItem.Click += new System.EventHandler(this.myOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // abouteToolStripMenuItem
            // 
            this.abouteToolStripMenuItem.Name = "abouteToolStripMenuItem";
            this.abouteToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.abouteToolStripMenuItem.Text = "About";
            this.abouteToolStripMenuItem.Click += new System.EventHandler(this.abouteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(811, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Facts About Cats";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(742, 556);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(274, 77);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "A group of cats is called a clowder, a male cat is called a tom, a female cat is " +
    "called a molly or queen while young cats are called kittens.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1052, 679);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.check);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.personal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Adopte Cats";
            this.personal.ResumeLayout(false);
            this.personal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label check;
        private System.Windows.Forms.RichTextBox view;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.GroupBox personal;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.ComboBox Agetype;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

