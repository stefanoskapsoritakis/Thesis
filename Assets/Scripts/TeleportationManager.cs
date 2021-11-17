using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class TeleportationManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject destination;
    [SerializeField] GameObject target;
    [SerializeField] GameObject buttons;


    private bool isAiming = false;
    private GameObject currentDestination;
    // Start is called before the first frame update
    void Start()
    {
        currentDestination = Instantiate(destination, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAiming)
        {
            CheckDestination();
        }
    }

    private void CheckDestination()
    {
        Ray ray = new Ray(transform.position, transform.rotation * Vector3.up);

        RaycastHit hit;

        bool b = Physics.Raycast(ray, out hit, 5, 1 << 9);

        if (b)
        {
            currentDestination.transform.position = hit.point;
            currentDestination.SetActive(true);
            Debug.DrawLine(transform.position, currentDestination.transform.position, Color.red);
        }
    }

    public void Teleportation(InteractableStateArgs stateArg)
    {
        if (stateArg.NewInteractableState == InteractableState.ActionState)
        {
            if (isAiming && currentDestination.activeSelf)
            {
                //player.transform.position = currentDestination.transform.position;
                Vector3 headOffset = new Vector3(Camera.main.transform.localPosition.x, 0f, Camera.main.transform.localPosition.z);
                player.transform.position = player.transform.TransformPoint(player.transform.InverseTransformPoint(currentDestination.transform.position) + -headOffset);
                currentDestination.SetActive(false);
                TeleportButtons(); 
            }
        }
    }
    public void Switching(InteractableStateArgs stateArg)
    {
        if (stateArg.NewInteractableState == InteractableState.ActionState)
        {
            isAiming = !isAiming;

            if (!isAiming)
            {
                currentDestination.SetActive(false);
            }
        }
    }
    public void HandSwitch()
    {
        
        isAiming = !isAiming;

        if (!isAiming)
        {
            currentDestination.SetActive(false);
        }
    }
    public void TeleportButtons()
    {
        buttons.transform.position = target.transform.position;
    }

}
