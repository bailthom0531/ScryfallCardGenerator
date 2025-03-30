using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScryfallCardGenerator.Tools
{
    public class CardInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("color_identity")]
        public List<string> ColorIdentity { get; set; }

        [JsonProperty("image_uris")]
        public ImageUris ImageUris { get; set; }

        // This method fetches the image and returns it as an Image object
        public async Task<Image> GetImageAsync(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms); // Return the Image
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions if the image cannot be loaded
                    MessageBox.Show("Error loading image: " + ex.Message);
                    return null; // Return null if there was an error
                }
            }
        }

        // Helper method to get the 'normal' image URL
        public string ImageUrl => ImageUris?.Normal;
    }

    public class ImageUris
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

}
