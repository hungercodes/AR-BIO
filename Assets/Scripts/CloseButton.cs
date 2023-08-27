using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject Obj;
    private int clickCounter;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCloseButtonClicked()
    {
        Obj.SetActive(false);
    }
}
