using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResetObject : MonoBehaviour
{
    _PinchZoomHandler m_PinchZoomHandler;
    _DragRotationHandler m_DragRotationHandler;
    public PlaceOnPlane m_PlaceOnPlane;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Check if finger is over a UI element
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                Debug.Log("Touched the UI");
            }
        }
    }

    public void onResetRotationClick()
    {
        if (m_PlaceOnPlane.spawnedObject != null)
        {
            if (m_DragRotationHandler == null)
            {
                m_DragRotationHandler = m_PlaceOnPlane.spawnedObject.GetComponentInChildren<_DragRotationHandler>();
            }
            m_DragRotationHandler.InitRotation();
            Debug.Log("reset rotation");
        }
    }

    public void onResetScaleClick()
    {
        if (m_PlaceOnPlane.spawnedObject != null)
        {
            if (m_PinchZoomHandler == null)
            {
                m_PinchZoomHandler = m_PlaceOnPlane.spawnedObject.GetComponentInChildren<_PinchZoomHandler>();
            }
            m_PinchZoomHandler.InitScale();
            Debug.Log("reset scale");
        }
    }
}
