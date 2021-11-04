using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] Interactable button;
    [SerializeField] UnityEvent unityEvent;

    public void Button(InteractableStateArgs stateArg)
    {
        if (stateArg.NewInteractableState == InteractableState.ActionState)
        {
            unityEvent.Invoke();
        }
    }

    /*private void Start()
    {
        button.ActionZoneEvent += Activate;
    }

    void Activate(ColliderZoneArgs args)
    {
        if (args.InteractionT == InteractionType.Exit)
        {
            if (lamp.gameObject.activeInHierarchy == false)
            {
                lamp.SetActive(true);
            }
            else
            {
                lamp.SetActive(false);
            }
        }
    }*/

}
