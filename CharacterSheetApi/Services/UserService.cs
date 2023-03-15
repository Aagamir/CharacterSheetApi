using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CharacterSheetApi.Services
{
    public class UsersService : IUsersService
    {
        private readonly Context _context;
        private readonly IPasswordHasher<Users> _passwordHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public UsersService(Context context, IPasswordHasher<Users> passwordHasher, AuthenticationSettings authenticationSettings)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _authenticationSettings = authenticationSettings;
        }

        public void UserPutterInDatabase(RegisterUserDto dto)
        {
            Users user = new Users();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

            user.Role = _context.Roles.FirstOrDefault(x => x.RoleId == RoleId.User);

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {

        }

        public string GenerateLoginToken(LoginDto dto)
        {
            var user = _context
                .Users
                .FirstOrDefault(x => x.Email == dto.Email);


            if (user is null)
            {
                // throw new BadRequestException("Invalid username or password");
                throw new BadHttpRequestException("Invalid username or password");
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                // throw new BadRequestException("Invalid username or password");
                throw new BadHttpRequestException("Invalid username or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                //new Claim(ClaimTypes.Role, user.Role.Name)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
