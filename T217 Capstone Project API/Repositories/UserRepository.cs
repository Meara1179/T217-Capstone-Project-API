﻿using T217_Capstone_Project_API.Models.DTO;
using T217_Capstone_Project_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using T217_Capstone_Project_API.Authentication;
using Microsoft.CodeAnalysis.Elfie.Model.Strings;
using System.Runtime.CompilerServices;
using T217_Capstone_Project_API.Repositories.Interfaces;

namespace T217_Capstone_Project_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        enum UpdateStatus
        {
            Success,
            BadRequest,
            NotFound
        }

        private readonly StakeholderRisksContext _context = new StakeholderRisksContext();

        public async Task<User> GetUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);

            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users.Where(x => x.UserEmail == email).FirstOrDefaultAsync();

            if (user == null)
            {
                user = new User();
            }
            return user;
        }

        public async Task<string> GetApiKeyAsync(string email, string password)
        {
            var user = await _context.Users.Where(x => x.UserEmail == email).FirstOrDefaultAsync();
            string key = "";

            if (user == null)
            {
                key = "USER NOT FOUND";
            }
            else
            {
                bool passwordCorrect = BCrypt.Net.BCrypt.EnhancedVerify(password, user.Password);

                if (passwordCorrect)
                {
                    key = user.ApiKey;
                }
                else key = "PASSWORD INCORRECT";
            }
            return key;
        }

        public async Task<User> GetUserByApiKeyAsync(string apiKey)
        {
            var user = await _context.Users.Where(x => x.ApiKey == apiKey).FirstOrDefaultAsync();

            if (user == null)
            {
                user = new User();
            }
            return user;
        }

        public async Task<List<User>> GetUserListAsync()
        {
            var userList = await _context.Users.OrderBy(x => x.UserID).ToListAsync();

            if (userList == null)
            {
                userList = new List<User>();
            }
            return userList;
        }

        public async Task<User> CreateUserAsync(UserDTO user)
        {
            User newUser = new User();

            newUser.UserEmail = user.UserEmail;
            newUser.UserFirstName = user.UserFirstName;
            newUser.UserLastName = user.UserLastName;
            newUser.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }

        public async Task<int> UpdateUserAsync(int id, User user)
        {
            if (id != user.UserID)
            {
                return (int)UpdateStatus.BadRequest;
            }

            _context.Users.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return (int)UpdateStatus.NotFound;
                }
                else
                {
                    throw;
                }
            }
            return (int)UpdateStatus.Success;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return false;
            }

            _context.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }
    }
}