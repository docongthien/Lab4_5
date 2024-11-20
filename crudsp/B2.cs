using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsp
{
    public class B2
    {
        public List<B2_> cruds = new List<B2_>();
        public void additem(B2_ sp)
        {
            if (sp == null)
                throw new ArgumentNullException(nameof(cruds), "Item không được null.");
            if (string.IsNullOrWhiteSpace(sp.Name) || !IsValidName(sp.Name))
                throw new ArgumentException("Name phải là chữ và độ dài nhỏ hơn hoặc bằng 50.");

            cruds.Add(sp);
        }
        public void Updateitem(int Id, string newname) 
        {
            if (string.IsNullOrWhiteSpace(newname) || !IsValidName(newname))
                throw new ArgumentException("Name phải là chữ và độ dài nhỏ hơn hoặc bằng 50.");

            var item = cruds.FirstOrDefault(x => x.Id == Id);
            if (item == null)
                throw new KeyNotFoundException("Không tìm thấy Item với Id được cung cấp.");
                item.Name = newname;
        }
        public void delete(int Id)
        {
            var removedCount = cruds.RemoveAll(i => i.Id == Id);
            if (removedCount == 0)
                throw new KeyNotFoundException("Không tìm thấy Item với Id được cung cấp.");
        }
        private bool IsValidName(string name)
        {
            return name.Length <= 50 && name.All(char.IsLetter);
        }
    }
}
