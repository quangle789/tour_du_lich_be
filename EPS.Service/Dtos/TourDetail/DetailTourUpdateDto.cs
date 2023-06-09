﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPS.Service.Dtos.TourDetail
{
    public class DetailTourUpdateDto
    {
        public int id_tour { get; set; }
        public string price { get; set; }
        public string infor { get; set; }
        public string intro { get; set; }
        public string schedule { get; set; }
        public string policy { get; set; }
        public string note { get; set; }
        public string background_image { get; set; }
        public string tour_guide { get; set; }
        public string isurance { get; set; }
        public DetailTourUpdateDto(int IdTour, string Price, string Infor, string Intro, string Schedule, string Policy, string Note, string Background_image, string Tour_guide, string Isurance)
        {
            id_tour = IdTour;
            price = Price;
            infor = Infor;
            intro = Intro;
            schedule = Schedule;
            policy = Policy;
            note = Note;
            background_image = Background_image;
            tour_guide = Tour_guide;
            isurance = Isurance;
        }
    }
}
