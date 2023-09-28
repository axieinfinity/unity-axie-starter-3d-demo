using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public class CameraRotate : MonoBehaviour
    {
        [SerializeField] private GameObject target;
        private float speed = 50f;

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Camera.main.transform.RotateAround(target.transform.position,
                                                 Camera.main.transform.up,
                                                Input.GetAxis("Mouse X") * speed);
            }
        }
    }
}

