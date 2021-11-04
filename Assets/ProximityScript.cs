using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] MeshRenderer mesh;
    [SerializeField] float distance;

    // Start is called before the first frame update
    void Start()
    {
        mesh = transform.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= transform.position.x + distance
            && player.transform.position.x >= transform.position.x - distance
            && player.transform.position.z <= transform.position.z + distance
            && player.transform.position.z >= transform.position.z - distance)
        {
            mesh.enabled = false;
        }
        else
        {
            mesh.enabled = true;
        }
    }
}
