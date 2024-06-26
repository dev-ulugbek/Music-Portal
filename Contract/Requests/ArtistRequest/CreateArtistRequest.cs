﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Requests.ArtistRequest
{
    public record CreateArtistRequest
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }
}
