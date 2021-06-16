using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject secondCamera;
    public GameObject[] racers;
    public GameObject startgameScreen;
    public GameObject endgameScreen;
    public GameObject selector;
    public TMP_Text nameText;
    public TMP_Text infoText;
    public TMP_Text endgameText;
    public bool gameStart;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        PrepareRace();
    }

    public void PrepareRace()
    {
        gameOver = false;
        gameStart = false;
        mainCamera.SetActive(true);
        secondCamera.SetActive(false);
        selector.gameObject.SetActive(true);
        UpdateUI();
        racers[0].GetComponent<Racer>().SelectRacer();
    }

    public void StartRace()
    {
        HideUI();

        foreach (GameObject racerObject in racers)
        {
            racerObject.GetComponent<Racer>().Accelerate();
        }
    }

    public void FinishRace(string winner)
    {
        if (winner.Equals(nameText.text))
        {
            endgameText.text = "YOU WIN\n";
        }
        else
        {
            endgameText.text = "YOU LOSE\n";
        }
        endgameText.text += "1st place: " + winner;
        gameOver = true;
        UpdateUI();
    }

    public void RestartRace()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void UpdateUI()
    {
        startgameScreen.SetActive(!gameOver);
        endgameScreen.SetActive(gameOver);
    }

    void HideUI()
    {
        gameStart = true;
        selector.gameObject.SetActive(false);
        mainCamera.SetActive(false);
        secondCamera.SetActive(true);
        startgameScreen.SetActive(false);
        endgameScreen.SetActive(false);
        selector.SetActive(false);
    }
}
