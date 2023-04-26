using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class WebcamCube : MonoBehaviour
{

    private WebCamTexture webcam;
    
    // Start is called before the first frame update
    void Start()
    {
        #if PLATFORM_ANDROID
                if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
                {
                    Permission.RequestUserPermission(Permission.Camera);
                }
        #endif
        
        if (webcam == null)
            // webcam = new WebCamTexture();
            webcam = new WebCamTexture(WebCamTexture.devices[0].name, 1980, 1080, 60);

        GetComponent<Renderer>().material.mainTexture = webcam;
        webcam.Play();
        
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}