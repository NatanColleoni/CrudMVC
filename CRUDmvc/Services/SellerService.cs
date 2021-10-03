using CRUDmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDmvc.Services
{
    public class SellerService
    {
        private readonly CRUDmvcContext _context;

        public SellerService(CRUDmvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //sincrona - a aplicação fica bloqueada até que esse método seja executado.
            return _context.Seller.ToList();
        }
    }
}
