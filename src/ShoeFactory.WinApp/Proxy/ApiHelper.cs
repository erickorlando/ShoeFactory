using System.Text;
using Newtonsoft.Json;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;

namespace ShoeFactory.WinApp.Proxy;

public class ApiHelper
{
    private readonly HttpClient _httpClient;
    public ApiHelper()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5000")
        };
    }

    // Singleton instance
    private static ApiHelper? _instance;
    public static ApiHelper Instance => _instance ??= new ApiHelper();

    public async Task<ICollection<TableTypeDtoResponse>> Currencies(string filter)
    {
        var response = await _httpClient.GetAsync($"api/Currencies?filter={filter}");
        if (response.IsSuccessStatusCode == false)
        {
            throw new Exception(response.ReasonPhrase);
        }
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<BaseResponseCollection<TableTypeDtoResponse>>(content);

        return result!.Data!;
    }

    public async Task<ICollection<TableTypeDtoResponse>> List(string endpoint, string filter)
    {
        var response = await _httpClient.GetAsync($"api/{endpoint}?filter={filter}");
        if (response.IsSuccessStatusCode == false)
        {
            throw new Exception(response.ReasonPhrase);
        }
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<BaseResponseCollection<TableTypeDtoResponse>>(content);

        return result!.Data!;
    }

    public async Task<TableTypeDtoResponse> Get(string endpoint, int id)
    {
        var response = await _httpClient.GetAsync($"api/{endpoint}/{id}");
        if (response.IsSuccessStatusCode == false)
        {
            throw new Exception(response.ReasonPhrase);
        }
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<BaseResponseGeneric<TableTypeDtoResponse>>(content);

        return result!.Data!;
    }

    public BaseResponse Add(string endpoint, TableTypeDtoRequest dto)
    {
        string content = null!;
        var task = Task.Run(async () =>
        {

            var json = JsonConvert.SerializeObject(dto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/{endpoint}", data);
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception(response.ReasonPhrase);
            }

            content = await response.Content.ReadAsStringAsync();
        });

        task.Wait();

        var result = JsonConvert.DeserializeObject<BaseResponse>(content);

        return result!;
    }

    public BaseResponse Update(string endpoint, int id, TableTypeDtoRequest dto)
    {
        string content = null!;

        var task = Task.Run(async () =>
        {
            var json = JsonConvert.SerializeObject(dto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/{endpoint}/{id}", data);
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception(response.ReasonPhrase);
            }
            content = await response.Content.ReadAsStringAsync();
        });
        task.Wait();
        var result = JsonConvert.DeserializeObject<BaseResponse>(content);

        return result!;
    }

    public async Task<BaseResponse> Delete(string endpoint, int id)
    {
        var response = await _httpClient.DeleteAsync($"api/{endpoint}/{id}");
        if (response.IsSuccessStatusCode == false)
        {
            throw new Exception(response.ReasonPhrase);
        }
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<BaseResponse>(content);

        return result!;
    }
}