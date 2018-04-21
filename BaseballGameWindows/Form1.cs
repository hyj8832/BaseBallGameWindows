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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새창NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseGame bg = new BaseGame();
            bg.MdiParent = this; //class Form1이 this야 (새창이 Form 창 안에 생기는 것 )
            bg.Show();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           // Application.Exit();//윗 줄 코드와 동일하다. 하지만 이 코드는 완벽한 끝맺음은 없는거야. Close()가 더 좋은것.
        }

        private void 계단식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //배치를 내가 어떻게 할 것인지 Casecade 계단처럼 생긴 것
        }

        private void 가로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 세로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

       
    }
}
