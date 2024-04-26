using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.TrackRequest
{
    public record CreateTrackRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Language { get; set; }

        public Artist Genre { get; set; }
        public Guid GenreId { get; set; }
    }
}
