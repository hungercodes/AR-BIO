using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public KuisManager kuisManager;
    public void answer()
    {
        if (isCorrect)
        {
            Debug.Log("Jawaban benar");
            kuisManager.correctAnswer();
        }
        else
        {
            Debug.Log("Jawaban salah");
            kuisManager.wrongAnswer();
        }
    }
}
