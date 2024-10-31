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
    public partial class KhachHang : Form
    {
        private Model1 context;
        public KhachHang()
        {
            InitializeComponent();
            context = new Model1();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            List<Khach> dsKH = context.Khaches.ToList();
            DoDuLieuDSKH(dsKH);
        }
        private void DoDuLieuDSKH(List<Khach> dsKH)
        {
            dgvkhachhang.Rows.Clear();
            foreach (var item in dsKH)
            {
                int index = dgvkhachhang.Rows.Add();
                dgvkhachhang.Rows[index].Cells[0].Value = item.MaKhach;
                dgvkhachhang.Rows[index].Cells[1].Value = item.TenKhach;
                dgvkhachhang.Rows[index].Cells[2].Value = item.DiaChi;
                dgvkhachhang.Rows[index].Cells[3].Value = item.SDT;

            }
        }
    }
}
