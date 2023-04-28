using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        public GameManager instance
        {
            get { return _instance; }
        }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }

}
