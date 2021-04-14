using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.TagHelpers
{

    //[HtmlTargetElement("tr", Attributes = "bg-color,text-color", ParentTag = "thead")]
    //[HtmlTargetElement("tr", Attributes = "bg-color,text-color", ParentTag = "tbody")]
    //[HtmlTargetElement("tr", ParentTag = "tbody")]

    [HtmlTargetElement("*", Attributes = "bg-color,text-color")]
    public class TrTagHelper : TagHelper
    {
        public string BgColor { get; set; } = "dark";
        public string TextColor { get; set; } = "white";

        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class",
            $"bg-{BgColor} text-center text-{TextColor}");
        }
    }
}
