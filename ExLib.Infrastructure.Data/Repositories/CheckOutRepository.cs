using ExLib.Domain.Entities;
using ExLib.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Infrastructure.Data.Repositories
{
    public class CheckOutRepository : ICheckOutRepository
    {
        public LibraryDbContext _dbContext;
        public CheckOutRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CheckOut> AddcheckOut(CheckOut checkOut)
        {
            try
            {
                _dbContext.CheckOuts.Add(checkOut);
                _dbContext.SaveChanges();
                return checkOut;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<CheckOut> GetCheckOuts()
        {
            return _dbContext.CheckOuts
            .Include(e => e.Book);
        }

    }
}
