using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UP_manager
{
    static class RegCard
    {
        public static void PfrRegCard_create(string name, string pfr, string pfr_code, string cert_cont, string card_path)
        {
            XmlTextWriter textWritter = new XmlTextWriter(card_path, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("регистрационнаяИнформация");
            textWritter.WriteEndDocument();
            textWritter.Close();

            XmlDocument document = new XmlDocument();
            document.Load(card_path);

            XmlNode element = document.CreateElement("датаВремяФормирования");
            document.DocumentElement.AppendChild(element);
            element.InnerText = DateTime.Now.ToString();

            element = document.CreateElement("списокСубъектов");
            document.DocumentElement.AppendChild(element);

            XmlNode subject = document.CreateElement("субъект");
            element.AppendChild(subject);

            XmlAttribute attribute = document.CreateAttribute("идентификаторСубъекта"); // создаём атрибут
            attribute.Value = pfr; // устанавливаем значение атрибута
            subject.Attributes.Append(attribute); // добавляем атрибут

            attribute = document.CreateAttribute("типСубъекта");
            attribute.Value = "АбонентСЭД";
            subject.Attributes.Append(attribute);

            attribute = document.CreateAttribute("имя");
            attribute.Value = name;
            subject.Attributes.Append(attribute);

            attribute = document.CreateAttribute("кодУчастка");
            attribute.Value = pfr_code;
            subject.Attributes.Append(attribute);

            attribute = document.CreateAttribute("пароль");
            attribute.Value = pfr.Remove(0, 8);
            subject.Attributes.Append(attribute);

            XmlNode cert_list = document.CreateElement("списокСертификатов");
            subject.AppendChild(cert_list);

            attribute = document.CreateAttribute("типПодписанта");
            attribute.Value = "руководитель";
            cert_list.Attributes.Append(attribute);

            XmlNode cert = document.CreateElement("сертификат");
            cert.InnerText = cert_cont;
            cert_list.AppendChild(cert);

            attribute = document.CreateAttribute("активный");
            attribute.Value = "true";
            cert.Attributes.Append(attribute);



            document.Save(card_path);
        }
    }
}
