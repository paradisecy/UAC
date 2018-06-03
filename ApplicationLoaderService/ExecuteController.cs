using System;
using System.Web.Http;


namespace Toolkit
{
    public class ExecuteController : ApiController
    {
       [HttpGet]
        public void Execute(string command)
        {
            string applicationName = $"cmd.exe {command}";

            ApplicationLoader.PROCESS_INFORMATION procInfo;
            ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo);
        }
    }
}
