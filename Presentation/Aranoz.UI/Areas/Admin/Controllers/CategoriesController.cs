using Aranoz.UI.Areas.Admin.Dtos.CategoryDtos;
using Aranoz.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Aranoz.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiBaseUrl _apiBaseUrl;

        public CategoriesController(IHttpClientFactory httpClientFactory, IOptions<ApiBaseUrl> apiBaseUrl)
        {
            _httpClientFactory = httpClientFactory;
            _apiBaseUrl = apiBaseUrl.Value;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl); // appsetting.js da oluşturulan base adresi aldık
            var responseMessage = await client.GetAsync("Categories"); // base adres devamı istek yapılacak yer
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonData); // responsu dinamik olarak aldık
            if ((bool)jsonObject.isSuccessfull) // respondan gelen successfull true ise 
            {
                var result = jsonObject.data;
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(result.ToString());
                return View(values);
            }
            return View();
        }
    }
}
