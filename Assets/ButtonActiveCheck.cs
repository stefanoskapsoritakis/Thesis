using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActiveCheck : MonoBehaviour
{
    [SerializeField] GameObject buttonBase;
    [SerializeField] public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    public void SwitchOn(bool set)
    {
        isOn = set;

        if (set == true)
        {
            buttonBase.SetActive(true);
        }
        else 
        {
            buttonBase.SetActive(false);
        }
    }

}
