using System.ComponentModel.DataAnnotations;

namespace ShoeFactory.Entities;

public class TableTypeBase : EntityBase
{
    [StringLength(20)]
    public string Code { get; set; } = default!;

    [StringLength(500)]
    public string Description { get; set; } = default!;
}