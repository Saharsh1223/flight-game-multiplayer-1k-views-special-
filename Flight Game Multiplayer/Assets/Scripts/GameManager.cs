using UnityEngine;
using Photon.Pun;
using FlightKit;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.ImageEffects;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public UIEventsPublisher uIEventsPublisher;
    public ColorCorrectionCurves colorCorrectionCurves;
    public AutoCam cam;
    public GameObject mainCanvas;
    public Animator buttonAnim;

    DisableScripts disableScripts;
    PhotonView playerView;

    private void Start()
    {
        GameObject newPlayer = PhotonNetwork.Instantiate(playerPrefab.name, playerPrefab.transform.position, playerPrefab.transform.rotation);
        playerView = newPlayer.GetComponent<PhotonView>();
        cam.SetTarget(newPlayer.transform);
    }

    private void Update()
    {
        if (!playerView.IsMine)
        {
            colorCorrectionCurves.enabled = false;
        }
    }

    public void Play()
    {
        buttonAnim.enabled = true;
    }
}
