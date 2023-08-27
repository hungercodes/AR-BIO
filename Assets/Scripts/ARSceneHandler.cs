using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ARSceneHandler : MonoBehaviour
{
    public PlaceOnPlane m_PlaceOnPlane;
    public ARPlaneManager arPlaneManager;
    public bool isSurfaceScanned = false;
    public GameObject scanForSurface;

    void Update()
    {
        if(arPlaneManager.enabled)
        {
            if(!isSurfaceScanned)
            {
                Debug.Log("surface not scan");
                if(arPlaneManager.trackables.count > 0)
                {
                    print("Surface is scanned!");
                    scanForSurface.SetActive(false);
                    isSurfaceScanned = true;
                }
            }
            else
            {
                foreach (var plane in arPlaneManager.trackables)
                {
                    MeshRenderer mesh = plane.GetComponent<MeshRenderer>();
                    mesh.enabled = false;
                }
            }
        }
    }
}
