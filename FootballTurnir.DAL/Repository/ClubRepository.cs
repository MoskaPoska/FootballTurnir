using FootballTurnir.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTurnir.DAL.Repository
{
    public class ClubRepository
    {
        private readonly DbContext _dbContext;
        public ClubRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Club? GetById(int id)
        {
            return _dbContext.Set<Club>().Find(id);
        }
        public void Add(object club)
        {
            _dbContext.Add(club);
            _dbContext.SaveChanges();
        }
        public void Update(object club)
        {
            _dbContext.Entry(club).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public void Delete(object club)
        {
            _dbContext.Remove(club);
            _dbContext.SaveChanges();
        }
        public List<TEntity>GetAll<TEntity>() where TEntity : class
        {
            return _dbContext.Set<TEntity>().ToList();
        }
    }
}
