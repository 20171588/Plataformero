using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject vcam1;

    [SerializeField]
    private Transform startFollowPoint;

    [SerializeField]
    private BackgroundMovement bgMovement;

    private CinemachineVirtualCamera vcam1VC;

    private void Start()
    {
        vcam1VC = vcam1.GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (transform.position.x < startFollowPoint.position.x)
        {
            bgMovement.UnFollow();
            vcam1VC.Follow = null;
        }
        else
        {
            bgMovement.Follow();
            vcam1VC.Follow = transform;
        }
    }
}
