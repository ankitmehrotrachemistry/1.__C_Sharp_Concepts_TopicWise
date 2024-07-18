using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSON_Read_Parse_Plant_ASP
{
    public partial class ReadJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                String rawJSON = webClient.DownloadString("http://plantplaces.com/perl/mobile/viewplantsjson.pl?Combined_Name=Redbud");
                
                // Convert the JSON String to Series of Objects.
                PlantCollection plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawJSON);

                Console.WriteLine(plantCollection.Plants.Count);
            }
        }
    }
}