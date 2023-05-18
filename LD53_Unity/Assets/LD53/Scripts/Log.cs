using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{

    public class Log : MonoSingleton<Log>
    {
        [SerializeField]
        private LOGLEVEL_T logLevel;
        private ServiceLocator<ILogService> _logger;
        private ConsoleLogger _consoleLogger;

        protected override void InitSingleton()
        {
            UnityEngine.Debug.Log("Initing Log Singleton");
            //_logger = new ServiceLocator<ILoggerService>();
            _consoleLogger = new ConsoleLogger();
            ServiceLocator<ILogService>.Provide(_consoleLogger);
            ServiceLocator<ILogService>.GetProvider().SetLogLevel(logLevel);
        }

        public static void Debug(string s)
        {
            ServiceLocator<ILogService>.GetProvider().Debug(s);
        }
    }
}