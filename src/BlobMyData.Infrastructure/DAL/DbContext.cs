using BlobMyData.Infrastructure.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace BlobMyData.Infrastructure.DAL
{
    public class DbContext
    {
        #region Fields

        private string _dbPath;
        private ISessionFactory _SessionFactory;

        #endregion

        public DbContext(string dbPath)
        {
            _dbPath = dbPath;
        }

        #region Public Properties

        public ISessionFactory SessionFactory
        {
            get
            {
                if (_SessionFactory == null)
                    InitializeSessionFactory();

                return _SessionFactory;
            }
        }

        #endregion

        #region Helpers

        private void InitializeSessionFactory()
        {
            _SessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                .UsingFile(_dbPath)
                )
                .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<ProfileMap>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }

        #endregion
    }

}
