using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ERPProject
{
    public partial class masterForm : Form
    {
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        Form5 frm5 = new Form5();
        static Form frma;

        Setting setting1= new Setting();
        //Setting setting = new Setting();    


        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        FileInfo dp1 = new FileInfo(dtif.FullName + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
        //static string asd = dp1.LastWriteTime.ToString();

        public static DateTime asd = new FileInfo(dtif.FullName + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt").LastWriteTime;

        

        public masterForm()
        {
            InitializeComponent();

            //string asd = dp1.LastWriteTime.ToString();

            timer1.Interval = 1000; //주기 설정

            timer1.Tick += new EventHandler(timer1_Tick); //주기마다 실행되는 이벤트 등록  // +=는 축적, -=는 감소
            //timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //공지사항 패널
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //power();
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            //panel2.Visible = true;
            panel2.BringToFront();
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                frm2.Show();
            }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //재무팀
            //power();
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.TopLevel = false; 
            panel3.Controls.Add(frm3);
            frm3.Dock = DockStyle.Fill;            
            panel3.BringToFront();
           
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                frm3.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            frm4.TopLevel = false;
     
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.TopLevel = false;
            panel4.Controls.Add(frm4);
            frm4.Dock = DockStyle.Fill;
            
            panel4.BringToFront();
            if ( panel4.Visible == false)
            {
                panel4.Visible = true;
                frm4.Show();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //서비스팀
            //frm5.FormBorderStyle = FormBorderStyle.None;
            //panel2.Controls.Clear();
            //frm5.TopLevel = false;
            //panel2.Controls.Add(frm5);
            //frm5.Show();
            //frm5.Dock = DockStyle.Fill;
            frm5.FormBorderStyle = FormBorderStyle.None;
            frm5.TopLevel = false;
            panel5.Controls.Add(frm5);
            frm5.Dock = DockStyle.Fill;
            //panel5.Visible=true;
            panel5.BringToFront();

            
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
                frm5.Show();
            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void xhlrms()// 퇴근 함수
        {
            Form1 frm1 = new Form1();

            

            DateTime now = DateTime.Now;
            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif.FullName + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox3.Text + ".txt");
            string dp1 = dtif.FullName + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\";

            string strFilePath = dtif.FullName + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox3.Text + ".txt"; // 저장할위치 + 저장할 텍스트이름

            StreamReader lines = new StreamReader(strFilePath, Encoding.UTF8);
            string a = lines.ReadLine().ToString();
            string[] splitData = a.Split('\t');
            lines.Close();
            lines.Dispose();
            if (splitData[0] == textBox3.Text)
            {
                DateTime.TryParse(splitData[1], out DateTime qqq);
                DateTime hhh = qqq.AddHours(9);
                if (now > hhh)
                {
                    writer_ = File.CreateText(strFilePath);
                    writer_.Write(splitData[0] + '\t' + splitData[1] + '\t' + splitData[2] + '\t' + DateTime.Now + "\t" + "퇴근");
                    writer_.Close();
                    writer_.Dispose();
                }
            }
            frm1.Visible = true;
            this.Close();
            this.Dispose();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            xhlrms();
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // 프포세스 완전종료
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        public void SetText12(string data)
        {
            textBox3.Text = data;
        }
        public void SetTex7(string data)
        {
            textBox7.Text = data;
            textBox8.Text = data;
        }

        public void setX(object name)
        {
            frma = (Form)name;
        }

        private void power()
        {
            
            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            Form4 frm4 = new Form4();
            Form5 frm5 = new Form5();
            Setting setting = new Setting();
            FileInfo dp11 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt");
            FileInfo dp12 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt");
            FileInfo dp13 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox3 .Text + "\\" + textBox3.Text + ".txt");
            FileInfo dp14 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt");
            FileInfo dp0 = new FileInfo(dtif + "\\직원관리" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt");
            string dp00 = dtif + "\\직원관리" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt";
            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt";
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt";
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt";
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox3.Text + "\\" + textBox3.Text + ".txt";

            try
            {
                //MessageBox.Show(dp11.FullName.ToString());
                if (dp11.Exists)
                {
                   
                    StreamReader lines = new StreamReader(dp, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    if (splitData[3] == "인사팀" && splitData[4] != "사장")
                    {
                        button2.Enabled = true;
                        button3.Enabled = false;
                        button3.Visible = false;
                        button4.Enabled = false;
                        button4.Visible = false;
                        button5.Enabled = false;
                        button5.Visible = false;
                        positionAuthority(splitData[4], "인사팀");

                    }
                    else if (splitData[3] == "인사팀" && splitData[4] == "사장")
                    {
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }


                }
                else if (dp12.Exists)
                {
                    StreamReader lines = new StreamReader(dp1, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    if (splitData[3] == "재무팀" && splitData[4] != "사장")
                    {
                        button2.Enabled = false;
                        button2.Visible = false;
                        button3.Enabled = true;
                        button4.Enabled = false;
                        button4.Visible = false;
                        button5.Enabled = false;
                        button5.Visible = false;
                        positionAuthority(splitData[4], "재무팀");
                    }
                    else if (splitData[3] == "재무팀" && splitData[4] == "사장")
                    {
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }
                }


                else if (dp13.Exists)
                {
                    StreamReader lines = new StreamReader(dp2, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    if (splitData[3] == "재고팀" && splitData[4] != "사장")
                    {
                        button2.Enabled = false;
                        button2.Visible = false;
                        button3.Enabled = false;
                        button3.Visible = false;
                        button4.Enabled = true;
                        button5.Enabled = false;
                        button5.Visible = false;
                        positionAuthority(splitData[4], "재고팀");
                    }
                    else if (splitData[3] == "재고팀" && splitData[4] == "사장")
                    {
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }


                }

                else if (dp14.Exists)
                {
                    StreamReader lines = new StreamReader(dp3, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    if (splitData[3] == "서비스팀" && splitData[4] != "사장")
                    {
                        button2.Enabled = false;
                        button2.Visible = false;
                        button3.Enabled = false;
                        button3.Visible = false;
                        button4.Enabled = false;
                        button4.Visible = false;
                        button5.Enabled = true;
                        positionAuthority(splitData[4], "서비스팀");
                    }
                    else if (splitData[3] == "서비스팀" && splitData[4] == "사장")
                    {
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }

                }
                else if (dp0.Exists)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
            }

            catch
            {

            }
        }
        public void positionAuthority(string position, string Dipartment)
        {
            // 직책에 따른 권한 설정 함수???
            if (position == "사원")
            {
                // 제한이 많음
                // 사원등록 인사발령 평가사용 못함
                if (Dipartment == "인사팀")
                {
                    frm2.employee();
                }
                else if (Dipartment == "재무팀")
                {
                    frm3.employee();
                }
                else if (Dipartment == "재고팀")
                {
                    frm4.employee();
                }
                else
                {
                    frm5.employee();
                }
            }
            else if (position == "대리")
            {
                // 사원보다 사용할 수 있는 항목이 많음
                // 인사발령 평가 사용못함
                if (Dipartment == "인사팀")
                {
                    frm2.deputy();
                }
                else if (Dipartment == "재무팀")
                {
                    frm3.deputy();
                }
                else if (Dipartment == "재고팀")
                {
                    frm4.deputy();
                }
                else
                {
                    frm5.deputy();
                }

            }
            else
            {

            }
        }
        private void masterForm_Load(object sender, EventArgs e)
        {
            power();
            timer1.Start();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //공지사항
        }

        private void Func()//잘못입력 알람 쓰레드 매개변수
        {
            
            FileInfo dp = new FileInfo(dtif + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\");
            FileInfo dp1 = new FileInfo(dtif + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\"+ DateTime.Now.ToString("yyyyMMdd") + ".txt");
            string strFilePath = dp + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            StreamReader lines = new StreamReader(strFilePath, Encoding.UTF8);
            //asd = dp1.LastWriteTime.ToString();
            try
            {
                string a = lines.ReadLine().ToString();
                lines.Close();
                lines.Dispose();
                //var asd123 = dp1.LastWriteTime.ToString();

                if (asd != dp1.LastWriteTime)
                {

                    textBox4.Text = a;
                    //timer1.Start();
                }
            }
            catch
            {

            }
           
            

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Func();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Setting setting = new Setting();
            //setting.SetText12(textBox3.Text);
            //setting.Show();
            panel6.Visible = false;
            power();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //개인정보 버튼
            //Setting setting = new Setting();
            setting1.SetText(textBox3.Text);
            setting1.Show();
            
        }
    }
}
