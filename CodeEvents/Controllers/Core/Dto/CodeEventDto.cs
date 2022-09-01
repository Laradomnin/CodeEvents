using CodeEvents.Api.Controllers.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace CodeEvents.Api.Controllers.Core.Dto
{
#nullable disable
    public class CodeEventDto
    {
        [Required]
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public int Length { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCityTown { get; set; }
        public string LocationStateProvince { get; set; }
        public string LocationPostalCode { get; set; }
        public string LocationCountry { get; set; }


        public ICollection<Lecture> Lectures { get; set; }

    }
}
