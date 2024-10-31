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
    public partial class NhanVienn : Form
    {
        private Model1 context;
        public NhanVienn()
        {
           InitializeComponent();
            context = new Model1();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNV = context.NhanViens.ToList();
            DoDuLieuDSNV(dsNV);
        }
        private void DoDuLieuDSNV(List<NhanVien> dsNV)
        {
            dgvnhanvien.Rows.Clear();
            foreach (var item in dsNV)
            {
                int index = dgvnhanvien.Rows.Add();
                dgvnhanvien.Rows[index].Cells[0].Value = item.MaNV;
                dgvnhanvien.Rows[index].Cells[1].Value = item.TenNV;
                dgvnhanvien.Rows[index].Cells[2].Value = item.GioiTinh;
                dgvnhanvien.Rows[index].Cells[3].Value = item.DiaChi;
                dgvnhanvien.Rows[index].Cells[4].Value = item.SDT;
                dgvnhanvien.Rows[index].Cells[5].Value = item.NgaySinh;

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
