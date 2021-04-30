using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code.Together.ProgrammingLanguages
{
    public interface IProgrammingLanguageAppService : IAsyncCrudAppService<ProgrammingLanguageDto, int, PagedProgrammingLanguageResultRequestDto, CreateProgrammingLanguageDto, ProgrammingLanguageDto>
    {
    }

    public class PagedProgrammingLanguageResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }

    public class ProgrammingLanguageDto : EntityDto<int>
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double Difficulty { get; set; }

        public List<string> GrantedPermissions { get; set; }
    }


    public class CreateProgrammingLanguageDto
    {
        public CreateProgrammingLanguageDto()
        {
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Difficulty { get; set; }

        public string Description { get; set; }
    }


    public class ProgrammingLanguageService : AsyncCrudAppService<ProgrammingLanguage, ProgrammingLanguageDto, int, PagedProgrammingLanguageResultRequestDto, CreateProgrammingLanguageDto, ProgrammingLanguageDto>, IProgrammingLanguageAppService
    {
        public ProgrammingLanguageService(IRepository<ProgrammingLanguage, int> repository) : base(repository)
        {
        }
    }
}
