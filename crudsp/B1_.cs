using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace crudsp
{
    public class B1_
    {
        public string Id { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public float Gia { get; set; }
        public string MauSac {  get; set; }
        public string KichThuoc { get; set; }
        public int Soluong {  get; set; }

        public B1_(string id, string maSanPham, string tenSanPham, float gia, string mauSac, string kichThuoc, int soluong)
        {
            Id = id;
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            Gia = gia;
            MauSac = mauSac;
            KichThuoc = kichThuoc;
            Soluong = soluong;
        }

        public String getId()
        {
            return Id;
        }

        public void setId(String id)
        {
            this.Id = id;
        }

        public String getMaSanPham()
        {
            return MaSanPham;
        }

        public void setMaSanPham(String maSanPham)
        {
            this.MaSanPham = maSanPham;
        }

        public String getTenSanPham()
        {
            return TenSanPham;
        }

        public void setTenSanPham(String tenSanPham)
        {
            this.TenSanPham = tenSanPham;
        }

        public float getGia()
        {
            return Gia;
        }

        public void setGia(float gia)
        {
            this.Gia = gia;
        }

        public String getMauSac()
        {
            return MauSac;
        }

        public void setMauSac(String mauSac)
        {
            this.MauSac = mauSac;
        }

        public String getKichThuoc()
        {
            return KichThuoc;
        }

        public void setKichThuoc(String kichThuoc)
        {
            this.KichThuoc = kichThuoc;
        }

        public int getSoLuong()
        {
            return Soluong;
        }

        public void setSoLuong(int soLuong)
        {
            this.Soluong = soLuong;
        }
    }
}
