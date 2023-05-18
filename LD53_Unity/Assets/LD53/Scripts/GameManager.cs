using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class GameManager : MonoSingleton<GameManager>
    {

        public void Start()
        {
            Test();
        }

        public void Test()
        {
            Log.Debug("GameManager Testing");
        }
    }

}
