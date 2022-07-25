using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

using Newtonsoft.Json;


namespace CraftDemonstration
{
    public partial class DesktopApplication : Form
    {
        private int searchBtnClickCount = 0;

        public DesktopApplication()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            searchBtnClickCount++;
            if (searchBtnClickCount > 1)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            var text = SearchTextbox.Text;

            using (var client = new HttpClient())
            {
                var flickrApiUrl = GetFlickrApiUrl(text);
                client.BaseAddress = new Uri(flickrApiUrl);

                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var httpResponse = responseTask.Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    var readTask = httpResponse.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var rawData = readTask.Result;
                    var jsonFormatData = rawData.Substring(14, (rawData.Length - 28));
                    var jsonDataToBeDeserialised = jsonFormatData.Insert(jsonFormatData.Length, "}");
                    DeserialiseToApiDataModel(jsonDataToBeDeserialised);
                }
            }
        }

        public string GetFlickrApiUrl(string searchString)
        {
            return $"https://api.flickr.com/services/rest/?format=json&method=flickr.photos.search&api_key=793bf235e9b0d2640da1985f77d524d6&tags=%27+{searchString}+%27&jsoncallback=?";
        }

        public void DeserialiseToApiDataModel(string json)
        {
            var deserialisedJsonData = JsonConvert.DeserializeObject<ApiData>(json);
            var imageUrlList = new List<string>();
            foreach (var pic in deserialisedJsonData.photos.photo)
            {
                var correctedFarm = pic.farm == 0 ? 1 : pic.farm;
                imageUrlList.Add(CreateimageUri(correctedFarm, pic.server, pic.secret, pic.id));
            }
            DisplayImagesInLayoutPanel(imageUrlList);
        }

        public string CreateimageUri(int farm, string server, string secret, string id)
        {
            return $"http://farm{farm}.staticflickr.com/{server}/{id}_{secret}.jpg";
        }

        public void DisplayImagesInLayoutPanel(List<string> imageUrl)
        {
            int imageCount = imageUrl.Count;
            int x = 10, y = 20;
            for (int i = 0; i < imageCount; i++)
            {
                var image = new PictureBox()
                {
                    ImageLocation= imageUrl[i],
                    Location = new Point(x, y),
                    SizeMode = PictureBoxSizeMode.CenterImage
                };
                image.Height = 100;
                image.Width = 100;
                image.BackgroundImageLayout = ImageLayout.Stretch;
                flowLayoutPanel1.SuspendLayout();
                flowLayoutPanel1.Controls.Add(image);
                flowLayoutPanel1.ResumeLayout();
                flowLayoutPanel1.AutoScroll = true;
            }

           


        }
     
    }
}