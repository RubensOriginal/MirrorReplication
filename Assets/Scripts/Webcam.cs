using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Webcam : MonoBehaviour
{

    private WebCamTexture webcam;
    
    public RawImage image;
    // Start is called before the first frame update
    void Start()
    {
        if (webcam == null)
            webcam = new WebCamTexture(WebCamTexture.devices[0].name, Screen.width, Screen.height, 60);

        image.texture = webcam;
        image.material.mainTexture = webcam;
        
        webcam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
