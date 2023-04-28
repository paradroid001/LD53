using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LD53
{
    public class MouseControl : MonoBehaviour
    {
        protected CharacterMovement _movement;
        public GameObject clickDestinationPrefab;
        private GameObject oldClickDestination = null;
        // Start is called before the first frame update
        void Start()
        {
            _movement = GetComponent<CharacterMovement>();
        }

        // Update is called once per frame
        void Update()
        {
            // Let UI block raycasts. 
            // This is pretty dirty, see https://www.youtube.com/watch?v=ptmum1FXiLE
            // for perhaps a better way
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                Vector3 dest = GetMousePositionInWorld();
                if (dest != Vector3.zero)
                {
                    _movement.currentDestination = dest;
                    if (oldClickDestination != null && clickDestinationPrefab != null)
                    {
                        Destroy(oldClickDestination);
                        oldClickDestination = Instantiate(clickDestinationPrefab, dest, Quaternion.identity);
                    }
                }
            }
        }

        Vector3 GetMousePositionInWorld()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                return hit.point;
            }

            return Vector3.zero;
        }
    }
}

