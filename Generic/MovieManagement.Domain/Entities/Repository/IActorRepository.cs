﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities.Repository
{
    public interface IActorRepository :IGenericRepository<Actor>
    {
        IEnumerable<Actor> GetActorsWithMovies();

    }
}
