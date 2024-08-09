using Aranoz.UI.Areas.Admin.Dtos.BannerDtos;
using Aranoz.UI.Areas.Admin.Dtos.CategoryDtos;
using Aranoz.UI.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Nodes;

namespace Aranoz.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiBaseUrl _apiBaseUrl;

        public BannersController(IHttpClientFactory httpClientFactory, IOptions<ApiBaseUrl> apiBaseUrl)
        {
            _httpClientFactory = httpClientFactory;
            _apiBaseUrl = apiBaseUrl.Value;
        }

        public async Task<IActionResult> GetListBanner()
        {

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.GetAsync("Banners");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonData);
            if ((bool)jsonObject.isSuccessfull)
            {
                var result = jsonObject.data;
                var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(result.ToString());
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var JsonObject = JsonConvert.SerializeObject(createBannerDto);
            StringContent stringContent = new StringContent(JsonObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("Banners", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GetListBanner");
            }
            return View();

        }
        public async Task<IActionResult> DeleteBanner(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.DeleteAsync("Banners" + id);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("GetListBanner"); }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBanner(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var responseMessage = await client.GetAsync("Banners" + id);
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
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiBaseUrl.BaseUrl);
            var JsonObject = JsonConvert.SerializeObject(updateBannerDto);
            StringContent stringContent = new StringContent(JsonObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("Banners", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GetListBanner");
            }
            return View();
        }



    }
}
