using Microsoft.EntityFrameworkCore;
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
    public class ActorRepository :GenericRepository<Actor>,IActorRepository
    {
        public ActorRepository(MovieManagementDbContext context):base(context) 
        {
                
        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorWithMovies = _context.Actors.Include(u => u.Movies).ToList();
            return actorWithMovies;
        }
    }
}
