using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_StructClass
{
    struct structPlayer
    {
        public int iCount;      // Player가 몇회 진행중인지

        public int iSun;        // 해에 대한 값
        public int iMoon;       // 달에 대한 값
        public int iStar;       // 별에 대한 값

        public int iCardSum;    // 해, 달, 별을 더한 값


        // 값들을 더해서 반환
        public int CardSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }


        // 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
        public string ResultText()
        {
            return string.Format("{0}회) 해: {1}, 달: {2}, 별: {3} → 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }
    }


    class classPlayer
    {
        public int iCount = 1;      // Player가 몇회 진행중인지

        public int iSun = 0;        // 해에 대한 값
        public int iMoon = 0;       // 달에 대한 값
        public int iStar = 0;       // 별에 대한 값

        public int iCardSum = 0;    // 해, 달, 별을 더한 값


        // 값들을 더해서 반환
        public int CardSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }


        // 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
        public string ResultText()
        {
            return string.Format("{0}회) 해: {1}, 달: {2}, 별: {3} → 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        structPlayer _stPlayer1;     // 1번 플레이어
        structPlayer _stPlayer2;     // 2번 플레이어

        Random _rd = new Random();

        classPlayer _clPlayer1 = new classPlayer();
        classPlayer _clPlayer2; // 이렇게만 선언하면 빈 껍데기라서 NPE 발생

        private void iCheckedChanged()
        {
            if(radioPlayer1.Checked) 
            {
                radioPlayer2.Checked = true;
            }   
            else
            {
                radioPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            if(radioPlayer1.Checked) 
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum= _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

                strResult = _stPlayer1.ResultText();

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = _stPlayer2.ResultText();

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChanged();

            if(_stPlayer1.iCount >= 5 && _stPlayer2.iCount>=5) // 5회가 끝나면 게임 set
            {
                if(_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player 1이 이겼습니다.");
                }
                else if (_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player 2가 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21); // 1 ~ 20 까지

            if(radioPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pBoxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21); // 1 ~ 20 까지

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();
        }

        private void pBoxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21); // 1 ~ 20 까지

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();
        }

        private void pBoxNone_Click(object sender, EventArgs e)
        {
            // 아무일 없이 한턴을 넘긴다.

            Result();
        }
    }
}
