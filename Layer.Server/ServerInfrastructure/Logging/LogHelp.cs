using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ServerInfrastructure.Help.Config;


namespace ServerInfrastructure.Logging
{
    /// <summary>
    /// 文件写日志
    /// </summary>
    public class LogHelp : ILogHelp
    {

        /// <summary>
        /// 保存的文件夹
        /// </summary>
        public static AppSettingsSection sd = LibConfig.InitAppConfig().AppSettings;
        private static string logPath = sd.Settings["LogPath"].Value.ToString();


        //这里考虑是否开放日志输出配置属性
        public static string LogPath
        {
            get
            {
                if (logPath == string.Empty)
                {
                    // 默认不配置
                    logPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\";
                }
                return logPath;
            }
            set
            {
                logPath = value;
            }

        }
        /// <summary>
        /// 日志前缀例如：ybf2018-09-27.txt
        /// </summary>
        private static string logFielPrefix = string.Empty;

        /// <summary>
        /// 写日志方法
        /// </summary>
        /// <param name="logFile">日志的级别类型</param>
        /// <param name="msg">内容</param>
        public static void WriteFile(string logFile, string msg)
        {
            try
            {
                System.IO.StreamWriter sw = System.IO.File.AppendText(
                    LogPath + logFielPrefix + logFile + " " +
                    DateTime.Now.ToString("yyyyMMdd") + ".Log"
                    );
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") + msg);
                sw.Close();
            }
            catch
            { }
        }
        /// <summary>
        /// 写日志方法
        /// </summary>
        /// <param name="logFile">日志枚举参数</param>
        /// <param name="msg">记录内容</param>
        public static void WriteFile(LogFile logFile, string msg)
        {
            try
            {
                WriteFile(logFile.ToString(), msg);
            }
            catch
            { }
        }
    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogFile
    {
        Trace,//
        Warning,//警告
        Error,//错误
    }
}
