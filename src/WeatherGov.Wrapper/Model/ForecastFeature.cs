using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherGov.Wrapper.Model
{
    public class ForecastFeature : Feature
    {
        public ForecastFeature(IGeometryObject geometry, IDictionary<string, object> properties = null, string id = null) : base(geometry, properties, id)
        {
        }

        public List<GridpointForecastPeriod> Periods { get; set; }

        public static ForecastFeature FromFeature(Feature feature)
        {
            ForecastFeature ffeature = new ForecastFeature(feature.Geometry, feature.Properties, feature.Id);
            ffeature.Periods = new List<GridpointForecastPeriod>();

            if (feature.Properties!= null && feature.Properties.ContainsKey("periods"))
            {
                var jarr = (JArray)feature.Properties["periods"];
                foreach ( var j1 in jarr)
                {
                    ffeature.Periods.Add(JsonConvert.DeserializeObject<GridpointForecastPeriod>(JsonConvert.SerializeObject(j1)));
                }
                
            }
            return ffeature;
        }
    }
}
