using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActiveCheck : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ToggleActive()
    {
        //Debug.Log("<color=red>called 1</color>");
        if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
