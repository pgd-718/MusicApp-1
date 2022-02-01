using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;

namespace API.Data
{
    public class FavouriteAlbumRepository : IFavouriteAlbumRepository
    {
        private readonly DataContext _context;
        public FavouriteAlbumRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Tuple<string, int>> GetNumberOfUsersWithFavouriteAlbum()
        {
            var result = from u in _context.Users
                         join a in _context.FavouriteAlbums on u.Id equals a.AppUser.Id
                         group a by a.FavouriteAlbumName into g
                         select new
                         {
                             g.Key,
                             Col1 = g.Count()
                         };
        
            var list = new List<Tuple<string, int>>();

            foreach (var x in result)
            {
                var t = new Tuple<string, int>(x.Key, x.Col1);
                list.Add(t);
            }

            return list;
        }
    }
}