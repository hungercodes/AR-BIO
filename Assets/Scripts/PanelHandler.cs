using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    public GameObject laring;
    public GameObject trakea;
    public GameObject bronkus;
    public GameObject paruParu;
    public GameObject alveolus;
    public GameObject bronkiolus;

    public void onLaringSignClicked()
    {
        laring.SetActive(!laring.activeSelf);
        trakea.SetActive(false);
        bronkus.SetActive(false);
        paruParu.SetActive(false);
        alveolus.SetActive(false);
        bronkiolus.SetActive(false);
        Debug.Log("Panel Laring");
    }

    public void onTrakeaSignClicked()
    {
        laring.SetActive(false);
        trakea.SetActive(!trakea.activeSelf);
        bronkus.SetActive(false);
        paruParu.SetActive(false);
        alveolus.SetActive(false);
        bronkiolus.SetActive(false);
        Debug.Log("Panel Trakea");
    }

    public void onBronkusSignClicked()
    {
        laring.SetActive(false);
        trakea.SetActive(false);
        bronkus.SetActive(!bronkus.activeSelf);
        paruParu.SetActive(false);
        alveolus.SetActive(false);
        bronkiolus.SetActive(false);
        Debug.Log("Panel Bronkus");
    }

    public void onParuparuSignClicked()
    {
        laring.SetActive(false);
        trakea.SetActive(false);
        bronkus.SetActive(false);
        paruParu.SetActive(!paruParu.activeSelf);
        alveolus.SetActive(false);
        bronkiolus.SetActive(false);
        Debug.Log("Panel Paru-paru");
    }

    public void onAlveolusButtonClicked()
    {
        laring.SetActive(false);
        trakea.SetActive(false);
        bronkus.SetActive(false);
        paruParu.SetActive(false);
        alveolus.SetActive(!alveolus.activeSelf);
        bronkiolus.SetActive(false);
        Debug.Log("Panel Alveolus");
    }

    public void onBronkiolusButtonClicked()
    {
        laring.SetActive(false);
        trakea.SetActive(false);
        bronkus.SetActive(false);
        paruParu.SetActive(false);
        alveolus.SetActive(false);
        bronkiolus.SetActive(!bronkiolus.activeSelf);
        Debug.Log("Panel Bronkiolus");
    }
}
