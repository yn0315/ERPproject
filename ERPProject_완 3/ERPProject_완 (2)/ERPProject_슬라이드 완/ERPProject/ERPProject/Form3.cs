using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;


namespace ERPProject
{
    public partial class Form3 : Form
    {
        Form frn;     
        static Form frma;

        static DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath + "../../../../" + "\\Database");
        string strdtiffullName = dtif.FullName;

        DateTime now = DateTime.Now;

        string Days = DateTime.Now.ToString("yyyy.MM.dd");
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 152;
        const int MIN_SLIDING_WIDTH = 10;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 1;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 152;
        




        public Form3()
        {
            InitializeComponent();
            textBox52.Text = now.ToString("yyyyMMdd");
            textBox90.Text = now.ToString("yyyyMMdd");


        }
        public void setX(object name)
        {
            frma= (Form)name;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel12.Visible= true;
            panel12.BringToFront();
            // 보고서 분기별 등록 버튼
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // 재무별 보고서 분기별 차트 그래프
        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 재무 보고서 분기별 그리드뷰
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 월별 매입 확인
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            // 월별 매입 그래프
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            // 보고서 검색 칸
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //보고서 검색 확인 칸
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 보고서 분기별 그리드뷰
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 보고서 분기별 수정버튼
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel12.Visible= false;
            
            // 분기별 보고서 작성 후 등록 버튼
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 제목 텍스트 박스
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 담당자 텍스트 박스
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 내용 텍스트 박스
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 담당자 직급 입력칸
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 작성 일자 입력칸
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 분기 입력칸
        }

        private void button67_Click(object sender, EventArgs e)
        {
            panel36.Visible= true;
            panel36.BringToFront();
            // 분기별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //월별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //년별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel15.Visible= true;
            panel15.BringToFront();
            // 보고서에서 월별 보고서로 들어가는 버튼
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            // 월별 보고서 검색 창
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // 월별 보고서 검색 창 확인버튼
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //월별 보고서 수정 버튼
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel16.Visible= true;
            panel16.BringToFront();
            //월별 보고서 등록 버튼
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별 보고서 그리드뷰
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 제목 입력칸
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 담당자 입력칸
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 직급 입력칸
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 작성일자 등록칸
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 기간 입력칸
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            // 월별 보고서 내용 입력칸
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel16.Visible= false;
            //월별보고서 작성 내용 등록버튼
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            // 년별보고서 제목 입력칸
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            // 년별 보고서 담당자 입력칸
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            //년별보고서 작성 일자 입력칸
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            //년별 보고서 직급 입력칸
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
           //년별 보고서 년도 입력칸
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            // 년별 보고서 내용 입력칸
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel11.Visible= false;
            // 년별 보고서 작성 등록 버튼
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel10.Visible= true;
            panel10.BringToFront();
            //년별 보고서로 들어가는 버튼
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {
            //분기별보고서
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //월별보고서
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //년별 보고서

        }

        private void button33_Click(object sender, EventArgs e)
        {
            //집계표 패널로 들어가는 버튼
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            //월별 집계표 날자 검색 첫번째 칸
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //월별 집계표 날자 검색 두번째 칸
        }

        private void button35_Click(object sender, EventArgs e)
        {
            // 월별 집계표 날자 검색 검색버튼
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별 집계표 그리드뷰
        }

        private void textBox43_TextChanged_1(object sender, EventArgs e)
        {
            // 사원 전체 연봉 검색창
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //사원 전체 연봉 검색 버튼
            //그리드 뷰에 넣기 위한 테이블 생성
            DataTable table = new DataTable();

            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("부    서", typeof(string));
            table.Columns.Add("직    책", typeof(string));
            table.Columns.Add("연    봉", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀";
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
                            foreach (string line in arr)
                            {
                                string[] arra = line.Split('\t');
                                string position = arra[4];
                                for(int j=0; j<arra.Length;j++)
                                {
                                    if (!arra[4].Contains("사장"))
                                    {
                                        if (arra[j].Contains(textBox43.Text))
                                        {
                                            string txtName = strdtiffullName + "\\직원관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                                            string txtvalue = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                                            if (!File.Exists(txtName))
                                            {
                                                FileInfo a = new FileInfo(txtvalue);
                                                var qwer = File.ReadAllLines(a.FullName);
                                                int asdf = Int32.Parse(qwer[0]);
                                                table.Rows.Add(arra[0], arra[2], arra[3], arra[4], (asdf * 2) * 12);
                                            }
                                        }                                        
                                    }
                                }                                                            
                            }
                        }
                    }
                }
            }

            dataGridView4.DataSource = table;

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //사원 전체 연봉 그리드뷰
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // 사원 전체 연봉 수정 버튼
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //사원 전체 연봉 확인버튼
            DataTable table = new DataTable();

            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("부    서", typeof(string));
            table.Columns.Add("직    책", typeof(string));
            table.Columns.Add("연    봉", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string TextName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급";
            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀";
            string[] TextNameArr = Directory.GetFiles(TextName, "*.*", SearchOption.AllDirectories);

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
                            foreach (string line in arr)
                            {
                                string[] arra = line.Split('\t');
                                string position = arra[4];
                                if (!position.Equals(null))
                                {
                                    string txtName = strdtiffullName + "\\직원관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                                    string txtvalue = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                                    if (!File.Exists(txtName))
                                    {
                                        foreach (var lineA in TextNameArr)
                                        {
                                            string Name = Path.GetFileNameWithoutExtension(lineA);
                                            if (position.Contains(Name))
                                            {
                                                FileInfo a = new FileInfo(txtvalue);
                                                var qwer = File.ReadAllLines(a.FullName);
                                                int asdf = Int32.Parse(qwer[0]);
                                                table.Rows.Add(arra[0], arra[2], arra[3], arra[4], (asdf * 2) * 12);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            dataGridView4.DataSource = table;

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            //사원 전체 연봉
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel18.Visible= true;
            panel18.BringToFront();
            // 사원 전체 연봉으로 들어가는 버튼
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            //자금계획표 날자 왼쪽 칸 검색책
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            //자금계획표 날자 오른쪽 칸 검색책
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            //자금계획표 날짜 검색 버튼
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //자금계획표 그리드뷰
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 제목
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 담당자
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 작성일자
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 예상금액
        }

        private void textBox45_TextChanged_1(object sender, EventArgs e)
        {
            //자금계획서 실행일자
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 내용입력칸
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel24.Visible= false;
            //자금계획서 작성 내용 등록 칸

            DateTime now = DateTime.Now;
            DataTable table = new DataTable();            

            //제목
            string Title = textBox57.Text;
            //담당자
            string Name = textBox54.Text;
            //작성일자
            string YMN = textBox52.Text;
            //예상금액
            string Pay = textBox50.Text;
            //실행일자
            string YMA = textBox45.Text;
            //내용
            string txtName = textBox56.Text;

            //자금계획표 주소
            string FolderAName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\자금계획표";
            //날짜로 폴더 주소
            string folderName = FolderAName+"\\"+now.ToString("yyyyMMdd");
            //제목으로 *.txt 주소
            string fileName = folderName + "\\" + Title + ".txt";
            //자금계획서 작성 각각의 텍스트 내용 배열에 저장
            string[] strings = new string[] {Title, Name,YMN,Pay,YMA,txtName }; 

            table.Columns.Add("등록일자",typeof(string));
            table.Columns.Add("내    용", typeof(string));
            table.Columns.Add("예상금액", typeof(string));
            table.Columns.Add("실행일자", typeof(string));
            table.Columns.Add("담 당 자", typeof(string));
            table.Columns.Add("비    고", typeof(string));
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            //날짜 폴더 없으면 생성
            if (Directory.Exists(FolderAName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderAName);
                foreach (var item in foldername.GetDirectories())
                {                   

                    for (int i = 0; i < strings.Length; i++)
                    {
                        if (!i.Equals(strings.Length - 1))
                        {

                            File.AppendAllText(fileName, strings[i] + "\t");
                        }
                        else
                        {

                            File.AppendAllText(fileName, strings[i]);
                        }
                    }
                }
            }
            /*
            if(Directory.Exists(folderNaem))
            {
                Directory.CreateDirectory(folderNaem);
                for (int i = 0; i < strings.Length; i++)
                {
                    if (!i.Equals(strings.Length - 1))
                    {

                        File.AppendAllText(fileName, strings[i] + "\t");
                    }
                    else
                    {

                        File.AppendAllText(fileName, strings[i]);
                    }
                }
            }
            */

            textBox57.Clear();
            textBox54.Clear();
            textBox52.Clear();
            textBox50.Clear();
            textBox45.Clear();
            textBox56.Clear();

            if (Directory.Exists(FolderAName))
            {
                DirectoryInfo folder = new DirectoryInfo(FolderAName);
                foreach (var item in folder.GetDirectories())
                {
                    string[] arrAll = Directory.GetFiles(FolderAName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i=0; i<arrAll.Length;i++)
                    {
                        string[] arr= File.ReadAllLines(arrAll[i]);
                        foreach(string line in arr)
                        {
                            string[] txtcontent= line.Split('\t');

                            table.Rows.Add(txtcontent[2], txtcontent[0], txtcontent[3], txtcontent[4], txtcontent[1]);

                        }
                    }
                }
            }
            dataGridView5.DataSource= table;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 자금계획서 수정버튼
            DataTable table =new DataTable();

            string FolderAName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\자금계획표";

            table.Columns.Add("등록일자", typeof(string));
            table.Columns.Add("내    용", typeof(string));
            table.Columns.Add("예상금액", typeof(string));
            table.Columns.Add("실행일자", typeof(string));
            table.Columns.Add("담 당 자", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            if (Directory.Exists(FolderAName))
            {
                DirectoryInfo folder = new DirectoryInfo(FolderAName);
                foreach (var item in folder.GetDirectories())
                {
                    string[] arrAll = Directory.GetFiles(FolderAName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < arrAll.Length; i++)
                    {
                        string[] arr = File.ReadAllLines(arrAll[i]);
                        foreach (string line in arr)
                        {
                            string[] txtcontent = line.Split('\t');

                            table.Rows.Add(txtcontent[2], txtcontent[0], txtcontent[3], txtcontent[4], txtcontent[1]);

                        }
                    }
                }
            }
            dataGridView5.DataSource = table;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel24.Visible= true;
            panel24.BringToFront();
            //자금계획서 등록버튼
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel21.Visible= true;
            panel21.BringToFront();
            //자금계획표로 들어가는 버튼
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            //지출 날짜 왼쪽 창 입력
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            //지출 날짜 오른쪽 창 입력
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //지출 검색창 확인 버튼
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //지출 그리드뷰
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //지출 확인버튼

            string volume ;
            string day ;
            DataTable table = new DataTable();

            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("내    역", typeof(string));
            table.Columns.Add("출고수량", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\재고관리" + "\\재고팀" + "\\창고";

            if (Directory.Exists(FolderName))
            {
                string[] arrfolder = Directory.GetFiles(FolderName, "*.*", SearchOption.AllDirectories);
                foreach (string line in arrfolder)
                {

                    string[] arr = File.ReadAllLines(line);
                    //volume += Int32.Parse(arr[4]);
                    for (int j = 0; j < arr.Length; j++)
                    {

                        string[] arra = arr[j].Split('\t', '\n');
                        volume = arra[5];
                        string a = arra[0];
                        char[] chars = a.ToCharArray(0, 10);
                        day = a[0].ToString() + a[1].ToString() + a[2].ToString()
                            + a[3].ToString() + a[5].ToString() + a[6].ToString()
                            + a[8].ToString() + a[9].ToString();
                        string lastFileName = Path.GetFileName(line);
                        table.Rows.Add(day, arra[2]+ arra[3], volume);
                    }
                }
            }

            dataGridView6.DataSource = table;
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 담당자입력칸
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 작성 일자 입력칸
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 총 지출 금액 입력칸
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 실행 날자 입력칸
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel27.Visible= false;
            //지출 내역서 작성 등록
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel26.Visible= true;
            panel26.BringToFront();
            //지출로 들어가는 버튼
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel28.Visible= true;
            panel28.BringToFront();
            //수입으로 들어가는 버튼
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            //수입 날짜 왼쪽 창 입력
        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            //수입 날짜 오른쪽 창 입력
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //수입 검책창 확인
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 수입 그리드뷰
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            //수입내역서 담당자 입력칸
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            //수입 내역서 작성 날자 입력칸
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            //수입내역서 총 수입 입력칸
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            // 수입내역서 실행날짜
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //수입 내역서 내용 그리드뷰
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            //지출
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //지출 내역서 그리드뷰
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel31.Visible= false;
            //수입내역서 작성 등록버튼
        }

        private void button41_Click(object sender, EventArgs e)
        {
            // 수입내역서 확인 버튼
            int volume=0;
            string day ="";
            DataTable table= new DataTable();

            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("내    역", typeof(string));
            table.Columns.Add("입고수량", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\재고관리" + "\\재고팀"+"\\발주";

            if(Directory.Exists(FolderName))
            {
                string[] arrfolder = Directory.GetFiles(FolderName , "*.*", SearchOption.AllDirectories);
                foreach(string line in arrfolder)
                {
                    
                    string[] arr = File.ReadAllLines(line);
                    //volume += Int32.Parse(arr[4]);
                    for(int j=0; j < arr.Length; j++)
                    {
                        
                        string[] arra = arr[j].Split('\t','\n');
                        volume = Int32.Parse(arra[4]);
                        string a = arra[0];
                        char[] chars= a.ToCharArray(0,10);
                        day = a[0].ToString()+ a[1].ToString() + a[2].ToString() 
                            + a[3].ToString() + a[5].ToString() + a[6].ToString() 
                            + a[8].ToString() + a[9].ToString();
                        //string lastFileName = Path.GetFileName(line);

                        table.Rows.Add(day.ToString(), arra[1].ToString()
                            + arra[2].ToString(), volume.ToString());
                    }
                }
            }
            
            dataGridView9.DataSource= table;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //수입내역서 등록버튼
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            //수입
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel34.Visible= true;
            panel34.BringToFront();
            //직원경조사로 들어가는 버튼
        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            //직원 경조사
        }

        private void textBox98_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 날자 왼쪽 검색칸  
        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 날짜 오른쪽 검색칸
        }

        private void button47_Click(object sender, EventArgs e)
        {
            // 직원 경조사 날짜 검색 확인버튼
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //직원 경조사 그리드뷰
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //직원 경조사 수정
            //그리드 뷰에 넣기 위한 테이블 생성           
            DataTable table = new DataTable();

            //그리드뷰 헤더 선언
            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("사 원 명", typeof(string));
            table.Columns.Add("경 조 사", typeof(string));
            table.Columns.Add("금    액", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\경조사";

            if (Directory.Exists(FolderName))
            {
              
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {
                   
                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < arrfolder.Length; i++)
                    {
                      
                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach (string line in arr)
                        {
                          
                            string[] arr2 = line.Split('\t', '\n');

                            table.Rows.Add(arr2[3], arr2[0], arr2[1], arr2[2],"100000");


                        }

                    }

                }

            }

            dataGridView11.DataSource = table;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //직원 경조사 등록




            panel35.Visible= true;
            panel35.BringToFront();
            
        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 관련 서류 사원번호
        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            // 직원 경조사 관련 서류 사원명
        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 관련 서류 종류
        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 작성일자
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 내용 입력칸
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel35.Visible= false;
            //직원 경조사 내용 등록



            string FolderName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\경조사";
            //사원번호
            string Number = textBox88.Text;
            //사원명
            string Name = textBox86.Text;
            //작성일자
            textBox90.Text = Days;
            //종류
            string Sort = textBox92.Text;            
            //내용
            string Memo = textBox99.Text;

            string path = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\경조사" + "\\" + Sort + "\\" + Number + ".txt";

            string[] strings = new string[] { Number, Name, Sort, Days, Memo };

            if (Directory.Exists(FolderName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {                    
                    if (!Number.Equals(null) & !Name.Equals(null) & !Sort.Equals(null) & !Days.Equals(null) & !Memo.Equals(null))
                    {
                        if (item.Name.Equals(Sort))
                        {
                            for (int i = 0; i < strings.Length; i++)
                            {
                                if (!i.Equals(strings.Length - 1))
                                {
                                    
                                    File.AppendAllText(path, strings[i] + "\t");
                                }
                                else
                                {
                                    
                                    File.AppendAllText(path, strings[i]+"\n");
                                }
                            }
                        }
                    }


                }


            }
            /*
                if (!Number.Equals(null) & !Name.Equals(null) & !Sort.Equals(null) & !Days.Equals(null) & !Memo.Equals(null))
                {
                

                for (int i = 0; i < strings.Length; i++)
                {
                    if (!i.Equals(strings.Length - 1))
                    {

                        File.AppendAllText(path, strings[i] + "\t");
                    }
                    else
                    {
                        File.AppendAllText(path, strings[i]);
                    }
                }
            }
            */
            

            textBox88.Clear();
            textBox86.Clear();
            textBox92.Clear();
            textBox90.Clear();
            textBox99.Clear();

            //그리드 뷰에 넣기 위한 테이블 생성           
            DataTable table = new DataTable();

            //그리드뷰 헤더 선언
            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("사 원 명", typeof(string));
            table.Columns.Add("경 조 사", typeof(string));
            table.Columns.Add("금    액", typeof(string));
            table.Columns.Add("비    고", typeof(string));


   
            //string txtvalue = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
            if (Directory.Exists(FolderName))
            {

                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {

                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < arrfolder.Length; i++)
                    {

                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach (string line in arr)
                        {

                            string[] arr2 = line.Split('\t');
                            string PositionName = arr2[0].ToString();
                            table.Rows.Add(arr2[3], arr2[0], arr2[1], arr2[2],"100000");

                        }

                    }

                }

            }
  


            dataGridView11.DataSource = table;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel40.Visible= true;
            panel40.BringToFront();
            panel41.Visible = true;          
            //일용직 급여 들어가는 버튼
        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여 검색창
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //일용직 급여 검색창 확인 버튼
            DataTable table = new DataTable();
            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀" + "\\일용직";

            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("연 락 처", typeof(string));
            table.Columns.Add("계    좌", typeof(string));
            table.Columns.Add("주    소", typeof(string));

            if (Directory.Exists(FolderName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {
                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < arrfolder.Length; i++)
                    {
                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach (string line in arr)
                        {
                            string[] arra = line.Split('\t');
                            for (int j = 0; j < arra.Length; j++)
                            {
                                if (arra[j].Contains(textBox111.Text))
                                {
                                    table.Rows.Add(arra);
                                }
                            }
                        }
                    }
                }
            }

            dataGridView10.DataSource = table;
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //일용직 급여 그리드뷰
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //일용직 급여 수정버튼
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //일용직 급여 확인버튼
            DataTable table = new DataTable();
            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀" + "\\일용직";

            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("연 락 처", typeof(string));
            table.Columns.Add("계    좌", typeof(string));
            table.Columns.Add("주    소", typeof(string));

            if (Directory.Exists(FolderName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {
                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for (int i = 0; i < arrfolder.Length; i++)
                    {
                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach (string line in arr)
                        {
                            string[] arra = line.Split('\t','\n');
                            

                            table.Rows.Add(arra);
                        }
                    }
                }
            }
            dataGridView10.DataSource= table;

        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 일한 지역/부서
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //일용직 급여의 캘린더
            DataTable table = new DataTable();
            string YMdata = monthCalendar1.SelectionStart.ToString("yyMM");
            string Daydata = monthCalendar1.SelectionStart.ToString("dd");

            string FileName = strdtiffullName + "\\직원관리" + "\\인사팀" + "\\일용직" + "\\" + YMdata + "\\" + Daydata + ".txt";

            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("연 락 처", typeof(string));
            table.Columns.Add("계    좌", typeof(string));
            table.Columns.Add("주    소", typeof(string));


            FileInfo file = new FileInfo(FileName);
            if (file.Exists)
            {
                string[] arr = File.ReadAllLines(file.FullName);
                foreach (string line in arr)
                {
                    if (line != null)
                    {
                        table.Rows.Add(line.Split('\t', '\n'));
                    }
                }
            }
            dataGridView10.DataSource = table;
        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 이름
        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 전화번호
        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 계좌
        }

        private void button49_Click(object sender, EventArgs e)
        {

            //일용직 급여 확인창의 확인버튼
        }

        private void button53_Click(object sender, EventArgs e)
        {
            // 일용직 급여 삭제버튼
            foreach (DataGridViewRow item in this.dataGridView10.SelectedRows)
            {
                dataGridView10.Rows.RemoveAt(item.Index);
            }


        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {
            //일용직 급여
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel42.Visible= true;
            panel42.BringToFront();
            //퇴직급여로 들어가는 창
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            //퇴직급여 검색창
            
        }

        private void button57_Click(object sender, EventArgs e)
        {
            
            //퇴직급여 검색 확인창
            DataTable table = new DataTable();

            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("부    서", typeof(string));
            table.Columns.Add("직    책", typeof(string));
            table.Columns.Add("입 사 일", typeof(string));
            table.Columns.Add("퇴 사 일", typeof(string));

            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀"+ "\\퇴직인원";
            if(Directory.Exists(FolderName))
            {
                DirectoryInfo foldername= new DirectoryInfo(FolderName);
                foreach(var item in foldername.GetDirectories())
                {
                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for(int i = 0; i<arrfolder.Length;i++)
                    {
                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach(string line in arr)
                        {
                            string[] arra = line.Split('\t');
                            for (int j=0; j<arra.Length;j++)
                            {
                                if (arra[j].Contains(textBox121.Text))
                                {
                                    if(textBox121.Text.Length> 0)
                                    {
                                        string a = arra[0];
                                        char[] chars = a.ToCharArray(0, 8);
                                        string YMD = chars[0].ToString() + chars[1].ToString() + chars[2].ToString() + chars[3].ToString() + "." + chars[4].ToString() + chars[5].ToString() + "." + chars[6].ToString() + chars[7].ToString();


                                        string b = arra[4];
                                        char[] charss = b.ToCharArray(0, 8);
                                        string YMDA = charss[0].ToString() + charss[1].ToString() + charss[2].ToString() + charss[3].ToString() + "." + charss[4].ToString() + charss[5].ToString() + "." + charss[6].ToString() + charss[7].ToString();

                                        table.Rows.Add(arra[0], arra[1], arra[2], arra[3], YMD, YMDA);
                                        dataGridView12.DataSource = table;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            
            textBox121.Clear();
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //퇴직급여 그리드뷰
        }
        
        
        private void button56_Click(object sender, EventArgs e)
        {
            //퇴직급여 수정버튼
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //panel45.Visible= true;
            //panel45.BringToFront();
            //퇴직 급여 확인버튼
            DataTable table = new DataTable();            

            table.Columns.Add("사원번호", typeof(string));
            table.Columns.Add("이    름", typeof(string));
            table.Columns.Add("부    서", typeof(string));
            table.Columns.Add("직    책", typeof(string));
            table.Columns.Add("입 사 일", typeof(string));
            table.Columns.Add("퇴 사 일", typeof(string));

            string FolderName = strdtiffullName + "\\직원관리" + "\\인사팀"+"\\퇴직인원";
            if (Directory.Exists(FolderName))
            {
                DirectoryInfo foldername = new DirectoryInfo(FolderName);
                foreach (var item in foldername.GetDirectories())
                {
                    string[] arrfolder = Directory.GetFiles(FolderName + "\\" + item.Name, "*.*", SearchOption.AllDirectories);
                    for(int i=0; i<arrfolder.Length;i++)
                    {
                        string[] arr = File.ReadAllLines(arrfolder[i]);
                        foreach(string line in arr)
                        {
                            string[] arra = line.Split('\t');
                            string a = arra[0];
                            char[] chars= a.ToCharArray(0,8);
                            string YMD = chars[0].ToString() + chars[1].ToString() + chars[2].ToString() + chars[3].ToString() + "." + chars[4].ToString() + chars[5].ToString() + "." + chars[6].ToString() + chars[7].ToString();
                            
                            
                            string b = arra[4];
                            char[] charss = b.ToCharArray(0,8);
                            string YMDA = charss[0].ToString() + charss[1].ToString() + charss[2].ToString() + charss[3].ToString() + "." + charss[4].ToString() + charss[5].ToString() + "." + charss[6].ToString() + charss[7].ToString();

                            table.Rows.Add(arra[0], arra[1], arra[2], arra[3], YMD, YMDA);                     
                        }
                        

                    }
                    
                    
                    
                }
            }

            dataGridView12.DataSource = table;
            textBox121.Clear();
        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {
            //퇴직급여창
        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원번호
        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원명
        }

        private void textBox117_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 부서명
        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원직책
        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 입사일
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 퇴사일
        }

        private void textBox127_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 근무기간
        }

        private void textBox129_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 퇴직금액
        }

        private void button54_Click(object sender, EventArgs e)
        {
            panel45.Visible= false;
            textBox127.Clear();
            //퇴직 급여 관리 내용 확인버튼
            
        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {
            //퇴직급여 관리
        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {
            //일용직 급여 확인창
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            // 직원 경조사 관련 서류
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            //수입내역 등록
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            //지출 내역 창
        }

        private void button39_Click(object sender, EventArgs e)
        {
            // 지출 등록 창
            panel27.Visible= true;
            panel27.BringToFront();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            //자금계획표
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            //자금계획서
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            // 년 별 보고서창
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel11.Visible= true;
            panel11.BringToFront();
            //년별 보고서 등록
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //년별 보고서 수정
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //월별 보고서 등록 창
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel36.Visible= true;
            panel36.BringToFront();
            // 보고서 창으로 들어가는 버튼
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //분기별 보고서
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

            panel14.Height = _posSliding;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                panel14.Size = new Size(152, 6);
                checkBox2.Location = new Point(x: 3, y: 121);
                panel15.Location = new Point(x: 3, y: 151);

                if(checkBox2.Checked == true)
                {
                    panel15.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 164);
                    panel16.Location = new Point(x: 3, y: 193);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 205);
                        //panel4.Location = new Point(x: 3, y:234);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 254);
                        //panel4.Location = new Point(x: 3, y: 283);
                    }
                }
                else
                {
                    panel15.Size = new Size(152, 116);
                    checkBox3.Location = new Point(x: 3, y: 275);
                    panel16.Location = new Point(x: 3, y:304);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 314);
                        //panel4.Location = new Point(x: 3, y: 343);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 367);
                        //panel4.Location = new Point(x: 3, y: 396);
                    }
                }
            }
            else
            {
                panel14.Size = new Size(152, 120);
                checkBox2.Location = new Point(x: 3, y: 232);
                panel15.Location = new Point(x: 3, y: 262);

                if(checkBox2.Checked == true)
                {
                    panel15.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 274);
                    panel16.Location = new Point(x: 3, y: 303);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 315);
                        //panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 362);
                        //panel4.Location = new Point(x: 3, y: 391);
                    }
                }
                else
                {
                    panel15.Size = new Size(152, 116);
                    checkBox3.Location = new Point(x: 3, y: 385);
                    panel16.Location = new Point(x: 3, y: 414);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 426);
                        //panel4.Location = new Point(x: 3, y: 455);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 481);
                        //panel4.Location = new Point(x: 3, y: 511);
                    }    
                }
            }
            timerSliding1.Start();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                panel15.Size = new Size(152, 6);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 164);
                    panel16.Location = new Point(x: 3, y: 193);
                    
                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 205);
                        //panel4.Location = new Point(x: 3, y: 234);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 254);
                        //panel4.Location = new Point(x: 3, y: 283);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox3.Location = new Point(x: 3, y: 274);
                    panel16.Location = new Point(x: 3, y: 303);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 315);
                        //panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 362);
                        //panel4.Location = new Point(x: 3, y: 391);
                    }
                }
            }
            else
            {
                panel15.Size = new Size(152, 116);
                if(checkBox1.Checked== true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y:275);
                    panel16.Location = new Point(x: 3, y: 304);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 314);
                        //panel4.Location = new Point(x: 3, y: 343);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 367);
                        //panel4.Location = new Point(x: 3, y: 396);
                    }
                }
                else
                {
                    panel14.Size = new Size(150, 120);
                    checkBox3.Location = new Point(x: 3, y: 385);
                    panel16.Location = new Point(x: 3, y: 414);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 426);
                        //panel4.Location = new Point(x: 3, y: 455);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        //checkBox4.Location = new Point(x: 3, y: 481);
                        //panel4.Location = new Point(x: 3, y: 511);
                    }
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

            panel15.Height = _posSliding;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                panel16.Size = new Size(152, 6);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 205);
                        //panel4.Location = new Point(x: 3, y: 234);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        //checkBox4.Location = new Point(x: 3, y: 314);
                        //panel4.Location = new Point(x: 3, y: 343);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);
                    
                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 315);
                        //panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        //checkBox4.Location = new Point(x: 3, y: 426);
                        //panel4.Location = new Point(x: 3, y: 455);
                    }
                }
            }
            else
            {
                panel16.Size = new Size(152, 53);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 254);
                        //panel4.Location = new Point(x: 3, y: 283);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        //checkBox4.Location = new Point(x: 3, y: 367);
                        //panel4.Location = new Point(x: 3, y: 396);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        //checkBox4.Location = new Point(x: 3, y: 362);
                        //panel4.Location = new Point(x: 3, y: 391);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        //checkBox4.Location = new Point(x: 3, y: 481);
                        //panel4.Location = new Point(x: 3, y: 511);
                    }
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

            panel16.Height = _posSliding;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox4.Checked == true)
            //{
            //    panel4.Size = new Size(152, 6);

            //    if(checkBox1.Checked == true)
            //    {
            //        panel14.Size = new Size(152, 6);
            //        checkBox2.Location = new Point(x: 3, y: 121);
            //        panel15.Location = new Point(x: 3, y: 151);

            //        if(checkBox2.Checked == true)
            //        {
            //            panel15.Size = new Size(152, 6);
            //            checkBox3.Location = new Point(x: 3, y: 164);
            //            panel16.Location = new Point(x: 3, y: 193);
            //        }
            //        else
            //        {
            //            panel15.Size = new Size(152, 116);
            //            checkBox3.Location = new Point(x: 3, y: 275);
            //            panel16.Location = new Point(x: 3, y: 304);
            //        }
            //    }
            //    else
            //    {
            //        panel14.Size = new Size(152, 120);
            //        checkBox2.Location = new Point(x: 3, y: 232);
            //        panel15.Location = new Point(x: 3, y: 262);

            //        if(checkBox2.Checked == true)
            //        {
            //            panel15.Size = new Size(152, 6);
            //            checkBox3.Location = new Point(x: 3, y: 274);
            //            panel16.Location = new Point(x: 3, y: 303);
            //        }
            //        else
            //        {
            //            panel15.Size = new Size(152, 116);
            //            checkBox3.Location = new Point(x: 3, y: 385);
            //            panel16.Location = new Point(x: 3, y: 414);
            //        }

            //    }

            //}
            //else
            //{
            //    panel14.Size = new Size(152, 48);

            //    if (checkBox1.Checked == true)
            //    {
            //        panel14.Size = new Size(152, 6);
            //        checkBox2.Location = new Point(x: 3, y: 121);
            //        panel15.Location = new Point(x: 3, y: 151);

            //        if (checkBox2.Checked == true)
            //        {
            //            panel15.Size = new Size(152, 6);
            //            checkBox3.Location = new Point(x: 3, y: 164);
            //            panel16.Location = new Point(x: 3, y: 193);
            //        }
            //        else
            //        {
            //            panel15.Size = new Size(152, 116);
            //            checkBox3.Location = new Point(x: 3, y: 275);
            //            panel16.Location = new Point(x: 3, y: 304);
            //        }
            //    }
            //    else
            //    {
            //        panel14.Size = new Size(152, 120);
            //        checkBox2.Location = new Point(x: 3, y: 232);
            //        panel15.Location = new Point(x: 3, y: 262);

            //        if (checkBox2.Checked == true)
            //        {
            //            panel15.Size = new Size(152, 6);
            //            checkBox3.Location = new Point(x: 3, y: 274);
            //            panel16.Location = new Point(x: 3, y: 303);
            //        }
            //        else
            //        {
            //            panel15.Size = new Size(152, 116);
            //            checkBox3.Location = new Point(x: 3, y: 385);
            //            panel16.Location = new Point(x: 3, y: 414);
            //        }
            //    }
            //}
            //timerSliding4.Start();
        }

        private void timerSliding4_Tick(object sender, EventArgs e)
        {
            //if (checkBox4.Checked == true)
            //{
            //    //슬라이딩 메뉴를 숨기는 동작
            //    _posSliding -= STEP_SLIDING;
            //    if (_posSliding <= MIN_SLIDING_WIDTH)
            //        timerSliding4.Stop();
            //}
            //else
            //{
            //    //슬라이딩 메뉴를 보이는 동작
            //    _posSliding += STEP_SLIDING;
            //    if (_posSliding >= MAX_SLIDING_WIDTH)
            //        timerSliding4.Stop();
            //}

            //panel4.Height = _posSliding;
        }

        private void textBox131_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetText(string data)
        {
            textBox131.Text = data;
        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrieView12_CellMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            textBox113.Text = dataGridView12.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView12_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //사원번호
            textBox113.Text = this.dataGridView12.CurrentRow.Cells[0].Value.ToString();
            //사원명
            textBox100.Text = this.dataGridView12.CurrentRow.Cells[1].Value.ToString();
            //부서
            textBox117.Text = this.dataGridView12.CurrentRow.Cells[2].Value.ToString();
            //직책
            textBox115.Text = this.dataGridView12.CurrentRow.Cells[3].Value.ToString();
            //입사일
            textBox125.Text = this.dataGridView12.CurrentRow.Cells[4].Value.ToString();
            //퇴사일
            textBox122.Text = this.dataGridView12.CurrentRow.Cells[5].Value.ToString();

            string[] YMD= this.dataGridView12.CurrentRow.Cells[4].Value.ToString().Split('.');
            string[] YMDA= this.dataGridView12.CurrentRow.Cells[5].Value.ToString().Split('.');
            


            int[] AAA = { Int32.Parse(YMDA[0])- Int32.Parse(YMD[0]), Int32.Parse(YMDA[1])- Int32.Parse(YMD[1]), Int32.Parse(YMDA[2])- Int32.Parse(YMD[2]) };

            string a= AAA[0].ToString();
            string b= AAA[1].ToString();
            string c= AAA[2].ToString();

            //근무기간
            if (AAA[0]>0)
            {
                textBox127.Text += a + "년";
            }    
            if (AAA[1]>0) 
            {
                textBox127.Text += b + "월";
            }
            if (AAA[2]>0) 
            {
                textBox127.Text += c + "일";
            }


            //퇴직급
            if (AAA[0]>5)
            {
                string position = this.dataGridView12.CurrentRow.Cells[3].Value.ToString();
                string txtName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                FileInfo file = new FileInfo(txtName);

                var money = File.ReadAllLines(file.FullName);

                int basepay = Int32.Parse(money[0]);

                int qwer = (basepay * 4)* AAA[0];                

                textBox129.Text= qwer.ToString();

            }
            else
            {
                string position = this.dataGridView12.CurrentRow.Cells[3].Value.ToString();
                string txtName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\기본급" + "\\" + position + ".txt";
                FileInfo file = new FileInfo(txtName);

                var money = File.ReadAllLines(file.FullName);

                int basepay = Int32.Parse(money[0]);

                int qwer = (basepay * 2) * AAA[0];


                textBox129.Text = qwer.ToString();
            }


            //textBox129.Text = this.dataGridView12.CurrentRow.Cells[0].Value.ToString();

            panel45.Visible = true;

            
        }
        public void TextGenerate(string path)
        {
            
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable table = new DataTable();
            string YMFullName = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");
            string volume;
            string day;
            

            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("내    역", typeof(string));
            table.Columns.Add("입고수량", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\재고관리" + "\\재고팀" + "\\발주";

            if (Directory.Exists(FolderName))
            {
                string[] arrfolder = Directory.GetFiles(FolderName, "*.*", SearchOption.AllDirectories);
                foreach (string line in arrfolder)
                {

                    string[] arr = File.ReadAllLines(line);
                    //volume += Int32.Parse(arr[4]);
                    for (int j = 0; j < arr.Length; j++)
                    {
                        
                        string[] arra = arr[j].Split('\t', '\n');
                        
                        if (arra[0].Contains(YMFullName)) 
                        {
                            volume = arra[4];
                            string a = arra[0];
                            char[] chars = a.ToCharArray(0, 10);
                            day = a[0].ToString() + a[1].ToString() + a[2].ToString()
                                + a[3].ToString() + a[5].ToString() + a[6].ToString()
                                + a[8].ToString() + a[9].ToString();
                            //string lastFileName = Path.GetFileName(line);

                            table.Rows.Add(day, arra[1]+ arra[2], volume);
                        }                        
                    }
                }
            }
            dataGridView9.DataSource = table;
        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable table = new DataTable();
            string YMFullName = monthCalendar3.SelectionStart.ToString("yyyy-MM-dd");
            string volume;
            string day;


            table.Columns.Add("일    자", typeof(string));
            table.Columns.Add("내    역", typeof(string));
            table.Columns.Add("출고수량", typeof(string));
            table.Columns.Add("비    고", typeof(string));

            string FolderName = strdtiffullName + "\\재고관리" + "\\재고팀" + "\\창고";

            if (Directory.Exists(FolderName))
            {
                string[] arrfolder = Directory.GetFiles(FolderName, "*.*", SearchOption.AllDirectories);
                foreach (string line in arrfolder)
                {

                    string[] arr = File.ReadAllLines(line);
                    //volume += Int32.Parse(arr[4]);
                    for (int j = 0; j < arr.Length; j++)
                    {

                        string[] arra = arr[j].Split('\t', '\n');

                        if (arra[0].Contains(YMFullName))
                        {
                            volume = arra[4];
                            volume = arra[5];
                            string a = arra[0];
                            char[] chars = a.ToCharArray(0, 10);
                            day = a[0].ToString() + a[1].ToString() + a[2].ToString()
                                + a[3].ToString() + a[5].ToString() + a[6].ToString()
                                + a[8].ToString() + a[9].ToString();
                            string lastFileName = Path.GetFileName(line);
                            table.Rows.Add(day, arra[2] + arra[3], volume);
                        }
                    }
                }
            }
            dataGridView6.DataSource = table;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            panel35.Visible= false;
        }

        private void button35_Click_2(object sender, EventArgs e)
        {
            panel24.Visible= false;
        }
        public void employee() // 사원
        {
            // 자금계획표
            // 퇴직급여
            // 보고서

            button22.Enabled = false;
            button3.Enabled = false;
        }
        public void deputy() // 대리
        {
            // 자금계획표 안됨
            // 보고서
            button22.Enabled = false;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            //삭제
            TextFileDelete();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView5.Rows.RemoveAt(item.Index);
            }
        }
        private void TextFileDelete()
        {
            //자금계획표 주소
            string FolderAName = strdtiffullName + "\\재무관리" + "\\재무팀" + "\\자금계획표";

            int rowindex = dataGridView5.CurrentRow.Index;

            string RowIndexSelectElement = dataGridView5.Rows[rowindex].Cells[0].Value.ToString();
            string RowIndexSelectElementA = dataGridView5.Rows[rowindex].Cells[1].Value.ToString();

            //textBox152.Text = RowIndexSelectElement;

            string dtifa = FolderAName + "\\" + RowIndexSelectElement + "\\" + RowIndexSelectElementA + ".txt";
            File.Delete(dtifa);
        }
    }
}
