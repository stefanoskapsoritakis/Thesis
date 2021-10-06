using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    [SerializeField] bool isBlinking = false;
    [SerializeField] float timeOn;
    [SerializeField] float timeOff;
    [SerializeField] GameObject sign;

    private void Update()
    {
        if (isBlinking == false)
        {
            StartCoroutine(BlinkingSign());
        }        
    }

    IEnumerator BlinkingSign()
    {
        isBlinking = true;
        sign.gameObject.SetActive(false);
        timeOff = 0.5f;
        yield return new WaitForSeconds(timeOff);
        sign.gameObject.SetActive(true);
        timeOn = 0.5f;
        yield return new WaitForSeconds(timeOn);
        isBlinking = false;

    }
}
