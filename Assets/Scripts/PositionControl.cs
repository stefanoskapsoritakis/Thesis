using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionControl : MonoBehaviour
{
    
    [SerializeField] bool isVert;

    [Header("Vertical Control Variables")]
    [SerializeField] float minZPos;
    [SerializeField] float maxZPos;

    [Header("Horizontal Control Variables")]
    [SerializeField] float minXPos;
    [SerializeField] float maxXPos;

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
        if (gameObject.transform.position.y != 0.86f || gameObject.transform.position.x != 0.25f)
        {
            Vector3 controlPosition = new Vector3(0.25f, 0.86f, transform.position.z);
            transform.position = controlPosition;
        }
        if (gameObject.transform.position.z > maxZPos)
        {
            Vector3 xPos = new Vector3(transform.position.x, transform.position.y, maxZPos);
            transform.position = xPos;
        }
        if (gameObject.transform.position.z < minZPos)
        {
            Vector3 xPos = new Vector3(transform.position.x, transform.position.y, minZPos);
            transform.position = xPos;
        }
    }
    void HorizontalControl()
    {
        if (gameObject.transform.position.y != 0.86f || gameObject.transform.position.z != 1.4f)
        {
            Vector3 controlPosition = new Vector3(transform.position.x, 0.86f, 1.4f);
            transform.position = controlPosition;
        }
        if (gameObject.transform.position.x > maxXPos)
        {
            Vector3 xPos = new Vector3(maxXPos, transform.position.y, transform.position.z);
            transform.position = xPos;
        }
        if (gameObject.transform.position.x < minXPos)
        {
            Vector3 xPos = new Vector3(minXPos, transform.position.y, transform.position.z);
            transform.position = xPos;
        }
    }
}
