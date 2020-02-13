using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //基礎ステータス
    [SerializeField] private float move_speed;
    [SerializeField] private int HP;
    private int Max_HP;
    [SerializeField] private float attack;
    [SerializeField] private float defense;

    //エフェクト
    [SerializeField] private GameObject find_direction_effect;
    [SerializeField] private GameObject useitem_effect;

    //その他
    private float distance_every_grid = 0.813f;
    [SerializeField] private Having_Itemlist itemlist;

    // Start is called before the first frame update
    void Start()
    {
        Max_HP = HP;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Find();
        Useitem();
    }

    void Move()
    {
        Vector3 scale = transform.localScale;

        //移動方向の指定
        var direction_x = 0f; var direction_y = 0f;
        if (Input.GetKey(KeyCode.W))      { direction_y =   move_speed;  scale.y = -0.08f;                   }
        else if (Input.GetKey(KeyCode.S)) { direction_y = -(move_speed); scale.y =  0.08f;                   }
        else if (Input.GetKey(KeyCode.A)) { direction_x = -(move_speed); scale.y =  0.08f; scale.x = -0.08f; }
        else if (Input.GetKey(KeyCode.D)) { direction_x =   move_speed;  scale.y =  0.08f; scale.x =  0.08f; }
        else { direction_x = 0f; direction_y = 0f; }
        //回転角の代入
        transform.localScale = scale; 

        //移動
        Vector2 velocity = new Vector2(direction_x,direction_y);
        transform.Translate(velocity);
    }

    

    void Find()
    {
        Vector3 scale = transform.localScale;
        Vector3 position = transform.localPosition;
        float continue_time = 3f;
        
        //スクリプトの方向転換
        //向いた方向にエフェクト生成
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))         { scale.y = -0.08f;                   StartCoroutine(Effect_Outbreak(find_direction_effect, new Vector3(position.x, position.y + distance_every_grid, position.z), continue_time)); }
            else if (Input.GetKeyDown(KeyCode.DownArrow))  { scale.y =  0.08f;                   StartCoroutine(Effect_Outbreak(find_direction_effect, new Vector3(position.x, position.y - distance_every_grid, position.z), continue_time)); }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))  { scale.y =  0.08f; scale.x = -0.08f; StartCoroutine(Effect_Outbreak(find_direction_effect, new Vector3(position.x - distance_every_grid, position.y, position.z), continue_time)); }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) { scale.y =  0.08f; scale.x =  0.08f; StartCoroutine(Effect_Outbreak(find_direction_effect, new Vector3(position.x + distance_every_grid, position.y, position.z), continue_time)); }
        }
        
        //回転角の代入
        transform.localScale = scale;
    }

    void Useitem()
    {
        Vector3 scale = transform.localScale;
        Vector3 position = transform.localPosition;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))         { scale.y = -0.08f;                   StartCoroutine(Effect_Outbreak(useitem_effect, new Vector3(position.x, position.y + distance_every_grid, position.z), 5)); }
            else if (Input.GetKeyDown(KeyCode.DownArrow))  { scale.y =  0.08f;                   StartCoroutine(Effect_Outbreak(useitem_effect, new Vector3(position.x, position.y - distance_every_grid, position.z), 5)); }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))  { scale.y =  0.08f; scale.x = -0.08f; StartCoroutine(Effect_Outbreak(useitem_effect, new Vector3(position.x - distance_every_grid, position.y, position.z), 5)); }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) { scale.y =  0.08f; scale.x =  0.08f; StartCoroutine(Effect_Outbreak(useitem_effect, new Vector3(position.x + distance_every_grid, position.y ,position.z), 5)); }
        }

        //回転角の代入
        transform.localScale = scale;
    }

    //生成したEffectを持っておくためのList
    private List<GameObject> list_efeect_outbreak;

    IEnumerator Effect_Outbreak(GameObject effect,Vector3 vector3,float outbreak_time)
    {
        if(list_efeect_outbreak == null)
            list_efeect_outbreak = new List<GameObject>();

        //インスタンスを作成
        GameObject effect_outbreak = Instantiate(effect,vector3,Quaternion.identity) as GameObject;

        //生成したインスタンスをリストで持っておく
        list_efeect_outbreak.Add(effect_outbreak);
        
        // outbreak_timeフレーム後に消滅
        for (int i = 0; i < outbreak_time; i++) { yield return null; }
        
        //リストで保持しているインスタンスを削除
        for (int i = 0; i < list_efeect_outbreak.Count; i++){ Destroy(list_efeect_outbreak[i]); }

        //リスト自体をキレイにする
        list_efeect_outbreak.Clear();

        StopCoroutine(Effect_Outbreak(effect,vector3,outbreak_time));
    }

    public int getHP() { return HP; }
    public int getMax_HP() { return Max_HP; }
}