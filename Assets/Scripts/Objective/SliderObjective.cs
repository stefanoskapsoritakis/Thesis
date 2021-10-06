using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SliderObjective : MonoBehaviour
{
    [SerializeField] GameObject pin;
    [SerializeField] UnityEvent CompleteTask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pin.transform.position.x >= 0.55 && pin.transform.position.x <= 0.65 && pin.transform.position.z <= -0.55 && pin.transform.position.z >= -0.65)
            CompleteTask.Invoke();
    }
}
