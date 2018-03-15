using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Facebook;
using Newtonsoft.Json.Linq;

namespace FacebookPosting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          //  PublishPhoto();
          //  Initialize();
        }

        private static void Initialize()
        {
            string userAccessToken = "EAACEdEose0cBACBuSg8cy8QVqSfKiINlxjWPxgxkK76DnyqqkZA6qEyEnbLPnLjGPWJvL4uGBa9weSPmV8icMmiEXw07ylCpKcZCvZBPsx3QpgnCO3IVCUO4nZAZB2quI45c6KMf7ZAgo3jcRwbGYgjjmHIFNEZAmiwVaXPkz1Ehai47ayc8B2ZCYmtI7tZBQ2H8ZD";
            FacebookClient client = new FacebookClient(userAccessToken);
            dynamic parameters = new ExpandoObject();
            parameters.message = "Please click this link. http://oneproductsite.azurewebsites.net/home/productdetail";
            //parameters.link = "http://oneproductsite.azurewebsites.net/home/productdetail";
            JsonObject result = client.Post("me/feed", parameters);
            
            dynamic result2 = client.Post("/"+result[0].ToString());

        }

        private static void PublishPhoto()
        {
            string userAccessToken = "EAACEdEose0cBAGDCBSRKxWTeAHwQnZAqZBFs2KVKI0conctFEDsN2ZClPIyzNtGevr0TPb4dm9QpZAqKnLOPBc2rVk7c4oOzZCR3Vw8KfSm2aFVOYCiPvBnDxwBpdgrNSnaZCJnsPZBsg9FUUDpgNZAV0ZC5ROGnymZB7iZBTt62LFkzjbG22uSBRnWT9HtjoXxdusZD";
            FacebookClient client = new FacebookClient(userAccessToken);

            


            dynamic parameters = new ExpandoObject();
           

            FileStream imgStream = File.OpenRead("test.jpg");
            byte[] blob = new byte[imgStream.Length];
            imgStream.Read(blob, 0, (int)imgStream.Length);

            FacebookMediaObject uploadFileObject = new FacebookMediaObject();
            uploadFileObject.FileName = "test.jpg";
            uploadFileObject.ContentType = "image/jpeg";
            uploadFileObject.SetValue(blob);

            imgStream.Dispose();

            parameters.message = "Please link to purchase. http://oneproductsite.azurewebsites.net/home/productdetail";
            parameters.source = uploadFileObject;
            //JsonObject result = client.Post("me/photos", parameters);
            JsonObject result = client.Post("323941914785830/photos", parameters);
        }

        private static void GetAccessToken()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("client_id", "");
            parameters.Add("redirect_uri", "https:");
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            txtbxHeader.Text = string.Empty;
            MonaWebApiClient client = new MonaWebApiClient();
            var result = client.Register(string.Empty);



            var response = await result;
            txtbxHeader.Text = response.Headers.ToString();

        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            txtbxHeader.Text = string.Empty;
            MonaWebApiClient client = new MonaWebApiClient();
            AccessToken accessToken = await client.GetAccessTokenAsync("test@gmail.com", "Password1!");

            txtbxHeader.Text = accessToken.TokenString;
        }

        public class AccessToken
        {
            /// <summary>
            /// </summary>
            public DateTime Expiration { get; set; }

            /// <summary>
            /// </summary>
            public string TokenString { get; set; }
        }
    }
}
