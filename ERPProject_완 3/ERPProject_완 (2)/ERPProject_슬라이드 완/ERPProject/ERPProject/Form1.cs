using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;


namespace ERPProject
{


    public partial class Form1 : Form
    {
        //string department;

        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        string strdtif = dtif.FullName;
        public bool test = false;
        System.Windows.Forms.TextBox[] txtList;
        const string IdPlaceholder = "계정 (아이디 또는 이메일)";
        const string PwPlaceholder = "비밀번호";
        WindowsMediaPlayer wmp;
        public static string login;

        Form2 form2 = new Form2();
        masterForm master = new masterForm();



        public Form1()
        {


            InitializeComponent();
            //ID, Password TextBox Placeholder 설정
            txtList = new System.Windows.Forms.TextBox[] { textBox1, textBox2 };
            foreach (var txt in txtList)
            {

                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == textBox1) txt.Text = IdPlaceholder;
                else if (txt == textBox2) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;

            }


        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == textBox1) textBox2.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == textBox1) txt.Text = IdPlaceholder;
                else if (txt == textBox2) { txt.Text = PwPlaceholder; textBox2.PasswordChar = default; }
            }
        }


        //부서확인함수

        private void button1_Click(object sender, EventArgs e)
        {
            //로그인 버튼

            attendance();
            personal();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void personal() //아이디 비번 확인 함수
        {

            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            Form4 frm4 = new Form4();
            Form5 frm5 = new Form5();
            Setting setting = new Setting();
            FileInfo dp11 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt");
            FileInfo dp12 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt");
            FileInfo dp13 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt");
            FileInfo dp14 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt");
            FileInfo dp0 = new FileInfo(dtif + "\\직원관리" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt");
            string dp00 = dtif + "\\직원관리" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt";
            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt";
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재무팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt";
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "재고팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt";
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + "서비스팀" + "\\" + textBox1.Text + "\\" + textBox1.Text + ".txt";

            try
            {
                if (dp11.Exists)
                {
                    StreamReader lines = new StreamReader(dp, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    lines.Close();
                    lines.Dispose();
                    if (splitData[3] == "인사팀")
                    {
                        if (textBox2.Text == splitData[1] && textBox1.Text == splitData[0])
                        {


                            this.Visible = false;
                            //form2.Show();
                            ////form3.Show();
                            ////메서드를 이용한 form2로 데이터 전송
                            //form2.SetText(textBox1.Text);
                            //frm3.Visible= true;
                            master.setX(this);
                            master.SetText12(textBox1.Text);
                            master.SetTex7(splitData[4]);
                            master.Show();
                            wmp.URL = "C:\\Users\\woong\\Desktop\\sample.mp3";
                            wmp.controls.stop();
                        }
                        else
                        {
                            Thread myThread = new Thread(Func);
                            myThread.Start();
                            MessageBox.Show("잘못입력하셨습니다");

                        }
                    }


                }
                else if (dp0.Exists)
                {
                    StreamReader lines = new StreamReader(dp00, Encoding.UTF8);
                    string a = lines.ReadLine().ToString();

                    string[] splitData = a.Split('\t');
                    lines.Close();
                    lines.Dispose();
                    if (textBox2.Text == splitData[1] && textBox1.Text == splitData[0])
                    {
                        this.Visible = false;
                        //form2.Show();

                        ////메서드를 이용한 form2로 데이터 전송
                        //form2.SetText(textBox1.Text);
                        //frm2.setX(this);
                        ////wmp.URL = "C:\\Users\\woong\\Desktop\\sample.mp3";
                        ///master.setX(this);
                        master.SetText12(textBox1.Text);
                        //master.SetTex7(splitData[4]);
                        wmp.controls.stop();
                        master.Show();
                    }
                    else
                    {
                        Thread myThread = new Thread(Func);
                        myThread.Start();
                        MessageBox.Show("잘못입력하셨습니다");

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
                        if (textBox2.Text == splitData[1] && textBox1.Text == splitData[0])
                        {
                            this.Visible = false;
                            //form2.SetText(textBox1.Text);
                            //form2.Show();
                            master.setX(this);
                            master.SetText12(textBox1.Text);
                            master.SetTex7(splitData[4]);

                            wmp.controls.stop();
                            master.Show();
                        }
                        else
                        {
                            Thread myThread = new Thread(Func);
                            myThread.Start();
                            MessageBox.Show("잘못입력하셨습니다");

                        }
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
                        if (textBox2.Text == splitData[1] && textBox1.Text == splitData[0])
                        {
                            this.Visible = false;
                            //frm4.Visible = true;
                            master.setX(this);
                            master.SetText12(textBox1.Text);
                            master.SetTex7(splitData[4]);
                            wmp.controls.stop();
                            master.Show();
                        }
                        else
                        {
                            Thread myThread = new Thread(Func);
                            myThread.Start();
                            MessageBox.Show("잘못입력하셨습니다");

                        }

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
                        if (textBox2.Text == splitData[1] && textBox1.Text == splitData[0])
                        {
                            this.Visible = false;
                            //frm5.Visible = true;
                            master.setX(this);
                            master.SetText12(textBox1.Text);
                            master.SetTex7(splitData[4]);
                            wmp.controls.stop();
                            master.Show();
                        }
                        else
                        {
                            Thread myThread = new Thread(Func);
                            myThread.Start();
                            MessageBox.Show("잘못입력하셨습니다");

                        }
                    }


                }
                else
                {
                    Thread myThread = new Thread(Func);
                    myThread.Start();
                    MessageBox.Show("잘못입력하셨습니다");

                }

            }
            catch
            {
                Thread myThread = new Thread(Func);
                myThread.Start();
                MessageBox.Show("잘못입력하셨습니다");

            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
            wmp.URL = "C:\\Users\\woong\\Desktop\\c#프로젝트\\ERPProject_슬라이드 완\\sample.mp3";
            wmp.controls.play();
            Foder(dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd"));
            Foder(dtif + "\\직원관리" + "\\" + "1111");
            Foder(dtif + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd"));
            textSave();
            textSave1();
        }

        private void attendance() //출근시
        {

            int start = Int32.Parse(DateTime.Now.ToString("hhmm"));
            int timer = 0900;
            DateTime nowtime = DateTime.Now;
            DateTime xgkrns = nowtime.AddHours(9);
            int atten = 0;
            string b = "출근";
            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox1.Text + ".txt");
            string dp1 = dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\";


            string strFilePath = dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox1.Text + ".txt"; // 저장할위치 + 저장할 텍스트이름



            if (!dp.Exists)
            {

                writer_ = File.CreateText(strFilePath);
                writer_.Write(textBox1.Text + "\t" + nowtime + "\t" + b);

                writer_.Close();
                writer_.Dispose();

            }
            else
            {



            }

        }


        private void Foder(string a)//출결관리 폴더 만드는 함수
        {

            string dp = a;

            if (Directory.Exists(dp) == false)
            {
                Directory.CreateDirectory(dp);
            }


        }

        private void textSave()
        {
            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\" + "1111" + "\\");

            string strFilePath = dp + "1111" + ".txt"; // 저장할위치 + 저장할 텍스트이름




            writer_ = File.CreateText(strFilePath);
            writer_.Write("1111" + "\t" + "1111");
            writer_.Close();
            writer_.Dispose();



        }

        private void panel62_Paint(object sender, PaintEventArgs e)
        {

        }

        private static void Func()//잘못입력 알람 쓰레드 매개변수
        {

            Console.Beep(392, 400);
            Console.Beep(392, 400);
            Console.Beep(440, 400);
            Console.Beep(440, 400);
            Console.Beep(392, 400);
            Console.Beep(392, 400);
            Console.Beep(330, 400);
        }

        private void textSave1() //공지사항 텍스트파일 생성 함수
        {

            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\공지사항" + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\");

            string strFilePath = dp + DateTime.Now.ToString("yyyyMMdd") + ".txt"; // 저장할위치 + 저장할 텍스트이름



            writer_ = File.CreateText(strFilePath);
            writer_.Write(DateTime.Now.ToString("yyyyMMdd"));
            writer_.Close();
            writer_.Dispose();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }
    }
}
