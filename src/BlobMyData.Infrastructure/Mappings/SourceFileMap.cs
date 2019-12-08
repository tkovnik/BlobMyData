using BlobMyData.Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobMyData.Infrastructure.Mappings
{
    public class SourceFileMap : ClassMap<SourceFile>
    {
        public SourceFileMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.FullName);
            Map(x => x.LastBackupDate);
            Map(x => x.Comment);
            Map(x => x.Tags);


        }
    }
}
