using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        String month = "";
        String day = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void namingBtn_Click(object sender, EventArgs e)
        {
            if (this.month1.Checked)
                month = "츠키노";
            else if (this.month2.Checked)
                month = "아이노";
            else if (this.month3.Checked)
                month = "소라노";
            else if (this.month4.Checked)
                month = "미즈노";
            else if (this.month5.Checked)
                month = "하나노";
            else if (this.month6.Checked)
                month = "우츄-우노";
            else if (this.month7.Checked)
                month = "타이요오노";
            else if (this.month8.Checked)
                month = "호시노";
            else if (this.month9.Checked)
                month = "오오모리노";
            else if (this.month10.Checked)
                month = "카게노";
            else if (this.month11.Checked)
                month = "텐노";
            else if (this.month12.Checked)
                month = "유키노";

            if (this.day1.Checked)
                day = "카케라";
            else if (this.day2.Checked)
                day = "텐시";
            else if (this.day3.Checked)
                day = "나미다";
            else if (this.day4.Checked)
                day = "차카시";
            else if (this.day5.Checked)
                day = "유메";
            else if (this.day6.Checked)
                day = "코코로";
            else if (this.day7.Checked)
                day = "시즈쿠";
            else if (this.day8.Checked)
                day = "요-오세이";
            else if (this.day9.Checked)
                day = "온가쿠";
            else if (this.day10.Checked)
                day = "하카리";
            else if (this.day11.Checked)
                day = "사메";
            else if (this.day12.Checked)
                day = "켓쇼오";
            else if (this.day13.Checked)
                day = "사사야키";
            else if (this.day14.Checked)
                day = "오츠케";
            else if (this.day15.Checked)
                day = "오마지나이";
            else if (this.day16.Checked)
                day = "이츠와리";
            else if (this.day17.Checked)
                day = "이노리";
            else if (this.day18.Checked)
                day = "네코";
            else if (this.day19.Checked)
                day = "미치시루베";
            else if (this.day20.Checked)
                day = "쿠마";
            else if (this.day21.Checked)
                day = "호고샤";
            else if (this.day22.Checked)
                day = "마호";
            else if (this.day23.Checked)
                day = "타카라";
            else if (this.day24.Checked)
                day = "타마시이";
            else if (this.day25.Checked)
                day = "오오카미";
            else if (this.day26.Checked)
                day = "키츠네";
            else if (this.day27.Checked)
                day = "오오카미";
            else if (this.day28.Checked)
                day = "츠바사";
            else if (this.day29.Checked)
                day = "오미야게";
            else if (this.day30.Checked)
                day = "카이토오";
            else if (this.day31.Checked)
                day = "하카이샤";

            if (this.month4.Checked || this.month6.Checked || this.month9.Checked || this.month11.Checked || this.month2.Checked)
            {
                if (this.day31.Checked || (this.month2.Checked && this.day30.Checked)) MessageBox.Show("존재하지 않는 날짜입니다. 다시 입력해주세요", "잘못 입력");
            }
            else MessageBox.Show("당신의 이름은 " + month + " " + day + "입니다", "이름짓기");

        }
    }
}
