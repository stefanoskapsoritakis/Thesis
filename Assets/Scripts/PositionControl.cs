using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionControl : MonoBehaviour
{
    [SerializeField] bool isVert;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isVert == true)
        {
            VerticalControl();
        }
        else
        {
            HorizontalControl();
        }
        
    }
    void VerticalControl()
    {
        if (gameObject.transform.position.y != 1f || gameObject.transform.position.x != 0.5f)
        {
            Vector3 controlPosition = new Vector3(0.5f, 1f, transform.position.z);
            transform.position = controlPosition;
        }
        if (gameObject.transform.position.z > -0.5f)
        {
            Vector3 xPos = new Vector3(transform.position.x, transform.position.y, -0.5f);
            transform.position = xPos;
        }
        if (gameObject.transform.position.z < -0.9f)
        {
            Vector3 xPos = new Vector3(transform.position.x, transform.position.y, -0.9f);
            transform.position = xPos;
        }
    }
    void HorizontalControl()
    {
        if (gameObject.transform.position.y != 1f || gameObject.transform.position.z != -1f)
        {
            Vector3 controlPosition = new Vector3(transform.position.x, 1f, -1f);
            transform.position = controlPosition;
        }
        if (gameObject.transform.position.x > 1f)
        {
            Vector3 xPos = new Vector3(1f, transform.position.y, transform.position.z);
            transform.position = xPos;
        }
        if (gameObject.transform.position.x < 0.6f)
        {
            Vector3 xPos = new Vector3(0.6f, transform.position.y, transform.position.z);
            transform.position = xPos;
        }
    }
}
