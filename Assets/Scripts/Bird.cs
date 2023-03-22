using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public int Score;
    public bool oldumu;
    public Rigidbody2D rb2d;
    public float velocity = 1f;
    public GameManager gameManager;
    public GameObject olumEkrani;
    public int BalloonScore=0;
    float zValue;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d == true)
        {
            zValue = transform.rotation.eulerAngles.z;
            transform.Rotate(new Vector3(0f, 0f, -1f));
            if (transform.eulerAngles.z > 50 && transform.eulerAngles.z < 310)
            {
                transform.eulerAngles = Vector3.forward * (zValue);
            }
            if (oldumu == true)
            {
                transform.eulerAngles = Vector3.forward * (zValue);
            }
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * velocity;
            //transform.Rotate(new Vector3(0f, 0f, 30f));
            //if (transform.position.y < 0)
            //{
            //    transform.Rotate(new Vector3(0f, 0f, -30f));
            //}
                transform.Rotate(new Vector3(0f, 0f, 25f));

            if (transform.eulerAngles.z > 50 && transform.eulerAngles.z < 310)
            {
                transform.eulerAngles = Vector3.forward * (zValue);
            }
            if (oldumu == true)
            {
                transform.eulerAngles = Vector3.forward * (zValue);
            }
        }
        //else
        //{

            
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="SkorSay")
        {
            gameManager.UpdateSkor();
        }
        if (collision.gameObject.tag == "Balloon")
        {
            BalloonScore++;
            gameManager.UpdateSkor();
            Destroy(collision.gameObject);
            if (BalloonScore == 5)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(1);
                BalloonScore = 0;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="OlumAlaný")
        {
            oldumu = true;
            Time.timeScale = 0;
            olumEkrani.SetActive(true); 
            gameManager.ScoreRestart();
        }

    }
}
