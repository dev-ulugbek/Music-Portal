using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.TrackRequest
{
    public record DeleteTrackRequest
    {
        public Guid Id { get; set; }
    }
}
