using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodisappear : MonoBehaviour
{
    [SerializeField] float timeUntilOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Disappear());
    }

    IEnumerator Disappear()
    {
        timeUntilOff = 10f;
        yield return new WaitForSeconds(timeUntilOff);

        gameObject.SetActive(false);
        
    }
}
