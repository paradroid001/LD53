using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    [System.Serializable]
    public enum LOGLEVEL_T
    {
        DEBUG = 0,
        INFO,
        WARNING,
        ERROR,
        CRITICAL,
        NONE
    }

    public interface ILoggable
    {
        public void SetLogLevel(LOGLEVEL_T logLevel);
        public void Debug(string debugString);
        public void Info(string infoString);
        public void Warning(string warningString);
        public void Error(string errorString);
        public void Critical(string criticalString);
    }
}
