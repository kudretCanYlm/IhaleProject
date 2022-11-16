using System.ComponentModel.DataAnnotations;

namespace IhaleProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}