using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingDemo : MonoBehaviour
{
    [SerializeField]
    private float rayDistance;
    private GameObject lastObjectHit;
    private bool isLookingAtSomething;

    [SerializeField]
    private Transform anchorPoint;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(transform.position, transform.forward * rayDistance, out RaycastHit hitInfo))
        {
            if (lastObjectHit == hitInfo.transform.gameObject)
                return;

            if (lastObjectHit != null)
            {
                lastObjectHit.GetComponent<MeshRenderer>().material.color = Color.white;
            }

            isLookingAtSomething = true;
            lastObjectHit = hitInfo.transform.gameObject;
            Debug.Log(hitInfo.transform.gameObject.name);

            lastObjectHit.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            if (lastObjectHit != null)
            {
                lastObjectHit.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            lastObjectHit = null;
            isLookingAtSomething = false;
        }
    }
    private bool isHoldingItem;

    private GameObject heldItem;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isLookingAtSomething)
        {
            if (isHoldingItem == true)
            {
                heldItem = null;
                isHoldingItem = false;
            }
            else
            {
                heldItem = lastObjectHit;
                isHoldingItem = true;
            }
        }
        if (isHoldingItem == true)
        {
            heldItem.transform.position = anchorPoint.position;
        }
    }
}
