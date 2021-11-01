using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCollider : MonoBehaviour
{
    [SerializeField] Collider fingerCollider;
    // Start is called before the first frame update
    void Start()
    {
        fingerCollider = transform.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fingerCollider.enabled == false)
        {
            fingerCollider.enabled = true;
        }
        else
        {
            fingerCollider.enabled = true;
        }
    }
}
