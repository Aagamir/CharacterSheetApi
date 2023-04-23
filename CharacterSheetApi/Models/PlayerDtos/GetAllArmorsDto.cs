using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetApi.Models.PlayerDtos
{
    public class GetAllArmorsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArmorPoints { get; set; }
        public int Weight { get; set; }
        public ArmorTypeId ArmorTypeId { get; set; }
        public string ArmorType { get; set; }
        public List<String> BodyLocations { get; set; }
    }
}