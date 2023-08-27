using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignHandler : MonoBehaviour
{
    public PlaceOnPlane m_PlaceOnPlane;
    public bool laringClick;
    public bool trakeaClick;
    public bool bronkusClick;
    public bool paruparuClick;
    public bool alveolusClick;
    public bool bronkiolusClick;
    
    void Awake()
    {
        laringClick = false;
        trakeaClick = false;
        bronkusClick = false;
        paruparuClick = false;
    }

    void Update()
    {
        inputTouchButton();
    }

    public void inputTouchButton()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            print("Touch received");
    
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                print("Raycasting");
                if(hit.collider != null)
                {
                    if(hit.collider.tag == "signLaring")
                    {
                        onLaringSignClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        laringClick = true;
                    }
                    else if(hit.collider.tag == "signTrakea")
                    {
                        onTrakeaSignClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        trakeaClick = true;
                    }
                    else if(hit.collider.tag == "signBronkus")
                    {
                        onBronkusSignClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        bronkusClick = true;
                    }
                    else if (hit.collider.tag == "signParuparu")
                    {
                        onParuparuSignClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        paruparuClick = true;
                    }
                    else if (hit.collider.tag == "buttonAlveolus")
                    {
                        onAlveolusButtonClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        alveolusClick = true;
                    }
                    else if (hit.collider.tag == "buttonBronkiolus")
                    {
                        onBronkiolusButtonClicked();
                        Debug.Log("Object: " + hit.collider.gameObject.name);
                        bronkiolusClick = true;
                    }
                }
            }
        }
    }

    public void onLaringSignClicked()
    {
        if(m_PlaceOnPlane.spawnedObject != null)
        {    
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onLaringSignClicked();
        }
    }

    public void onTrakeaSignClicked()
    {
        if(m_PlaceOnPlane.spawnedObject != null)
        {
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onTrakeaSignClicked();
        }
    }

    public void onBronkusSignClicked()
    {
        if(m_PlaceOnPlane.spawnedObject != null)
        {
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onBronkusSignClicked();
        }
    }

    public void onParuparuSignClicked()
    {
        if (m_PlaceOnPlane.spawnedObject != null)
        {
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onParuparuSignClicked();
        }
    }

    public void onAlveolusButtonClicked()
    {
        if (m_PlaceOnPlane.spawnedObject != null)
        {
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onAlveolusButtonClicked();
        }
    }

    public void onBronkiolusButtonClicked()
    {
        if (m_PlaceOnPlane.spawnedObject != null)
        {
            m_PlaceOnPlane.triviaPanel.gameObject.SetActive(true);
            m_PlaceOnPlane.m_PanelHandler.onBronkiolusButtonClicked();
        }
    }
}
