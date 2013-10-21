using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusAroundMe
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Agency
    {
        /// <summary>
        /// 
        /// </summary>
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private Uri uri;
        [XmlIgnore]
        public Uri Uri
        {
            get { return uri; }
            set { uri = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string timeZone;
        public string TimeZone
        {
            get { return timeZone; }
            set { timeZone = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string language;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string disclaimer;
        public string Disclaimer
        {
            get { return disclaimer; }
            set { disclaimer = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private bool privateService;
        public bool PrivateService
        {
            get { return privateService; }
            set { privateService = value; }
        }

    }
}
