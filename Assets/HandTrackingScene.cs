using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OculusSampleFramework;
using UnityEngine.Events;

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
    public void QuitGame()
    {
        Application.Quit();
        Debug.LogError("this was called");
    }
    public void Quit(InteractableStateArgs stateArg)
    {
        if (stateArg.NewInteractableState == InteractableState.ActionState)
        {
            Application.Quit();
        }
    }
}
