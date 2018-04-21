using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGameWindows
{
    public partial class BaseGame : Form
    {
        private BaseballGameEngine bge;
        public BaseGame()
        {
            InitializeComponent();
            //BaseballGameEngine을 생성하고 (생성자), quiz내자.
            bge = new BaseballGameEngine();
            bge.Init();
            MessageBox.Show(bge.GetQuiz());
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            //tNumber 1,2,3에 있는 값을 가져와서
            //string 으로 연결하고
            try //문자열을 입력하는 것 예외처리
            {
                int a = int.Parse(tNumber1.Text);
             }
            catch
            {
                MessageBox.Show("첫 번째 숫자 이상해요!");
                tNumber1.Text = ""; //문자가 들어간 칸 비워주기
                return; //stlike,ball판정가지 않게 return 해주기 
            }
            try //문자열을 입력하는 것 예외처리
            {
                int a = int.Parse(tNumber2.Text);
            }
            catch
            {
                MessageBox.Show("두 번째 숫자 이상해요!");
                tNumber2.Text = ""; //문자가 들어간 칸 비워주기
                return; //stlike,ball판정가지 않게 return 해주기 
            }
            try //문자열을 입력하는 것 예외처리
            {
                int a = int.Parse(tNumber3.Text);
            }
            catch
            {
                MessageBox.Show("세 번째 숫자 이상해요!");
                tNumber3.Text = ""; //문자가 들어간 칸 비워주기
                return; //stlike,ball판정가지 않게 return 해주기 
            }
            string input = tNumber1.Text + tNumber2.Text + tNumber3.Text; //3 6 9를 369로 이어주는 문장이야
            //BaseballGameEngine에 주자.
            //게임엔진이 stlike , ball을 판정한다.
            bge.Play(input);
            //statusLabel에 stlike,ball을 출력하자
            statusLabel.Text = String.Format("Stlike:{0},Ball:{1}",bge.GerStrike(),bge.GetBall()); //test code
            //stlike와 quiz길이가 같으면 ㅊㅋㅊㅋ 메시지 박스 
            if (bge.GerStrike() == bge.GetQuizLength())
            {
                MessageBox.Show("이야~~~ 잘 맞추셨어요!");
                //  Close();
                Clear();
                bge.Init();
            }

            //int i = 0;
            listView1.BeginUpdate();
            ListViewItem item;
            item = new ListViewItem("숫자");
            //http://blog.naver.com/PostView.nhn?blogId=inho860&logNo=220053153176&beginTime=0&jumpingVid=&from=search&redirect=Log&widgetTypeCall=true  


        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tNumber1.Text = "";
            tNumber2.Text = "";
            tNumber3.Text = "";
            statusLabel.Text = "Play Ball!!";
        }

       
        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   int [] array=new int[20];
        //   StringBuilder sb = new StringBuilder();
        //   sb.AppendLine(tNumber1.Text+ tNumber2.Text+ tNumber3.Text);

        //}
    }
}
