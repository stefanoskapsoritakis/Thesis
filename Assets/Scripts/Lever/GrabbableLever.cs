using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableLever : OVRGrabbable
{
    [SerializeField] Transform visualHandle;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);
        if (visualHandle.TryGetComponent(out Rigidbody rb))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        transform.position = visualHandle.position;
        transform.rotation = visualHandle.rotation;
    }
}
