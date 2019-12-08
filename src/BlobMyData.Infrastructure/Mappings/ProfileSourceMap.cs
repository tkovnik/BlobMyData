using BlobMyData.Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobMyData.Infrastructure.Mappings
{
    public class ProfileSourceMap : ClassMap<ProfileSource>
    {
        public ProfileSourceMap()
        {
            Id(x => x.Id);
            Map(x => x.Path);

            HasMany(x => x.Files)
                .KeyColumn("ProfileSourceId")
                .Inverse()
                .Cascade
                .All();

        }
    }
}
