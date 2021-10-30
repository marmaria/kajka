using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class TrackedImageInfoMultipleManager : MonoBehaviour
{
    [SerializeField] AR_ModeScript ar_ModeScript;

    [SerializeField] private GameObject[] arObjectsToPlace;

//    [SerializeField]    private Vector3 scaleFactor = new Vector3(0.05f, 0.05f, 0.05f);

    private ARTrackedImageManager m_TrackedImageManager;

    private Dictionary<string, GameObject> arObjects = new Dictionary<string, GameObject>();

    [SerializeField]
    private Camera arCamera;

    private Vector2 touchPosition = default;

    private bool isARMode;
    private bool isQRMode;

    private int counterAR;

    void Awake()
    {
        counterAR = 0;

        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        
        // setup all game objects in dictionary
        foreach(GameObject arObject in arObjectsToPlace)
        {
            GameObject newARObject = Instantiate(arObject, Vector3.zero, Quaternion.identity );
            newARObject.name = arObject.name;
            newARObject.SetActive(false);
            arObjects.Add(arObject.name, newARObject);
            arObject.SetActive(false);
        }
    }

    void Update()
    {
        //ar_ModeScript.ShowHint(true);
        //foreach (GameObject arObject in arObjectsToPlace)
        //{
        //    if (arObject.activeSelf)
        //    {
        //        ar_ModeScript.ShowHint(false);
        //    }
        //}

        isARMode = ar_ModeScript.isARMode;
        isQRMode = ar_ModeScript.isQRMode;


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    GameObject placementObject = hitObject.transform.gameObject;
                    if (placementObject != null)
                    {
                        ChangeSelectedObject(placementObject);
                    }
                }
            }
        }
    }

    void ChangeSelectedObject(GameObject selected)
    {
        MeshRenderer meshRenderer = selected.GetComponent<MeshRenderer>();
        if (selected.GetComponent<SoundScript>().Selected)
        {
            selected.GetComponent<SoundScript>().Selected = false;
           // meshRenderer.material.color = inactiveColor;
            selected.GetComponent<SoundScript>().StopClip();
        }
        else
        {
            selected.GetComponent<SoundScript>().Selected = true;
         //   meshRenderer.material.color = activeColor;
            selected.GetComponent<SoundScript>().PlayClip();
        }
    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        if (isARMode || isQRMode)
        {
            foreach (ARTrackedImage trackedImage in eventArgs.added)
            {
                UpdateARImage(trackedImage);
            }

            foreach (ARTrackedImage trackedImage in eventArgs.updated)
            {
                UpdateARImage(trackedImage);
            }
        }

    }

    private void UpdateARImage(ARTrackedImage trackedImage)
    {
        if (trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
        {
            if (trackedImage.referenceImage.name.Contains("qr"))
            {
                ar_ModeScript.ShowQRAskPanel(true, trackedImage.referenceImage.name);
            }
            else
            {
                // Assign and Place Game Object
                AssignGameObject(trackedImage.referenceImage.name, trackedImage.transform.position);
            }
        }
        else if (trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Limited)
        {
            if (trackedImage.referenceImage.name.Contains("qr"))
            {
                ar_ModeScript.ShowQRAskPanel(false);
            }
            else
            {
                HideGameObject(trackedImage.referenceImage.name);
            }
        }


       // Debug.Log($"trackedImage.referenceImage.name: {trackedImage.referenceImage.name}");
    }

    void AssignGameObject(string goName, Vector3 newPosition)
    {
        if(arObjectsToPlace != null)
        {
            GameObject goARObject = arObjects[goName];
            goARObject.SetActive(true);
            ar_ModeScript.ShowHint(false);
            goARObject.transform.position = newPosition;
            //          goARObject.transform.localScale = scaleFactor;

            //counterAR++;
        }
    }

    void HideGameObject(string name)
    {
        if (arObjectsToPlace != null)
        {
            GameObject goARObject = arObjects[name];
            goARObject.SetActive(false);
            //ar_ModeScript.ShowHint(true);

            //counterAR--;
        }
        if (counterAR == 0)
        {
            //ar_ModeScript.ShowHint(true);
        }
    }
}
