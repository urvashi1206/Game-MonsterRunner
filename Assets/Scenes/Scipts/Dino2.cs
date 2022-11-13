using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            stand.SetActive(true);
            crouch.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
