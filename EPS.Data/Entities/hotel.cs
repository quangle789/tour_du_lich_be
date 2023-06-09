﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPS.Data.Entities
{
    public partial class hotel
    {
        public hotel()
        {
        }
        public int id { get; set; }
        public int category_id { get; set; }

        [ForeignKey("category_id")]
        [InverseProperty("hotels")]
        public virtual category category { get; set; }
        public string name { get; set; }
        public string background_image { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public int status { get; set; }
    }
}
