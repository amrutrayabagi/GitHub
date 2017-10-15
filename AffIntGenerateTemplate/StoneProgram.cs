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
//                productName = "RedBricksCharm",
//                linkProductName = "Red Bricks Charm Wallpaper",
//                productDescription = "This magnificent Red Bricks charm wallpaper emphasizes the traditional & nature beauty of your home. A great selection for your home living room, dining area or featured wall. Moreover, this design is available in 4 wonderful colors for you to impress your guests. ",
//                productImages = new string[] { "RedBricksCharm.png" }
//            });

//            products.Add(new Product()
//            {
//                productName = "MagnificentBricks",
//                linkProductName = "Magnificent Bricks Wallpaper",
//                productDescription = "This Magnificent Bricks wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "MagnificentBricks.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "ElegantBricks",
//                linkProductName = "Elegant Bricks Wallpaper",
//                productDescription = "This Elegant Bricks wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection to add to your living room, dining area or featured wall.",
//                productImages = new string[] { "ElegantBricks.jpg " }
//            });

//            products.Add(new Product()
//            {
//                productName = "StunningBricks",
//                linkProductName = "Stunning Bricks Wallpaper",
//                productDescription = "This Stunning Bricks wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "StunningBricks.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "FantasyStones",
//                linkProductName = "Fantasy Stones Wallpaper",
//                productDescription = "This Fantasy Stones wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "FantasyStones.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "StunningStones",
//                linkProductName = "Stunning Stones Wallpaper",
//                productDescription = "This Stunning Stones wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "StunningStones.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "MarvelousStones",
//                linkProductName = "Marvelous Stones Wallpaper",
//                productDescription = "This Marvelous Stones Wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "MarvelousStones.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "Amazingbricks",
//                linkProductName = "Amazing bricks Wallpaper",
//                productDescription = "This Amazing Bricks wallpaper emphasizes the traditional & nature beauty of your home & office. A great selection for your living room, dining area or featured wall.",
//                productImages = new string[] { "Amazingbricks.PNG" }
//            });

//            products.Add(new Product()
//            {
//                productName = "RockSteps",
//                linkProductName = "Rock Steps Wallpaper",
//                productDescription = "This Rock Step wallpaper emphasizes the traditional & nature beauty of your Steps and Staircases & background of any TV Unit. A great selection for your Steps, Staircases, living room, dining area or featured wall.",
//                productImages = new string[] { "RockSteps.jpg" }
//            });

//            products.Add(new Product()
//            {
//                productName = "OceanBeachCalm",
//                linkProductName = "Ocean Beach Calm Wallpaper",
//                productDescription = "This Ocean Beach Calm wallpaper emphasizes the beauty of combination of Ocean, Beach and Nature Beauty for your living room & background of any TV Unit. A great selection for your Living Room, , dining area or featured wall.",
//                productImages = new string[] { "OceanBeachCalm.jpg" }
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
//                strib.AppendFormat("<img src=\"~/images/Stone/{0}\" alt=\"\">", product.productImages[0]);
//                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/Stone/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
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
//            File.WriteAllText("StoneRelatedProducts.cshtml", strib.ToString());
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
//                strib.AppendFormat("<img src=\"~/images/Stone/{0}\" alt=\"\">", product.productImages[0]);
//                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/Stone/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
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
//            strib.AppendLine("</section>");
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

//            File.WriteAllText("Stone.cshtml", strib.ToString());
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
//                strib.AppendLine(string.Format("<img src=\"~/images/Stone/{0}\" alt=\"\">", item));
//                strib.AppendLine(string.Format("<a href=\"~/images/Stone/{0}\" class=\"popup-img overlay-link\" title=\"image title\"><i class=\"icon-plus-1\"></i></a>", item));
//                strib.AppendLine("</div>");
//            }
//            strib.AppendLine("</div>");
//            strib.AppendLine("<div class=\"content-slider-thumbs-container\">");
//            strib.AppendLine("<div class=\"owl-carousel content-slider-thumbs\">");
//            foreach (string item in product.productImages)
//            {

//                strib.AppendLine("<div class=\"owl-nav-thumb\">");
//                strib.AppendLine(string.Format("<img src=\"~/images/Stone/{0}\" alt=\"\">", item));
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
//            strib.AppendLine("@Html.Action(\"StoneRelatedProducts\", \"Product\", new { name = \"WoodSkinTexturedStone\" })".Replace("WoodSkinTexturedStone", product.productName));
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

