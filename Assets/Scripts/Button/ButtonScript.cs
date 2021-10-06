using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] GameObject lamp;
    [SerializeField] Interactable button;

    public void Button(InteractableStateArgs stateArg)
    {
        if (stateArg.NewInteractableState == InteractableState.ActionState)
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
