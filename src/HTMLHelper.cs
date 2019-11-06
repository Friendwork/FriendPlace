using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace FriendsWork.TagHelpers
{
    public class HTMLHelper
    {
        ///<summary>
        /// Get content of html file in assembly 
        ///</summary>
        public static async Task<string> GetHtmlFileContent(string htmlFileName, object model = null)
        {
            var assembly = Assembly.GetAssembly(typeof(HTMLHelper));
            var htmlContentStream = assembly.GetManifestResourceStream(htmlFileName);
            StreamReader sr = new StreamReader(htmlContentStream);
            var html = await sr.ReadToEndAsync();
            return html;
        }
    }
}