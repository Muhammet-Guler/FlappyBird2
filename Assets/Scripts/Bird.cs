using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool oldumu;
    public Rigidbody2D rb2d;
    public float velocity = 1f;
    public GameManager gameManager;
    public GameObject olumEkrani;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="SkorSay")
        {
            gameManager.UpdateSkor();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="OlumAlaný")
        {
            oldumu = true;
            Time.timeScale = 0;
            olumEkrani.SetActive(true); 
        }
    }
}
