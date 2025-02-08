using AmusementPark.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class

    {
        private readonly DataContext help;
        private readonly DbSet<T> _dataSet;
        public Repository(DataContext dataContext)
        {
            _dataSet = dataContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dataSet.ToListAsync();
        }
        public T? GetById(int id)
        {
            return _dataSet.Find(id);
        }
        public T Add(T t)
        {
            _dataSet.Add(t);
            return t;
        }


        public T Update(int id, T updatedEntity)
        {
            var existingEntity = _dataSet.Find(id);
            if (existingEntity == null)
            {
                return null;
            }

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(prop => prop.Name != "Id");

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(updatedEntity);

                if (updatedValue != null)
                {
                    property.SetValue(existingEntity, updatedValue);
                }
            }

            return existingEntity;
        }
        public bool Delete(int id)
        {
            T find = _dataSet.Find(id);
            if (find != null)
            {
                _dataSet.Remove(find);
                return true;
            }
            return false;
        }

    }
}
