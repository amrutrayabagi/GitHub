using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffIntGenerateTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                productName = "BleachedWalnut",
                linkProductName = "Bleached walnut" + " Wooden Floor",
                productDescription = "Walnut Wood Grain print with an all over contemporary grey-off white colour wash.",
                productImages = new string[] { "BleachedWalnut.jpg" }
            });

            products.Add(new Product()
            {
                productName = "AfricanWalnut",
                linkProductName = "African walnut" + " Wooden Floor",
                productDescription = "This is a golden yellow to reddish brown, sometimes with darker streaks and veins. Color tends to darken upon exposure and with age. Sapwood is a medium yellow to light gray,and is generally narrow.",
                productImages = new string[] { "AfricanWalnut.jpg" }
            });

            products.Add(new Product()
            {
                productName = "BrandyWoodenFlooring",
                linkProductName = "Brandy" + " Wooden Floor",
                productDescription = "This hard, dense, open-grained wood has an inherent, traditional warmth. Ranging from a pinkish light wheat color to a rich, golden tone, oak also takes stains well.",
                productImages = new string[] { "BrandyWoodenFlooring.jpg" }
            });


            products.Add(new Product()
            {
                productName = "GunstockOak",
                linkProductName = "Gunstock Oak" + " Wooden Floor",
                productDescription = "The traditional, warm look and rustic character of oak,Dura-Luster Plus finish provides long-lasting shine and beauty.With the robust grain characteristics of oak hardwood add a touch of rustic character for a unique charm in your decor. With the Dura-Luster Finish ",
                productImages = new string[] { "GunstockOak.jpg" }
            });

            products.Add(new Product()
            {
                productName = "Havana",
                linkProductName = "Havana" + " Wooden Floor",
                productDescription = "Creates a startling level of realism as the surface of the floor matches the pattern underneath it. Remember to complete your project you'll need Underlay, Trims and Threshold Bars.",
                productImages = new string[] { "Havana.jpg" }
            });

            products.Add(new Product()
            {
                productName = "LightGrayOak",
                linkProductName = "Light Gray Oak" + " Wooden Floor",
                productDescription = "The mid tone in the colour range, Oak Trends Havana Timber Flooring is defined by its deep brown highlights offset against yellow and amber timber tones. Guaranteed to be a feature in any room.",
                productImages = new string[] { "LightGrayOak.jpg" }
            });

            products.Add(new Product()
            {
                productName = "LusaWalnut",
                linkProductName = "Lusa walnut Oak" + " Wooden Floor",
                productDescription = "The mid tone in the colour range, Oak Trends Havana Timber Flooring is defined by its deep brown highlights offset against yellow and amber timber tones. Guaranteed to be a feature in any room.",
                productImages = new string[] { "LusaWalnut.jpg" }
            });

            products.Add(new Product()
            {
                productName = "Merbau3Strips",
                linkProductName = "Merbau 3 strips" + " Wooden Floor",
                productDescription = "Merbau wood flooring is suitable for all domestic and commercial projects, and is a very popular species, commonly used for high-end refurbishments in place of Mahogany or Sapele.",
                productImages = new string[] { "Merbau3Strips.jpg" }
            });

            products.Add(new Product()
            {
                productName = "Oak country",
                linkProductName = "Oak country" + " Wooden Floor",
                productDescription = "It’s a readily available hardwood with a long history of use in fine construction and wood working throughout history. The quality and consistency of the grain pattern in Oak is one of the most popular characteristics of an Oak hardwood floor along with it’s proven durability.",
                productImages = new string[] { "OakCountry.jpg" }
            });

            products.Add(new Product()
            {
                productName = "OliveWood",
                linkProductName = "Olive wood" + " Wooden Floor",
                productDescription = "It’s a readily available hardwood with a long history of use in fine construction and wood working throughout history. The quality and consistency of the grain pattern in Oak is one of the most popular characteristics of an Oak hardwood floor along with it’s proven durability.",
                productImages = new string[] { "OliveWood.jpg" }
            });

            products.Add(new Product()
            {
                productName = "PangaPanaga",
                linkProductName = "Panga Panga" + " Wooden Floor",
                productDescription = "Panga Panga wood flooring is suitable for all domestic and most commercial projects, and is a very unusual species that makes for a unique appearance.",
                productImages = new string[] { "PangaPanaga.jpg" }
            });

            products.Add(new Product()
            {
                productName = "ShutterOak",
                linkProductName = "Shutter oak" + " Wooden Floor",
                productDescription = "Oak is a heavy wood which makes very heavy window hardwood shutters. Oak interior shutters add much weight to window jambs and screws require pre-drilling. Oak wood shutters are not suitable for painting and Oak shutter louvers tend to warp.",
                productImages = new string[] { "ShutterOak.jpg" }
            });


            products.Add(new Product()
            {
                productName = "SilverWood",
                linkProductName = "Silver wood" + " Wooden Floor",
                productDescription = "Silver is a really clever choice for wood flooring. Why? Because it’s so versatile and it is sure to stand the test of time. When working on interior colour schemes, people are currently tending to go for warm, natural colours or a mix of monochrome black and white with the occasional splash of colour right now. And not so very long ago, a monochrome interior called for either a black or a white floor as the perfect backdrop. But the introduction of a great choice of silver, grey wood flooring has caught the eye of many discerning interior lovers.",
                productImages = new string[] { "SilverWood.jpg" }
            });

            products.Add(new Product()
            {
                productName = "StableOak",
                linkProductName = "Stable oak" + " Wooden Floor",
                productDescription = "The oak tree is synonymous with stability and strength. So much so, that companies have been known to use the oak tree as the image in their logo because it implies to their customers that they are strong and long-lasting – that they are going to provide good service or good products for a very long time.",
                productImages = new string[] { "StableOak.jpg" }
            });

            products.Add(new Product()
            {
                productName = "SummerOak",
                linkProductName = "Summer oak" + " Wooden Floor",
                productDescription = "The oak tree is synonymous with stability and strength. So much so, that companies have been known to use the oak tree as the image in their logo because it implies to their customers that they are strong and long-lasting – that they are going to provide good service or good products for a very long time.",
                productImages = new string[] { "SummerOak.jpg" }
            });

            products.Add(new Product()
            {
                productName = "TobacoOak",
                linkProductName = "Tobaco Oak" + " Wooden Floor",
                productDescription = "Tobacco Oak's cool neutral brown color with amber tones will fit in almost any home decor. A dark fill brings out the rustic elements like cracks and splits while the multi-level gloss highlights the designs natural character. Beauty and strength come together in this incredibly durable laminate floor",
                productImages = new string[] { "TobacoOak.jpg" }
            });

            products.Add(new Product()
            {
                productName = "Walnut3Strips",
                linkProductName = "Walnut 3 strips" + " Wooden Floor",
                productDescription = "3 Strip Walnut is a stunning 7mm laminate floor.  With rich chocolate earthen tones, it will be easy to style around this floor to achieve the most beautiful interior possible!",
                productImages = new string[] { "Walnut3Strips.jpg" }
            });

            products.Add(new Product()
            {
                productName = "Wenge",
                linkProductName = "Wenge" + " Wooden Floor",
                productDescription = "Wenge floors are suitable for all domestic and some light commercial applications, and is a very select species, which is mostly used for high-end refurbishments and designer projects. Wenge wood flooring is ideal for areas with high levels of use.",
                productImages = new string[] { "Wenge.jpg" }
            });


            GenerateMainPage(products);
            GenerateRelatedProductsPage(products);

            foreach (var product in products)
            {
                GenerateProduct(product);
            }


        }

        private static void GenerateRelatedProductsPage(List<Product> products)
        {
            StringBuilder strib = new StringBuilder();
            strib.AppendLine("<section class=\"section light-gray-bg clearfix\">");
            strib.AppendLine("<div class=\"container\">");
            strib.AppendLine("<div class=\"row\">");
            strib.AppendLine("<div class=\"col-md-12\">");
            strib.AppendLine("<!-- Tab panes -->");
            strib.AppendLine("<div class=\"tab-content clear-style\">");
            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
            strib.AppendLine("<div class=\"row masonry-grid-fitrows grid-space-10\">");
            foreach (var product in products)
            {
                strib.AppendFormat(" @if (ViewBag.Product != \"{0}\")", product.productName);
                strib.AppendLine("{");
                strib.AppendLine("<div class=\"col-md-3 col-sm-6 masonry-grid-item\">");
                strib.AppendLine("<div class=\"listing-item white-bg bordered mb-20\">");
                strib.AppendLine("<div class=\"overlay-container\">");
                strib.AppendFormat("<img src=\"~/images/WoodenFlooring/{0}\" alt=\"\">", product.productImages[0]);
                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/WoodenFlooring/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
                strib.AppendLine("<div class=\"overlay-to-top links\">");
                strib.AppendLine("<span class=\"small\">");
                strib.AppendFormat("<a href=\"/product/product?name={0}\" class=\"btn-sm-link\"><i class=\"icon-link pr-5\"></i>View Details</a>", product.productName);
                strib.AppendLine("</span>");
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
                strib.AppendLine("<div class=\"body\">");
                strib.AppendLine("<h3>");
                strib.AppendFormat("<a href=\"/product/product?name={0}\">{1}</a>", product.productName, product.linkProductName);
                strib.AppendLine("</h3>");
                strib.AppendFormat("<p class=\"small\">{0}</p>", product.productDescription);
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
                strib.AppendLine("}");
            }
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div></section>");
            File.WriteAllText("_WoodenFlooringRelatedProducts.cshtml", strib.ToString());
        }

        private static void GenerateMainPage(List<Product> products)
        {
            StringBuilder strib = new StringBuilder();
            strib.AppendLine("@{");
            strib.AppendLine("ViewBag.Title = \"Home Page\";}");

            strib.AppendLine("<!-- banner start -->" +
"<div class=\"banner clearfix\">" +
 "   <div class=\"slideshow\">" +
  "      <div class=\"slider-banner-container\">" +
   "         <div class=\"slider-banner-fullscreen\">" +
    "            <ul class=\"slides\">" +
     "               <!-- slide 1 start -->" +
      "              <li data-transition=\"random-static\" data-slotamount=\"7\" data-masterspeed=\"500\" data-saveperformance=\"on\" data-title=\"\">" +
       "                 <!-- main image -->" +
        "                <img src =\"~/images/Wallpapers/wallpapers.jpg\" alt=\"slidebg1\" data-bgposition=\"center top\" data-bgrepeat=\"no-repeat\" data-bgfit=\"cover\">" +
         " <!-- Transparent Background -->" +
          "              <div class=\"tp-caption dark-translucent-bg\"" +
           "                  data-x=\"center\"" +
            "                 data-y=\"bottom\"" +
             "                data-speed=\"500\"" +
              "               data-easing=\"easeOutQuad\"" +
               "              data-start=\"0\"" +
                "             data-endspeed=\"0\">" +
                 "       </div>" +
                  "      <!-- LAYER NR. 4 -->" +
                   " <div class=\"tp-caption large_white\"" +
                    "         data-x=\"left\"" +
                     "        data-y=\"200\"" +
                      "       data-speed=\"500\"" +
                       "      data-easing=\"easeOutQuad\"" +
                        "     data-start=\"0\"" +
                         "    data-end=\"10000\"" +
                          "   data-endspeed=\"0\">" +
                           " Wallpapers<br />" +
                        "</div>" +
                        "<div class=\"tp-caption sfb fadeout large_white tp-resizeme hidden-xs\"" +
                         "    data-x=\"left\"" +
                          "   data-y=\"250\"" +
                           "  data-speed=\"500\"" +
                            " data-start=\"0\"" +
                             "data-end=\"10000\"" +
                             "data-endspeed=\"0\"" +
                             "data-easing=\"easeOutQuad\">" +
                            "<div class=\"separator-2 light\"></div>" +
                        "</div>" +
                        "<!-- LAYER NR. 9 -->" +
                        "<div class=\"tp-caption sft fadeout small_white \"" +
                           "  data-x=\"left\"" +
                          "   data-y=\"280\"" +
                         "    data-speed=\"500\"" +
                        "     data-easing=\"easeOutQuad\"" +
                       "      data-start=\"0\"" +
                      "       data-end=\"10000\"" +
                     "        data-endspeed=\"0\">" +
                    "        WallFlavors brings you an unrivelled range of gorgeous, unique and exclusive wallpapers." +
                   "     </div>" +
                  "      <!-- LAYER NR. 10 -->" +
                 "       <div class=\"tp-caption fade fadeout\"" +
                "             data-x=\"center\"" +
               "              data-y=\"bottom\"" +
              "               data-voffset=\"100\"" +
             "                data-speed=\"500\"" +
            "                 data-easing=\"easeOutQuad\"" +
           "                  data-start=\"0\"" +
          "                   data-end=\"10000\"" +
         "                    data-endspeed=\"0\">" +
        "                    <a href =\"#page-start\" class=\"btn btn-lg moving smooth-scroll\"><i class=\"icon-down-open-big\"></i><i class=\"icon-down-open-big\"></i><i class=\"icon-down-open-big\"></i></a>" +
       "                 </div>" +
      "              </li>" +
     "               <!-- slide 1 end -->" +
    "            </ul>" +
   "             <div class=\"tp-bannertimer\"></div>" +
  "          </div>" +
 "       </div>" +
 "   </div>" +
"</div>" +
"<!-- banner end -->" +
"<div id =\"page-start\"></div>" +
"<!-- section start -->" +

"<section class=\"section dark-bg clearfix\">" +
    "<!-- Nav tabs -->" +
    "<ul class=\"nav nav-pills dark-bg stickynav\" role=\"tablist\">" +
    "    <li class=\"active\"><a href=\"#pill-1\" role=\"tab\" data-toggle=\"tab\" title=\"Latest Arrivals\"><i class=\"icon-star\"></i> Latest Arrivals</a></li>" +
   "     <li><a href =\"#pill-2\" role=\"tab\" data-toggle=\"tab\" title=\"Featured\"><i class=\"icon-heart\"></i> Featured</a></li>" +
  "      <li><a href =\"#pill-3\" role=\"tab\" data-toggle=\"tab\" title=\"Top Sellers\"><i class=\" icon-up-1\"></i> Top Sellers</a></li>" +
 "   </ul>" +
"</section>");
            strib.AppendLine("<div id=\"page-start\"></div>");
            strib.AppendLine("<section class=\"section light-gray-bg clearfix\">");
            strib.AppendLine("<div class=\"container\">");
            strib.AppendLine("<div class=\"row\">");
            strib.AppendLine("<div class=\"col-md-12\">");
            strib.AppendLine("<!-- Tab panes -->");
            strib.AppendLine("<div class=\"tab-content clear-style\">");
            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
            strib.AppendLine("<div class=\"row masonry-grid-fitrows grid-space-10\">");
            foreach (var product in products)
            {
                strib.AppendLine("<div class=\"col-md-3 col-sm-6 masonry-grid-item\">");
                strib.AppendLine("<div class=\"listing-item white-bg bordered mb-20\">");
                strib.AppendLine("<div class=\"overlay-container\">");
                strib.AppendFormat("<img src=\"~/images/WoodenFlooring/{0}\" alt=\"\">", product.productImages[0]);
                strib.AppendFormat("<a class=\"overlay-link popup-img-single\" href=\"~/images/WoodenFlooring/{0}\"><i class=\"fa fa-search-plus\"></i></a>", product.productImages[0]);
                strib.AppendLine("<div class=\"overlay-to-top links\">");
                strib.AppendLine("<span class=\"small\">");
                strib.AppendFormat("<a href=\"/product/product?name={0}\" class=\"btn-sm-link\"><i class=\"icon-link pr-5\"></i>View Details</a>", product.productName);
                strib.AppendLine("</span>");
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
                strib.AppendLine("<div class=\"body\">");
                strib.AppendLine("<h3>");
                strib.AppendFormat("<a href=\"/product/product?name={0}\">{1}</a>", product.productName, product.linkProductName);
                strib.AppendLine("</h3>");
                strib.AppendFormat("<p class=\"small\">{0}</p>", product.productDescription);
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
                strib.AppendLine("</div>");
            }
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</section>");
            strib.AppendLine("<section class=\"section default-bg\">");
            strib.AppendLine("<div class=\"container\">");
            strib.AppendLine("<div class=\"call-to-action text-center\">");
            strib.AppendLine("<div class=\"row\">");
            strib.AppendLine("<div class=\"col-sm-8 col-sm-offset-2\">");
            strib.AppendLine("<div class=\"title container-title\">Book an appointment for free consultation</div>");
            strib.AppendLine("<p>with our expert team to get started on your dream home</p>");
            strib.AppendLine("<div class=\"separator\"></div>");
            strib.AppendLine("<p><a href=\"/forms/booknow\" class=\"btn btn-lg btn-gray-transparent btn-animated\">Book now<i class=\"fa fa-arrow-right");
            strib.AppendLine("pl-20\"></i></a></p>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</section>");

            File.WriteAllText("WoodenFlooring.cshtml", strib.ToString());
        }

        private static void GenerateProduct(Product product)
        {
            StringBuilder strib = new StringBuilder();
            strib.AppendLine("@{");
            strib.AppendLine("ViewBag.Title = \"Home Page\";}");
            strib.AppendLine("<section class=\"main-container\">");
            strib.AppendLine("<div class=\"container\">");
            strib.AppendLine("<div class=\"row\">");
            strib.AppendLine("<div class=\"main col-md-12\"> ");
            strib.AppendLine(string.Format("<h1 class=\"page-title text-center\">{0}</h1>", product.linkProductName));
            strib.AppendLine("<div class=\"separator with-icon\"><i class=\"fa fa-shopping-bag bordered\"></i></div>");
            strib.AppendLine("<div class=\"row\">");
            strib.AppendLine("<div class=\"col-md-4 col-lg-5\">");
            strib.AppendLine("<ul class=\"nav nav-pills\" role=\"tablist\">");
            strib.AppendLine("<li class=\"active\"><a href=\"#pill-1\" role=\"tab\" data-toggle=\"tab\" title=\"images\"><i class=\"fa fa-camera pr-5\"></i> Photo</a></li></ul>");
            strib.AppendLine("<div class=\"tab-content clear-style\">");
            strib.AppendLine("<div class=\"tab-pane active\" id=\"pill-1\">");
            strib.AppendLine("<div class=\"owl-carousel content-slider-with-thumbs mb-20\">");
            foreach (string item in product.productImages)
            {
                strib.AppendLine("<div class=\"overlay-container overlay-visible\">");
                strib.AppendLine(string.Format("<img src=\"~/images/WoodenFlooring/{0}\" alt=\"\">", item));
                strib.AppendLine(string.Format("<a href=\"~/images/WoodenFlooring/{0}\" class=\"popup-img overlay-link\" title=\"image title\"><i class=\"icon-plus-1\"></i></a>", item));
                strib.AppendLine("</div>");
            }
            strib.AppendLine("</div>");
            strib.AppendLine("<div class=\"content-slider-thumbs-container\">");
            strib.AppendLine("<div class=\"owl-carousel content-slider-thumbs\">");
            foreach (string item in product.productImages)
            {

                strib.AppendLine("<div class=\"owl-nav-thumb\">");
                strib.AppendLine(string.Format("<img src=\"~/images/WoodenFlooring/{0}\" alt=\"\">", item));
                strib.AppendLine("</div>");

            }
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("<!-- pills end -->");
            strib.AppendLine("</div>");
            strib.AppendLine("<div class=\"col-md-8 col-lg-7 pv-30\">");
            strib.AppendLine("<h2>Description</h2>");
            strib.AppendLine(string.Format("<p>{0}</p>", product.productDescription));
            strib.AppendLine("<h4 class=\"space-top\">Specifications</h4>");
            strib.AppendLine("<hr>");
            strib.AppendLine("@{Html.RenderPartial(\"_WallPaperSpecification\");}");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("<!-- main end -->");
            strib.AppendLine("</div>");
            strib.AppendLine("</div>");
            strib.AppendLine("</section>");
            strib.AppendLine("@{Html.RenderPartial(\"_BookAppointment\");}");
            strib.AppendLine("@Html.Action(\"WoodenFlooringRelatedProducts\", \"Product\", new { name = \"WoodSkinTexturedWoodenFlooring\" })".Replace("WoodSkinTexturedWoodenFlooring", product.productName));
            File.WriteAllText(product.productName + ".cshtml", strib.ToString());
        }
    }


    public class Product
    {
        public string productName;
        public string productDescription;
        public string linkProductName;
        public string[] productImages;
    }
}

