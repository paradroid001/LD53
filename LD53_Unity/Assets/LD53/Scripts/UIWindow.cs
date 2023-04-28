using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class UIWindow : MonoBehaviour
    {
        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }
        public virtual void Show()
        {
            gameObject.SetActive(true);
        }
        public virtual void Toggle()
        {
            gameObject.SetActive(!gameObject.activeInHierarchy);
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
