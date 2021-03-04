using System.ComponentModel.DataAnnotations;

namespace Code.Together.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}