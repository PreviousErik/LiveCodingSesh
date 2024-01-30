using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUp : MonoBehaviour
{
    [SerializeField]
    private float forceSpeed = 10f;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up *  forceSpeed, ForceMode.Force);
        }
    }
}
