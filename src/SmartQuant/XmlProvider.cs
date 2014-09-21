//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmartQuant
{
    public struct XmlProvider
    {
        [XmlElement("id")]
        public int ProviderId;

        [XmlElement("instance")]
        public int InstanceId;

        [XmlArrayItem("property")]
        [XmlArray("properties")]
        public List<XmlProviderProperty> Properties;
    }
}
