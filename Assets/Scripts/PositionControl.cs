using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionControl : MonoBehaviour
{
    
    [SerializeField] bool isVert;
    float defautY;
    float defautZ;
    float defautX;
    [Header("Vertical Control Variables")]
   
    [SerializeField] float zAxisMaxLimit;
    [SerializeField] float zAxisMinLimit;
    
    [Header("Horizontal Control Variables")]
    
    [SerializeField] float xAxisMaxLimit;
    [SerializeField] float xAxisMinLimit;

    // Start is called before the first frame update
    void Start()
    {
        defautY = transform.localPosition.y;
        defautX = transform.localPosition.x;
        defautZ = transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVert)
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
        if (transform.localPosition.y != defautY || transform.localPosition.x != defautX)
        {
            Vector3 controlPosition = new Vector3(defautX, defautY, transform.localPosition.z);
            transform.localPosition = controlPosition;
        }
        if (transform.localPosition.z > zAxisMaxLimit)
        {
            Vector3 xPos = new Vector3(transform.localPosition.x, transform.localPosition.y, zAxisMaxLimit);
            transform.localPosition = xPos;
        }
        if (transform.localPosition.z < zAxisMinLimit)
        {
            Vector3 xPos = new Vector3(transform.localPosition.x, transform.localPosition.y, zAxisMinLimit);
            transform.localPosition = xPos;
        }
    }
    void HorizontalControl()
    {
        if (transform.localPosition.y != defautY || transform.localPosition.z != defautZ)
        {
            Vector3 controlPosition = new Vector3(transform.localPosition.x, defautY, defautZ);
            transform.localPosition = controlPosition;
        }
        if (transform.localPosition.x > xAxisMaxLimit)
        {
            Vector3 xPos = new Vector3(xAxisMaxLimit, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = xPos;
        }
        if (transform.localPosition.x < xAxisMinLimit)
        {
            Vector3 xPos = new Vector3(xAxisMinLimit, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = xPos;
        }
    }
}
