﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;


namespace Cinema.DAL
{
    public static class Builder
    {               
        public static void Build<T>(this T entity, ApplicationDbContext context)
        {
            if (typeof(T) == typeof(Reservation)) BuildRelations(entity as Reservation, context);
            if (typeof(T) == typeof(Screening)) BuildRelations(entity as Screening, context);
            if (typeof(T) == typeof(Review)) BuildRelations(entity as Review, context);
            if (typeof(T) == typeof(Seat)) BuildRelations(entity as Seat, context);
            if (typeof(T) == typeof(SeatReservation)) BuildRelations(entity as SeatReservation, context);
            //if (typeof(T) == typeof(User)) await BuildRelations(entity as User, context);
        }

        private static void BuildRelations(Reservation entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.User = context.Users.Find(entity.UserId);
            entity.Screening = context.Screenings.Find(entity.ScreeningId);
        }

        private static void BuildRelations(Screening entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Hall = context.Halls.Find(entity.HallId);
            entity.Movie = context.Movies.Find(entity.MovieId);
        }

        private static void BuildRelations(Review entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.User = context.Users.Find(entity.UserId);
            entity.Movie = context.Movies.Find(entity.MovieId);
        }

        private static void BuildRelations(Seat entity, ApplicationDbContext context)
        {
            entity.Hall = context.Halls.Find(entity.Hall.Id);
        }

        private static void BuildRelations(SeatReservation entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Reservation = context.Reservations.Find(entity.Reservation.Id);
            entity.Seat = context.Seats.Find(entity.Seat.Id);
        }

        public static void UpdateRelations<T>(this T oldEnt, T newEnt)
        {
            if (typeof(T) == typeof(Reservation)) Update(oldEnt as Reservation, newEnt as Reservation);
            if (typeof(T) == typeof(Screening)) Update(oldEnt as Screening, newEnt as Screening);
            if (typeof(T) == typeof(Review)) Update(oldEnt as Review, newEnt as Review);
            if (typeof(T) == typeof(Seat)) Update(oldEnt as Seat, newEnt as Seat);
            if (typeof(T) == typeof(SeatReservation)) Update(oldEnt as SeatReservation, newEnt as SeatReservation);
        }

        private static void Update(Reservation oldEnt, Reservation newEnt)
        {
            oldEnt.User = newEnt.User;
            oldEnt.Screening = newEnt.Screening;
        }

        private static void Update(Screening oldEnt, Screening newEnt)
        {
            oldEnt.Hall = newEnt.Hall;
            oldEnt.Movie = newEnt.Movie;
        }

        private static void Update(Review oldEnt, Review newEnt)
        {
            oldEnt.User = newEnt.User;
            oldEnt.Movie = newEnt.Movie;
        }

        private static void Update(Seat oldEnt, Seat newEnt)
        {
            oldEnt.Hall = newEnt.Hall;
        }

        private static void Update(SeatReservation oldEnt, SeatReservation newEnt)
        {
            oldEnt.Reservation = newEnt.Reservation;
            oldEnt.Seat = newEnt.Seat;
        }

    }
}
