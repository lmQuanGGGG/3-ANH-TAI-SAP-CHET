using GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BanHang : Form
    {
        private Model1 context;
        public BanHang()
        {
            InitializeComponent();
            context = new Model1();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void DoDuLieuDSHH(List<Hang> dsHH)
        {
            dgvHangHoa.Rows.Clear();
            foreach (var item in dsHH)
            {
                int index = dgvHangHoa.Rows.Add();
                dgvHangHoa.Rows[index].Cells[0].Value = item.MaHang;
                dgvHangHoa.Rows[index].Cells[1].Value = item.TenHang;
                dgvHangHoa.Rows[index].Cells[2].Value = item.SoLuong;
                dgvHangHoa.Rows[index].Cells[3].Value = item.LoaiHang.TenLoaiHang;
                dgvHangHoa.Rows[index].Cells[4].Value = item.DonGiaBan;
            }
        }
        private void DoDuLieuDSHangHoa(List<LoaiHang> dsHangHoa)
        {
            cbxLoaiMatHang.DataSource = dsHangHoa;
            cbxLoaiMatHang.ValueMember = "MaLoaiHang";
            cbxLoaiMatHang.DisplayMember = "TenLoaiHang";
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            List<LoaiHang> dsHangHoa = context.LoaiHangs.ToList();
            List<Hang> dsHH = context.Hangs.ToList();
            DoDuLieuDSHangHoa(dsHangHoa);
            DoDuLieuDSHH(dsHH);
        }
    }
}
