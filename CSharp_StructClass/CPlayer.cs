using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdditionalClass
{
    internal class CPlayer
    {
        public int iCount = 0;      // Player가 몇회 진행중인지

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
}
