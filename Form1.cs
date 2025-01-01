


namespace WinFormsApp1
{



    public partial class Form1 : Form
    {
        protected System.Double k1 = 0; // �d���A���͂��ƂɈقȂ�萔.
        protected System.Double a = 0; // �d������[sq, mm^2].
        protected System.Double i = 0; // �u���[�J�[�e��[A].
        protected System.Double l = 0; // �d����[m].
        protected System.Double vd = 0; // �d���~��[V].
        protected System.Double vdr = 0; // �d���~����[%].
        protected System.Double vs = 0; // �d���d��[V].
        protected bool oc = false; // ���e�d������.


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // �P��3����(�d��)
            if (radioButton1.Checked)
            {
                k1 = 0.0178; // �P��3����. 
                vs = 100; // 100V
            }

            updateResult();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // �O��3����(����)
            if (radioButton2.Checked)
            {
                k1 = 0.0308; // �O��3����
                vs = 200; // 200V
            }

            updateResult();
        }

        protected void updateResult()
        {
            label2.Visible = false;
            label2.Text = "";
            label2.ForeColor = Color.Black;

            if (k1 == 0)
            {
                label2.Visible = true;
                label2.Text = "�G���[:�d��������I�����ĉ������B";
                label2.ForeColor = Color.Red;

                return;
            }

            if (a == 0)
            {
                label2.Visible = true;
                label2.Text = "�G���[:�d���̑�����I�����ĉ������B";
                label2.ForeColor = Color.Red;

                return;
            }

            if (i == 0)
            {
                label2.Visible = true;
                label2.Text = "�G���[:�u���[�J�[�e�ʂ�I�����ĉ������B";
                label2.ForeColor = Color.Red;

                return;
            }

            if (l == 0)
            {
                label2.Visible = true;
                label2.Text = "�G���[:�d��������͂��ĉ������B";
                label2.ForeColor = Color.Red;

                return;
            }

            // ���e�d�����ߌx��.
            if(oc == true) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

            // �d���~���v�Z.
            vd = k1 * i * l / a;
            vdr = vd * 100 / vs;

            // ���ʕ\��.
            label2.Visible = true;
            label2.ForeColor = Color.Black;
            
            label2.Text = "�d���~���́A" + vd.ToString("F3") + "[V]�ł��B";

            // �L���[�r�N��.
            label4.Visible = true;
            label4.Text = "�L���[�r�N������̒ሳ��d: �~";

            if (l <= 120 && vdr <= 5)
            {
                label4.Text = "�L���[�r�N������̒ሳ��d: �Z";
            }
            
            if(l <= 200 && vdr <= 6)
            {
                label4.Text = "�L���[�r�N������̒ሳ��d: �Z";
            }

            if (l > 200 && vdr <= 7)
            {
                label4.Text = "�L���[�r�N������̒ሳ��d: �Z";
            }

            // �d�͉�Ђ���̒ሳ��d.
            label5.Visible = true;
            label5.Text = "�d�͉�Ђ���̒ሳ��d: �~";

            if (l <= 120 && vdr <= 4)
            {
                label5.Text = "�d�͉�Ђ���̒ሳ��d: �Z";
            }

            if (l <= 200 && vdr <= 5)
            {
                label5.Text = "�d�͉�Ђ���̒ሳ��d: �Z";
            }

            if (l > 200 && vdr <= 6)
            {
                label5.Text = "�d�͉�Ђ���̒ሳ��d: �Z";
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // 2sq.
                a = 2;

                label3.Visible = true;
                if(i > 18.9) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A18.9A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                // 3.5sq.
                a = 3.5;
                label3.Visible = true;
                if (i > 25.9) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A25.9A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                // 5.5sq.
                a = 5.5;
                label3.Visible = true;
                if (i > 34.3) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A34.3A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                // 8sq.
                a = 8;
                label3.Visible = true;
                if (i > 42.7) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A42.7A�ł��B(�d�������W��0.7�Ƃ���)";
                
                updateResult();
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                // 14sq.
                a = 14;
                label3.Visible = true;
                if (i > 61.6) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A61.6A�ł��B(�d�������W��0.7�Ƃ���)";
                updateResult();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                // 22sq.
                a = 22;
                label3.Visible = true;
                if (i > 80.5) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A80.5A�ł��B(�d�������W��0.7�Ƃ���)";
                updateResult();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                // 38sq.
                a = 38;
                label3.Visible = true;
                if (i > 113.4) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A113.4A�ł��B(�d�������W��0.7�Ƃ���)";
                updateResult();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                // 60sq.
                a = 60;
                label3.Visible = true;
                if (i > 151.9) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A151.9A�ł��B(�d�������W��0.7�Ƃ���)";
                updateResult();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                // 100sq.
                a = 100;
                label3.Visible = true;
                if (i > 208.6) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A208.6A�ł��B(�d�������W��0.7�Ƃ���)";
                updateResult();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                // 150sq.
                a = 150;
                label3.Visible = true;
                if (i > 276.5) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A276.5A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                // 200sq.
                a = 200;
                label3.Visible = true;
                if (i > 328.3) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A328.3A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                // 250sq.
                a = 250;
                label3.Visible = true;
                if (i > 389.2) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A389.2A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                // 325sq.
                a = 325;
                label3.Visible = true;
                if (i > 455.0) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A455.0A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                // 400sq.
                a = 400;
                label3.Visible = true;
                if (i > 521.5) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A521.5A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                // 500sq.
                a = 500;
                label3.Visible = true;
                if (i > 589.4) { oc = true; } else { oc = false; }
                label3.Text = "�����e�d���́A589.4A�ł��B(�d�������W��0.7�Ƃ���)";

                updateResult();
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                // �u���[�J�[�e��:3A
                i = 3;

                updateResult();
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                // �u���[�J�[�e��:5A
                i = 5;

                updateResult();
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                // �u���[�J�[�e��:10A
                i = 10;

                updateResult();
            }

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                // �u���[�J�[�e��:15A
                i = 15;

                updateResult();
            }

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                // �u���[�J�[�e��:20A
                i = 20;
                if (a < 3.5) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

                updateResult();
            }

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                // �u���[�J�[�e��:30A
                i = 30;
                if (a < 3.5) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

                updateResult();

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                // �u���[�J�[�e��:32A
                i = 32;

                updateResult();

            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                // �u���[�J�[�e��:40A
                i = 40;

                updateResult();

            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                // �u���[�J�[�e��:50A
                i = 50;

                updateResult();

            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                // �u���[�J�[�e��:60A
                i = 60;

                updateResult();

            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                // �u���[�J�[�e��:63A
                i = 63;

                updateResult();

            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
            {
                // �u���[�J�[�e��:75A
                i = 75;

                updateResult();

            }
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked)
            {
                // �u���[�J�[�e��:100A
                i = 100;

                updateResult();

            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                // �u���[�J�[�e��:125A
                i = 125;

                updateResult();

            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                // �u���[�J�[�e��:150A
                i = 150;

                updateResult();

            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                // �u���[�J�[�e��:175A
                i = 175;

                updateResult();

            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked)
            {
                // �u���[�J�[�e��:200A
                i = 200;

                updateResult();

            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
            {
                // �u���[�J�[�e��:225A
                i = 225;

                updateResult();

            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                // �u���[�J�[�e��:250A
                i = 250;

                updateResult();
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked)
            {
                // �u���[�J�[�e��:300A
                i = 300;

                updateResult();

            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked)
            {
                // �u���[�J�[�e��:350A
                i = 350;

                updateResult();

            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                {
                    // �u���[�J�[�e��:400A
                    i = 400;

                    updateResult();
                }
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton40.Checked)
            {
                {
                    // �u���[�J�[�e��:450A
                    i = 450;

                    updateResult();
                }

            }
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton41.Checked)
            {
                // �u���[�J�[�e��:500A
                i = 500;

                updateResult();
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked)
            {
                // �u���[�J�[�e��:600A
                i = 600;

                updateResult();
            }
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton43.Checked)
            {
                // �u���[�J�[�e��:700A
                i = 700;

                updateResult();
            }
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton44.Checked)
            {
                // �u���[�J�[�e��:700A
                i = 700;

                updateResult();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l = System.Double.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                l = 0;
            }

            if(l < 0)
            {
                l = 0;
            }

            updateResult();
        }
    }
}
