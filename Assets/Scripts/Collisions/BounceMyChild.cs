using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMyChild : MonoBehaviour
{
    [SerializeField]
    private float bounceMultiplication = 1.1f;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            ballRb.velocity *= bounceMultiplication;
            Debug.Log("Yeet!");
        }
    }
}
