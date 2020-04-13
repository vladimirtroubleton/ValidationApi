using Newtonsoft.Json;

namespace ValidApiCore3._1.JsonModels
{
    public class OrderJsonModel
    {
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("productCount")]
        public int ProductCount { get; set; }

        [JsonProperty("productPrice")]
        public double ProductPrice { get; set; }

        

        
    }
}
