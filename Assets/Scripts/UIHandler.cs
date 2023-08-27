using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    private void Update()
    {
        onAndroidBackButtonClick();
    }
    public void onBackButtonClicked()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    private void onAndroidBackButtonClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }  
    }
}
