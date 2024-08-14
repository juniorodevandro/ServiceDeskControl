using Desenvolvimento.Enums;
using IniParser;
using IniParser.Model;
using System.Diagnostics;
using System.ServiceProcess;

namespace Desenvolvimento.Shared
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

        public Task<bool> ExecuteCommandAsync(string command, string path = "", TextBox outputTextBox = null)
        {
            return Task.Run(() =>
            {
                bool result = false;

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c {command}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    if (!string.IsNullOrEmpty(path))
                    {
                        process.StartInfo.WorkingDirectory = path;
                    }

                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (outputTextBox != null && e.Data != null)
                        {
                            outputTextBox.BeginInvoke(new Action(() =>
                            {
                                outputTextBox.Text += e.Data + Environment.NewLine;
                                outputTextBox.SelectionStart = outputTextBox.Text.Length;
                                outputTextBox.ScrollToCaret();
                            }));
                        }
                    };

                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (outputTextBox != null && e.Data != null)
                        {
                            outputTextBox.BeginInvoke(new Action(() =>
                            {
                                outputTextBox.Text += "ERRO: " + e.Data + Environment.NewLine;
                                outputTextBox.SelectionStart = outputTextBox.Text.Length;
                                outputTextBox.ScrollToCaret();
                            }));
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit(); 

                    result = process.ExitCode == 0;
                }

                return result;
            });
        }

        private static ServiceController GetService(string serviceName)
        {
            return new ServiceController(serviceName);
        }

        public async Task StartServiceAscync(string serviceName)
        {
            ServiceController service = GetService(serviceName);
            if (service.Status == ServiceControllerStatus.Stopped ||
                service.Status == ServiceControllerStatus.StopPending)
            {
                service.Start(new string[] { "/SEMESCALAEXE" });
                await Task.Run(() => service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(60)));
            }
            await Task.Delay(2000);
        }

        public async Task StopServiceAscync(string serviceName)
        {
            ServiceController service = GetService(serviceName);
            if (service.Status == ServiceControllerStatus.Running ||
                service.Status == ServiceControllerStatus.StartPending)
            {
                service.Stop();
                await Task.Run(() => service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(20)));
            }
            await Task.Delay(1000);
        }
    }
}