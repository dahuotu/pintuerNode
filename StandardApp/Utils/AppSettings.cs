using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace com.DaHuotu
{
    public class AppSettings
    {

        /*
        //调用    
        string[] sections = new string[] { "section1", "section2", "section3", "section4" };
        foreach (string section in sections)
        {
            for (int i = 0; i < 3; i++)
            {
                setString(section, section + "key" + i, section + "value" + i);
            }
        }
        string result = string.Empty;
        foreach (string section in sections)
        {
            result += string.Format("配置节点：{0}", section);
            for (int i = 0; i < 3; i++)
            {
                string childSection = string.Format("{0}", section + "key" + i);
                result += string.Format("\r\n\tkey：{0}，", childSection);
                result += string.Format("value：{0}", getString(section, childSection));
            }
            result += "\r\n";
        }
        MessageBox.Show(result);
            
        */

        //其他变量
        public static string conncetString { set; get; }
        private static string _configFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\appString\user.config";
        private static string configFile { get { return _configFile; } }
        private static Configuration _config;

        /// <summary>
        /// 配置对象
        /// </summary>
        public static Configuration config
        {
            get
            {
                if (_config != null) { return _config; }
                else
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                    fileMap.ExeConfigFilename = configFile;
                    _config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                    return _config;
                }
            }
        }

        /// <summary>
        /// 获取节点值
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">key关键字</param>
        /// <returns>返回value值</returns>
        public static string getString(string section, string key)
        {
            try
            {
                Configuration configuration = config;
                AppSettingsSection newSection = appSection(section);
                if (newSection.Settings[key] == null) { return ""; }
                else { return newSection.Settings[key].Value; }
            }
            catch { return ""; }
        }

        /// <summary>
        /// 设置节点值
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">key关键字</param>
        /// <param name="value">返回value值</param>
        public static void setString(string section, string key, string value)
        {
            try
            {
                Configuration configuration = config;
                AppSettingsSection appSetting = appSection(section);
                if (appSetting.Settings[key] == null) { appSetting.Settings.Add(key, value); }
                else { appSetting.Settings[key].Value = value; }
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(section);
            }
            catch (System.Exception Ex) { }
        }

        /// <summary>
        /// 获取所有节点下的值
        /// </summary>
        /// <param name="sectionName">节点名称</param>
        /// <returns>返回所有节点值</returns>
        public static AppSettingsSection appSection(string sectionName)
        {
            AppSettingsSection appSetting = (AppSettingsSection)config.GetSection(sectionName);
            if (appSetting != null) { return appSetting; }
            try
            {
                appSetting = new AppSettingsSection();
                config.Sections.Add(sectionName, appSetting);
                appSetting.SectionInformation.ForceSave = true;
                config.Save(ConfigurationSaveMode.Modified);
                return appSetting;
            }
            catch (ConfigurationErrorsException Ex) { return null; }
        }
    }
}