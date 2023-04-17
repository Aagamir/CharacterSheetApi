using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetApi
{
    public class Seeder
    {
        private readonly Context _context;
        private readonly IPasswordHasher<Users> _passwordHasher;

        public Seeder(Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.Users.Any())
                {
                    var users = GetUsers();
                    _context.Users.AddRange(users);
                    _context.SaveChanges();
                }
            }
        }

        private IEnumerable<Users> GetUsers()
        {
            var users = new List<Users>()
            {
                new Users()
                {
                    Name = "GameMaster",
                    Email = "game.master@gmail.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEGWn4zhbKsowa4YeGEHO8qSRPU5yhRHq1FrWg7oN4TD2Z591yvEY5QQ3TLdt9y4GeA==",
                    RoleId = RoleId.GameMaster,
                    CharacterSheets = null
                },
                new Users()
                {
                    Name = "Player",
                    Email = "player@gmail.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEGMR36kpcBjZjn0i538A3LdbCniQ1lCNdTKKdhaj9tAkLGMDPULRLQ4K+EKT/GF2pQ==",
                    RoleId = RoleId.Player,
                    CharacterSheets = null
                }
            };
            return users;
        }
    }
}