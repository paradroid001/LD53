using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LD53
{
    public class CharacterControl : MonoBehaviour
    {
        protected CharacterMovement _movement;

        // Start is called before the first frame update
        void Start()
        {
            _movement = GetComponent<CharacterMovement>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_movement != null)
            {
                float h = Input.GetAxisRaw("Horizontal");
                float v = Input.GetAxisRaw("Vertical");
                if (v != 0 || h != 0)
                {
                    _movement.relativeDestination = transform.forward * v + transform.right * h; // + transform.up * transform.position.y;
                }
            }
        }
    }
}
