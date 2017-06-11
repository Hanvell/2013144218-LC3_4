using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2013144218_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //CREATES
        //Agrega un registro al repositorio(SQL Server) a la tabla TEntity
        void Add(TEntity entity);
        //Agrega un grupo de registros al repositorio(SQL Server) a la tabla TEntity
        void AddRange(IEnumerable<TEntity> entities);

        //READS
        //Obtiene el Registro con Primary key =Id de la tabla TEntity
        TEntity Get(int? Id);
        //Obtiene todos los registros de la tabla TEntity
        IEnumerable<TEntity> GetAll();
        //Obtiene todos los registros de la tabla TEntity que cumplan con la condicion preditate
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //UPDATES
        //Actualiza registro al repositorio(SQL Server) a la tabla TEntity
        //void Update(TEntity entity);
        //Actualiza grupo de registros al repositorio(SQL Server) a la tabla TEntity
        //void UpdateRange(IEnumerable<TEntity> entities);

        //DELETES
        //Elimina un registro al repositorio(SQL Server) a la tabla TEntity
        void Delete(TEntity entity);
        //Elimina un grupo de registros al repositorio(SQL Server) a la tabla TEntity
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
