using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    [SerializeField] AR_ModeScript AR_Controller;
    [SerializeField] StoriesScript Stories_Controller;

    // Start is called before the first frame update
    void Start()
    {
        VerifyPermission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AR_Mode()
    {
        AR_Controller.StartARMode();
    }

    public void QR_Mode()
    {
        AR_Controller.StartQR();
    }

    public void Stories_Mode()
    {
        Stories_Controller.StartStories();
    }

    public void Store_Mode()
    {
       Application.OpenURL("https://kajka.shop/");
    }

    public void VerifyPermission()
    {
     //   Debug.Log("VerifyPermission()");

        // Use native UI to request camera permission.
        iOSCameraPermission.VerifyPermission(gameObject.name, "SampleCallback");
    }

    private void SampleCallback(string permissionWasGranted)
    {
      //  Debug.Log("Callback.permissionWasGranted = " + permissionWasGranted);
    }
}
