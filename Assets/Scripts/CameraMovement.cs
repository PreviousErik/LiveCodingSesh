using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float cameraTurnspeed;
    [SerializeField]
    private Transform playerTransform;
    void Update()
    {
        float rightTurn = Input.GetAxisRaw("Mouse X") * cameraTurnspeed;
        float upAndDown = Input.GetAxisRaw("Mouse Y") * cameraTurnspeed;


        transform.eulerAngles += new Vector3(-upAndDown, 0);
        playerTransform.eulerAngles += new Vector3(0, rightTurn);

    }
}
