using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CP = CSharp_AdditionalClass;

namespace CSharp_StructClass
{
    public partial class Form1 : Form
    {

        struct structPlayer
        {
            public int iCount;      // Player가 몇회 진행중인지

            public int iSun;        // 해에 대한 값
            public int iMoon;       // 달에 대한 값
            public int iStar;       // 별에 대한 값

            public int iCardSum;    // 해, 달, 별을 더한 값


            //// 값들을 더해서 반환
            //public int CardSum(int iSun, int iMoon, int iStar)
            //{
            //    return iSun + iMoon + iStar;
            //}


            //// 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
            //public string ResultText()
            //{
            //    return string.Format("{0}회) 해: {1}, 달: {2}, 별: {3} → 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            //}
        }


        public Form1()
        {
            InitializeComponent();
        }

        structPlayer _stPlayer1;     // 1번 플레이어
        structPlayer _stPlayer2;     // 2번 플레이어

        Random _rd = new Random();

        CSharp_AdditionalClass.CPlayer _clPlayer1 = new CSharp_AdditionalClass.CPlayer();
        CSharp_AdditionalClass.CPlayer _clPlayer2 = new CSharp_AdditionalClass.CPlayer(); 

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


        CSharp_AdditionalClass.CPlayer cPlayer = new CSharp_AdditionalClass.CPlayer();

        private void Result()
        {
            string strResult = string.Empty;

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = cPlayer.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

                strResult = cPlayer.ResultText(_stPlayer1.iCount, _stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar, _stPlayer1.iCardSum);

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = cPlayer.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = cPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar, _stPlayer2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChanged();


            // 결과 체크
            if (_stPlayer1.iCount == _stPlayer2.iCount)
            {
                lboxSituationBoard.Items.Add(cPlayer.ComparePlayerScore(_stPlayer2.iCount, _stPlayer1.iCardSum, _stPlayer2.iCardSum));

                if(_stPlayer2.iCount==5)
                {
                    lboxSituationBoard.Items.Add(cPlayer.PlayerResult(_stPlayer1.iCardSum, _stPlayer2.iCardSum));
                }
            }
        }
    }
}
