using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SliderObjective : MonoBehaviour
{
    [SerializeField] GameObject pin;
    [SerializeField] UnityEvent CompleteTask;
    [SerializeField] float offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pin.transform.position.x <= transform.position.x + offset
            && pin.transform.position.x >= transform.position.x - offset
            && pin.transform.position.z <= transform.position.z + offset
            && pin.transform.position.z >= transform.position.z - offset)
            CompleteTask.Invoke();
    }

}
