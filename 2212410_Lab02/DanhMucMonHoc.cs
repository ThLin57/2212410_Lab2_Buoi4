using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212410_Lab02
{
    public class DanhMucMonHoc
    {
        public ArrayList ds;
        public DanhMucMonHoc() 
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh Sach Mon Hoc:";
            foreach (object mh in s)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }
    }
}
