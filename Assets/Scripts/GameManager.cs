using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Bird BirdScript;
    public int skor;
    public Text skortext;
    // Start is called before the first frame update
    void Start()
    {
            skor = PlayerPrefs.GetInt(nameof(skor));
            skortext.text = skor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void UpdateSkor()
    {
        skor++;
        PlayerPrefs.SetInt(nameof(skor), skor);
        skortext.text = skor.ToString();
    }
    public void UpdateTenScore()
    {
        PlayerPrefs.SetInt(nameof(skor), skor);
        skor += 10;
        skortext.text = skor.ToString();
    }
    public void RestartGame()
    {
        skor = 0;
        PlayerPrefs.SetInt(nameof(skor), skor);
        SceneManager.LoadScene(0);
    }
    public void ScoreRestart()
    {
        skor = 0;
        PlayerPrefs.SetInt(nameof(skor), skor);
    }
}
