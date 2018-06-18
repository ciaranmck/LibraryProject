using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Borrower
    {
        private readonly string _name;
        private ArrayList _backpack;

        public Borrower(string name, ArrayList backpack)
        {
            _name = name;
            _backpack = backpack;
        }

        public string GetName()
        {
            return _name;
        }

        public int CountBooks()
        {
           return _backpack.Count;
        }
    }
}
