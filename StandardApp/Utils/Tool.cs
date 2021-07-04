using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections.Generic;
using System.Xml;
using System.Data;
using System.IO;

namespace com.DaHuotu
{
    public static class Tool
    {
        private static string CmdPath = @"cmd.exe";

        /// <summary>
        /// 执行cmd命令
        /// 多命令请使用批处理命令连接符：
        /// <![CDATA[
        /// &:同时执行两个命令
        /// |:将上一个命令的输出,作为下一个命令的输入
        /// &&：当&&前的命令成功时,才执行&&后的命令
        /// ||：当||前的命令失败时,才执行||后的命令]]>
        /// 其他请百度
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="output"></param>
        public static void RunCmd(string cmd, out string output)
        {
            cmd = cmd.Trim().TrimEnd('&') + "&exit";//说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                p.Start();//启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
            }
        }

        /// <summary>
        /// 正则
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string RegexTest(string input, string pattern)
        {
            string result = null;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(pattern, options);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                result = match.Value;
            }
            return result;
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="saveType"></param>
        /// <param name="saveFileName"></param>
        public static void SaveFile(string saveInput, string savePath, string saveType, string saveName)
        {
            string saveFilePath = savePath + "//" + saveType;
            string saveFileName = savePath + "//" + saveType + "//" + saveName;
            if (Directory.Exists(saveFilePath) == false)
            {
                //如果不存在就创建file文件夹
                Directory.CreateDirectory(saveFilePath);
            }
            else
            {
                //删除文件夹以及文件夹中的子目录，文件
                Directory.Delete(saveFilePath, true);
                Directory.CreateDirectory(saveFilePath);
            }
            File.WriteAllText(saveFileName, saveInput);
        }

    }

}

