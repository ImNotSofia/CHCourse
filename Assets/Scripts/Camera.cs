using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera CameraPOV;

    [SerializeField] private CinemachineVirtualCamera CameraCHThird;

  //  [SerializeField] private CinemachineVirtualCamera CameraFollowinDirt;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            CameraChange(CameraPov, CameraCHThird);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            CameraChange(CameraCHThird, CameraPov);

        }

        //if (Input.GetKeyDown(KeyCode.D))
        //{

        //    CameraChange(CameraFollowinDirt, CameraPov);

        //}

    }

    private void CameraChange(CinemachineVirtualCamera cameraON, CinemachineVirtualCamera otherOne)
    {

        cameraON.gameObject.SetActive(true);

        otherOne.gameObject.SetActive(false);


    }
}
