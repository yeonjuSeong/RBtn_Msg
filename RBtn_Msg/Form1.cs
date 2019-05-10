using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;  // 메시지 버튼 옵션 설정 
        MessageBoxIcon mbi;     // 메시지 버튼 아이콘 설정

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e) // 이벤트 핸들러
        {
            if(this.rbOk.Checked) // == true
            {
                this.mbb = MessageBoxButtons.OK; // 확인 버튼
            } else if(this.rbOkCancel.Checked)
            {
                this.mbb = MessageBoxButtons.OKCancel; // 취소 버튼
            } else if(this.rbYesNo.Checked)
            {
                this.mbb = MessageBoxButtons.YesNo;// 예, 아니오 버튼
            }
            // mbb는 message box button

            if(this.rbError.Checked)
            {
                this.mbi = MessageBoxIcon.Error; // 에러 아이콘
            } else if(rbInformation.Checked)
            {
                this.mbi = MessageBoxIcon.Information; // 정보 아이콘
            } else if(rbQuestion.Checked)
            {
                this.mbi = MessageBoxIcon.Question; // 질문 아이콘
            }
            // mbi는 message box icon

            MessageBox.Show("메시지 박스를 확인하세요.", "알림", mbb, mbi);
        }
    }
}
