using crudsp;
using static crudsp.B1;

namespace Test_CRUD
{
    [TestFixture]
    public class Tests
    {
        private SanPhamService sanPhamService;

        [SetUp]
        public void Setup()
        {
            sanPhamService = new SanPhamService();
        }


        [Test]
        public void ThemSanPham_SanPhamHopLe()
        {
            var sanPham = new B1_("1", "SP001", "Tên sản phẩm", 100000, "Đỏ", "M", 50);
            sanPhamService.ThemSanPham(sanPham);
            Assert.AreEqual(1, sanPhamService.sanPhams.Count);
        }

        [Test]
        public void ThemSanPham_SoLuongAm()
        {
            var sanPham = new B1_("2", "SP002", "Tên sản phẩm", 100000, "Đỏ", "M", -10);
            Assert.Throws<ArgumentException>(() => sanPhamService.ThemSanPham(sanPham));
        }

        [Test]
        public void ThemSanPham_SoLuongLonHon99()
        {
            var sanPham = new B1_("3", "SP003", "Tên sản phẩm", 100000, "Đỏ", "M", 101);
            Assert.Throws<ArgumentException>(() => sanPhamService.ThemSanPham(sanPham));
        }
        [Test]
        public void ThemSanPham_SoLuongBang0()
        {
            var sanPham = new B1_("4", "SP003", "Tên sản phẩm", 100000, "Đỏ", "M", 0);
            Assert.Throws<ArgumentException>(() => sanPhamService.ThemSanPham(sanPham));
        }
        [Test]
        public void ThemSanPham_SoLuongBang1()
        {
            var sanPham = new B1_("5", "SP003", "Tên sản phẩm", 100000, "Đỏ", "M", 1);
            Assert.Throws<ArgumentException>(() => sanPhamService.ThemSanPham(sanPham));
        }





        [Test]
        public void SuaSanPham_MaSanPhamKhongTonTai()
        {
            var sanPhamMoi = new B1_("2", "SP002", "Tên sản phẩm mới", 150000, "Xanh", "L", 75);
            Assert.Throws<ArgumentException>(() => sanPhamService.SuaSanPham(sanPhamMoi));
        }

        [Test]
        public void SuaSanPham_MaSanPhamTrung()
        {
            var sanPham1 = new B1_("1", "SP001", "Tên sản phẩm 1", 100000, "Đỏ", "M", 50);
            sanPhamService.ThemSanPham(sanPham1);

            var sanPham2 = new B1_("2", "SP001", "Tên sản phẩm 2", 150000, "Xanh", "L", 75);
            Assert.Throws<ArgumentException>(() => sanPhamService.SuaSanPham(sanPham2));
        }

        [Test]
        public void SuaSanPham_TenSanPhamNull()
        {
            var sanPham1 = new B1_("1", "SP001", "Tên sản phẩm 1", 100000, "Đỏ", "M", 50);
            sanPhamService.ThemSanPham(sanPham1);

            var sanPham2 = new B1_("1", "SP001", null, 150000, "Xanh", "L", 75);
            Assert.Throws<ArgumentException>(() => sanPhamService.SuaSanPham(sanPham2));
        }

        [Test]
        public void SuaSanPham_GiaAm()
        {
            var sanPham1 = new B1_("1", "SP001", "Tên sản phẩm 1", 100000, "Đỏ", "M", 50);
            sanPhamService.ThemSanPham(sanPham1);

            var sanPham2 = new B1_("1", "SP001", "Tên sản phẩm 2", -150000, "Xanh", "L", 75);
            Assert.Throws<ArgumentException>(() => sanPhamService.SuaSanPham(sanPham2));
        }

        [Test]
        public void SuaSanPham_SoluongAm()
        {
            var sanPham1 = new B1_("1", "SP001", "Tên sản phẩm 1", 100000, "Đỏ", "M", 50);
            sanPhamService.ThemSanPham(sanPham1);

            var sanPham2 = new B1_("1", "SP001", "Tên sản phẩm 2", 150000, "Xanh", "L", -75);
            Assert.Throws<ArgumentException>(() => sanPhamService.SuaSanPham(sanPham2));
        }
    }
}