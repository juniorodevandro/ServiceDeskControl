using IniParser;
using IniParser.Model;
using System.Diagnostics;
using System;
using System.ServiceProcess;
using System.Threading;

namespace Desenvolvimento
{
    public class uTils
    {
        public string GetIniParam(IniParamsEnum prParam)
        {
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.ini");

            var parser = new FileIniDataParser();

            IniData data = parser.ReadFile(iniFilePath);

            string result = data["PARAMETROS"][Enum.GetName(typeof(IniParamsEnum), prParam)];

            if (string.IsNullOrEmpty(result))
            {
                throw new Exception($"Parametro \"{Enum.GetName(typeof(IniParamsEnum), prParam)}\" não informado nas configurações.");
            }

            return result;
        }

        public string ExecuteCommand(string command, string path = "")
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c {command}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            if (!String.IsNullOrEmpty(path))
            {
                process.StartInfo.WorkingDirectory = path;
            }
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }

        private static ServiceController GetService(string serviceName)
        {
            return new ServiceController(serviceName);
        } 

        public void StartService(string serviceName)
        {
            ServiceController service = GetService(serviceName);
            if (service.Status == ServiceControllerStatus.Stopped ||
                service.Status == ServiceControllerStatus.StopPending)
            {
                service.Start(new string[] { "/SEMESCALAEXE" });
                service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(60));
            }
            Thread.Sleep(2000);
        }

        public void StopService(string serviceName)
        {
            ServiceController service = GetService(serviceName);
            if (service.Status == ServiceControllerStatus.Running ||
                service.Status == ServiceControllerStatus.StartPending)
            {
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(20));
            }
            Thread.Sleep(1000);
        }

    }
}