using GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HangHoa : Form
    {
        private Model1 context;
        public HangHoa()
        {
            InitializeComponent();
            context = new Model1();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            List<LoaiHang> dsHangHoa = context.LoaiHangs.ToList();
            List<Hang> dsKHoa = context.Hangs.ToList();
            DoDuLieuDSHHOA(dsKHoa);
            DoDuLieuDSHangHoa(dsHangHoa);
        }
        private void DoDuLieuDSHangHoa(List<LoaiHang> dsHangHoa)
        {
            cboLoaiHang.DataSource = dsHangHoa;
            cboLoaiHang.ValueMember = "MaLoaiHang";
            cboLoaiHang.DisplayMember = "TenLoaiHang";
        }
        private void DoDuLieuDSHHOA(List<Hang> dsHHoa)
        {
            dgvHangHoa.Rows.Clear();
            foreach (var item in dsHHoa)
            {
                int index = dgvHangHoa.Rows.Add();
                dgvHangHoa.Rows[index].Cells[0].Value = item.MaHang;
                dgvHangHoa.Rows[index].Cells[1].Value = item.TenHang;
                dgvHangHoa.Rows[index].Cells[2].Value = item.LoaiHang.TenLoaiHang;
                dgvHangHoa.Rows[index].Cells[3].Value = item.SoLuong;
                dgvHangHoa.Rows[index].Cells[4].Value = item.DonGiaNhap;
                dgvHangHoa.Rows[index].Cells[5].Value = item.DonGiaBan;
                dgvHangHoa.Rows[index].Cells[6].Value = item.NgayNhap;
                dgvHangHoa.Rows[index].Cells[7].Value = item.Anh;
                dgvHangHoa.Rows[index].Cells[7].Value = item.GhiChu;
            }
        }
    }
}
