using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinControl : MonoBehaviour
{
    [SerializeField] GameObject vertControl;
    [SerializeField] GameObject horizControl;
    float pinYPos;

    Vector3 pinPos;
    // Start is called before the first frame update
    void Start()
    {
        pinYPos = horizControl.transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        pinPos = new Vector3(horizControl.transform.localPosition.x ,  pinYPos, vertControl.transform.localPosition.z);

        transform.localPosition = pinPos;
    }

}
