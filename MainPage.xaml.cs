using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Map = Esri.ArcGISRuntime.Mapping.Map;

namespace EsriMapTest
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            MyMapView.Map = new Map(new Basemap(new Uri("https://www.arcgis.com/home/item.html?id=ef5920f160bd4239bdeb1348de3a3156")));
            MyMapView.Map.LoadAsync();
            //MyMapView.LocationDisplay.IsEnabled = true;
        }
    }

}
