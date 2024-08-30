using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_Lab02
{ 
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void ReSet()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

   

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int totalAmount = 0;

            if (chkTinHocA.Checked)
                totalAmount += 300000; // Replace with actual price for Tin Hoc A
            if (chkTinHocB.Checked)
                totalAmount += 500000; // Replace with actual price for Tin Hoc B
            if (chkTiengAnhA.Checked)
                totalAmount += 40000; // Replace with actual price for Tieng Anh A
            if (chkTiengAnhB.Checked)
                totalAmount += 600000; // Replace with actual price for Tieng Anh B

            this.txtTongTien.Text = $"{totalAmount:N0} VND"; // Format as currency
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            ReSet();
        }
    }
}
