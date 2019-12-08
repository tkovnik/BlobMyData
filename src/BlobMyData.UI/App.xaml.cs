using BlobMyData.Domain.Model;
using BlobMyData.Infrastructure.Base;
using BlobMyData.UI.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BlobMyData.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DbProvider db = DbProviderFactory.CreateDbProvider();

            List<BlobStorage> bs = db.GetAll<BlobStorage>().ToList();

        }
    }
}
