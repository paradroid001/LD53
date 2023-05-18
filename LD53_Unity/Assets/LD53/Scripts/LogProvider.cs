using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class LogProvider : ILogService
    {
        protected LOGLEVEL_T _logLevel = LOGLEVEL_T.DEBUG;

        public virtual void InitService()
        {
            //override me
        }

        public void SetLogLevel(LOGLEVEL_T logLevel)
        {
            _logLevel = logLevel;
        }
        
        public void Debug(string debugString)
        {
            if ((int)_logLevel > (int)LOGLEVEL_T.DEBUG)
                return;
            LogDebug(debugString);
        }
        public void Info(string infoString)
        {
            if ((int)_logLevel > (int)LOGLEVEL_T.INFO)
                return;
            LogInfo(infoString);
        }
        public void Warning(string warningString)
        {
            if ((int)_logLevel > (int)LOGLEVEL_T.WARNING)
                return;
            LogWarning(warningString);
        }
        public void Error(string errorString)
        {
            if ((int)_logLevel > (int)LOGLEVEL_T.ERROR)
                return;
            LogDebug(errorString);
        }
        public void Critical(string criticalString)
        {
            if ((int)_logLevel > (int)LOGLEVEL_T.CRITICAL)
                return;
            LogCritical(criticalString);
        }

        protected virtual void LogDebug(string s)
        {
            //override me
        }
        protected virtual void LogInfo(string s)
        {
            //override me
        }
        protected virtual void LogWarning(string s)
        {
            //override me
        }
        protected virtual void LogError(string s)
        {
            //override me
        }
        protected virtual void LogCritical(string s)
        {
            //override me
        }
    }
}