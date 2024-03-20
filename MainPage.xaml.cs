using Esri.ArcGISRuntime.Mapping;
using Map = Esri.ArcGISRuntime.Mapping.Map;

namespace EsriMapTest
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPKd746d17db8a248429fa96aa9b5188f98NPIrC5a1kIzxJgKfPwzhfRm65jEydZtfxTWrZWt0cK9U-YeGQOwWcfAgygIGntkT";

            Task.Run(async () =>
            {
                MyMapView.Map = new Map(new Basemap(new Uri("https://www.arcgis.com/home/item.html?id=ef5920f160bd4239bdeb1348de3a3156")));
                await MyMapView.Map.LoadAsync();

                MyMapView.LocationDisplay.IsEnabled = true;
            });
        }
    }

}
