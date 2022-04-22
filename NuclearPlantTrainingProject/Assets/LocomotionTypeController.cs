using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionTypeController : MonoBehaviour
{

    public ActionBasedContinuousMoveProvider moveProvider;
    public TeleportationProvider teleportProvider;
    public GameObject Ray;
    // Start is called before the first frame update
    public void EnableTeleport()
    {
            moveProvider.enabled = false;
            teleportProvider.enabled = true;
            Ray.SetActive(true);
    }

    public void EnableLocomotion()
    {
        moveProvider.enabled = true;
        teleportProvider.enabled = false;
        Ray.SetActive(false);
    }


}
