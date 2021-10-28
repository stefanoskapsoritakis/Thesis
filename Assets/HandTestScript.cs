using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandTestScript : MonoBehaviour
{
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.LogWarning(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (primaryButtonValue)
            Debug.LogWarning("Yep");

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > 0.1f)
            Debug.LogWarning("help meeee");
    }
}
