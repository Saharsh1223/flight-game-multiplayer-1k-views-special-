using UnityEngine;
using Photon.Pun;
using FlightKit;
using UnityStandardAssets.Vehicles.Aeroplane;
using UnityStandardAssets.Utility;

public class DisableScripts : MonoBehaviour
{
    public PhotonView photonView;
    [Space]
    public AeroplaneController aeroplaneController;
    public AirplaneUserControl airPlaneUserControl;
    public TakeOffPublisher takeOffPublisher;
    public CrashController crashController;
    public ObjectResetter objectResetter;
    public ActivateOnTakeOff activateOnTakeOff;
    public LevelBroundsTracker levelBroundsTracker;
    public AirplaneTrails airplaneTrails;
    [Space]
    public GameObject flightObject;
    public GameObject colliders;

    private void Update()
    {
        if (!photonView.IsMine)
        {
            aeroplaneController.enabled = false;
            airPlaneUserControl.enabled = false;
            takeOffPublisher.enabled = false;
            crashController.enabled = false;
            objectResetter.enabled = false;
            activateOnTakeOff.enabled = false;
            levelBroundsTracker.enabled = false;
            airplaneTrails.enabled = false;
        }
    }
}
