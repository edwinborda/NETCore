using AutoMapper;
using MillionAndUp.Admin.API.Application.Models;
using MillionAndUp.Admin.Domain;

namespace MillionAndUp.Admin.API.Application.Mapper
{
    public class AuthorProfile: Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorModel>();
        }
    }
}
