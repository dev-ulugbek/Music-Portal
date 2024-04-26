using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.ArtistRequest
{
    public record DeleteArtistRequest
    {
        public Guid Id { get; set; }
    }
}
