using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{

    public class CharacterSheetService : ICharacterSheetService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;

        public CharacterSheetService(Context context, IUserContextService userContextService)
        {
            _context = context;
            _userContextService = userContextService;
        }

        public void AddWeapon(AddWeaponDto dto )
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            //
            List<Weapon> weapons = _context.Weapons.ToList().Join(dto.WeaponIds, c => c.Id, d => d, (c, d) => c).ToList();//_context.Weapons.FirstOrDefault(w => w.Id == dto.WeaponId);
            //jak nie znajdzie to błąd
            characterInfo.Weapons.AddRange(weapons);
            _context.SaveChanges();
        }
    }
}
