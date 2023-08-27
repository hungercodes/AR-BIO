using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onAndroidBackButtonClick();
    }

    public void onAnatomiClick()
    {
        SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
    }

    public void onKuisClick()
    {
        SceneManager.LoadScene("Kuis", LoadSceneMode.Single);
    }

    private void onAndroidBackButtonClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
