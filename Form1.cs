


namespace WinFormsApp1
{



    public partial class Form1 : Form
    {
        protected System.Double k1 = 0; // 電灯、動力ごとに異なる定数.
        protected System.Double a = 0; // 電線太さ[sq, mm^2].
        protected System.Double i = 0; // ブレーカー容量[A].
        protected System.Double l = 0; // 電線長[m].
        protected System.Double vd = 0; // 電圧降下[V].
        protected System.Double vdr = 0; // 電圧降下率[%].
        protected System.Double vs = 0; // 電源電圧[V].
        protected bool oc = false; // 許容電流超過.


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
            // 単相3線式(電灯)
            if (radioButton1.Checked)
            {
                k1 = 0.0178; // 単相3線式. 
                vs = 100; // 100V
            }

            updateResult();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // 三相3線式(動力)
            if (radioButton2.Checked)
            {
                k1 = 0.0308; // 三相3線式
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
                label2.Text = "エラー:電源方式を選択して下さい。";
                label2.ForeColor = Color.Red;

                return;
            }

            if (a == 0)
            {
                label2.Visible = true;
                label2.Text = "エラー:電線の太さを選択して下さい。";
                label2.ForeColor = Color.Red;

                return;
            }

            if (i == 0)
            {
                label2.Visible = true;
                label2.Text = "エラー:ブレーカー容量を選択して下さい。";
                label2.ForeColor = Color.Red;

                return;
            }

            if (l == 0)
            {
                label2.Visible = true;
                label2.Text = "エラー:電線長を入力して下さい。";
                label2.ForeColor = Color.Red;

                return;
            }

            // 許容電流超過警告.
            if(oc == true) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

            // 電圧降下計算.
            vd = k1 * i * l / a;
            vdr = vd * 100 / vs;

            // 結果表示.
            label2.Visible = true;
            label2.ForeColor = Color.Black;
            
            label2.Text = "電圧降下は、" + vd.ToString("F3") + "[V]です。";

            // キュービクル.
            label4.Visible = true;
            label4.Text = "キュービクルからの低圧受電: ×";

            if (l <= 120 && vdr <= 5)
            {
                label4.Text = "キュービクルからの低圧受電: 〇";
            }
            
            if(l <= 200 && vdr <= 6)
            {
                label4.Text = "キュービクルからの低圧受電: 〇";
            }

            if (l > 200 && vdr <= 7)
            {
                label4.Text = "キュービクルからの低圧受電: 〇";
            }

            // 電力会社からの低圧受電.
            label5.Visible = true;
            label5.Text = "電力会社からの低圧受電: ×";

            if (l <= 120 && vdr <= 4)
            {
                label5.Text = "電力会社からの低圧受電: 〇";
            }

            if (l <= 200 && vdr <= 5)
            {
                label5.Text = "電力会社からの低圧受電: 〇";
            }

            if (l > 200 && vdr <= 6)
            {
                label5.Text = "電力会社からの低圧受電: 〇";
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
                label3.Text = "※許容電流は、18.9Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、25.9Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、34.3Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、42.7Aです。(電流減少係数0.7とする)";
                
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
                label3.Text = "※許容電流は、61.6Aです。(電流減少係数0.7とする)";
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
                label3.Text = "※許容電流は、80.5Aです。(電流減少係数0.7とする)";
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
                label3.Text = "※許容電流は、113.4Aです。(電流減少係数0.7とする)";
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
                label3.Text = "※許容電流は、151.9Aです。(電流減少係数0.7とする)";
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
                label3.Text = "※許容電流は、208.6Aです。(電流減少係数0.7とする)";
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
                label3.Text = "※許容電流は、276.5Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、328.3Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、389.2Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、455.0Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、521.5Aです。(電流減少係数0.7とする)";

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
                label3.Text = "※許容電流は、589.4Aです。(電流減少係数0.7とする)";

                updateResult();
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                // ブレーカー容量:3A
                i = 3;

                updateResult();
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                // ブレーカー容量:5A
                i = 5;

                updateResult();
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                // ブレーカー容量:10A
                i = 10;

                updateResult();
            }

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                // ブレーカー容量:15A
                i = 15;

                updateResult();
            }

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                // ブレーカー容量:20A
                i = 20;
                if (a < 3.5) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

                updateResult();
            }

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                // ブレーカー容量:30A
                i = 30;
                if (a < 3.5) { label3.ForeColor = Color.Red; } else { label3.ForeColor = Color.Black; }

                updateResult();

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                // ブレーカー容量:32A
                i = 32;

                updateResult();

            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                // ブレーカー容量:40A
                i = 40;

                updateResult();

            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                // ブレーカー容量:50A
                i = 50;

                updateResult();

            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                // ブレーカー容量:60A
                i = 60;

                updateResult();

            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                // ブレーカー容量:63A
                i = 63;

                updateResult();

            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
            {
                // ブレーカー容量:75A
                i = 75;

                updateResult();

            }
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked)
            {
                // ブレーカー容量:100A
                i = 100;

                updateResult();

            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                // ブレーカー容量:125A
                i = 125;

                updateResult();

            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                // ブレーカー容量:150A
                i = 150;

                updateResult();

            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                // ブレーカー容量:175A
                i = 175;

                updateResult();

            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked)
            {
                // ブレーカー容量:200A
                i = 200;

                updateResult();

            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
            {
                // ブレーカー容量:225A
                i = 225;

                updateResult();

            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                // ブレーカー容量:250A
                i = 250;

                updateResult();
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked)
            {
                // ブレーカー容量:300A
                i = 300;

                updateResult();

            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked)
            {
                // ブレーカー容量:350A
                i = 350;

                updateResult();

            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                {
                    // ブレーカー容量:400A
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
                    // ブレーカー容量:450A
                    i = 450;

                    updateResult();
                }

            }
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton41.Checked)
            {
                // ブレーカー容量:500A
                i = 500;

                updateResult();
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked)
            {
                // ブレーカー容量:600A
                i = 600;

                updateResult();
            }
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton43.Checked)
            {
                // ブレーカー容量:700A
                i = 700;

                updateResult();
            }
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton44.Checked)
            {
                // ブレーカー容量:700A
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
