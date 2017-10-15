using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffIntGenerateTemplate
{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>();
//            products.Add(new Product()
//            {
//                productName = "JuniorDino",
//                linkProductName = "Junior Dino Wallpaper",
//                productDescription = "Welcome to a  kingdom of Dinosaurs where Dinos of different sizes and verities live in harmony.This wallpaper is nearly 24' W and 33' L makes a marvelous statement installed above the baseboards in a child’s room. The top can be hand trimmed for a cut-out look. Coordinate with Shell Texture.",
//                productImages = new string[] { "JuniorDino.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "SparklingMotorcrossBike",
//                linkProductName = "Sparkling Motorcross Bike Wallpaper",
//                productDescription = "Live, breathe and sleep motor cross with this action-packed wallpaper for your kid’s room or the man cave. Many different riders kick up the dirt and dust as they circle the track. The high wallpaper is a perfect addition to any neutral or boldly colored wallpaper.",
//                productImages = new string[] { "SparklingMotorcrossBike.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "DecoPrincess",
//                linkProductName = "Deco Princess Wallpaper",
//                productDescription = "Bring the beauty of your favorite Disney princess characters into your room with this magical wallpaper wallpaper.",
//                productImages = new string[] { "DecoPrincess.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "MiniEiffelTower",
//                linkProductName = "Mini Eiffel Tower Wallpaper",
//                productDescription = "This beautiful wallpaper depicting postcard images of Miniatire version of  Eiffel Tower from Paris in shades of Light Pink and Rusted Metal is enhanced with images of postal stamps and activated wordings. You will be sure to find this a charming addition to any room where the sheer idea of one, will revive the soul.",
//                productImages = new string[] { "MiniEiffelTower.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "SummarCloud",
//                linkProductName = "Summar Cloud Wallpaper",
//                productDescription = "A traditional children's cloud wallpaper is modernized with clean lines and a pretty pastel. When your child is surrounded by this design, the sky is the limit for all of the ideas they can dream up!",
//                productImages = new string[] { "SummarCloud.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "WaverlyKidsAeroplane",
//                linkProductName = "Waverly Kids Aeroplane Wallpaper",
//                productDescription = "In an aerial display all manner of aircraft are piloted through the clouds. What an exciting and colorful airshow for the young aviation enthusiast.",
//                productImages = new string[] { "WaverlyKidsAeroplane.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "FloralPrincess",
//                linkProductName = "Floral Princess Wallpaper",
//                productDescription = "Colored daisies of purple. Green, pink, and cream alternate in this beautiful Wallpaper. Absolutely perfect in a little girl's room with similar colors, this wallpaper will be a big hit!",
//                productImages = new string[] { "FloralPrincess.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "JuniorTranspoVehicle",
//                linkProductName = "Junior TranspoVehicle Wallpaper",
//                productDescription = "A playful dotted white line road meanders and curves in happy abandon on this new-age retro graphic design around town. Cars, delivery trucks, buses and construction vehicles all have a place along the roadway. Retro stylized trees and traffic lights rest along the roadway adding a restful feel to a design that is on the move!",
//                productImages = new string[] { "JuniorTranspoVehicle.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "PrincessHeartandBubbleCombi",
//                linkProductName = "Princess Heart and Bubble Combi Wallpaper",
//                productDescription = "Sweet hearts are caught in a web of pearlescent scrolls. Ultra-feminine and prettily colored with bubbles with red hearts or swirling designs, the valentines rest on a field of pink and white.",
//                productImages = new string[] { "PrincessHeartandBubbleCombi.PNG" }
//            });

//            GenerateMainPage(products);
//            GenerateRelatedProductsPage(products);

//            foreach (var product in products)
//            {
//                GenerateProduct(product);
//            }


//        }

//        private static void GenerateRelatedProductsPage(List<Product> products)
//        {
//            StringBuilder strib = new StringBuilder();
//            strib.AppendLine("<section class=\"section light-gray-bg clearfix\">");
//            strib.AppendLine("<div class=\"container\">");
//            strib.AppendLine("<div class=\"row\">");
//            strib.AppendLine("<div class=\"col-md-12\">");
//            strib.AppendLine("<!-- Tab panes -->");
//            strib.AppendLine("<div class=\"tab-content clear-style\">");
//            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
//            strib.AppendLine("<div class=\"row masonry-grid-fitrows grid-space-10\">");
//            foreach (var product in products)
//            {
//                strib.AppendFormat(" @if (ViewBag.Product != \"{0}\")", product.productName);
//                strib.AppendLine("{");
//                strib.AppendLine("<div class=\"col-md-3 col-sm-6 masonry-grid-item\">");
//                strib.AppendLine("<div class=\"listing-item white-bg bordered mb-20\">");
//                strib.AppendLine("<div class=\"overlay-container\">");
//                strib.AppendFormat("<img src=\"~/images/Kids/{0}\" alt=\"\">", product.productImages[0]);
//                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/Kids/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
//                strib.AppendLine("<div class=\"overlay-to-top links\">");
//                strib.AppendLine("<span class=\"small\">");
//                strib.AppendFormat("<a href=\"/product/product?name={0}\" class=\"btn-sm-link\"><i class=\"icon-link pr-5\"></i>View Details</a>", product.productName);
//                strib.AppendLine("</span>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("<div class=\"body\">");
//                strib.AppendLine("<h3>");
//                strib.AppendFormat("<a href=\"/product/product?name={0}\">{1}</a>", product.productName, product.linkProductName);
//                strib.AppendLine("</h3>");
//                strib.AppendFormat("<p class=\"small\">{0}</p>", product.productDescription);
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("}");
//            }
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div></section>");
//            File.WriteAllText("KidsRelatedProducts.cshtml", strib.ToString());
//        }

//        private static void GenerateMainPage(List<Product> products)
//        {
//            StringBuilder strib = new StringBuilder();
//            strib.AppendLine("@{");
//            strib.AppendLine("ViewBag.Title = \"Home Page\";}");

//            strib.AppendLine("<!-- banner start -->" +
//"<div class=\"banner clearfix\">" +
// "   <div class=\"slideshow\">" +
//  "      <div class=\"slider-banner-container\">" +
//   "         <div class=\"slider-banner-fullscreen\">" +
//    "            <ul class=\"slides\">" +
//     "               <!-- slide 1 start -->" +
//      "              <li data-transition=\"random-static\" data-slotamount=\"7\" data-masterspeed=\"500\" data-saveperformance=\"on\" data-title=\"\">" +
//       "                 <!-- main image -->" +
//        "                <img src =\"~/images/Wallpapers/wallpapers.jpg\" alt=\"slidebg1\" data-bgposition=\"center top\" data-bgrepeat=\"no-repeat\" data-bgfit=\"cover\">" +
//         " <!-- Transparent Background -->" +
//          "              <div class=\"tp-caption dark-translucent-bg\"" +
//           "                  data-x=\"center\"" +
//            "                 data-y=\"bottom\"" +
//             "                data-speed=\"500\"" +
//              "               data-easing=\"easeOutQuad\"" +
//               "              data-start=\"0\"" +
//                "             data-endspeed=\"0\">" +
//                 "       </div>" +
//                  "      <!-- LAYER NR. 4 -->" +
//                   " <div class=\"tp-caption large_white\"" +
//                    "         data-x=\"left\"" +
//                     "        data-y=\"200\"" +
//                      "       data-speed=\"500\"" +
//                       "      data-easing=\"easeOutQuad\"" +
//                        "     data-start=\"0\"" +
//                         "    data-end=\"10000\"" +
//                          "   data-endspeed=\"0\">" +
//                           " Wallpapers<br />" +
//                        "</div>" +
//                        "<div class=\"tp-caption sfb fadeout large_white tp-resizeme hidden-xs\"" +
//                         "    data-x=\"left\"" +
//                          "   data-y=\"250\"" +
//                           "  data-speed=\"500\"" +
//                            " data-start=\"0\"" +
//                             "data-end=\"10000\"" +
//                             "data-endspeed=\"0\"" +
//                             "data-easing=\"easeOutQuad\">" +
//                            "<div class=\"separator-2 light\"></div>" +
//                        "</div>" +
//                        "<!-- LAYER NR. 9 -->" +
//                        "<div class=\"tp-caption sft fadeout small_white \"" +
//                           "  data-x=\"left\"" +
//                          "   data-y=\"280\"" +
//                         "    data-speed=\"500\"" +
//                        "     data-easing=\"easeOutQuad\"" +
//                       "      data-start=\"0\"" +
//                      "       data-end=\"10000\"" +
//                     "        data-endspeed=\"0\">" +
//                    "        WallFlavors brings you an unrivelled range of gorgeous, unique and exclusive wallpapers." +
//                   "     </div>" +
//                  "      <!-- LAYER NR. 10 -->" +
//                 "       <div class=\"tp-caption fade fadeout\"" +
//                "             data-x=\"center\"" +
//               "              data-y=\"bottom\"" +
//              "               data-voffset=\"100\"" +
//             "                data-speed=\"500\"" +
//            "                 data-easing=\"easeOutQuad\"" +
//           "                  data-start=\"0\"" +
//          "                   data-end=\"10000\"" +
//         "                    data-endspeed=\"0\">" +
//        "                    <a href =\"#page-start\" class=\"btn btn-lg moving smooth-scroll\"><i class=\"icon-down-open-big\"></i><i class=\"icon-down-open-big\"></i><i class=\"icon-down-open-big\"></i></a>" +
//       "                 </div>" +
//      "              </li>" +
//     "               <!-- slide 1 end -->" +
//    "            </ul>" +
//   "             <div class=\"tp-bannertimer\"></div>" +
//  "          </div>" +
// "       </div>" +
// "   </div>" +
//"</div>" +
//"<!-- banner end -->" +
//"<div id =\"page-start\"></div>" +
//"<!-- section start -->" +

//"<section class=\"section dark-bg clearfix\">" +
//    "<!-- Nav tabs -->" +
//    "<ul class=\"nav nav-pills dark-bg stickynav\" role=\"tablist\">" +
//    "    <li class=\"active\"><a href=\"#pill-1\" role=\"tab\" data-toggle=\"tab\" title=\"Latest Arrivals\"><i class=\"icon-star\"></i> Latest Arrivals</a></li>" +
//   "     <li><a href =\"#pill-2\" role=\"tab\" data-toggle=\"tab\" title=\"Featured\"><i class=\"icon-heart\"></i> Featured</a></li>" +
//  "      <li><a href =\"#pill-3\" role=\"tab\" data-toggle=\"tab\" title=\"Top Sellers\"><i class=\" icon-up-1\"></i> Top Sellers</a></li>" +
// "   </ul>" +
//"</section>");
//            strib.AppendLine("<div id=\"page-start\"></div>");
//            strib.AppendLine("<section class=\"section light-gray-bg clearfix\">");
//            strib.AppendLine("<div class=\"container\">");
//            strib.AppendLine("<div class=\"row\">");
//            strib.AppendLine("<div class=\"col-md-12\">");
//            strib.AppendLine("<!-- Tab panes -->");
//            strib.AppendLine("<div class=\"tab-content clear-style\">");
//            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
//            strib.AppendLine("<div class=\"row masonry-grid-fitrows grid-space-10\">");
//            foreach (var product in products)
//            {
//                strib.AppendLine("<div class=\"col-md-3 col-sm-6 masonry-grid-item\">");
//                strib.AppendLine("<div class=\"listing-item white-bg bordered mb-20\">");
//                strib.AppendLine("<div class=\"overlay-container\">");
//                strib.AppendFormat("<img src=\"~/images/Kids/{0}\" alt=\"\">", product.productImages[0]);
//                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/Kids/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
//                strib.AppendLine("<div class=\"overlay-to-top links\">");
//                strib.AppendLine("<span class=\"small\">");
//                strib.AppendFormat("<a href=\"/product/product?name={0}\" class=\"btn-sm-link\"><i class=\"icon-link pr-5\"></i>View Details</a>", product.productName);
//                strib.AppendLine("</span>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("<div class=\"body\">");
//                strib.AppendLine("<h3>");
//                strib.AppendFormat("<a href=\"/product/product?name={0}\">{1}</a>", product.productName, product.linkProductName);
//                strib.AppendLine("</h3>");
//                strib.AppendFormat("<p class=\"small\">{0}</p>", product.productDescription);
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//                strib.AppendLine("</div>");
//            }
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div></section>");
//            strib.AppendLine("<section class=\"section default-bg\">");
//            strib.AppendLine("<div class=\"container\">");
//            strib.AppendLine("<div class=\"call-to-action text-center\">");
//            strib.AppendLine("<div class=\"row\">");
//            strib.AppendLine("<div class=\"col-sm-8 col-sm-offset-2\">");
//            strib.AppendLine("<div class=\"title container-title\">Book an appointment for free consultation</div>");
//            strib.AppendLine("<p>with our expert team to get started on your dream home</p>");
//            strib.AppendLine("<div class=\"separator\"></div>");
//            strib.AppendLine("<p><a href=\"/forms/booknow\" class=\"btn btn-lg btn-gray-transparent btn-animated\">Book now<i class=\"fa fa-arrow-right");
//            strib.AppendLine("pl-20\"></i></a></p>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</section>");

//            File.WriteAllText("Kids.cshtml", strib.ToString());
//        }

//        private static void GenerateProduct(Product product)
//        {
//            StringBuilder strib = new StringBuilder();
//            strib.AppendLine("@{");
//            strib.AppendLine("ViewBag.Title = \"Home Page\";}");
//            strib.AppendLine("<section class=\"main-container\">");
//            strib.AppendLine("<div class=\"container\">");
//            strib.AppendLine("<div class=\"row\">");
//            strib.AppendLine("<div class=\"main col-md-12\"> ");
//            strib.AppendLine(string.Format("<h1 class=\"page-title text-center\">{0}</h1>", product.linkProductName));
//            strib.AppendLine("<div class=\"separator with-icon\"><i class=\"fa fa-shopping-bag bordered\"></i></div>");
//            strib.AppendLine("<div class=\"row\">");
//            strib.AppendLine("<div class=\"col-md-4 col-lg-5\">");
//            strib.AppendLine("<ul class=\"nav nav-pills\" role=\"tablist\">");
//            strib.AppendLine("<li class=\"active\"><a href=\"#pill-1\" role=\"tab\" data-toggle=\"tab\" title=\"images\"><i class=\"fa fa-camera pr-5\"></i> Photo</a></li></ul>");
//            strib.AppendLine("<div class=\"tab-content clear-style\">");
//            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
//            strib.AppendLine("<div class=\"owl-carousel content-slider-with-thumbs mb-20\">");
//            foreach (string item in product.productImages)
//            {
//                strib.AppendLine("<div class=\"overlay-container overlay-visible\">");
//                strib.AppendLine(string.Format("<img src=\"~/images/Kids/{0}\" alt=\"\">", item));
//                strib.AppendLine(string.Format("<a href=\"~/images/Kids/{0}\" class=\"popup-img overlay-link\" title=\"image title\"><i class=\"icon-plus-1\"></i></a>", item));
//                strib.AppendLine("</div>");
//            }
//            strib.AppendLine("</div>");
//            strib.AppendLine("<div class=\"content-slider-thumbs-container\">");
//            strib.AppendLine("<div class=\"owl-carousel content-slider-thumbs\">");
//            foreach (string item in product.productImages)
//            {

//                strib.AppendLine("<div class=\"owl-nav-thumb\">");
//                strib.AppendLine(string.Format("<img src=\"~/images/Kids/{0}\" alt=\"\">", item));
//                strib.AppendLine("</div>");

//            }
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("<!-- pills end -->");
//            strib.AppendLine("</div>");
//            strib.AppendLine("<div class=\"col-md-8 col-lg-7 pv-30\">");
//            strib.AppendLine("<h2>Description</h2>");
//            strib.AppendLine(string.Format("<p>{0}</p>", product.productDescription));
//            strib.AppendLine("<h4 class=\"space-top\">Specifications</h4>");
//            strib.AppendLine("<hr>");
//            strib.AppendLine("@{Html.RenderPartial(\"_WallPaperSpecification\");}");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("<!-- main end -->");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</div>");
//            strib.AppendLine("</section>");
//            strib.AppendLine("@{Html.RenderPartial(\"_BookAppointment\");}");
//            strib.AppendLine("@Html.Action(\"KidsRelatedProducts\", \"Product\", new { name = \"WoodSkinTexturedKids\" })".Replace("WoodSkinTexturedKids", product.productName));
//            File.WriteAllText(product.productName + ".cshtml", strib.ToString());
//        }
//    }


//    public class Product
//    {
//        public string productName;
//        public string productDescription;
//        public string linkProductName;
//        public string[] productImages;
//    }
}

