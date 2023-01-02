using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ERPProject
{

    public partial class Form2 : Form
    {
        const int MAX_SLIDING_WIDTH = 152;
        const int MIN_SLIDING_WIDTH = 10;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 1;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 152;

        static Form frma;

        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        Form5 frm5 = new Form5();

        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        string strdtif = dtif.FullName;
        static DirectoryInfo dp = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\인사팀" + "\\");
        static DirectoryInfo dp1 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\재무팀" + "\\");
        static DirectoryInfo dp2 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\재고팀" + "\\");
        static DirectoryInfo dp3 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\서비스팀" + "\\");
        static DirectoryInfo dp4 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\포상기록");
        static DirectoryInfo dp5 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\징계기록");
        static DirectoryInfo dp6 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\평가관리");
        static DirectoryInfo dp7 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\급여명세서");
        static DirectoryInfo dp8 = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\퇴직관리");

        DateTime time = DateTime.Now;
        WindowsMediaPlayer wmp;

        public void SetText(string data)
        {
            textBox147.Text = data;
        }

        public Form2()
        {
            InitializeComponent();
            textBox77.Text = DateTime.Now.ToString("yy.MM.dd"); //포상 날짜
            textBox79.Text = DateTime.Now.ToString("yy.MM.dd"); //징계 날짜
            textBox95.Text = DateTime.Now.ToString("yy.MM.dd"); //평가관리 날짜
            string Years = DateTime.Now.ToString("yyyy");
            grideShow();

            if (!dp4.Exists)
            {
                dp4.Create();
            }
            if (!dp5.Exists)
            {
                dp5.Create();
            }
            if (!dp6.Exists)
            {
                dp6.Create();
            }
            if (!dp7.Exists)
            {
                dp7.Create();
            }
            if (!dp8.Exists)
            {
                dp8.Create();
            }

        }

        


        public void setX(object name)
        {
            frma = (Form)name;
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            //사원관리 검색 텍스트
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //사원관리 검색 완료
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //사원관리
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //사원관리 선택버튼
            panel23.Visible = true;
            panel23.BringToFront();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox5.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox5.Text = strTemp;
            textBox5.Select(textBox5.Text.Length, 0); //offset 이동
            textBox5.Focus();


        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            textSave(textBox43.Text, textBox148.Text, textBox42.Text, textBox131.Text, textBox39.Text, textBox38.Text);
            textBox43.Clear();
            textBox148.Clear();
            textBox42.Clear();
            textBox39.Clear();
            textBox38.Clear();
            textBox131.Clear();
            panel23.Visible = false;
            //사원 개인정보 팝업 확인 버튼
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 사번
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 이름
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 직책
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 연락처
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 픽쳐박스
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            //사원 개인정보 팝업 등록 버튼
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 이름
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 사원번호
        }
        private void textBox131_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 부서
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 1주차
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 2주차
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 3주차
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 4주차
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 종류
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 신청일
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 팝업 허가일
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //사원 개인정보 근무통계 버튼
            panel6.Visible = true;
            panel6.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel23.Visible = true;
            panel23.BringToFront();
            //personal(textBox43.Text,
            //    textBox148.Text,
            //    textBox42.Text,
            //    textBox131.Text,
            //    textBox39.Text,
            //    textBox38.Text);
            //사원개인정보 버튼
        }
        private void button39_Click(object sender, EventArgs e)
        {
            //사원등록 버튼
            panel58.Visible = true;
            panel58.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel6.BringToFront();
            //근무 통계 버튼
        }

  

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox30.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox30.Text = strTemp;
            textBox30.Select(textBox30.Text.Length, 0); //offset 이동
            textBox30.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //사원관리 지급내역서 팝업 완료
            panel8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //지급내역서 버튼
            panel8.Visible = true;
            panel8.BringToFront();
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //지급내역서 팝업 사번
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            //지급내역서 팝업 이름
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            //지급내역서 팝업 부서
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //지급내역서 팝업 직책
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //지급내역서 팝업 이번달급여
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //지급내역서 팝업 지급내역
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //인사발령통지서 팝업 사번
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            //인사발령통지서 팝업 이름
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            //인사발령통지서 팝업 부서
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            //인사발령통지서 팝업 직책
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            //인사발령통지서 팝업 발령이유 텍스트
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Foder(textBox56.Text + "\\" + textBox57.Text + "\\" + textBox31.Text, textBox56.Text);
            textSave(textBox57.Text, textBox151.Text, textBox53.Text, textBox56.Text, textBox46.Text, textBox153.Text);

            panel11.Visible = false;
            //인사발령통지서 팝업 등록
        }

        private void button9_Click(object sender, EventArgs e)
        {

            panel11.Visible = true;
            panel11.BringToFront();
            personal();
            //인사발령통지서 버튼
        }
        private void button38_Click(object sender, EventArgs e)
        {
            Foder(textBox134.Text + "\\" + textBox138.Text, textBox134.Text);
            textSave(textBox138.Text, textBox145.Text, textBox137.Text, textBox134.Text, textBox142.Text, textBox141.Text);
            textBox138.Clear();
            textBox145.Clear();
            textBox137.Clear();
            textBox134.Clear();
            textBox142.Clear();
            textBox141.Clear();
            panel58.Visible = false;
            //사원등록 팝업 등록버튼
            //string message = string.Empty;


        }


        private void textBox138_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 사번

        }

        private void textBox145_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 생년월일 < 비밀번호역할
        }

        private void textBox137_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 이름
        }

        private void textBox134_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 부서
        }

        private void textBox142_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 직책
        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {
            //사원등록 팝업 연락처
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel14.BringToFront();
            //왼쪽 일용직관리 버튼
            DataTable table = new DataTable();
            string YMdata = time.ToString("yyMM");
            string DayData = time.ToString("dd");
            DirectoryInfo filea = new DirectoryInfo(dtif + "\\직원관리" + "\\인사팀" + "\\일용직" + "\\" + YMdata);
            if (!filea.Exists)
            {
                filea.Create();
            }

            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("연 락 처", typeof(string));
            table.Columns.Add("계    좌", typeof(string));
            table.Columns.Add("주    소", typeof(string));

            string file = dtif + "\\직원관리" + "\\인사팀" + "\\일용직" + "\\" + YMdata + "\\" + DayData + ".txt";
            try
            {
                string[] arr = new string[] { };
                arr = File.ReadAllLines(file);

                foreach (string line in arr)
                {
                    string[] splitData = line.Split('\t', '\n');
                    table.Rows.Add(splitData);
                }
            }
            catch
            {

            }


            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //왼쪽 사원관리 버튼
            panel46.BringToFront();
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //일용직관리 검색 텍스트
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //일용직관리 완료 버튼
        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            //일용직 관리 저장버튼
            //일용직 그리드뷰 저장 버튼
            string YMdata = time.ToString("yyMM");
            string DayData = time.ToString("dd");
            FileInfo file = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\일용직" + "\\" + YMdata + "\\" + DayData + ".txt");
            StreamWriter sw = new StreamWriter(file.FullName);

            if (this.dataGridView1.RowCount == 0)
            {
                return;
            }



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (!row.IsNewRow == true)
                    {

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int a = Int32.Parse(row.Cells.Count.ToString());
                            if (i == a - 1)
                            {
                                //조건이 맞으면 문자열만 *.txt 에 추가
                                sw.Write(row.Cells[i].Value);
                            }
                            else
                            {
                                //조건이 맞지 않으면 *.txt 에 "\t"를 붙여서 추가
                                sw.Write(row.Cells[i].Value + "\t");
                            }
                        }
                        sw.Write(sw.NewLine);

                    }

                }
                catch
                {

                }

            }
            //열었던 파일 닫기
            sw.Close();
            //파일의 리소스 해제
            sw.Dispose();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //일용직직원 고용 팝업 등록버튼
        }

        private void gridView3AddEmployee(string[] files)
        {
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < files.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(files[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView3.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }

        }


        private void button22_Click(object sender, EventArgs e)
        {
            panel21.BringToFront();
            //포상/징계 포상관리 버튼
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            dataGridView3.Rows.Clear();

            string[] splitData = new string[] { };
            string[] array = new string[] { };
            // column을 추가합니다.


            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\인사팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles2 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재고팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles3 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재무팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles4 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\서비스팀", "*.*", SearchOption.AllDirectories);

            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            /*
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView3.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }
            */
            gridView3AddEmployee(allfiles);
            gridView3AddEmployee(allfiles2);
            gridView3AddEmployee(allfiles3);
            gridView3AddEmployee(allfiles4);

            
            //dataGridView3.Rows.Add(arr[2], arr[0], arr[3], arr[4]);

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 사번
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 부서
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 이름
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 직책
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 신청인 이름
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //포상/징계 포상관리 팝업 등록버튼
            panel25.Visible = false;

            //string Absoluteposition = dtif.ToString() + "\\직원관리\\인사팀\\포상기록" + "\\" + textBox74.Text + ".txt";
            //File.Create(Absoluteposition);

            string filename = dtif.ToString() + "\\직원관리\\인사팀\\포상기록" + "\\" + textBox74.Text + ".txt";
            FileStream fi = new FileStream(filename, FileMode.Create);

            //FileInfo file = new FileInfo(Absoluteposition);
            StreamWriter sw = new StreamWriter(fi);
            sw.Write(textBox74.Text + "\t");
            sw.Write(textBox70.Text + "\t");
            sw.Write(textBox73.Text + "\t");
            sw.Write(textBox69.Text + "\t");
            sw.Write(textBox64.Text + "\t");
            sw.Close();
            sw.Dispose();

            fi.Close();
            fi.Dispose();

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox64.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox64.Text = strTemp;
            textBox64.Select(textBox64.Text.Length, 0); //offset 이동
            textBox64.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel25.Visible = true;
            panel25.BringToFront();
            //포상관리 선택 버튼
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Selected == true)
                { 
                    textBox74.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();//사번
                    textBox70.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();//이름
                    textBox73.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();//부서
                    textBox69.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();//직책
                }
            }




        }


        private void gridView4AddEmployee(string[] files)
        {
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < files.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(files[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView4.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel31.BringToFront();
            //징계관리선택버튼
   
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            dataGridView4.Rows.Clear();

            string[] splitData = new string[] { };
            string[] array = new string[] { };
            // column을 추가합니다.


            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\인사팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles2 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재고팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles3 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재무팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles4 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\서비스팀", "*.*", SearchOption.AllDirectories);

            //string[] arr = new string[] { };
            /*
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView4.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }
            */
            gridView4AddEmployee(allfiles);
            gridView4AddEmployee(allfiles2);
            gridView4AddEmployee(allfiles3);
            gridView4AddEmployee(allfiles4);


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //포상/징계 징계관리


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //포상/징계 포상관리 그리드뷰




        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel28.BringToFront();
            panel28.Visible = true;
            //포상/징계 징계관리 선택버튼

            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                if (dataGridView4.Rows[i].Selected == true)
                {
                    textBox90.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();//사번
                    textBox86.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();//이름
                    textBox89.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();//부서
                    textBox85.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();//직책
                }
            }


        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 징계관리 팝업 사번
        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 징계관리 팝업 이름
        }

        private void textBox89_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 징계관리 팝업 부서
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            //포상/징계 징계관리 팝업 직책
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //포상/징계 징계관리 팝업 등록버튼
            panel28.Visible = false;

            //string Absoluteposition = dtif.ToString() + "\\직원관리\\인사팀\\포상기록" + "\\" + textBox74.Text + ".txt";
            //File.Create(Absoluteposition);

            string filename = dtif.ToString() + "\\직원관리\\인사팀\\징계기록" + "\\" + textBox90.Text + ".txt";
            FileStream fi = new FileStream(filename, FileMode.Create);

            //FileInfo file = new FileInfo(Absoluteposition);
            StreamWriter sw = new StreamWriter(fi);
            sw.Write(textBox90.Text + "\t");
            sw.Write(textBox86.Text + "\t");
            sw.Write(textBox89.Text + "\t");
            sw.Write(textBox85.Text + "\t");
            sw.Write(textBox83.Text + "\t");
            sw.Close();
            sw.Dispose();

            fi.Close();
            fi.Dispose();
        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox83.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox83.Text = strTemp;
            textBox83.Select(textBox83.Text.Length, 0); //offset 이동
            textBox83.Focus();
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //평가 관리 그리드뷰
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel20.BringToFront();
            //왼쪽 포상/징계 관리
            

        }
        private void gridView5AddEmployee(string[] files)
        {
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < files.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(files[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView5.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel33.BringToFront();
            //왼쪽 평가관리 버튼
            string[] splitData = new string[] { };
            string[] array = new string[] { };
            // column을 추가합니다.

            dataGridView5.Rows.Clear();
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\인사팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles2 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재고팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles3 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재무팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles4 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\서비스팀", "*.*", SearchOption.AllDirectories);

            /*
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                
                dataGridView5.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }
            */
            gridView5AddEmployee(allfiles);
            gridView5AddEmployee(allfiles2);
            gridView5AddEmployee(allfiles3);
            gridView5AddEmployee(allfiles4);

        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel38.Visible = true;
            panel38.BringToFront();
            //평가관리 선택 버튼


            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                if (dataGridView5.Rows[i].Selected == true)
                {
                    textBox106.Text = dataGridView5.Rows[i].Cells[1].Value.ToString();//사번
                    textBox102.Text = dataGridView5.Rows[i].Cells[0].Value.ToString();//이름
                    textBox105.Text = dataGridView5.Rows[i].Cells[2].Value.ToString();//부서
                    textBox101.Text = dataGridView5.Rows[i].Cells[3].Value.ToString();//직책
                }
            }


        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {
            //평가관리 팝업 사번
        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {
            //평가관리 팝업 이름
        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {
            //평가관리 팝업 부서
        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {
            //평가관리 팝업 직책
        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {
            //평가관리 팝업 등록인
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel38.Visible = false;
            //평가관리 팝업 등록

            //string Absoluteposition = dtif.ToString() + "\\직원관리\\인사팀\\포상기록" + "\\" + textBox74.Text + ".txt";
            //File.Create(Absoluteposition);

            string filename = dtif.ToString() + "\\직원관리\\인사팀\\평가관리" + "\\" + textBox106.Text + ".txt";
            FileStream fi = new FileStream(filename, FileMode.Create);

            //FileInfo file = new FileInfo(Absoluteposition);
            StreamWriter sw = new StreamWriter(fi);
            sw.Write(textBox106.Text + "\t");
            sw.Write(textBox102.Text + "\t");
            sw.Write(textBox105.Text + "\t");
            sw.Write(textBox101.Text + "\t");
            sw.Write(textBox99.Text + "\t");
            sw.Close();
            sw.Dispose();

            fi.Close();
            fi.Dispose();
        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox99.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox99.Text = strTemp;
            textBox99.Select(textBox99.Text.Length, 0); //offset 이동
            textBox99.Focus();
        }

        private void gridView7AddEmployee(string[] files)
        {
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < files.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(files[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView7.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }

        }


        private void button31_Click(object sender, EventArgs e)
        {
            panel42.BringToFront();
            //왼쪽 급여명세서 등록 버튼
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            dataGridView7.Rows.Clear();

            string[] splitData = new string[] { };
            string[] array = new string[] { };
            // column을 추가합니다.


            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\인사팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles2 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재고팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles3 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\재무팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles4 = Directory.GetFiles(dtif + "\\직원관리\\인사팀" + "\\서비스팀", "*.*", SearchOption.AllDirectories);

            /*
            string[] arr = new string[] { };
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    arr = line.Split('\t');
                }
                dataGridView7.Rows.Add(arr[2], arr[0], arr[3], arr[4]);
            }

            */
            //dataGridView3.Rows.Add(arr[2], arr[0], arr[3], arr[4]);

            gridView7AddEmployee(allfiles);
            gridView7AddEmployee(allfiles2);
            gridView7AddEmployee(allfiles3);
            gridView7AddEmployee(allfiles4);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //급여 명세서 그리드뷰
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 사번
        }

        private void textBox118_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 이름
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 부서
        }

        private void textBox117_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 직책
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel50.Visible = true;
            panel50.BringToFront();
            //급여명세서 선택버튼


            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                if (dataGridView7.Rows[i].Selected == true)
                {
                    textBox122.Text = dataGridView7.Rows[i].Cells[1].Value.ToString();//사번
                    textBox118.Text = dataGridView7.Rows[i].Cells[0].Value.ToString();//이름
                    textBox121.Text = dataGridView7.Rows[i].Cells[2].Value.ToString();//부서
                    textBox117.Text = dataGridView7.Rows[i].Cells[3].Value.ToString();//직책
                }
            }

        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 지금 공제내역 텍박
        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 지급일 텍ㄷ박
        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 신청일 이름
        }

        private void textBox129_TextChanged(object sender, EventArgs e)
        {
            //급여명세서 팝업 계좌번호
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel50.Visible = false;
            //등록버튼

            //string Absoluteposition = dtif.ToString() + "\\직원관리\\인사팀\\포상기록" + "\\" + textBox74.Text + ".txt";
            //File.Create(Absoluteposition);

            string filename = dtif.ToString() + "\\직원관리\\인사팀\\급여명세서" + "\\" + textBox122.Text + ".txt";
            FileStream fi = new FileStream(filename, FileMode.Create);

            //FileInfo file = new FileInfo(Absoluteposition);
            /*
            if (listBox1.SelectedItem != null)
            {
                textBox61.Text = listBox1.SelectedItem.ToString();
            }
            */

            
            StreamWriter sw = new StreamWriter(fi);
            sw.Write(textBox122.Text + "\t");//사번
            sw.Write(textBox118.Text + "\t");//이름
            sw.Write(textBox121.Text + "\t");//부서
            sw.Write(textBox61.Text + "\t");//은행이름
            sw.Write(textBox129.Text + "\t");//계좌
            sw.Write(textBox115.Text + "\n");//지급공제내역

            sw.Close();
            sw.Dispose();


            fi.Close();
            fi.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel53.BringToFront();
            //왼쪽 인사관리 버튼
        }



        //다이얼로그 기본 정보 정의

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //일용직 그리드뷰

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //사원관리 그리드뷰

        }

        private void button40_Click(object sender, EventArgs e)////////////////////텍스트박스 그리드뷰에 옴기는 버튼
        {
            //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 주소를 배열에 저장
            //인사관리 불러오기 버튼
            grideShow();


        }

        private void grideShow() // 각 폴더안의 모든 텍스트파일 그리드뷰에 넣기
        {

            string[] allfiles = Directory.GetFiles(dtif + "\\" + "직원관리" + "\\" + "인사팀" + "\\" + "인사팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles1 = Directory.GetFiles(dtif + "\\" + "직원관리" + "\\" + "인사팀" + "\\" + "재무팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles2 = Directory.GetFiles(dtif + "\\" + "직원관리" + "\\" + "인사팀" + "\\" + "재고팀", "*.*", SearchOption.AllDirectories);
            string[] allfiles3 = Directory.GetFiles(dtif + "\\" + "직원관리" + "\\" + "인사팀" + "\\" + "서비스팀", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("이 름", typeof(string));
            table.Columns.Add("부 서", typeof(string));
            table.Columns.Add("직급", typeof(string));
            table.Columns.Add("전화번호", typeof(string));

            //반복문을 이용해서 배열에 저장된 길이 만큼 반복

            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    //조건 : 배열이 null이 아니면
                    if (line != null)
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        table.Rows.Add(line.Split('\t'));
                    }

                }
            }

            for (int i = 0; i < allfiles1.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles1[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    //조건 : 배열이 null이 아니면
                    if (line != null)
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        table.Rows.Add(line.Split('\t'));
                    }

                }
            }
            for (int i = 0; i < allfiles2.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles2[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    //조건 : 배열이 null이 아니면
                    if (line != null)
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        table.Rows.Add(line.Split('\t'));
                    }

                }
            }
            for (int i = 0; i < allfiles3.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles3[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    //조건 : 배열이 null이 아니면
                    if (line != null)
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        table.Rows.Add(line.Split('\t'));
                    }

                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView11.DataSource = table;
        }

        private void textSave(string a, string b, string c, string d, string e, string f) //직원생성 함수
        {

            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\인사팀" + "\\" + a + "\\");
            FileInfo dp1 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\재무팀" + "\\" + a + "\\");
            FileInfo dp2 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\재고팀" + "\\" + a + "\\");
            FileInfo dp3 = new FileInfo(dtif + "\\직원관리" + "\\인사팀" + "\\서비스팀" + "\\" + a + "\\");
            string strFilePath = dp + a + ".txt"; // 저장할위치 + 저장할 텍스트이름
            string strFilePath1 = dp1 + a + ".txt";
            string strFilePath2 = dp2 + a + ".txt";
            string strFilePath3 = dp3 + a + ".txt";

            try
            {
                if (d == "인사팀")
                {
                    writer_ = File.CreateText(strFilePath);
                    writer_.Write(a + "\t" +
                        b + "\t" +
                        c + "\t" +
                        d + "\t" +
                        e + "\t" +
                        f);
                    writer_.Close();
                    writer_.Dispose();


                }
                else if (d == "재무팀")
                {
                    writer_ = File.CreateText(strFilePath1);  /////////////////////////////////////////////////////////////////오류
                    writer_.Write(a + "\t" +
                        b + "\t" +
                        c + "\t" +
                        d + "\t" +
                        e + "\t" +
                        f);
                    writer_.Close();
                    writer_.Dispose();

                }

                else if (d == "재고팀")
                {
                    writer_ = File.CreateText(strFilePath2);
                    writer_.Write(a + "\t" +
                        b + "\t" +
                        c + "\t" +
                        d + "\t" +
                        e + "\t" +
                        f);
                    writer_.Close();
                    writer_.Dispose();

                }

                else if (d == "서비스팀")
                {
                    writer_ = File.CreateText(strFilePath3);
                    writer_.Write(a + "\t" +
                        b + "\t" +
                        c + "\t" +
                        d + "\t" +
                        e + "\t" +
                        f);
                    writer_.Close();
                    writer_.Dispose();

                }
                else
                {
                    MessageBox.Show("잘못입력하셨습니다.");
                }
            }
            catch
            {

            }


        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            //사원관리 삭제버튼
            TextFileDelete();
        }

        private void TextFileDelete() // 그리드뷰에서 선택 텍스트파일 삭제 함수
        {
            int rowindex = dataGridView11.CurrentRow.Index;

            string RowIndexSelectElementName = dataGridView11.Rows[rowindex].Cells[0].Value.ToString();
            string RowIndexSelectElement = dataGridView11.Rows[rowindex].Cells[3].Value.ToString();

            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";

            if (RowIndexSelectElement == "인사팀")
            {

                File.Delete(dp);
                grideShow();

            }
            else if (RowIndexSelectElement == "재무팀")
            {

                File.Delete(dp1);
                grideShow();

            }
            else if (RowIndexSelectElement == "재고팀")
            {
                File.Delete(dp2);
                grideShow();

            }
            else if (RowIndexSelectElement == "서비스팀")
            {

                File.Delete(dp3);
                grideShow();

            }
        }

        private void Foder(string a, string b)
        {

            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + a;
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + a;
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + a;
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + a;


            if (b == "인사팀")
            {
                if (Directory.Exists(dp) == false)
                {
                    Directory.CreateDirectory(dp);
                }

            }
            else if (b == "재무팀")
            {
                if (Directory.Exists(dp1) == false)
                {
                    Directory.CreateDirectory(dp1);
                }
            }

            else if (b == "재고팀")
            {

                if (Directory.Exists(dp2) == false)
                {
                    Directory.CreateDirectory(dp2);
                }

            }
            else if (b == "서비스팀")
            {

                if (Directory.Exists(dp3) == false)
                {
                    Directory.CreateDirectory(dp3);
                }

            }

        }


        private void personal() // 선택 그리드뷰 텍스트 파일로 이동 함수
        {
            int rowindex = dataGridView11.CurrentRow.Index;
            string RowIndexSelectElementName = dataGridView11.Rows[rowindex].Cells[0].Value.ToString();

            string RowIndexSelectElement = dataGridView11.Rows[rowindex].Cells[3].Value.ToString();

            string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp1 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp2 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";
            string dp3 = dtif + "\\직원관리" + "\\인사팀" + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementName + "\\" + RowIndexSelectElementName + ".txt";


            if (dp.Contains(RowIndexSelectElementName) == true)
            {
                StreamReader lines = new StreamReader(dp, Encoding.UTF8);
                string a = lines.ReadLine().ToString();

                string[] splitData = a.Split('\t');

                textBox57.Text = splitData[0];
                textBox151.Text = splitData[1];
                textBox53.Text = splitData[2];
                textBox56.Text = splitData[3];
                textBox46.Text = splitData[4];
                textBox153.Text = splitData[5];

            }

            else if (dp1.Contains(RowIndexSelectElementName) == true)
            {
                StreamReader lines1 = new StreamReader(dp1, Encoding.UTF8);
                string a1 = lines1.ReadLine().ToString();

                string[] splitData = a1.Split('\t');

                textBox57.Text = splitData[0];
                textBox151.Text = splitData[1];
                textBox53.Text = splitData[2];
                textBox56.Text = splitData[3];
                textBox46.Text = splitData[4];
                textBox153.Text = splitData[5];
            }

            else if (dp2.Contains(RowIndexSelectElementName) == true)
            {
                StreamReader lines2 = new StreamReader(dp2, Encoding.UTF8);
                string a2 = lines2.ReadLine().ToString();

                string[] splitData = a2.Split('\t');

                textBox57.Text = splitData[0];
                textBox151.Text = splitData[1];
                textBox53.Text = splitData[2];
                textBox56.Text = splitData[3];
                textBox46.Text = splitData[4];
                textBox153.Text = splitData[5];
            }

            else if (dp3.Contains(RowIndexSelectElementName) == true)
            {
                StreamReader lines3 = new StreamReader(dp3, Encoding.UTF8);
                string a3 = lines3.ReadLine().ToString();

                string[] splitData = a3.Split('\t');

                textBox57.Text = splitData[0];
                textBox151.Text = splitData[1];
                textBox53.Text = splitData[2];
                textBox56.Text = splitData[3];
                textBox46.Text = splitData[4];
                textBox153.Text = splitData[5];
            }

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            //사원개인정보 팝업 이름
        }

        private void textBox147_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox148_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xhlrms()// 퇴근 함수
        {
            Form1 frm1 = new Form1();
            
            frma.Visible = true;
            this.Visible = false;

            DateTime now = DateTime.Now;
            StreamWriter writer_;

            FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox1.Text + ".txt");
            string dp1 = dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\";

            string strFilePath = dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox147.Text + ".txt"; // 저장할위치 + 저장할 텍스트이름

            StreamReader lines = new StreamReader(strFilePath, Encoding.UTF8);
            string a = lines.ReadLine().ToString();
            string[] splitData = a.Split('\t');
            lines.Close();
            lines.Dispose();
            if (splitData[0] == textBox147.Text)
            {
                DateTime.TryParse(splitData[1], out DateTime qqq);
                DateTime hhh = qqq.AddHours(9);
                if (now > hhh)
                {
                    writer_ = File.CreateText(strFilePath);
                    writer_.Write(splitData[0]+'\t'+ splitData[1] + '\t' + splitData[2] + '\t' +  DateTime.Now + "\t" + "퇴근");
                    writer_.Close();
                    writer_.Dispose();                   
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            frm3.Show();
            //재무버튼
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frm4.Show();
            //재고버튼
        }

        private void button42_Click(object sender, EventArgs e)
        {
            frm5.Show();
            //서비스버튼
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //string dp = dtif + "\\직원관리" + "\\인사팀" + "\\" + "인사팀" + "\\" + textBox147.Text + "\\" + textBox147.Text + ".txt";
            //FileInfo dp = new FileInfo(dtif + "\\직원관리" + "\\출결관리" + "\\" + DateTime.Now.ToString("yyMMdd") + "\\" + textBox1.Text + ".txt");
            //try
            //{
            //    if (dp.)
            //    {
            //        StreamReader lines = new StreamReader(dp, Encoding.UTF8);
            //        string a = lines.ReadLine().ToString();

            //        string[] splitData = a.Split('\t');
            //        lines.Close();
            //        lines.Dispose();
            //        if (splitData[0] == textBox147.Text)
            //        {
            //            panel17.Visible = true;

            //        }

            //    }
            
            //}
            //catch
            //{
                
            //}


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //급여명세서 은행 리스트박스
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void button43_Click_1(object sender, EventArgs e)
        {
   
            textBox61.Text = listBox1.Text;
      
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }
        public void employee()
        {
            button39.Enabled = false;
            button19.Enabled = false;
            button16.Enabled = false;
            button9.Enabled = false;
        }
        public void deputy()
        {
            button19.Enabled = false;
            button16.Enabled = false;
            button9.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            panel18.Visible = true;
            panel18.BringToFront();
            DateTime now = DateTime.Now;
            textBox160.Text = now.ToString("yyyyMMdd");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DirectoryInfo fd = new DirectoryInfo(now.ToString("yyMM"));

            string fileName = dp8 + "\\" + fd + "\\" + textBox171.Text;



            string FolderName = strdtif + "\\직원관리" + "\\인사팀";
            if (Directory.Exists(FolderName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {

                    if (item.Name.Contains("인사팀") || item.Name.Contains("재고팀") || item.Name.Contains("재무팀") || item.Name.Contains("서비스팀"))
                    {

                        string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                        for (int i = 0; i < arrfolder.Length; i++)
                        {
                            string[] arr = File.ReadAllLines(arrfolder[i]);

                            for (int j = 0; j < arr.Length; j++)
                            {
                                string position = textBox171.Text;
                                if (!position.Equals(null))
                                {
                                    string beforeName = foldername + "\\" + item.Name + "\\" + position + "\\" + position + ".txt";
                                    string afterName = foldername + "\\퇴직관리" + "\\" + fd + "\\" + textBox171.Text;

                                    if (arr[j].StartsWith(position) == true)
                                    {
                                        File.Move(beforeName, afterName + ".txt");

                                        FileStream fi = new FileStream(afterName + ".txt", FileMode.Open);
                                        StreamWriter writer = new StreamWriter(fi);

                                        if (fd.Exists == false)
                                        {
                                            Directory.CreateDirectory(fd.FullName);
                                        }
                                        else
                                        {
                                            writer.Write(textBox171.Text + "\t");
                                            writer.Write(textBox167.Text + "\t");
                                            writer.Write(textBox170.Text + "\t");
                                            writer.Write(textBox166.Text + "\t");
                                            writer.Write(textBox161.Text + "\t");
                                            writer.Write(textBox160.Text);
                                        }
                                        writer.Close();
                                        fi.Close();

                                        writer.Dispose();
                                        fi.Dispose();

                                        textBox171.Text = "";
                                        textBox167.Text = "";
                                        textBox170.Text = "";
                                        textBox166.Text = "";
                                        textBox160.Text = "";
                                        textBox161.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                panel3.Size = new Size(151, 6);
                checkBox2.Location = new Point(x: 3, y: 119);
                panel19.Location = new Point(x: 3, y: 148);

                if(checkBox2.Checked == true)
                {
                    panel19.Size = new Size(151, 6);
                    checkBox3.Location = new Point(x: 3, y:156);
                    panel41.Location = new Point(x: 3, y: 188);
                }
                else
                {
                    panel19.Size = new Size(151, 67);
                    checkBox3.Location = new Point(x: 3, y: 219);
                    panel41.Location = new Point(x: 3, y: 251);
                }
            }
            else
            {
                panel3.Size = new Size(151, 69);
                checkBox2.Location = new Point(x: 3, y: 190);
                panel19.Location = new Point(x: 3, y: 219);

                if(checkBox2.Checked == true)
                {
                    panel19.Size = new Size(151, 6);
                    checkBox3.Location = new Point(x: 3, y: 227);
                    panel41.Location = new Point(x: 3, y: 259);
                }
                else
                {
                    panel19.Size = new Size(151, 67);
                    checkBox3.Location = new Point(x: 3, 293);
                    panel41.Location = new Point(x: 3, y: 325);
                }
            }
            timerSliding1.Start();
        }

        private void timerSliding1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding1.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding1.Stop();
            }

            panel3.Height = _posSliding;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                panel19.Size = new Size(151, 6);
                if(checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                    checkBox3.Location = new Point(x: 3, y: 156);
                    panel41.Location = new Point(x: 3, y: 188);
                }
                else
                {
                    panel3.Size = new Size(151, 69);
                    checkBox3.Location = new Point(x: 3, y: 227);
                    panel41.Location = new Point(x: 3, y: 259);
                }
            }
            else
            {
                panel19.Size = new Size(151, 67);
                if(checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                    checkBox3.Location = new Point(x: 3, y: 219);
                    panel41.Location = new Point(x: 3, y: 251);
                }
                else
                {
                    panel3.Size = new Size(151, 69);
                    checkBox3.Location = new Point(x: 3, y: 293);
                    panel41.Location = new Point(x: 3, y: 325);
                }
            }
            timerSliding2.Start();
        }

        private void timerSliding2_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding2.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding2.Stop();
            }

            panel19.Height = _posSliding;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                panel41.Size = new Size(151, 6);
                if(checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                    checkBox2.Location = new Point(x: 3, y: 119);
                    panel19.Location = new Point(x: 3, y: 148);
                }
                else
                {
                    panel3.Size = new Size(151, 69);
                    checkBox2.Location = new Point(x: 3, y: 190);
                    panel19.Location = new Point(x: 3, y: 219);
                }
            }
            else
            {
                panel41.Size = new Size(151, 38);
                if (checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                    checkBox2.Location = new Point(x: 3, y: 119);
                    panel19.Location = new Point(x: 3, y: 148);
                }
                else
                {
                    panel3.Size = new Size(151, 69);
                    checkBox2.Location = new Point(x: 3, y: 190);
                    panel19.Location = new Point(x: 3, y: 219);
                }
            }
            timerSliding3.Start();
        }

        private void timerSliding3_Tick(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding3.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding3.Stop();
            }

            panel41.Height = _posSliding;
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel38.Visible = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            panel50.Visible = false;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            panel58.Visible = false;
        }

        private void button49_Click_1(object sender, EventArgs e)
        {
            panel11.Visible = false;
        }

        private void button50_Click_1(object sender, EventArgs e)
        {
            panel25.Visible = false;
        }
    }
    
}
