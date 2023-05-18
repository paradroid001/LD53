using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class ServiceLocator<T> where T: IService
    {
        private static T _service;
        public static T GetProvider() { return _service; }
        public static void Provide(T service)
        {
            _service = service;
        } 
    }
}