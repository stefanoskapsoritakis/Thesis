using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinControl : MonoBehaviour
{
    [SerializeField] GameObject vertControl;
    [SerializeField] GameObject horizControl;
    Vector3 pinPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pinPos = new Vector3(horizControl.transform.position.x ,  1, vertControl.transform.position.z);

        transform.position = pinPos;
    }

}
