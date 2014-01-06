using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using PhotoServer.Domain;

namespace PhotoServer.DataAccessLayer.Queries
{
    public class FindAllPhotos :Query<Photo>
    {
        public FindAllPhotos()
        {
            ContextQuery = context => context.AsQueryable<Photo>();
        }
    }

    public class FindPhotoById : Scalar<Photo>
    {
        public FindPhotoById(Guid id)
        {
            ContextQuery = context => context.AsQueryable<Photo>().FirstOrDefault(p => p.Id == id);
        }
    }

    public class FindFirstPhoto : Scalar<Photo>
    {
        public FindFirstPhoto()
        {
            ContextQuery = context => context.AsQueryable<Photo>().FirstOrDefault();
        }
    }
}
