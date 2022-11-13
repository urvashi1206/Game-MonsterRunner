using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject GOPanel;

    public GameObject Interstitial;

    AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        loseSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void GameOver()
    {
        loseSound.Play();

        Time.timeScale = 0;
       // Interstitial.GetComponent<InterstitialAds>().ShowInterstitial();
        GOPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Dino");
    }
}
