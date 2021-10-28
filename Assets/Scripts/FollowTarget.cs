using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] public GameObject target;
    [SerializeField] public Transform thisTr;
    [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        thisTr = transform.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        thisTr.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * speed);

        thisTr.rotation = target.transform.rotation;
    }

}
