using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;
using AxMapWinGIS;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int providerId;
        TileProviders providers;

        static int zoom;
        static int y ;
        static int x;

        static string baseUrl = "http://127.0.0.1:8080/map/z{zoom}/{y}/{x}.png";
        string formattedUrl = baseUrl.Replace("{zoom}", zoom.ToString())
                                     .Replace("{y}", y.ToString())
                                     .Replace("{x}", x.ToString());

        public Form1()
        {
            InitializeComponent();
        }

        private void GoogleMapsBtn_Click(object sender, EventArgs e)
        {
            providers = axMap1.Tiles.Providers;
            providerId = (int)tkTileProvider.ProviderCustom + 1001;

            providers.Add(providerId, "map", formattedUrl, tkTileProjection.SphericalMercator, 0, 10);
            
            axMap1.Tiles.ProviderId = providerId;
        }
    }
}
