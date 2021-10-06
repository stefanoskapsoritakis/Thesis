using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonObjective : MonoBehaviour
{
    [SerializeField] GameObject redS;
    [SerializeField] UnityEvent CompleteTask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redS.gameObject.activeInHierarchy == true)
            CompleteTask.Invoke();
    }
}
