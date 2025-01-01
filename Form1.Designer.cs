namespace WinFormsApp1
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            label3 = new Label();
            radioButton17 = new RadioButton();
            radioButton16 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton44 = new RadioButton();
            radioButton43 = new RadioButton();
            radioButton42 = new RadioButton();
            radioButton41 = new RadioButton();
            radioButton40 = new RadioButton();
            radioButton39 = new RadioButton();
            radioButton38 = new RadioButton();
            radioButton37 = new RadioButton();
            radioButton36 = new RadioButton();
            radioButton35 = new RadioButton();
            radioButton34 = new RadioButton();
            radioButton33 = new RadioButton();
            radioButton32 = new RadioButton();
            radioButton31 = new RadioButton();
            radioButton30 = new RadioButton();
            radioButton29 = new RadioButton();
            radioButton28 = new RadioButton();
            radioButton27 = new RadioButton();
            radioButton26 = new RadioButton();
            radioButton25 = new RadioButton();
            radioButton24 = new RadioButton();
            radioButton23 = new RadioButton();
            radioButton22 = new RadioButton();
            radioButton21 = new RadioButton();
            radioButton20 = new RadioButton();
            radioButton19 = new RadioButton();
            radioButton18 = new RadioButton();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(211, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "単相3線式(電灯 100V)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(223, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(211, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "三相3線式(動力 200V)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 70);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "電源方式";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 30);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(131, 29);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "1.6mm, 2sq";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(143, 30);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(145, 29);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "2.0mm, 3.5sq";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(radioButton17);
            groupBox2.Controls.Add(radioButton16);
            groupBox2.Controls.Add(radioButton15);
            groupBox2.Controls.Add(radioButton14);
            groupBox2.Controls.Add(radioButton13);
            groupBox2.Controls.Add(radioButton12);
            groupBox2.Controls.Add(radioButton11);
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton9);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(12, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(589, 170);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "電線太さ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // radioButton17
            // 
            radioButton17.AutoSize = true;
            radioButton17.Location = new Point(364, 100);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(86, 29);
            radioButton17.TabIndex = 17;
            radioButton17.TabStop = true;
            radioButton17.Text = "500sq";
            radioButton17.UseVisualStyleBackColor = true;
            radioButton17.CheckedChanged += radioButton17_CheckedChanged;
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(272, 100);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(86, 29);
            radioButton16.TabIndex = 16;
            radioButton16.TabStop = true;
            radioButton16.Text = "400sq";
            radioButton16.UseVisualStyleBackColor = true;
            radioButton16.CheckedChanged += radioButton16_CheckedChanged;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(180, 100);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(86, 29);
            radioButton15.TabIndex = 15;
            radioButton15.TabStop = true;
            radioButton15.Text = "325sq";
            radioButton15.UseVisualStyleBackColor = true;
            radioButton15.CheckedChanged += radioButton15_CheckedChanged;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(88, 100);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(86, 29);
            radioButton14.TabIndex = 14;
            radioButton14.TabStop = true;
            radioButton14.Text = "250sq";
            radioButton14.UseVisualStyleBackColor = true;
            radioButton14.CheckedChanged += radioButton14_CheckedChanged;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(6, 100);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(86, 29);
            radioButton13.TabIndex = 13;
            radioButton13.TabStop = true;
            radioButton13.Text = "200sq";
            radioButton13.UseVisualStyleBackColor = true;
            radioButton13.CheckedChanged += radioButton13_CheckedChanged;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(426, 65);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(86, 29);
            radioButton12.TabIndex = 12;
            radioButton12.TabStop = true;
            radioButton12.Text = "150sq";
            radioButton12.UseVisualStyleBackColor = true;
            radioButton12.CheckedChanged += radioButton12_CheckedChanged;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(334, 65);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(86, 29);
            radioButton11.TabIndex = 11;
            radioButton11.TabStop = true;
            radioButton11.Text = "100sq";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += radioButton11_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(252, 65);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(76, 29);
            radioButton10.TabIndex = 10;
            radioButton10.TabStop = true;
            radioButton10.Text = "60sq";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(170, 65);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(76, 29);
            radioButton9.TabIndex = 9;
            radioButton9.TabStop = true;
            radioButton9.Text = "38sq";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(88, 65);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(76, 29);
            radioButton8.TabIndex = 8;
            radioButton8.TabStop = true;
            radioButton8.Text = "22sq";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 65);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(76, 29);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "14sq";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(445, 30);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(131, 29);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.Text = "3.2mm, 8sq";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(294, 30);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(145, 29);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "2.6mm, 5.5sq";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton44);
            groupBox3.Controls.Add(radioButton43);
            groupBox3.Controls.Add(radioButton42);
            groupBox3.Controls.Add(radioButton41);
            groupBox3.Controls.Add(radioButton40);
            groupBox3.Controls.Add(radioButton39);
            groupBox3.Controls.Add(radioButton38);
            groupBox3.Controls.Add(radioButton37);
            groupBox3.Controls.Add(radioButton36);
            groupBox3.Controls.Add(radioButton35);
            groupBox3.Controls.Add(radioButton34);
            groupBox3.Controls.Add(radioButton33);
            groupBox3.Controls.Add(radioButton32);
            groupBox3.Controls.Add(radioButton31);
            groupBox3.Controls.Add(radioButton30);
            groupBox3.Controls.Add(radioButton29);
            groupBox3.Controls.Add(radioButton28);
            groupBox3.Controls.Add(radioButton27);
            groupBox3.Controls.Add(radioButton26);
            groupBox3.Controls.Add(radioButton25);
            groupBox3.Controls.Add(radioButton24);
            groupBox3.Controls.Add(radioButton23);
            groupBox3.Controls.Add(radioButton22);
            groupBox3.Controls.Add(radioButton21);
            groupBox3.Controls.Add(radioButton20);
            groupBox3.Controls.Add(radioButton19);
            groupBox3.Controls.Add(radioButton18);
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 181);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "ブレーカー容量";
            // 
            // radioButton44
            // 
            radioButton44.AutoSize = true;
            radioButton44.Location = new Point(340, 135);
            radioButton44.Name = "radioButton44";
            radioButton44.Size = new Size(79, 29);
            radioButton44.TabIndex = 26;
            radioButton44.TabStop = true;
            radioButton44.Text = "800A";
            radioButton44.UseVisualStyleBackColor = true;
            radioButton44.CheckedChanged += radioButton44_CheckedChanged;
            // 
            // radioButton43
            // 
            radioButton43.AutoSize = true;
            radioButton43.Location = new Point(255, 135);
            radioButton43.Name = "radioButton43";
            radioButton43.Size = new Size(79, 29);
            radioButton43.TabIndex = 25;
            radioButton43.TabStop = true;
            radioButton43.Text = "700A";
            radioButton43.UseVisualStyleBackColor = true;
            radioButton43.CheckedChanged += radioButton43_CheckedChanged;
            // 
            // radioButton42
            // 
            radioButton42.AutoSize = true;
            radioButton42.Location = new Point(170, 135);
            radioButton42.Name = "radioButton42";
            radioButton42.Size = new Size(79, 29);
            radioButton42.TabIndex = 24;
            radioButton42.TabStop = true;
            radioButton42.Text = "600A";
            radioButton42.UseVisualStyleBackColor = true;
            radioButton42.CheckedChanged += radioButton42_CheckedChanged;
            // 
            // radioButton41
            // 
            radioButton41.AutoSize = true;
            radioButton41.Location = new Point(85, 135);
            radioButton41.Name = "radioButton41";
            radioButton41.Size = new Size(79, 29);
            radioButton41.TabIndex = 23;
            radioButton41.TabStop = true;
            radioButton41.Text = "500A";
            radioButton41.UseVisualStyleBackColor = true;
            radioButton41.CheckedChanged += radioButton41_CheckedChanged;
            // 
            // radioButton40
            // 
            radioButton40.AutoSize = true;
            radioButton40.Location = new Point(6, 135);
            radioButton40.Name = "radioButton40";
            radioButton40.Size = new Size(79, 29);
            radioButton40.TabIndex = 22;
            radioButton40.TabStop = true;
            radioButton40.Text = "450A";
            radioButton40.UseVisualStyleBackColor = true;
            radioButton40.CheckedChanged += radioButton40_CheckedChanged;
            // 
            // radioButton39
            // 
            radioButton39.AutoSize = true;
            radioButton39.Location = new Point(510, 100);
            radioButton39.Name = "radioButton39";
            radioButton39.Size = new Size(79, 29);
            radioButton39.TabIndex = 21;
            radioButton39.TabStop = true;
            radioButton39.Text = "400A";
            radioButton39.UseVisualStyleBackColor = true;
            radioButton39.CheckedChanged += radioButton39_CheckedChanged;
            // 
            // radioButton38
            // 
            radioButton38.AutoSize = true;
            radioButton38.Location = new Point(425, 100);
            radioButton38.Name = "radioButton38";
            radioButton38.Size = new Size(79, 29);
            radioButton38.TabIndex = 20;
            radioButton38.TabStop = true;
            radioButton38.Text = "350A";
            radioButton38.UseVisualStyleBackColor = true;
            radioButton38.CheckedChanged += radioButton38_CheckedChanged;
            // 
            // radioButton37
            // 
            radioButton37.AutoSize = true;
            radioButton37.Location = new Point(340, 100);
            radioButton37.Name = "radioButton37";
            radioButton37.Size = new Size(79, 29);
            radioButton37.TabIndex = 19;
            radioButton37.TabStop = true;
            radioButton37.Text = "300A";
            radioButton37.UseVisualStyleBackColor = true;
            radioButton37.CheckedChanged += radioButton37_CheckedChanged;
            // 
            // radioButton36
            // 
            radioButton36.AutoSize = true;
            radioButton36.Location = new Point(255, 100);
            radioButton36.Name = "radioButton36";
            radioButton36.Size = new Size(79, 29);
            radioButton36.TabIndex = 18;
            radioButton36.TabStop = true;
            radioButton36.Text = "250A";
            radioButton36.UseVisualStyleBackColor = true;
            radioButton36.CheckedChanged += radioButton36_CheckedChanged;
            // 
            // radioButton35
            // 
            radioButton35.AutoSize = true;
            radioButton35.Location = new Point(170, 100);
            radioButton35.Name = "radioButton35";
            radioButton35.Size = new Size(79, 29);
            radioButton35.TabIndex = 17;
            radioButton35.TabStop = true;
            radioButton35.Text = "225A";
            radioButton35.UseVisualStyleBackColor = true;
            radioButton35.CheckedChanged += radioButton35_CheckedChanged;
            // 
            // radioButton34
            // 
            radioButton34.AutoSize = true;
            radioButton34.Location = new Point(85, 100);
            radioButton34.Name = "radioButton34";
            radioButton34.Size = new Size(79, 29);
            radioButton34.TabIndex = 16;
            radioButton34.TabStop = true;
            radioButton34.Text = "200A";
            radioButton34.UseVisualStyleBackColor = true;
            radioButton34.CheckedChanged += radioButton34_CheckedChanged;
            // 
            // radioButton33
            // 
            radioButton33.AutoSize = true;
            radioButton33.Location = new Point(6, 100);
            radioButton33.Name = "radioButton33";
            radioButton33.Size = new Size(79, 29);
            radioButton33.TabIndex = 15;
            radioButton33.TabStop = true;
            radioButton33.Text = "175A";
            radioButton33.UseVisualStyleBackColor = true;
            radioButton33.CheckedChanged += radioButton33_CheckedChanged;
            // 
            // radioButton32
            // 
            radioButton32.AutoSize = true;
            radioButton32.Location = new Point(476, 65);
            radioButton32.Name = "radioButton32";
            radioButton32.Size = new Size(79, 29);
            radioButton32.TabIndex = 14;
            radioButton32.TabStop = true;
            radioButton32.Text = "150A";
            radioButton32.UseVisualStyleBackColor = true;
            radioButton32.CheckedChanged += radioButton32_CheckedChanged;
            // 
            // radioButton31
            // 
            radioButton31.AutoSize = true;
            radioButton31.Location = new Point(391, 65);
            radioButton31.Name = "radioButton31";
            radioButton31.Size = new Size(79, 29);
            radioButton31.TabIndex = 13;
            radioButton31.TabStop = true;
            radioButton31.Text = "125A";
            radioButton31.UseVisualStyleBackColor = true;
            radioButton31.CheckedChanged += radioButton31_CheckedChanged;
            // 
            // radioButton30
            // 
            radioButton30.AutoSize = true;
            radioButton30.Location = new Point(306, 65);
            radioButton30.Name = "radioButton30";
            radioButton30.Size = new Size(79, 29);
            radioButton30.TabIndex = 12;
            radioButton30.TabStop = true;
            radioButton30.Text = "100A";
            radioButton30.UseVisualStyleBackColor = true;
            radioButton30.CheckedChanged += radioButton30_CheckedChanged;
            // 
            // radioButton29
            // 
            radioButton29.AutoSize = true;
            radioButton29.Location = new Point(231, 65);
            radioButton29.Name = "radioButton29";
            radioButton29.Size = new Size(69, 29);
            radioButton29.TabIndex = 11;
            radioButton29.TabStop = true;
            radioButton29.Text = "75A";
            radioButton29.UseVisualStyleBackColor = true;
            radioButton29.CheckedChanged += radioButton29_CheckedChanged;
            // 
            // radioButton28
            // 
            radioButton28.AutoSize = true;
            radioButton28.Location = new Point(156, 65);
            radioButton28.Name = "radioButton28";
            radioButton28.Size = new Size(69, 29);
            radioButton28.TabIndex = 10;
            radioButton28.TabStop = true;
            radioButton28.Text = "63A";
            radioButton28.UseVisualStyleBackColor = true;
            radioButton28.CheckedChanged += radioButton28_CheckedChanged;
            // 
            // radioButton27
            // 
            radioButton27.AutoSize = true;
            radioButton27.Location = new Point(81, 65);
            radioButton27.Name = "radioButton27";
            radioButton27.Size = new Size(69, 29);
            radioButton27.TabIndex = 9;
            radioButton27.TabStop = true;
            radioButton27.Text = "60A";
            radioButton27.UseVisualStyleBackColor = true;
            radioButton27.CheckedChanged += radioButton27_CheckedChanged;
            // 
            // radioButton26
            // 
            radioButton26.AutoSize = true;
            radioButton26.Location = new Point(6, 65);
            radioButton26.Name = "radioButton26";
            radioButton26.Size = new Size(69, 29);
            radioButton26.TabIndex = 8;
            radioButton26.TabStop = true;
            radioButton26.Text = "50A";
            radioButton26.UseVisualStyleBackColor = true;
            radioButton26.CheckedChanged += radioButton26_CheckedChanged;
            // 
            // radioButton25
            // 
            radioButton25.AutoSize = true;
            radioButton25.Location = new Point(511, 30);
            radioButton25.Name = "radioButton25";
            radioButton25.Size = new Size(69, 29);
            radioButton25.TabIndex = 7;
            radioButton25.TabStop = true;
            radioButton25.Text = "40A";
            radioButton25.UseVisualStyleBackColor = true;
            radioButton25.CheckedChanged += radioButton25_CheckedChanged;
            // 
            // radioButton24
            // 
            radioButton24.AutoSize = true;
            radioButton24.Location = new Point(436, 30);
            radioButton24.Name = "radioButton24";
            radioButton24.Size = new Size(69, 29);
            radioButton24.TabIndex = 6;
            radioButton24.TabStop = true;
            radioButton24.Text = "32A";
            radioButton24.UseVisualStyleBackColor = true;
            radioButton24.CheckedChanged += radioButton24_CheckedChanged;
            // 
            // radioButton23
            // 
            radioButton23.AutoSize = true;
            radioButton23.Location = new Point(361, 30);
            radioButton23.Name = "radioButton23";
            radioButton23.Size = new Size(69, 29);
            radioButton23.TabIndex = 5;
            radioButton23.TabStop = true;
            radioButton23.Text = "30A";
            radioButton23.UseVisualStyleBackColor = true;
            radioButton23.CheckedChanged += radioButton23_CheckedChanged;
            // 
            // radioButton22
            // 
            radioButton22.AutoSize = true;
            radioButton22.Location = new Point(286, 30);
            radioButton22.Name = "radioButton22";
            radioButton22.Size = new Size(69, 29);
            radioButton22.TabIndex = 4;
            radioButton22.TabStop = true;
            radioButton22.Text = "20A";
            radioButton22.UseVisualStyleBackColor = true;
            radioButton22.CheckedChanged += radioButton22_CheckedChanged;
            // 
            // radioButton21
            // 
            radioButton21.AutoSize = true;
            radioButton21.Location = new Point(211, 30);
            radioButton21.Name = "radioButton21";
            radioButton21.Size = new Size(69, 29);
            radioButton21.TabIndex = 3;
            radioButton21.TabStop = true;
            radioButton21.Text = "15A";
            radioButton21.UseVisualStyleBackColor = true;
            radioButton21.CheckedChanged += radioButton21_CheckedChanged;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(136, 30);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(69, 29);
            radioButton20.TabIndex = 2;
            radioButton20.TabStop = true;
            radioButton20.Text = "10A";
            radioButton20.UseVisualStyleBackColor = true;
            radioButton20.CheckedChanged += radioButton20_CheckedChanged;
            // 
            // radioButton19
            // 
            radioButton19.AutoSize = true;
            radioButton19.Location = new Point(71, 30);
            radioButton19.Name = "radioButton19";
            radioButton19.Size = new Size(59, 29);
            radioButton19.TabIndex = 1;
            radioButton19.TabStop = true;
            radioButton19.Text = "5A";
            radioButton19.UseVisualStyleBackColor = true;
            radioButton19.CheckedChanged += radioButton19_CheckedChanged;
            // 
            // radioButton18
            // 
            radioButton18.AutoSize = true;
            radioButton18.Location = new Point(6, 30);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(59, 29);
            radioButton18.TabIndex = 0;
            radioButton18.TabStop = true;
            radioButton18.Text = "3A";
            radioButton18.UseVisualStyleBackColor = true;
            radioButton18.CheckedChanged += radioButton18_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(12, 451);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(589, 148);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "電線長";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 114);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 1;
            label1.Text = "[m]";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 610);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(638, 666);
            MinimumSize = new Size(638, 666);
            Name = "Form1";
            Text = "電圧降下計算";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton17;
        private RadioButton radioButton16;
        private RadioButton radioButton15;
        private RadioButton radioButton14;
        private RadioButton radioButton13;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private GroupBox groupBox3;
        private RadioButton radioButton18;
        private RadioButton radioButton24;
        private RadioButton radioButton23;
        private RadioButton radioButton22;
        private RadioButton radioButton21;
        private RadioButton radioButton20;
        private RadioButton radioButton19;
        private RadioButton radioButton35;
        private RadioButton radioButton34;
        private RadioButton radioButton33;
        private RadioButton radioButton32;
        private RadioButton radioButton31;
        private RadioButton radioButton30;
        private RadioButton radioButton29;
        private RadioButton radioButton28;
        private RadioButton radioButton27;
        private RadioButton radioButton26;
        private RadioButton radioButton25;
        private RadioButton radioButton39;
        private RadioButton radioButton38;
        private RadioButton radioButton37;
        private RadioButton radioButton36;
        private RadioButton radioButton44;
        private RadioButton radioButton43;
        private RadioButton radioButton42;
        private RadioButton radioButton41;
        private RadioButton radioButton40;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}
