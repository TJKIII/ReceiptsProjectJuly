using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ReceiptDB

{
    public class WPFListBoxModel
    {
        private IList<Category> _categories;
        public IList<Category> Categories
        {
            get
            {
                if (_categories == null)
                    _categories = new List<Category>();
                return _categories;
            }
            set { _categories = value; }
        }


        private IList<Category> _categories1;
        public IList<Category> Categories1
        {
            get
            {
                if (_categories1 == null)
                    _categories1 = new List<Category>();
                return _categories1;
            }
            set { _categories1 = value; }
        }

        private IList<Category> _categories2;
        public IList<Category> Categories2
        {
            get
            {
                if (_categories2 == null)
                    _categories2= new List<Category>();
                return _categories2;
            }
            set { _categories2= value; }
        }

        private IList<Category> _categories3;
        public IList<Category> Categories3
        {
            get
            {
                if (_categories3 == null)
                    _categories3 = new List<Category>();
                return _categories3;
            }
            set { _categories3 = value; }
        }

        private IList<Category> _combocats;
        public IList<Category> ComboxBox1
        {
            get
            {
                if (_combocats == null)
                    _combocats = new List<Category>();
                return _combocats;
            }
            set { _combocats = value; }
        }



    }
}




