using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        [DataType(DataType.Password)]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; init; }
        [Required(ErrorMessage = "ConfirmPassword is required.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword must be match.")]
        public string? ConfirmPassword { get; init; }

    }
}