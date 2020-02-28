using System.Xml.Serialization;
using System.Drawing;
using System.IO;
using System;

namespace FacebookFeaturesUI
{
    public class AppSettings
    {
        private static readonly string r_AppSettingsFilePath = AppDomain.CurrentDomain.BaseDirectory;

        public Point m_LastWindowLocation
        {
            get;
            set;
        }

        public bool m_RememberUser
        {
            get;
            set;
        }

        public string m_LastAccessToken
        {
            get;
            set;
        }

        private AppSettings()
        {
            m_LastWindowLocation = new Point(150, 30);
            m_RememberUser = false;
            m_LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = null;

            if (File.Exists(r_AppSettingsFilePath + @"\appSettings.xml"))
            {
                using (Stream stream = new FileStream(r_AppSettingsFilePath + @"\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                obj = new AppSettings();
            }

            return obj;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(r_AppSettingsFilePath + @"\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
