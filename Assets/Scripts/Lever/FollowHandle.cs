using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHandle : MonoBehaviour
{
    [SerializeField] Transform target;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rb.MovePosition(target.position);
    }
}
