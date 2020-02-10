using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private float distance_every_grid = 0.813f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_direction_select")
        {
            Vector3 position = transform.position;
            if(Input.GetKey(KeyCode.UpArrow)) { position.y += distance_every_grid; }
            else if (Input.GetKey(KeyCode.DownArrow)) { position.y -= distance_every_grid; }
            else if (Input.GetKey(KeyCode.LeftArrow)) { position.x -= distance_every_grid; }
            else if (Input.GetKey(KeyCode.RightArrow)) { position.x += distance_every_grid; }

            transform.position = position;
        }
    }
}
