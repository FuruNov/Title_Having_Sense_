using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPlayer : MonoBehaviour
{
    //基礎ステータス
    [SerializeField] float move_speed;
    [SerializeField] float HP;
    [SerializeField] float attack;
    [SerializeField] float defense;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //移動方向の指定
        var direction_x = 0f; var direction_y = 0f;

        if (Input.GetKey(KeyCode.W)) { direction_y = move_speed; }
        else if (Input.GetKey(KeyCode.A)) { direction_x = -(move_speed); }
        else if (Input.GetKey(KeyCode.D)) { direction_x = move_speed; }
        else if (Input.GetKey(KeyCode.S)) { direction_y = -(move_speed); }
        else { direction_x = 0f; direction_y = 0f; }

        //移動
        var velocity = new Vector2(direction_x, direction_y);
        transform.Translate(velocity);
    }

    void Find()
    {

    }

    void Attack()
    {

    }

}
