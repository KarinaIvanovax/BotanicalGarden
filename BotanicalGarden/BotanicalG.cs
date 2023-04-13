using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanicalGarden
{
    [System.Xml.Serialization.XmlRoot("BotanicalG")]
    public class BotanicalG
    {
        [System.Xml.Serialization.XmlElement("Растения")]
        public Plants Plants { get; set; }
        [System.Xml.Serialization.XmlElement("Животные")]
        public Animals Animals { get; set; }
        [System.Xml.Serialization.XmlElement("Информация о саде")]
        public Information Information { get; set; }
    }
    public class Plants
    {
        [System.Xml.Serialization.XmlElement("растение")]
        public Plant[] PlantsArray { get; set; }
    }

    public class Plant
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int pId { get; set; }
        [System.Xml.Serialization.XmlElement("название", Namespace = "")]
        public string pName { get; set; }
        [System.Xml.Serialization.XmlElement("окрас", Namespace = "")]
        public string pColour { get; set; }
        [System.Xml.Serialization.XmlElement("откуда", Namespace = "")]
        public string pFrom { get; set; }

     
    }
    public class Animals
    {
        [System.Xml.Serialization.XmlElement("зверек")]
        public Animal[] AnimalsArray { get; set; }
    }
    public class Animal
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int aId { get; set; }
        [System.Xml.Serialization.XmlElement("название", Namespace = "")]
        public string aName { get; set; }
        [System.Xml.Serialization.XmlElement("откуда", Namespace = "")]
        public string aFrom { get; set; }
        [System.Xml.Serialization.XmlElement("питание", Namespace = "")]
        public string aNutrition { get; set; }

    }
    public class Information
    {
        [System.Xml.Serialization.XmlElement("ill")]
        public Info[] InfoArray { get; set; }
    }
    public class Info
    {
        [System.Xml.Serialization.XmlAttribute("о саде", Namespace = "")]
        public string iPrice { get; set; }

        [System.Xml.Serialization.XmlElement("как добраться", Namespace = "")]
        public string iRoute { get; set; }

        [System.Xml.Serialization.XmlElement("часы работы и выходные дни", Namespace = "")]
        public string iWHours { get; set; }

    }

}
