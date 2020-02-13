using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stairs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_find_direction_effect")
        {
            if(SceneManager.GetActiveScene().name == "Mystery_Scene")
                SceneManager.LoadScene("Battle_Scene");

            if (SceneManager.GetActiveScene().name == "Battle_Scene")
                SceneManager.LoadScene("Title_Scene");
        }
    }
}
