using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MVCExcercise.Models
{
    [Serializable()]
    public class Proj
    {
        [XmlElement("ProjectId")]
        public string ProjectId { get; set; }

        [XmlElement("ProjectNumber")]
        public string ProjectNumber { get; set; }

        [XmlArray("AllSubmissions")]
        [XmlArrayItem("Sub", typeof(Sub))]
        public List<Sub> AllSubmissions { get; set; }
    }
}