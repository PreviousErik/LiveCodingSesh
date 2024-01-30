using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysicalVelocity : MonoBehaviour
{
    private void Awake()
    {
        AddVelocity3();
    }
    [SerializeField]
    private Vector3 direction;
    [ContextMenu("Force")]
    private void AddVelocity()
    {
        GetComponent<Rigidbody>().AddForce(direction, ForceMode.Force);
    }
    [ContextMenu("Impulse")]
    private void AddVelocity2()
    {
        GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
    }
    [ContextMenu("VelocityChange")]
    private void AddVelocity3()
    {
        GetComponent<Rigidbody>().AddForce(direction, ForceMode.VelocityChange);
    }
    [ContextMenu("Acceleration")]
    private void AddVelocity4()
    {
        GetComponent<Rigidbody>().AddForce(direction, ForceMode.Acceleration);
    }
}
