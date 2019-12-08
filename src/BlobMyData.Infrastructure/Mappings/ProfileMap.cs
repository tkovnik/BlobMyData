using BlobMyData.Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobMyData.Infrastructure.Mappings
{
    public class ProfileMap : ClassMap<Profile>
    {
        public ProfileMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.MachineName);
            Map(x => x.Description);

            HasMany(x => x.ProfileSources)
                .Inverse()
                .Cascade
                .All();
        }
    }
}
