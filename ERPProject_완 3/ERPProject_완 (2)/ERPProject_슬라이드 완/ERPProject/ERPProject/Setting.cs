using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERPProject
{
    public partial class Setting : Form

    {
        //masterForm master = new masterForm();
        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        string strdtif = dtif.FullName;




        public Setting()
        {

            InitializeComponent();

        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void SetText12(string data)
        {
            textBox1.Text = data;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSave() //공지사항 텍스트파일 생성 함수
        {

            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd")+"\\");
            
            string strFilePath = dp +DateTime.Now.ToString("yyyyMMdd")+ ".txt"; // 저장할위치 + 저장할 텍스트이름
           

            
            writer_ = File.CreateText(strFilePath);
            writer_.Write(textBox3.Text);
            writer_.Close();
            writer_.Dispose();
               

          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textSave();
            this.Close();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //출근 및 공지사항패널
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //개인 정보 및 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //비밀번호?
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //연차신청?
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //연차신청버튼
            panel6.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //비밀번호 변경 버튼
            configurationPass();
            //panel5.BringToFront();
            //panel5.Visible = true;


        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //기존 비밀번호 입력 텍스트박스
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //이름
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //사번
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //연차
        }


        public void SetText(string data)
        {
            textBox9.Text = data;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            configurationChange();
            
        }


        private void configurationPass()
        {
            FileInfo dp01 = new FileInfo(dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt");
            string dp001 = dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt";


            StreamReader Id = new StreamReader(dp001, Encoding.UTF8);
            string b = Id.ReadLine().ToString();
            string[] splitId = b.Split('\t');

            Id.Close();
            Id.Dispose();


            if (textBox13.Text == splitId[1])
            {
                panel5.Visible = true;
                panel5.BringToFront();

            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }


        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //변경전 비밀번호
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //변경후 비밀번호
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //비밀번호 변경 버튼
            textSave1();
            textBox13.Clear();
            panel5.Visible = false;
        }

        private void configurationChange()
        {
            FileInfo dp11 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt");
            FileInfo dp12 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt");
            FileInfo dp13 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt");
            FileInfo dp14 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt");

            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt";
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt";
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt";
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox9.Text + "\\" + textBox9.Text + ".txt";

            FileInfo dp01 = new FileInfo(dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt");
            string dp001 = dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt";


            if (dp11.Exists)
            {
                StreamReader lines = new StreamReader(dp, Encoding.UTF8);
                string a = lines.ReadLine().ToString();

                string[] splitData = a.Split('\t');

                lines.Close();
                lines.Dispose();
                if (splitData[3] == "인사팀")
                {
                    textBox7.Text = splitData[2];
                    textBox15.Text = splitData[4];

                }
            }
            else if (dp12.Exists)
            {
                StreamReader lines = new StreamReader(dp1, Encoding.UTF8);
                string a = lines.ReadLine().ToString();

                string[] splitData = a.Split('\t');

                lines.Close();
                lines.Dispose();
                if (splitData[3] == "재무팀")
                {
                    textBox7.Text = splitData[2];
                    textBox15.Text = splitData[4];

                }
            }
            else if (dp13.Exists)
            {
                StreamReader lines = new StreamReader(dp2, Encoding.UTF8);
                string a = lines.ReadLine().ToString();

                string[] splitData = a.Split('\t');

                lines.Close();
                lines.Dispose();
                if (splitData[3] == "재고팀")
                {
                    textBox7.Text = splitData[2];
                    textBox15.Text = splitData[4];

                }
            }
            else if (dp14.Exists)
            {
                StreamReader lines = new StreamReader(dp3, Encoding.UTF8);
                string a = lines.ReadLine().ToString();

                string[] splitData = a.Split('\t');

                lines.Close();
                lines.Dispose();
                if (splitData[3] == "서비스팀")
                {
                    textBox7.Text = splitData[2];
                    textBox15.Text = splitData[4];

                }
            }

        }
        private void textSave1() //비밀번호 변경
        {
            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\" + "비밀번호" + "\\");

            string strFilePath = dp + textBox9.Text + ".txt"; // 저장할위치 + 저장할 텍스트이름


           // FileInfo dp01 = new FileInfo(dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt");
            //string dp001 = dtif + "\\직원관리" + "\\" + "비밀번호" + "\\" + textBox9.Text + ".txt";


            StreamReader Id = new StreamReader(strFilePath, Encoding.UTF8);
            string b = Id.ReadLine().ToString();
            string[] splitId = b.Split('\t');

            Id.Close();
            Id.Dispose();




            if (textBox16.Text == splitId[1])
            {
                writer_ = File.CreateText(strFilePath);
                writer_.Write(textBox9.Text + "\t" + textBox18.Text);
                writer_.Close();
                writer_.Dispose();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다");
            }


        }

    }
}
