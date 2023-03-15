using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeChange : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Pokeball")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Theme Changed");
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Theme")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Theme Changed");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
