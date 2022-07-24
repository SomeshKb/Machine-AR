using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARPlaneManager))]
public class PlaneDetectionToggle : MonoBehaviour
{
    private ARPlaneManager planeManager;
    [SerializeField]
    private Text toggleButtonText;

    private void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
        toggleButtonText.text = "D";
    }

    public void TogglePlaneDetection()
    {
        planeManager.enabled = !planeManager.enabled;

        string toggleButtonMessage = "";
        
        if(planeManager.enabled){
            toggleButtonMessage = "D";
            SetAllPlanesActive(true);
        } else {
            toggleButtonMessage = "E";
            SetAllPlanesActive(false);
        }

        toggleButtonText.text = toggleButtonMessage;
    }

    private void SetAllPlanesActive(bool status){
        foreach(var plane in planeManager.trackables){
            plane.gameObject.SetActive(status);
        }
    }
}
