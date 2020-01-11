﻿using Cinema.Domain.Entities;
using System;

namespace Cinema.DTO.SpecificModels
{
    public class SeatingModel
    {
        public int SeatNumber { get; set; }
        public MasterModel Seat { get; set; }
        public bool Reserved { get; set; }
    }
}