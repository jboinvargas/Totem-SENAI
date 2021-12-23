using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControl : MonoBehaviour {

    public static gameControl instance;
    public Text scoreText;
    public Text timeText;
    public GameObject gameOverText;
    public bool gameOver = false;
    public int tempoTotal = 90;
    public int tempoInicial = 0;
    public int tempoAtual = 0;
    public bool up = false;
    public bool down = false;

    private int score = 0;
    public int tempo;

    // Use this for initialization
    void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        tempo = tempoTotal;
        tempoInicial = (int)Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        if (!gameOver)
        {
            tempo = tempoTotal - ((int)Time.time - tempoInicial);
            timeText.text = "Tempo: " + tempo.ToString() + "s";
        }


        if (gameOver && Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        if (gameOver && Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene("sceneMain");
        }

    }

    public void playerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void playerScored()
    {
        if (gameOver)
        { 
            return;
        }

        score++;
        scoreText.text = "Pontos: " + score.ToString();

    }
}
