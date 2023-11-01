using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "UserName is required.")]
        public string? UserName { get; init; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; init; }



        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "PhoneNumber is required.")]
        public string? PhoneNumber { get; init; }

public HashSet<String>Roles{get;set;}=new HashSet<string>();

    }
}