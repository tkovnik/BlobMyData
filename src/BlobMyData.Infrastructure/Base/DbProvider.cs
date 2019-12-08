using BlobMyData.Domain.Model;
using BlobMyData.Infrastructure.DAL;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlobMyData.Infrastructure.Base
{
    public class DbProvider
    {
        private readonly ISessionFactory _SessionFactory;
        private ITransaction _Transaction;

        public DbProvider(string dbPath)
        {
            DbContext context = new DbContext(dbPath);
            _SessionFactory = context.SessionFactory;
            Session = _SessionFactory.OpenSession();
        }

        #region Public Properties

        public ISession Session { get; private set; }

        #endregion

        public void Dispose()
        {
            Session.Close();
        }

        public Result SaveShanges()
        {
            Result res = new Result();
            try
            {
                BeginTransaction();

                Commit();

                res.Status = ResultStatus.OK;
                res.Message = "Entity succesfully saved";
            }
            catch (Exception ex)
            {
                res.Status = ResultStatus.Error;
                res.Message = $"Error:{Environment.NewLine}{ex.Message}";
            }

            return res;
        }

        public void RefreshData(object data)
        {
            Session.Refresh(data);
        }

        #region Private Helper Methods

        private void BeginTransaction()
        {
            if (_Transaction == null || !_Transaction.IsActive)
            {
                _Transaction = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            }
        }

        private void Commit()
        {
            if (_Transaction == null || !_Transaction.IsActive)
            {
                throw new InvalidOperationException("No active transaction.");
            }

            _Transaction.Commit();
        }

        #endregion

        #region CRUD operations

        public void Create(object entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Session.Save(entity);
        }

        public void Delete(object entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Session.Delete(entity);
        }

        public void Update(object entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Session.Update(entity);
        }

        #endregion

        #region Additional Generic Methods

        public T GetById<T>(int id) where T : IBaseModel<int>
        {
            return Session.Query<T>().FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<T> GetAll<T>()
        {
            return Session.Query<T>();
        }

        public IEnumerable<T> Where<T>(Expression<Func<T, bool>> predicate) where T : IBaseModel<int>
        {
            return Session.Query<T>().Where(predicate);
        }

        #endregion
    }
}
