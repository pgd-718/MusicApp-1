using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class FavouriteAlbum
    {
        public int FavouriteAlbumId { get; set; }
        public string FavouriteAlbumName { get; set; }   
        public virtual AppUser AppUser { get; set; }
    }
}