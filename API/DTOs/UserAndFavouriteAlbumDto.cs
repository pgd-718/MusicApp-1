using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserAndFavouriteAlbumDto
    {
        public string Username { get; set; }
        public string KnownAs { get; set; }
        public string FavouriteAlbumName { get; set;}
        
    }
}