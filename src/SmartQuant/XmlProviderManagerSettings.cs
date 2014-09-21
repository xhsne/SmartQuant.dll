//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmartQuant
{
    [XmlRoot("settings")]
    public struct XmlProviderManagerSettings
    {
        [XmlArrayItem("provider")]
        [XmlArray("providers")]
        public List<XmlProvider> Providers;
    }
}
