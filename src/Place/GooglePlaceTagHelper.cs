using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWork.TagHelpers.Google
{
    [HtmlTargetElement("googleplace")]
    public class GooglePlaceTagHelper : TagHelper
    {
        public string Name { get; set; } = "Place";
        public string CustomCSS { get; set; } = "";
        public string OnItemSelected { get; set; } = "()=>{}";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustomTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;
            var htmlContent = await HTMLHelper.GetHtmlFileContent("html.googleplace");
            htmlContent = htmlContent.Replace("${name}", Name);
            htmlContent = htmlContent.Replace("${customCss}", CustomCSS);
            htmlContent = htmlContent.Replace("${onItemSelected}", OnItemSelected);
            output.PreContent.SetHtmlContent(htmlContent);
        }
    }
}