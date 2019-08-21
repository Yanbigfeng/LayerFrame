using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServerInfrastructure.Help.Config
{
  public  class LibConfig
    {
        #region 1.获取当前类库的文件配置
        /// <summary>
        /// 获取当前类库的文件配置:谁调用就读取谁的配置文件
        /// </summary>
        /// <returns></returns>
        public static Configuration InitAppConfig()
        {
            string baesePath = AppDomain.CurrentDomain.RelativeSearchPath;
            string fullName = Path.GetFileName(Assembly.GetCallingAssembly().Location);
            string path = string.Format(@"{0}\{1}.config", baesePath, fullName);
            if (File.Exists(path) == false)
            {
                string msg = string.Format("{0}路径下的文件未找到 ", path);
                throw new FileNotFoundException(msg);
            }
            try
            {
                ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
                configFile.ExeConfigFilename = path;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
                return config;
            }
            catch (Exception ex) { throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 2.获取当前指定位置应用程序文件配置
        /// <summary>
        /// 获取当前指定位置文件配置
        /// </summary>
        /// <param name="fullName">
        /// 部分定义路径：在配置文件为类库且在类库二级文件下
        /// 和文件名称</param>
        /// <returns></returns>
        public static Configuration InitAppConfig2(string fullName)
        {
            string baesePath = AppDomain.CurrentDomain.RelativeSearchPath;

            string path = string.Format(@"{0}\{1}.dll.config", baesePath, fullName);
            if (File.Exists(path) == false)
            {
                string msg = string.Format("{0}路径下的文件未找到 ", path);
                throw new FileNotFoundException(msg);
            }
            try
            {
                ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
                configFile.ExeConfigFilename = path;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
                return config;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region 3.获取指定位置文件配置
        /// <summary>
        /// 获取指定位置文件配置
        /// </summary>
        /// <param name="fullName">
        /// 部分定义路径：在配置文件为类库且在类库二级文件下
        /// 和文件名称</param>
        /// <returns></returns>
        public static Configuration InitConfig(string fullName)
        {
            string baesePath = AppDomain.CurrentDomain.RelativeSearchPath;

            string path = string.Format(@"{0}\{1}.config", baesePath, fullName);
            if (File.Exists(path) == false)
            {
                string msg = string.Format("{0}路径下的文件未找到 ", path);
                throw new FileNotFoundException(msg);
            }
            try
            {
                ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
                configFile.ExeConfigFilename = path;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
                return config;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
