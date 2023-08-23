using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementation
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly MovieManagementDbContext _context;
        public UnitOfWork(MovieManagementDbContext context)
        {
            _context = context;
            Actor = new ActorRepository(_context);
            Movie = new MovieRepository(_context);  
            Biographic = new BiographicRepository(_context);    
            Genre = new GenreRepository(_context);  
        }

        public IActorRepository Actor { get; private set;}

        public IMovieRepository Movie { get; private set; }

        public IBiographicRepository Biographic { get; private set; }

        public IGenreRepository Genre { get; private set; }

        public void Dispose()
        {
            _context.Dispose(); 
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
