﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Queries.AdvertisementsQuery
{
    public class AdvertisementsQueryResponse
    {
        public AdvertisementsQueryResponse()
        {

        }

        public List<AdvertisementsItems> Items { get; set; }
    }
    public class AdvertisementsItems
    {
        public int Id { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public string Note { get; set; }
    }
}
