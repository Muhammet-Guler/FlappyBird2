using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int skor;
    public Text skortext;
    // Start is called before the first frame update
    void Start()
    {
        skor = 0;
        skortext.text = skor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateSkor()
    {
        skor++;
        skortext.text = skor.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
}
