using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetApi.Models.PlayerDtos
{
    public class GetAllSkillsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillLevelId SkillLevelId { get; set; }
        public string SkillLevel { get; set; }
    }
}