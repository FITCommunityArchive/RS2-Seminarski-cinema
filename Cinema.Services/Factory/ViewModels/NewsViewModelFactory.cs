using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.News;
using Cinema.Services.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cinema.Services.Factory.ViewModels
{
    public static class NewsViewModelFactory
    {
        public static NewsIndexVM ToIndexVM(this News news)
        {
            return new NewsIndexVM
            {
                Id = news.Id,
                Author = news.Author.CreateMaster(),
                Description = news.Description.Truncate(),
                Image = news.Image,
                Title = news.Title,
                DateCreated = news.Created.ToFormattedDate(),
                TimeCreated = news.Created.ToFormattedTime(),
                Type = news.Type.CreateMaster()
            };
        }

        public static NewsDetailsVM ToDetailsVM(this News news)
        {
            return new NewsDetailsVM
            {
                Id = news.Id,
                Author = news.Author.CreateMaster(),
                Description = news.Description,
                Image = news.Image,
                Title = news.Title,
                DateCreated = news.Created.ToFormattedDate(),
                TimeCreated = news.Created.ToFormattedTime(),
                Type = news.Type.CreateMaster()
            };
        }

        public static NewsCreateVM ToCreateVM(this News news, SelectList newsTypes)
        {
            return new NewsCreateVM
            {
                Id = news.Id,
                Description = news.Description,
                Image = news.Image,
                Title = news.Title,
                AuthorId = news.AuthorId,
                NewsTypeId = news.TypeId,
                NewsTypes = newsTypes
            };
        }
    }
}
