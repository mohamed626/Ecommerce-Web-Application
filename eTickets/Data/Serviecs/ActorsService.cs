using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace eTickets.Data.Serviecs
{


    public class ActorsService : EntityBaseRepository<Actor>, IActorsInterface
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
