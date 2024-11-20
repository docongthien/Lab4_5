using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsp
{
    public class B1
    {
        public class SanPhamService
        {
            public List<B1_> sanPhams = new List<B1_>();

            public void ThemSanPham(B1_ sanPham)
            {

                if (sanPham.Soluong > 0 && sanPham.Soluong < 100)
                {

                    sanPhams.Add(sanPham);

                }
                else
                {
                    throw new ArgumentException("Số lượng phải là số nguyên dương và nhỏ hơn 100");
                }


            }

            public void SuaSanPham(B1_ sanPham)
            {
                var item = sanPhams.FirstOrDefault(s => s.MaSanPham == sanPham.MaSanPham);
                if (item != null)
                {
                    if (sanPham.Soluong > 0 && sanPham.Soluong < 100)
                    {
                        item.TenSanPham = sanPham.TenSanPham;
                        item.Gia = sanPham.Gia;
                        item.MauSac = sanPham.MauSac;
                        item.KichThuoc = sanPham.KichThuoc;
                        item.Soluong = sanPham.Soluong;
                    }
                    else
                    {
                        throw new ArgumentException("Số lượng phải là số nguyên dương và nhỏ hơn 100");
                    }
                }
                else
                {
                    throw new ArgumentException("Mã sản phẩm không tồn tại");
                }
            }
        }
    }
}
