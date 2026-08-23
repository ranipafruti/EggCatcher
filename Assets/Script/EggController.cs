using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
            GameManager.instance.DecreaseHealth();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "EggDestroyer")
        {
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "Basket")
        { 
            Destroy(gameObject);
            ScoreManager.scoreManagerStatic.IncreaseScore();
        }
    }
}
