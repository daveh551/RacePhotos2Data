using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoServer.Domain;

namespace PhotoServer.DataAccessLayer.Mappings
{
    public class PhotoMapping : EntityTypeConfiguration<Photo>
    {
        public PhotoMapping()
        {
            ToTable("Photos");
        }
    }
}
