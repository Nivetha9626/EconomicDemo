using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Infrastructure
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private readonly string _connectionString;

        private ApplicationDbContext _dbContext;
        public ApplicationDbContextFactory(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void Dispose()
        {
            _dbContext=null;
        }

        public ApplicationDbContext Get()
        {
           if (_dbContext != null)
            {
                return _dbContext;
            }
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(_connectionString);

            var option = optionBuilder.Options;
            _dbContext = new ApplicationDbContext(option);
            return _dbContext;



        
        }
    }
}
