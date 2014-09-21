//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System.Xml.Serialization;

namespace SmartQuant
{
    public struct XmlProviderProperty
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlText]
        public string Value;
    }
}
