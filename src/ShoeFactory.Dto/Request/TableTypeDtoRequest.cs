using System.ComponentModel.DataAnnotations;

namespace ShoeFactory.Dto.Request;

public class TableTypeDtoRequest
{
    [Required]
    [StringLength(20)]
    public string Code { get; set; } = default!;

    [Required]
    [StringLength(500)]
    public string Description { get; set; } = default!;
}