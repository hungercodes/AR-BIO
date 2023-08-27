using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KuisManager : MonoBehaviour
{
    public List<SoaldanJawaban> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizPanel;
    public GameObject gameOverPanel;

    public Text questionText;
    public Text scoreText;

    float totalQuestions = 0;
    public float score;
    public float totalScore;

    private void Start()
    {
        totalQuestions = QnA.Count;
        gameOverPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void gameOver()
    {
        gameOverPanel.SetActive(true);
        quizPanel.SetActive(false);
        scoreText.text = "Skor: " + totalScore;
    }

    public void correctAnswer()
    {
        score += 1;
        totalScore = (score / totalQuestions) * 100;
        Debug.Log(totalQuestions);
        Debug.Log(totalScore);
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrongAnswer()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            questionText.text = QnA[currentQuestion].question;
            setAnswers();
        }
        else
        {
            Debug.Log("Pertanyaan habis");
            gameOver();
        }
        
    }

    void setAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answers[i];

            if(QnA[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
}
