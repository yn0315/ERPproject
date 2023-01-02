using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ERPProject
{
    
    public partial class Form5 : Form
    {
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 152;
        const int MIN_SLIDING_WIDTH = 10;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 1;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 152;


        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        string strdtifService = dtif.FullName + "\\직원관리" + "\\서비스팀";

        static DirectoryInfo dp = new DirectoryInfo(dtif.FullName + "\\직원관리" + "\\서비스팀");
        static DirectoryInfo dp1 = new DirectoryInfo(dp + "\\대여");
        static DirectoryInfo dp2 = new DirectoryInfo(dp + "\\서비스");
        static DirectoryInfo dp3 = new DirectoryInfo(dp + "\\수리");
        static DirectoryInfo dp4 = new DirectoryInfo(dp + "\\회원관리");
        static DirectoryInfo dp5 = new DirectoryInfo(dp4 + "\\블랙리스트");
        static DirectoryInfo dp6 = new DirectoryInfo(dp4 + "\\탈퇴");
        static DirectoryInfo dp7 = new DirectoryInfo(dp4 + "\\회원");


        Form frn;

        
        public Form5()
        {
            InitializeComponent();

            textBox6.Text = DateTime.Now.ToString("yy.MM.dd");//서비스접수 신청날짜      
            textBox85.Text = DateTime.Now.ToString("yy.MM.dd");
            textBox115.Text = DateTime.Now.ToString("yy.MM.dd");
            textBox144.Text = DateTime.Now.ToString("yy.MM.dd");

            if(!dp.Exists)
            {
                dp.Create();
            }
            if(!dp1.Exists)
            {
                dp1.Create();
            }
            if (!dp2.Exists)
            {
                dp2.Create();
            }
            if (!dp3.Exists)
            {
                dp3.Create();
            }
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frn.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            //왼쪽 서비스 접수 버튼
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //서비스접수 등록버튼
            // 텍스트 파일에 저장 신청자 신청 날짜 내용
            try
            {
                string fileName = textBox5.Text;
                string filename = strdtifService + "\\" + "서비스" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox6.Text + "\t");
                writer.Write(textBox5.Text + "\t");
                writer.Write(textBox128.Text + "\t");
                writer.Write(textBox7.Text + "\t");
                writer.Write(textBox131.Text + "\t");
                writer.Write("확인 대기" + "\t");


                writer.Close();
                fi.Close();

                writer.Dispose();
                fi.Dispose();

                textBox5.Text = "";
                textBox6.Text = "";
                textBox128.Text = "";
                textBox7.Text = "";
                textBox131.Text = "";


            }
            catch (Exception ex)
            {
                
            }
        }

        private void serviceAdd()
        {
            if (!dtif.Exists)
            {
                Directory.CreateDirectory(Application.StartupPath + "../../../../" + "\\Database");
            }
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //서비스접수 신청자 텍스트박스
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //서비스 접수 신청날짜 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int a = 40;
            string strTemp = textBox7.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox7.Text = strTemp;
            textBox7.Select(textBox7.Text.Length, 0); //offset 이동
            textBox7.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //서비스접수현황 그리드뷰
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //서비스접수현황 등록버튼
            panel11.Visible = true;
            panel11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
            //왼쪽 서비스접수현황버튼

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            int a = 20;
            string strTemp = textBox18.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox18.Text = strTemp;
            textBox18.Select(textBox18.Text.Length, 0); //offset 이동
            textBox18.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            //서비스접수현황 팝업 등록버튼
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //서비스접수현황 팝업신청자
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //서비스접수현황 팝업 날짜
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //서비스접수현황 팝업 서비스종류
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

            //서비스접수현황 팝업 처리현황
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //담당자 이름
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //수리신청 그리드뷰
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel14.BringToFront();
            //왼쪽 수리신청버튼
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //수리신청 삭제버튼
            panel55.Visible = true;
            panel55.BringToFront();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //수리신청 수정버튼
            panel17.Visible = true;
            panel17.BringToFront();
            button58.Visible = true;
            button58.BringToFront();
            textBox152.Visible = true;
            textBox152.BringToFront();
            button15.Visible = false;

            DataTable table = new DataTable();

            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목고유번호", typeof(string));
            table.Columns.Add("고장원인", typeof(string));
            table.Columns.Add("납부금액", typeof(string));

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    string fileName = strdtifService + "\\수리" + "\\" + dataGridView2.Rows[i].Cells[0].Value + dataGridView2.Rows[i].Cells[1].Value + ".txt";
                    string[] arr = File.ReadAllLines(fileName);
                    string str2 = ""; 
                    for (int j = 0; j<arr.Length;j++)
                    {
                        string[] str = arr[j].Split('\t','\n');

                        for (int k = 0; k < str.Length; k++)
                        {
                            if (j != arr.Length-1 && k < 2)
                            {
                                textBox152.Text = str[0];
                                textBox23.Text = str[1];
                            }
                            else if(j != arr.Length-1 && 1<k)
                            {                                   
                                if(k != str.Length-1)
                                {
                                    str2 += str[k]+"\t";
                                }
                                else
                                {
                                    str2 += str[k];
                                }
                                    
                            }

                            textBox27.Text = str[k];

                        }
                    }
                    string[] str3 = str2.Split('\t');
                    table.Rows.Add(str3);
                }
            }
            dataGridView3.DataSource = table;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //수리신청 확인
            string[] allfiles = Directory.GetFiles(strdtifService + "\\" + "수리", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("일 자", typeof(string));
            table.Columns.Add("담당자", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목고유번호", typeof(string));
            table.Columns.Add("고장원인", typeof(string));
            table.Columns.Add("납부금액", typeof(string));


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                for (int j = 0; j < arra.Length; j++)
                {
                    if(j != arra.Length- 1)
                    {
                        string[] str = arra[j].Split('\t', '\n');
                        table.Rows.Add(str);
                    }
                    
                }

                //반복문으로 저장된 배열의 내용을 처리
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView2.DataSource = table;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            //수리신청 팝업 주소 텍스트
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            //수리신청 검색 텍스트
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // 수리 검색 완료 버튼
            SearchinGrid1(textBox28.Text);

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            //서비스접수현황 검색 텍스트박스

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //서비스접수현황 검색 완료 버튼
            SearchinGrid(textBox29.Text.ToString());
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            //대여 현황 검색 텍스트박스
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //대여 현황 검색 완료
            SearchinGrid4(textBox31.Text);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //대여 현황 그리드뷰
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //대여 현황 확인버튼
            panel23.BringToFront();
            panel23.Visible = true;
            button62.Visible = true;
            button62.BringToFront();
            textBox151.Visible= true;
            textBox151.BringToFront();
            

            try
            {
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    if (dataGridView4.Rows[i].Selected == true)
                    {
                        string fileName = dataGridView4.Rows[i].Cells[0].Value.ToString();//데이터 테이블에서 가지고 와야됨
                        string path = strdtifService + "\\" + "대여" + "\\" + fileName + ".txt";
                        string[] arr = File.ReadAllLines(path);
                        foreach (string str in arr)
                        {
                            string[] str1 = str.Split('\t');
                            textBox39.Text = str1[0];
                            textBox42.Text = str1[1];
                            textBox38.Text = str1[2];
                            textBox46.Text = str1[3];
                            textBox43.Text = str1[4];
                            textBox50.Text = str1[5];
                            textBox51.Text = str1[6];
                            textBox47.Text = str1[7];
                            textBox151.Text = str1[8];
                            textBox34.Text = str1[9];
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //대여 불러오기버튼

            //수리신청 확인
            string[] allfiles = Directory.GetFiles(strdtifService + "\\" + "대여", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("대여자", typeof(string));
            table.Columns.Add("품목 명", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("가맹점", typeof(string));
            table.Columns.Add("대여 기간", typeof(string));
            table.Columns.Add("반납 여부", typeof(string));


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                foreach (string str in arra)
                {
                    string[] strr = str.Split('\t');
                    string str2 = strr[0] + '\t' + strr[2] + '\t' + strr[1] + '\t' + strr[3] + '\t' + strr[4] + '\t' + strr[5];
                    string[] strr2 = str2.Split('\t');
                    table.Rows.Add(strr2);
                }



                //반복문으로 저장된 배열의 내용을 처리
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView4.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel20.BringToFront();
            //왼쪽 대여현황 버튼
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 대여자
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 대여기간
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 품목명
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 품목기간
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 납부정보
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 대여비
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 대여장소
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 담당자
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //대여현황 팝업 완료 
            try
            {
                string fileName = textBox39.Text;
                string filename = strdtifService + "\\" + "대여" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox39.Text + "\t");
                writer.Write(textBox42.Text + "\t");
                writer.Write(textBox38.Text + "\t");
                writer.Write(textBox46.Text + "\t");
                writer.Write(textBox43.Text + "\t");
                writer.Write(textBox50.Text + "\t");
                writer.Write(textBox51.Text + "\t");
                writer.Write(textBox47.Text + "\t");
                writer.Write(textBox36.Text + "\t");
                writer.Write(textBox34.Text + "\t");

                writer.Close();
                fi.Close();
                writer.Dispose();
                fi.Dispose();

                textBox39.Text = "";
                textBox42.Text = "";
                textBox38.Text = "";
                textBox46.Text = "";
                textBox43.Text = "";
                textBox50.Text = "";
                textBox51.Text = "";
                textBox47.Text = "";
                textBox36.Text = "";
                textBox34.Text = "";


            }
            catch (Exception ex)
            {
                
            }
            panel23.Visible = false;

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            //대여현황 팝업 맨밑 담당자 이름
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            //회원관리 검색 텍스트
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //회원관리 완료 버튼
            SearchinGrid5(textBox55.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //회원관리 등록버튼
            panel29.Visible = true;
            panel29.BringToFront();

            // 회원 정보 수정
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\회원", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("대여자", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("반납 여부", typeof(string));
            table.Columns.Add("대여 날짜", typeof(string));

            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView6.DataSource = table;
        }

       
        private void button28_Click(object sender, EventArgs e)
        {
            //회원관리 불러오기버튼
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\회원", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("가입날짜", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("연락처", typeof(string));
            table.Columns.Add("이메일", typeof(string));

            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for(int j = 0; j < arra.Length;j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가

                            string str2 = str[0] + "\t" + str[4] + "\t" + str[1] + "\t" + str[2] + "\t" + str[3];
                            string[] arr2 = str2.Split('\t');
                            table.Rows.Add(arr2);

                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView5.DataSource = table;
        }
       
        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = textBox63.Text;
                string filename = strdtifService + "\\회원관리" + "\\회원" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox63.Text + "\t");
                writer.Write(textBox61.Text + "\t");
                writer.Write(textBox62.Text + "\t");
                writer.Write(textBox60.Text + "\t");
                writer.Write(textBox149.Text + "\t");
                writer.Write(textBox148.Text + "\n");

                foreach (DataGridViewRow row in dataGridView6.Rows)
                {
                    if (!row.IsNewRow == true)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int a = Int32.Parse(row.Cells.Count.ToString());
                            if (i == a - 1)
                            {
                                writer.Write(row.Cells[i].Value.ToString());
                            }
                            else
                            {
                                writer.Write(row.Cells[i].Value.ToString() + "\t");
                            }
                        }
                        writer.Write(writer.NewLine);
                    }

                }
                writer.Close();
                fi.Close();

                writer.Dispose();
                fi.Dispose();

              
                if (textBox148.Text != "")
                {
                    /* if (Directory.Exists(strdtifService + "\\회원관리" + "\\탈퇴"))
                     {
                         Directory.CreateDirectory(strdtifService + "\\회원관리" + "\\탈퇴");
                     }*/
           
                    string beforeFiledtif = strdtifService + "\\회원관리" + "\\회원" + "\\" + fileName + ".txt";
                    string afterFiledtif = strdtifService + "\\회원관리" + "\\탈퇴" + "\\" + fileName;
                    File.Move(beforeFiledtif, afterFiledtif + ".txt");
                }

                textBox63.Text = "";
                textBox61.Text = "";
                textBox62.Text = "";
                textBox60.Text = "";
                textBox149.Text = "";
                textBox148.Text = "";
            }
            catch (Exception ex)
            {
                
            }
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            //회원관리 팝업 아이디
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            //회원관리 팝업 생년월일
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //회원관리 팝업 연락처
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //회원관리 팝업 이메일
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //회원관리 팝업 그리드뷰
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel26.BringToFront();
            //왼쪽 회원관리 버튼
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel32.BringToFront();
            //왼쪽 블랙리스트관리 버튼
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 검색 텍스트
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //블랙리스트 검색 완료버튼
            SearchinGrid7(textBox58.Text);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //블랙리스트 그리드뷰
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //블랙리스트 완료버튼

        }

        private void button30_Click(object sender, EventArgs e)
        {
            //블랙리스트 확인버튼
            panel35.BringToFront();
            panel35.Visible = true;
            button65.Visible = false;
            button33.Visible= true;
            button33.BringToFront();


            try
            {
                for (int i = 0; i < dataGridView7.Rows.Count; i++)
                {
                    if (dataGridView7.Rows[i].Selected == true)
                    {
                        string path = strdtifService + "\\회원관리" + "\\블랙리스트" + "\\" + dataGridView7.Rows[i].Cells[0].Value.ToString() + ".txt";
                        string[] arr = File.ReadAllLines(path);

                        for (int j = 0; j < arr.Length; j++)
                        {
                            string[] str2 = arr[j].Split('\t');
                            if (j == 0)
                            {
                                textBox81.Text = str2[0];
                                textBox77.Text = str2[1];
                                textBox80.Text = str2[2];
                                textBox76.Text = str2[3];
                                textBox89.Text = str2[4];
                                textBox91.Text = str2[5];
                                textBox85.Text = str2[6];
                                textBox87.Text = str2[7];
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 아이디
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트  팝업 생년월일
        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 연락처
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 이메일
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 대여품목
        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 품목번호
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 반납여부
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 대여날짜
        }

        private void textBox89_TextChanged(object sender, EventArgs e)
        {
            
            //블랙리스트 팝업 선정날짜
        }

        private void textBox91_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 내용
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {
            //블랙리스트 팝업 담당자
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox81.Text = "";
            textBox77.Text = "";
            textBox80.Text = "";
            textBox76.Text = "";
            textBox89.Text = "";
            textBox91.Text = "";
            textBox85.Text = "";
            textBox87.Text = "";

            panel35.Visible = false;
            //블랙리스트 확인 팝업 닫기 버튼
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //미납/연체 수정버튼
            panel37.Visible = true;
            panel37.BringToFront();
        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {

        }


        private void button22_Click(object sender, EventArgs e)
        {
            panel46.BringToFront();
            //왼쪽 회원탈퇴 버튼
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            //회원탈퇴관리 검색 텍스트
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //회원탈퇴관리 검색 완료
            SearchinGrid11(textBox124.Text);
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //회원탈퇴관리 그리드뷰
        }

        private void button43_Click(object sender, EventArgs e)
        {
            // 회원 탈퇴 관리 확인 버튼
            panel29.Visible = true;
            panel29.BringToFront();

            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("대여자", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목번호", typeof(string));
            table.Columns.Add("대여여부", typeof(string));
            table.Columns.Add("납부금액", typeof(string));

            try
            {
                for (int i = 0; i < dataGridView11.Rows.Count; i++)
                {
                    if (dataGridView11.Rows[i].Cells[0].Selected == true)
                    {
                        string fileName = dataGridView11.Rows[i].Cells[0].Value.ToString();
                        string Filedtif = strdtifService + "\\회원관리" + "\\탈퇴" + "\\" + fileName + ".txt";
                        string[] arr = File.ReadAllLines(Filedtif);

                        for (int j = 0; j < arr.Length; j++)
                        {
                            string[] arr1 = arr[j].Split('\t');
                            if (j == 0)
                            {
                                textBox63.Text = arr1[0];
                                textBox62.Text = arr1[2];
                                textBox61.Text = arr1[1];
                                textBox60.Text = arr1[3];
                                textBox149.Text = arr1[4];
                                textBox148.Text = arr1[5];
                            }
                            else
                            {
                                table.Rows.Add(arr1);
                            }
                        }

                    }
                }
            }
            catch
            {

            }
            dataGridView6.DataSource = table;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //회원탈퇴관리 불러오기
            // 회원 정보에서 탈퇴칸이 ""이 아니면 불러온다
            // 탈퇴칸에 적힌 날짜의 1년뒤에 삭제
            // 확인을 누르면 회원 정보가 불러와야됨

            DataTable table = new DataTable();

            DateTime time= DateTime.Now;

            table.Columns.Add("아이디",typeof(string));
            table.Columns.Add("가입날짜",typeof(string));
            table.Columns.Add("탈퇴날짜",typeof(string));
            table.Columns.Add("탈퇴기간",typeof(string));

            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\탈퇴", "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for (int j = 0; j < arra.Length; j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            DateTime todaytime = new DateTime(time.Year, time.Month, time.Day);
                            string[] str3 = str[5].Split(',', '.');

                            DateTime timeDay = new DateTime(Convert.ToInt32(str3[0]), Convert.ToInt32(str3[1]), Convert.ToInt32(str3[2]));
                            MessageBox.Show(timeDay.ToString());
                            MessageBox.Show(todaytime.ToString());


                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                            if (365 <= (todaytime - timeDay).Days)
                            {
                                for (int w = 0; w < str[j].Length; w++)
                                {
                                    string fileName = str[0];
                                    string fileDtif = strdtifService + "\\회원관리" + "\\탈퇴" + "\\" + fileName + ".txt";
                                    File.Delete(fileDtif);
                                    foreach (DataGridViewRow item in this.dataGridView11.SelectedRows)
                                    {
                                        dataGridView11.Rows.RemoveAt(item.Index);
                                    }

                                }
                            }
                            else if ((todaytime - timeDay).Days < 365)
                            {
                                string str2 = str[0] + "\t" + str[4] + "\t" + str[5] + "\t" + (todaytime - timeDay).Days + "일";
                                string[] arr2 = str2.Split('\t');
                                table.Rows.Add(arr2);
                            }


                        }
                        foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                        {
                            dataGridView11.Rows.RemoveAt(item.Index);
                        }
                    }
                }
            }
            dataGridView11.DataSource= table;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //회원탈퇴관리 팝업 닫기
            panel51.Visible = false;
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //회원탈퇴관리 팝업 그리드뷰
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //회원탈퇴관리 팝업 삭제 버튼
            panel54.Visible = true;
            panel54.BringToFront();
        }

        private void textBox144_TextChanged(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            //삭제확인 팝업창
            panel54.Visible = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //삭제확인 예 창 이걸로 그리드뷰 삭제해야함
        }

        private void textBox128_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchinGrid(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();
            //TextBox 입력된 문자열 string 으로 저장
            string SearchAddress = strdtifService + "" + "\\" + TextName + ".txt";
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService, "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요
            table.Columns.Add("일자", typeof(string));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("서비스 종류", typeof(string));
            table.Columns.Add("신청 현황", typeof(string));
            table.Columns.Add("비고", typeof(string));
            //이거 빠지면 테이블의 열의 개수가 길다고 하면서 터지네요


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                foreach (string line in arra)
                {
                    string[] arr = line.Split('\t');
                    string str = arr[1] + "\t" + arr[0] + "\t" + arr[2] + "\t" + arr[3];
                    string[] str2 = str.Split('\t');
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str2[j] == TextName)
                        {
                            table.Rows.Add(str2);
                        }
                    }


                    //textBox152.Text += line+"담";

                    /*
                    //조건 : 배열이 null이 아니면
                    if (line.Equals(TextName))
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        table.Rows.Add(line.Split('\t'));
                    }
                    */
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView1.DataSource = table;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fileOpen(string folderName, string fileName)
        {
            string path = strdtifService + "\\" + folderName + "\\" + fileName + ".txt";
            string[] arr = File.ReadAllLines(path);

            try
            {
                foreach (string line in arr)
                {
                    //조건 : 배열이 null이 아니면
                    if (line != null)
                    {
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        string[] arrr = line.Split('\t', '\n');
                        //textBox130.Text = arrr[0];
                        textBox14.Text = arrr[1];
                        textBox16.Text = arrr[0];
                        textBox15.Text = arrr[2];
                        textBox17.Text = arrr[5];
                        textBox18.Text = arrr[3];
                        textBox20.Text = arrr[4];
                    }
                }
            }
            catch
            {

            }
        }

        public void button32_Click_1(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel11.BringToFront();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    fileOpen("서비스", dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            // 서비스 접수 현황 불러오기

            string[] allfiles = Directory.GetFiles(strdtifService + "\\" + "서비스", "*.*", SearchOption.AllDirectories);

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("일 자", typeof(string));
            table.Columns.Add("이 름", typeof(string));
            table.Columns.Add("서비스 종류", typeof(string));
            table.Columns.Add("신청 현황", typeof(string));
            table.Columns.Add("비고", typeof(string));

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
                        string[] str = line.Split('\t');
                        string str2 = str[0] + "\t" + str[1] + "\t" + str[2] + "\t" + str[5];
                        table.Rows.Add(str2.Split('\t'));
                    }

                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView1.DataSource = table;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            panel17.Visible = true;
            panel17.BringToFront();
            textBox26.Visible = true;
            textBox26.BringToFront();
            button15.Visible = true;
            button15.BringToFront();
            button58.Visible = false;

            textBox26.Text = DateTime.Now.ToString("yy.MM.dd");

            //수리신청 팝업 그리드뷰
            //수리신청 확인
            ;

            //table 선언
            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가

            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목고유번호", typeof(string));
            table.Columns.Add("고장원인", typeof(string));
            table.Columns.Add("납부금액", typeof(string));

            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView3.DataSource = table;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox63.Text = "";
            textBox62.Text = "";
            textBox61.Text = "";
            textBox60.Text = "";
            textBox149.Text = "";
            textBox148.Text = "";

            panel29.Visible = false;
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {
            // 회원 정보 수정버튼
            panel29.Visible=true;
            panel29.BringToFront();

            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("대여자", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목번호", typeof(string));
            table.Columns.Add("대여여부", typeof(string));
            table.Columns.Add("납부금액", typeof(string));

            try
            {
                for(int i = 0; i < dataGridView5.Rows.Count;i++)
                {
                    if (dataGridView5.Rows[i].Cells[0].Selected == true)
                    {
                        string fileName = dataGridView5.Rows[i].Cells[0].Value.ToString();
                        string Filedtif = strdtifService + "\\회원관리" + "\\회원"+"\\" + fileName + ".txt";
                        string[] arr = File.ReadAllLines(Filedtif);

                        for(int j = 0; j<arr.Length; j++)
                        {
                            string[] arr1 = arr[j].Split('\t');
                            if(j==0)
                            {
                                textBox63.Text = arr1[0];
                                textBox62.Text = arr1[2];
                                textBox61.Text = arr1[1];
                                textBox60.Text = arr1[3];
                                textBox149.Text = arr1[4];
                                textBox148.Text = arr1[5];
                            }
                            else
                            {
                                table.Rows.Add(arr1);
                            }
                        }

                    }
                }
            }
            catch
            {

            }
            dataGridView6.DataSource= table;
        }

        private void textBox149_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox148_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fileName = textBox26.Text + textBox23.Text;
                string filename = strdtifService + "\\" + "수리" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox26.Text + "\t");
                writer.Write(textBox23.Text + "\t");


                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (!row.IsNewRow == true)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {

                            int a = Int32.Parse(row.Cells.Count.ToString());
                            if (i == a - 1)
                            {
                                writer.Write(row.Cells[i].Value.ToString());
                            }
                            else
                            {
                                writer.Write(row.Cells[i].Value.ToString() + "\t");
                            }
                        }
                        writer.Write(writer.NewLine);
                    }
                    writer.Write(textBox27.Text);
                }

                writer.Close();
                fi.Close();

                writer.Dispose();
                fi.Dispose();

                textBox26.Text = "";
                textBox23.Text = "";
                textBox27.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox26_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox152.Text = "";
            textBox23.Text = "";
            textBox27.Text = "";
            panel17.Visible = false;
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = dataGridView3.Rows[0].Cells[0].Value.ToString() + dataGridView3.Rows[0].Cells[1].Value.ToString();//데이터 테이블에서 가지고 와야됨
                string filename = strdtifService + "\\" + "수리" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox152.Text + "\t");
                writer.Write(textBox23.Text + "\t");
                

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (!row.IsNewRow == true)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {

                            int a = Int32.Parse(row.Cells.Count.ToString());
                            if (i == a - 1)
                            {
                                writer.Write(row.Cells[i].Value.ToString());
                            }
                            else
                            {
                                writer.Write(row.Cells[i].Value.ToString() + "\t");
                            }
                        }
                        writer.Write(writer.NewLine);
                    }

                }
                writer.Write(textBox27.Text + "\n");

                writer.Close();
                fi.Close();

                writer.Dispose();
                fi.Dispose();

                textBox152.Text = "";
                textBox23.Text = "";
                textBox27.Text = "";

                foreach (DataGridViewRow item in this.dataGridView3.Rows)
                {
                    dataGridView3.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {// 대여 등록 버튼
            panel23.BringToFront();
            panel23.Visible = true;
            button18.Visible = true;
            button18.BringToFront();
            textBox36.Visible = true;
            textBox36.BringToFront();
            textBox36.Text = DateTime.Now.ToString("yy.MM.dd");
        }
        private void button61_Click(object sender, EventArgs e)
        {
            // 대여 정보 취소버튼
            panel23.Visible = false;

            textBox39.Text = "";
            textBox42.Text = "";
            textBox38.Text = "";
            textBox46.Text = "";
            textBox43.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox47.Text = "";
            textBox151.Text = "";
            textBox34.Text = "";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            //대여 정보 수정버튼
            try
            {
                string fileName = textBox39.Text;
                string filename = strdtifService + "\\" + "대여" + "\\" + fileName + ".txt";
                FileStream fi = new FileStream(filename, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fi);

                //File.WriteAllText(filename, textBox57.Text);


                //writer = File.CreateText(filename);

                writer.Write(textBox39.Text + "\t");
                writer.Write(textBox42.Text + "\t");
                writer.Write(textBox38.Text + "\t");
                writer.Write(textBox46.Text + "\t");
                writer.Write(textBox43.Text + "\t");
                writer.Write(textBox50.Text + "\t");
                writer.Write(textBox51.Text + "\t");
                writer.Write(textBox47.Text + "\t");
                writer.Write(textBox36.Text + "\t");
                writer.Write(textBox34.Text + "\t");

                writer.Close();
                fi.Close();
                writer.Dispose();
                fi.Dispose();

                textBox39.Text = "";
                textBox42.Text = "";
                textBox38.Text = "";
                textBox46.Text = "";
                textBox43.Text = "";
                textBox50.Text = "";
                textBox51.Text = "";
                textBox47.Text = "";
                textBox36.Text = "";
                textBox34.Text = "";


            }
            catch (Exception ex)
            {
                
            }
            panel23.Visible = false;

        }

        private void textBox36_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox151_TextChanged(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {
            // 대여 삭제 버튼
            for (int i = 0; i<dataGridView4.Rows.Count; i++)
            {
                if (dataGridView4.Rows[i].Selected == true)
                {
                    string fileName = dataGridView4.Rows[i].Cells[0].Value.ToString();
                    string fileDtif = strdtifService + "\\대여" + "\\" + fileName + ".txt";
                    if(File.Exists(fileDtif))
                    {
                        try
                        {
                            File.Delete(fileDtif);
                        }
                        catch
                        {

                        }
                    }
                }
                

            }
            foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {
                dataGridView4.Rows.RemoveAt(item.Index);
            }

        }

        private void button46_Click(object sender, EventArgs e)
        {
            //미납 관리의 수정버튼
            // 회원정보 패널이 나오며 거기엔 정보가 적혀있음
            // 수정된 정보가 들어감
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            // 블랙리스트의 불러오기 버튼

            DataTable table = new DataTable();
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("선정 날짜", typeof(string));
            table.Columns.Add("이유", typeof(string));
            table.Columns.Add("비고", typeof(string));

            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\블랙리스트", "*.*", SearchOption.AllDirectories);

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
                        string[] str = line.Split('\t');
                        //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가
                        string str2 = str[0] + "\t" + str[4] + "\t" + str[5];
                        string[] arr2 = str2.Split('\t');
                        table.Rows.Add(arr2);
                    }
                }
            }
            dataGridView7.DataSource = table;
        }
        public static int a = 0;

        private void writenotice()
        {
            //a를 가져와서 라벨,텍스트박스
        }
        private void button39_Click_1(object sender, EventArgs e)
        {
            

            //블랙리스트의 등록버튼
            panel43.Visible = true;
            panel43.BringToFront();
            button65.Visible= true;
            button66.Visible= true;
            button66.BringToFront();


            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\블랙리스트", "*.*", SearchOption.AllDirectories);

            DataTable table = new DataTable();
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("가입날짜", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("연락처", typeof(string));
            table.Columns.Add("이메일", typeof(string));

            dataGridView10.DataSource = table;
            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
          
        }

        private void button63_Click(object sender, EventArgs e)
        {
            // 블랙리스트 검색창 확인 버튼
            panel35.Visible = true;
            panel35.BringToFront();
            try
            {
                for (int i = 0; i < dataGridView10.Rows.Count; i++)
                {
                    if (dataGridView10.Rows[i].Selected == true)
                    {
                        string path = strdtifService + "\\회원관리" + "\\회원" + "\\" + dataGridView10.Rows[i].Cells[0].Value.ToString() + ".txt";
                        string[] arr = File.ReadAllLines(path);

                        for(int j = 0; j < arr.Length;j++)
                        {
                            string[] str2 = arr[j].Split('\t');
                            if(j == 0)
                            {
                                textBox81.Text = str2[0];
                                textBox77.Text = str2[1];
                                textBox80.Text = str2[2];
                                textBox76.Text = str2[3];
                            }
                        }
                        panel43.Visible= false;
                    }
                }
            }
            catch
            {

            }
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            // 블랙리스트 검색창 취소
            panel43.Visible = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SearchinGrid10(textBox69.Text);
        }

        private void textBox69_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void SearchinGrid5(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();
            //TextBox 입력된 문자열 string 으로 저장
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\회원", "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요
            //table 선언
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("가입날짜", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("연락처", typeof(string));
            table.Columns.Add("이메일", typeof(string));
            //이거 빠지면 테이블의 열의 개수가 길다고 하면서 터지네요


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for (int j = 0; j < arra.Length; j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가

                            string str2 = str[0] + "\t" + str[4] + "\t" + str[1] + "\t" + str[2] + "\t" + str[3];
                            string[] arr2 = str2.Split('\t');
                            if (arr2[j].Contains(TextName))
                            {
                                table.Rows.Add(arr2);
                            }
                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView5.DataSource = table;
        }
        private void SearchinGrid10(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();
            //TextBox 입력된 문자열 string 으로 저장
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\회원", "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요
            //table 선언
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("가입날짜", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("연락처", typeof(string));
            table.Columns.Add("이메일", typeof(string));
            //이거 빠지면 테이블의 열의 개수가 길다고 하면서 터지네요


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for (int j = 0; j < arra.Length; j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가

                            string str2 = str[0] + "\t" + str[4] + "\t" + str[1] + "\t" + str[2] + "\t" + str[3];
                            string[] arr2 = str2.Split('\t');
                            if (arr2[j].Contains(TextName))
                            {
                                table.Rows.Add(arr2);
                            }
                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView10.DataSource = table;
        }

        private void button65_Click(object sender, EventArgs e)
        {
        // 블랙리스트 등록 회원 정보창 등록 버튼
            string fileName = textBox81.Text;
            string Name = "블랙리스트.txt";

            string path = strdtifService + "\\회원관리" + "\\회원"+"\\" + textBox81.Text + ".txt";
            string filename = strdtifService + "\\회원관리" + "\\블랙리스트" + "\\" + fileName;

            string FolderName = strdtifService + "\\회원관리" + "\\블랙리스트";
            /*
            if(Directory.Exists(FolderName) == false) 
            {
                Directory.CreateDirectory(FolderName);
            }
            */
            FileStream fi = new FileStream(filename + ".txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fi);

            writer.Write(textBox81.Text + "\t");
            writer.Write(textBox77.Text + "\t");
            writer.Write(textBox80.Text + "\t");
            writer.Write(textBox76.Text + "\t");
            writer.Write(textBox89.Text + "\t");
            writer.Write(textBox91.Text + "\t");
            writer.Write(textBox85.Text + "\t");
            writer.Write(textBox87.Text);

            
            try
            {
                if (File.Exists(path))
                {
                    /*
                    foreach (DataGridViewRow item in this.dataGridView5.Rows)
                    {
                        dataGridView5.Rows.RemoveAt(item.Index);
                    }
                    */
                    
                    File.Move(path, filename+".txt");
                    //MessageBox.Show("2222");
                    //File.Delete(path);

                }
            }
                
            catch
            {

            }

            textBox81.Text = "";
            textBox77.Text = "";
            textBox80.Text = "";
            textBox76.Text = "";
            textBox89.Text = "";
            textBox91.Text = "";
            textBox85.Text = "";
            textBox87.Text = "";

            writer.Close();
            fi.Close();

            writer.Dispose();
            fi.Dispose();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            panel35.Visible= false;
        }
        private void SearchinGrid7(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();
            //TextBox 입력된 문자열 string 으로 저장
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\블랙리스트", "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요
            //table 선언
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("선정 날짜", typeof(string));
            table.Columns.Add("이유", typeof(string));
            table.Columns.Add("비고", typeof(string));
            //이거 빠지면 테이블의 열의 개수가 길다고 하면서 터지네요


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for (int j = 0; j < arra.Length; j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가

                            string str2 = str[0] + "\t" + str[4] + "\t" + str[5];
                            string[] arr2 = str2.Split('\t');
                            for (int k = 0; k < arr2.Length; k++)
                            {
                                if (arr2[k].Contains(TextName))
                                {
                                    table.Rows.Add(arr2);
                                }
                            }
                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView7.DataSource = table;
        }
        private void SearchinGrid4(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();

            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\대여" , "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요

            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("대여자", typeof(string));
            table.Columns.Add("품목 명", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("가맹점", typeof(string));
            table.Columns.Add("대여 기간", typeof(string));
            table.Columns.Add("반납 여부", typeof(string));


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                foreach (string str in arra)
                {
                    string[] strr = str.Split('\t');
                    string str2 = strr[0] + '\t' + strr[2] + '\t' + strr[1] + '\t' + strr[3] + '\t' + strr[4] + '\t' + strr[5];
                    string[] strr2 = str2.Split('\t');
                    for(int j = 0; j < strr2.Length;j++)
                    {
                        if (strr2[j].Contains(TextName))
                        {
                            table.Rows.Add(strr2);
                        }
       
                    }                    
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView4.DataSource = table;
        }
        private void SearchinGrid1(string TextName) 
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();

            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\수리", "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요

            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("일 자", typeof(string));
            table.Columns.Add("담당자", typeof(string));
            table.Columns.Add("품목 번호", typeof(string));
            table.Columns.Add("품목명", typeof(string));
            table.Columns.Add("품목고유번호", typeof(string));
            table.Columns.Add("고장원인", typeof(string));
            table.Columns.Add("납부금액", typeof(string));


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                for (int j = 0; j < arra.Length; j++)
                {
                    if (j != arra.Length - 1)
                    {
                        string[] str = arra[j].Split('\t', '\n');
                        if (arra[j].Contains(TextName))
                        {
                            table.Rows.Add(str);
                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView2.DataSource = table;
        }
        private void SearchinGrid11(string TextName)
        {
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();
            //TextBox 입력된 문자열 string 으로 저장
            string SearchAddress = strdtifService + "\\회원관리" + "\\탈퇴" + "\\" + TextName + ".txt";
            //폴더안에 폴더안에 모든 *.txt 파일 이름 배열에 저장
            string[] allfiles = Directory.GetFiles(strdtifService + "\\회원관리" + "\\탈퇴", "*.*", SearchOption.AllDirectories);

            //배열의 길이를 정해주는 것 같아요
            //table 선언
            //가맹점별 현황 그리드뷰

            //그리드 뷰 table 헤드 추가
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("탈퇴날짜", typeof(string));
            table.Columns.Add("생년월일", typeof(string));
            table.Columns.Add("연락처", typeof(string));
            table.Columns.Add("이메일", typeof(string));
            //이거 빠지면 테이블의 열의 개수가 길다고 하면서 터지네요


            //반복문을 이용해서 배열에 저장된 길이 만큼 반복
            for (int i = 0; i < allfiles.Length; i++)
            {
                //폴더 안의 폴더 안의 존재 하는 모든 *.txt 파일의 각각의 내용 배열에 저장
                string[] arra = File.ReadAllLines(allfiles[i]);

                //반복문으로 저장된 배열의 내용을 처리
                for (int j = 0; j < arra.Length; j++)
                {
                    //조건 : 배열이 null이 아니면
                    if (arra[j] != null)
                    {
                        if (j == 0)
                        {
                            string[] str = arra[j].Split('\t');
                            //배열의 문자열을 "\t"로 짜른 문자열을 그리드뷰의 행에 추가

                            string str2 = str[0] + "\t" + str[5] + "\t" + str[1] + "\t" + str[2] + "\t" + str[3];
                            string[] arr2 = str2.Split('\t');
                            table.Rows.Add(arr2);

                        }
                    }
                }
            }
            //table.Rows.Add로 추가한 내용을 띄우고 싶은 그리드 뷰에 뿌리기
            dataGridView11.DataSource = table;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            // 수리 신청/등록 삭제 panel아니요 버튼
            panel55.Visible= false;

        }

        private void button52_Click(object sender, EventArgs e)
        {
            //수리 신청/등록 삭제 paenl 예 버튼
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    string fileName = dataGridView2.Rows[i].Cells[0].Value + dataGridView2.Rows[i].Cells[1].Value.ToString();
                    string fileDtif = strdtifService + "\\수리" + "\\" + fileName + ".txt";
                    if (File.Exists(fileDtif))
                    {
                        try
                        {
                            File.Delete(fileDtif);
                        }
                        catch
                        {

                        }
                    }
                }


            }
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
            panel55.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                panel3.Size = new Size(151, 6);
                checkBox2.Location = new Point(x: 7, y: 117);
                panel25.Location = new Point(x: 7, y: 148);
            }
            else
            {
                panel3.Size = new Size(151, 133);
                checkBox2.Location = new Point(x: 7, y: 243);
                panel25.Location = new Point(x: 7, y: 274);
            }
            timerSliding1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                panel25.Size = new Size(151, 6);
                if(checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                }
                else
                {
                    panel3.Size = new Size(151, 133);
                }
            }
            else
            {
                panel25.Size = new Size(151, 93);
                if (checkBox1.Checked == true)
                {
                    panel3.Size = new Size(151, 6);
                }
                else
                {
                    panel3.Size = new Size(151, 133);
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

            panel25.Height = _posSliding;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void employee() // 사원
        {
            // 대여 현황
            // 블랙리스트 관리
            // 회원탈퇴관리

            button6.Enabled = false;
            button24.Enabled = false;
            button22.Enabled = false;
        }
        public void deputy() // 대리
        {
            // 블랙리스트관리
            button24.Enabled = false;
        }
    }
}
