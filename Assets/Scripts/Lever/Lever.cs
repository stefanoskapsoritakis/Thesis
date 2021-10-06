using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    bool isOn;

    public UnityEvent turnOn;
    public UnityEvent turnOff;

    [SerializeField] HingeJoint joint;
    [SerializeField] float threshold;

    // Update is called once per frame
    void Update()
    {
        if (joint.angle > threshold && isOn == false)
        {
            isOn = true;
            turnOn?.Invoke();
        }
        else if (joint.angle < threshold && isOn)
        {
            isOn = false;
            turnOff?.Invoke();
        }
    }
}
