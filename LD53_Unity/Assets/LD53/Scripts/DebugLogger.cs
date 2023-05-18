using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class ConsoleLogger : LogProvider
    {

        //[SerializeField]
        //protected LOGLEVEL_T _logLevel = LOGLEVEL_T.DEBUG;

        public override void InitService()
        {
            //nothing
        }

        protected override void LogDebug(string debugString)
        {
            UnityEngine.Debug.Log("[DEBUG]: " + debugString);
        }
        protected override void LogInfo(string infoString)
        {
            UnityEngine.Debug.Log("[INFO]: " + infoString);
        }
        protected override void LogWarning(string warningString)
        {
            UnityEngine.Debug.LogWarning("[WARN]: " + warningString);
        }
        protected override void LogError(string errorString)
        {
            UnityEngine.Debug.LogError("[ERROR]: " + errorString);
        }
        protected override void LogCritical(string criticalString)
        {
            UnityEngine.Debug.LogError("[CRITICAL]: " + criticalString);
        }
    }
}