namespace Cau1._14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BTN_Exit = new Button();
            BTN_Create = new Button();
            BTN_Update = new Button();
            comboBox_class = new ComboBox();
            brithday = new DateTimePicker();
            txt_address = new TextBox();
            txt_name = new TextBox();
            txt_ma = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTN_Exit);
            groupBox1.Controls.Add(BTN_Create);
            groupBox1.Controls.Add(BTN_Update);
            groupBox1.Controls.Add(comboBox_class);
            groupBox1.Controls.Add(brithday);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_ma);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(246, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin sinh vien";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BTN_Exit
            // 
            BTN_Exit.ForeColor = SystemColors.Desktop;
            BTN_Exit.Location = new Point(180, 250);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(75, 23);
            BTN_Exit.TabIndex = 12;
            BTN_Exit.Text = "Thoát";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // BTN_Create
            // 
            BTN_Create.ForeColor = SystemColors.Desktop;
            BTN_Create.Location = new Point(99, 250);
            BTN_Create.Name = "BTN_Create";
            BTN_Create.Size = new Size(75, 23);
            BTN_Create.TabIndex = 11;
            BTN_Create.Text = "Tạo mới";
            BTN_Create.UseVisualStyleBackColor = true;
            BTN_Create.Click += BTN_Create_Click;
            // 
            // BTN_Update
            // 
            BTN_Update.ForeColor = SystemColors.Desktop;
            BTN_Update.Location = new Point(18, 250);
            BTN_Update.Name = "BTN_Update";
            BTN_Update.Size = new Size(75, 23);
            BTN_Update.TabIndex = 10;
            BTN_Update.Text = "Cập nhật";
            BTN_Update.UseVisualStyleBackColor = true;
            BTN_Update.Click += BTN_Update_Click;
            // 
            // comboBox_class
            // 
            comboBox_class.FormattingEnabled = true;
            comboBox_class.Location = new Point(89, 180);
            comboBox_class.Name = "comboBox_class";
            comboBox_class.Size = new Size(132, 23);
            comboBox_class.TabIndex = 9;
            // 
            // brithday
            // 
            brithday.CustomFormat = "dd/MM/yyyy";
            brithday.Format = DateTimePickerFormat.Custom;
            brithday.Location = new Point(89, 143);
            brithday.Name = "brithday";
            brithday.Size = new Size(132, 23);
            brithday.TabIndex = 8;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(89, 106);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(132, 23);
            txt_address.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(89, 69);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(132, 23);
            txt_name.TabIndex = 6;
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(89, 34);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(132, 23);
            txt_ma.TabIndex = 5;
            txt_ma.KeyPress += txt_ma_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(6, 183);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(6, 149);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 24);
            listBox.Name = "listBox";
            listBox.Size = new Size(228, 304);
            listBox.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 347);
            Controls.Add(listBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minh hoa TreeView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button BTN_Exit;
        private Button BTN_Create;
        private Button BTN_Update;
        private ComboBox comboBox_class;
        private DateTimePicker brithday;
        private TextBox txt_address;
        private TextBox txt_name;
        private TextBox txt_ma;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBox;
    }
}