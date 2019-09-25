using System;
using System.Collections.Generic;

namespace LibraryEF
{
    public class CustomerServiceEF
    {
        private Context _context;
        public CustomerServiceEF()
        {
            _context = new Context();
        }

        public IEnumerable<Customers> GetAll() => _context.Customers;

    }
}
