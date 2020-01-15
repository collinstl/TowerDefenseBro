using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    private Transform camPos;
    private Transform parentPos;

    private Vector3 localRotation;
    private float camDistance = 10f;

    public float mouseSensitivity;
    public float scrollSensitivity;
    public float orbitDampening;
    public float scrollDampening;

    public bool camDisable = false;

    void Start()
    {
        this.camPos = this.transform;
        this.parentPos = this.transform.parent;
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            camDisable = !camDisable;
        }
        if (!camDisable)
        {
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                localRotation.x += Input.GetAxis("Mouse X") * mouseSensitivity;
                localRotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;

                localRotation.y = Mathf.Clamp(localRotation.y, 0f, 90f);
            }
        }
    }
}
