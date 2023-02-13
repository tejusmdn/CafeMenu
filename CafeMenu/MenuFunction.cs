using System;
using System.IO;
using System.Threading.Tasks;
using Cafe_Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CafeMenu
{
    public static class MenuFunction
    {
        [FunctionName("Menu")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var menuItems = new[]
            {
                new Item(1, "Cappuccino", "https://hips.hearstapps.com/hmg-prod/images/directly-above-shot-of-cappuccino-served-on-table-royalty-free-image-769817517-1564602749.jpg"),
                new Item(2, "Flat White", "https://d3vueie8hikq61.cloudfront.net/wp-content/uploads/2018/02/latte-vs-flat-white.jpg"),
                new Item(3, "Espresso", "https://d9pl0lig74xnv.cloudfront.net/catalog/product/cache/91e9c011f0ac998e686df01a906b8401/1/0/10602-10_a_1.jpg" ), //"https://www.nescafe.com/mena/sites/default/files/2022-03/espresso-azera-range-range-content-teaser-desktop.jpg"), //"https://www.acouplecooks.com/wp-content/uploads/2021/08/How-to-make-espresso-009.jpg"),
                new Item(4, "Cafe Latte", "https://coffeeaffection.com/wp-content/uploads/2020/01/how-to-make-a-latte-at-home.webp"), //"https://www.thespruceeats.com/thmb/-WnCLXReESX_69DfCOdylgUKuVY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/how-to-make-caffe-latte-765372-hero-01-2417e49c4a9c4789b3abdd36885f06ab.jpg"),
                new Item(5, "Black Tea", "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/ZX8GD/preset=pB6BA/T125AE008_chai_brewed_loose_leaf"),
                new Item(6, "Earl Grey Tea", "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/en7JL/preset=pB6BA/B125AE018_french_earl_grey_teabag_lifestyle"),
                new Item(7, "Green Tea", "https://cdn.shopify.com/s/files/1/0253/2553/5337/products/green_tea_b2b5b32f-1f04-44d8-8f01-f960b29b1be2_600x_crop_center.jpg?v=1568194793"),
            };
            return new OkObjectResult(menuItems);
        }
    }
}
