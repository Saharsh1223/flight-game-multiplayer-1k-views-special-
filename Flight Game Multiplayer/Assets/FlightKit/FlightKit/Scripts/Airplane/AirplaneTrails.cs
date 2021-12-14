using UnityEngine;
using Photon.Pun;

namespace FlightKit
{
    public class AirplaneTrails : MonoBehaviour {
        /// <summary>
        /// The GameObject that contains airplane's trails.
        /// </summary>
        public GameObject trailsContainer;
        public PhotonView photonView;

        
        public virtual void ActivateTrails()
        {
            if (trailsContainer != null)
            {
                if (photonView.IsMine)
                {
                    photonView.RPC("ActivateTrailsRPC", RpcTarget.AllBuffered);
                }
            }
        }
        
        public virtual void DeactivateTrails()
        {
            if (trailsContainer != null)
            {
                if (photonView.IsMine)
                {
                    photonView.RPC("DeactivateTrailsRPC", RpcTarget.AllBuffered);
                }
            }
        }

        public virtual void ClearTrails()
        {
            if (trailsContainer != null)
            {
                if (photonView.IsMine)
                {
                    photonView.RPC("ClearTrailsRPC", RpcTarget.AllBuffered);
                }
            }
        }

        [PunRPC]
        void ActivateTrailsRPC()
        {
            trailsContainer.SetActive(true);
        }

        [PunRPC]
        void DeactivateTrailsRPC()
        {
            trailsContainer.SetActive(false);
        }

        [PunRPC]
        void ClearTrailsRPC()
        {
            var renderers = trailsContainer.GetComponentsInChildren<TrailRenderer>();
            foreach (TrailRenderer r in renderers)
            {
                r.Clear();
                //r.time = 0;
            }
        }
    }
}