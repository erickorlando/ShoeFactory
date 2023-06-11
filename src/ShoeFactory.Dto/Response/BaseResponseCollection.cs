namespace ShoeFactory.Dto.Response;

public class BaseResponseCollection<T> : BaseResponse
{
    public ICollection<T>? Data { get; set; }

    public int TotalPages { get; set; }
}