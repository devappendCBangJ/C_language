using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_4_Mole
{
    public partial class Form1 : Form
    {
        // 초기화
        Random rnd = new Random();
        bool[] isOpen = new bool[5] { false, false, false, false, false };
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 랜덤 변수 생성
            int idx = rnd.Next(5);

            // 그림 열기 by 랜덤 변수
            if (idx == 0) picCard00.Image = Properties.Resources.open;
            else if (idx == 1) picCard01.Image = Properties.Resources.open;
            else if (idx == 2) picCard02.Image = Properties.Resources.open;
            else if (idx == 3) picCard03.Image = Properties.Resources.open;
            else picCard04.Image = Properties.Resources.open;

            // 타이머 전환
            timOpen.Enabled = false;
            timClose.Enabled = true;

            // 카드 상태 기억
            isOpen[idx] = true;
        }

        private void timClose_Tick(object sender, EventArgs e)
        {
            // 카드 닫기
            CloseAll();
        }

        private void picCard_MouseDown(object sender, MouseEventArgs e) // Event 통합 ♣♣♣
        {
            // sender : 5개의 picBox 중 하나

            // 카드 클릭 여부 확인
            int ihit;
            PictureBox pic = sender as PictureBox; // ♣♣♣
            if (pic.Name == "picCard00") ihit = 0; // ♣♣♣
            else if (pic.Name == "picCard01") ihit = 1;
            else if (pic.Name == "picCard02") ihit = 2;
            else if (pic.Name == "picCard03") ihit = 3;
            else ihit = 4;

            // 카드 클릭 시 행동
            if(isOpen[ihit]) // for문 없이 이게 가능??? ihit는 지정된 값이니까 가능 ♣♣
            {
                int score = Convert.ToInt32(lblScore.Text);
                score++;
                lblScore.Text = score.ToString();
                CloseAll();
            }
        }

        private void CloseAll()
        {
            // 그림 전부 닫기
            picCard00.Image = Properties.Resources.closed; // ♣♣♣
            picCard01.Image = Properties.Resources.closed;
            picCard02.Image = Properties.Resources.closed;
            picCard03.Image = Properties.Resources.closed;
            picCard04.Image = Properties.Resources.closed;

            // 타이머 전환
            timOpen.Enabled = true;
            timClose.Enabled = false;

            // 카드 상태 기억
            for (int i = 0; i < 5; i++) isOpen[i] = false;
        }
    }
}
