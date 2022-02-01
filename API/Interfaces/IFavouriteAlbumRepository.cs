using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IFavouriteAlbumRepository
    {
        ICollection<Tuple<string,int>> GetNumberOfUsersWithFavouriteAlbum();
    }
}