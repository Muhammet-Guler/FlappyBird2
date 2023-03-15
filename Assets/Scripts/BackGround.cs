using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    public Image Image1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Image1.sprite = Resources.Load<Sprite>("background");
        //Image1.transform.position = new Vector3(0, 0, 0);
        
    }
}
