﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPS.Service.Dtos.TourDetail
{
    public class DetailTourGridDto
    {
        public int id { get; set; }
        public int id_tour { get; set; }
        public string price { get; set; }
        public string infor { get; set; }
        public string intro { get; set; }
        public string schedule { get; set; }
        public string policy { get; set; }
        public string note { get; set; }
    }
}
