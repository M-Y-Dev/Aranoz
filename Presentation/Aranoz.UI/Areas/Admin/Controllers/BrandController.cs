using Aranoz.UI.Areas.Admin.Dtos.BrandDtos;
using Aranoz.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Text;
using Aranoz.UI.Areas.Admin.Dtos.BannerDtos;

namespace Aranoz.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiBaseUrl _apiBaseUrl;
        public BrandController(IHttpClientFactory httpClientFactory, ApiBaseUrl apiBaseUrl)
        {
            _httpClientFactory = httpClientFactory;
            _apiBaseUrl = apiBaseUrl;
        }

        public async Task<IActionResult> GetListBrand()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.GetAsync("Brands");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonData);
            if ((bool)jsonObject.isSuccessfull)
            {
                var result = jsonObject.data;
                var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(result.ToString());
                return View(values);
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var jsonObject = JsonConvert.SerializeObject(createBrandDto);
            StringContent stringContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("Brands", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GetListBrand");
            }
            return View();
        }
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.DeleteAsync("Brands" + id);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("GetListBrand"); }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBrand(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.GetAsync("Brands" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonData);
            if ((bool)jsonObject.isSuccessfull)
            {
                var result = jsonObject.data;
                var values = JsonConvert.DeserializeObject<UpdateBannerDto>(result.ToString());
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var JsonObject = JsonConvert.SerializeObject(updateBrandDto);
            StringContent stringContent = new StringContent(JsonObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("Brands", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GetListBrand");
            }
            return View();
        }
    }
}
