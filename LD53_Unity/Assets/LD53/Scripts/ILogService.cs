using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public interface ILogService : IService
    {
        //public void InitService();
        public void SetLogLevel(LOGLEVEL_T logLevel);
        public void Debug(string debugString);
        public void Info(string infoString);
        public void Warning(string warningString);
        public void Error(string errorString);
        public void Critical(string criticalString);
    }
}