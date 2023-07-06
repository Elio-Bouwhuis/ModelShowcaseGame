using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject leftCamera;
    [SerializeField] GameObject rightCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(true);
        leftCamera.SetActive(false);
        rightCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            mainCamera.SetActive(true);
            leftCamera.SetActive(false);
            rightCamera.SetActive(false);
        }
        else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            mainCamera.SetActive(false);
            leftCamera.SetActive(true);
            rightCamera.SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            mainCamera.SetActive(false);
            leftCamera.SetActive(false);
            rightCamera.SetActive(true);
        }
    }
}
