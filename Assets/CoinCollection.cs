using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour

{
    public Text score;
    private int scoreValue = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin") 
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            SetScore();
        
        
        
        }


    }

    void SetScore ()
    {
        score.text = "Coins: " + scoreValue;
    }

}
