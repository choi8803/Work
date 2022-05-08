using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _18_Timer
{
    public class CXMLControl
    {
        // Dictionary 및 XML의 항목을 정의 
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";

        /// <summary>
        /// XML을 저장하기 위해 사용
        /// </summary>
        /// <param name="strXMLPath">저장 할 XML File경로 및 파일명</param>
        /// <param name="DXMLConfig">XML로 저장 할 항목</param>
        public void fXML_Writer(string strXMLPath, Dictionary<string,string> DXMLConfig)
        {
            StringBuilder sb = new StringBuilder();
            //using(XmlWriter wr = XmlWriter.Create(strXMLPath))
            using(XmlWriter wr = XmlWriter.Create(sb))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }

            // 암호화
            string strRijndaelText = CRijndael.EncryptString(sb.ToString(), CRijndael._bkey);
            File.WriteAllText(strXMLPath, strRijndaelText);
        }

        /// <summary>
        /// XML을 읽어오기 위해 사용
        /// </summary>
        /// <param name="strXMLPath"></param>
        /// <returns></returns>
        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {
            string strRijndaelText = File.ReadAllText(strXMLPath);
            string strOECText = CRijndael.DecryptString(strRijndaelText, CRijndael._bkey);

            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            //using (XmlReader rd = XmlReader.Create(strXMLPath))
            using (XmlReader rd = XmlReader.Create(new StringReader(strOECText)))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            //string strID = rd["ID"];
                            rd.Read();

                            string strTemp = rd.ReadElementContentAsString(_TICK, "");
                            DXMLConfig.Add(_TICK, strTemp);

                            strTemp = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTemp);

                            strTemp = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strTemp);

                            strTemp = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strTemp);

                            strTemp = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXMLConfig.Add(_LEVEL_50, strTemp);
                        }
                    }
                }
            }
            return DXMLConfig;
        }

    }
}
