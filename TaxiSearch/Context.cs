using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSearch
{
    class Context
    {
        private static dbTaxiSearchEntities _context;

        public static dbTaxiSearchEntities GetContext()
        {
            if (_context == null)
            {
                _context = new dbTaxiSearchEntities();
            }

            return _context;
        }
    }
}
