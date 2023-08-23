using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementation
{
    public  class BiographicRepository : GenericRepository<Biography>, IBiographicRepository 
    { 
        public BiographicRepository(MovieManagementDbContext context) :base(context)
        {
                
        }
    }
}
