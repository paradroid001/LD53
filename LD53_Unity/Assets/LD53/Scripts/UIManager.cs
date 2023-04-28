using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class UIManager : MonoBehaviour
    {
        private Stack<UIWindow> _windowStack;
        
        [SerializeField]
        private UIWindow startingWindow;
        // Start is called before the first frame update
        void Start()
        {
            _windowStack = new Stack<UIWindow>();
            if (startingWindow != null)
            {
                Push(startingWindow);
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        //Switch to a window, hiding everything else.
        //This empties the stack and then populates it with only this window.
        //If the current window showing IS the passed window, do nothing.
        public void SwitchTo(UIWindow window)
        {
            if (_windowStack.Count > 0 && _windowStack.Peek() != window)
            {
                while (_windowStack.Count > 0)
                {
                    Pop();
                }
                
            }
            Push(window);
        }

        //Push something onto the UI stack, but don't hide anything else.
        public void Push(UIWindow window)
        {
            if (_windowStack.Count > 0 && _windowStack.Peek() == window)
            {
                return;
            }

            _windowStack.Push(window);
            window.Show();
        
        }

        //Pops the top item off the stack, and deactivates it.
        public UIWindow Pop()
        {
            UIWindow retval = null;
            if (_windowStack.Count > 0)
            {
                retval = _windowStack.Pop();
                retval.Hide();
            }
            return retval;
        }
        
        public void PopVoid()
        {
            Pop();
        }
    }

}
