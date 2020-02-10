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

    //周囲の照度の取得に使用
    [SerializeField] LightSensor[] lightSensor;
    
    //照度による移動制限の閾値
    [SerializeField] float move_limit_by_shadow;

    // Start is called before the first frame update
    void Start()
    {
        if(lightSensor == null)
            lightSensor = new LightSensor[4]; //0 ... 上,1 ... 左,2 ... 右,3 ... 下
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //移動方向の指定
        var direction_x = 0f; var direction_y = 0f;

        //周りが暗いと移動不可
        if (Input.GetKey(KeyCode.W) && lightSensor[0].lightValue >= move_limit_by_shadow) { direction_y = move_speed; }
        else if (Input.GetKey(KeyCode.A) && lightSensor[1].lightValue >= move_limit_by_shadow) { direction_x = -(move_speed); }
        else if (Input.GetKey(KeyCode.D) && lightSensor[2].lightValue >= move_limit_by_shadow) { direction_x = move_speed; }
        else if (Input.GetKey(KeyCode.S) && lightSensor[3].lightValue >= move_limit_by_shadow) { direction_y = -(move_speed); }
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
