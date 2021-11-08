using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandTrackingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickHandTracking()
    {
        SceneManager.LoadScene("HandTrackingScene");
    }
    public void PickController()
    {
        SceneManager.LoadScene("ControllerScene");
    }

}
