using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private float distance_every_grid = 0.808f;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_find_direction_effect")
        {
            Vector3 position = transform.position;
            if(Input.GetKey(KeyCode.UpArrow))          { position.y += distance_every_grid; }
            else if (Input.GetKey(KeyCode.DownArrow))  { position.y -= distance_every_grid; }
            else if (Input.GetKey(KeyCode.LeftArrow))  { position.x -= distance_every_grid; }
            else if (Input.GetKey(KeyCode.RightArrow)) { position.x += distance_every_grid; }

            transform.position = position;
            Destroy(other);
        }
    }
}
