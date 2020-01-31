using UnityEngine;
using System.Collections;


[System.Serializable]//この属性を使ってインスペクター上で表示
public class ItemList : MonoBehaviour
{
    public string itemName;        //名前
    public int itemID;             //アイテムID
    public string itemDesc;        //アイテムの説明文
    public Texture2D itemIcon;     //アイコン
    public int itemPower;          //攻撃力
    public int itemDefense;        //防御力
    public int itemAttackSpeed;    //攻撃速度
    public int itemLifeSteal;      //ライフスティール（特殊効果）
    public ElementType elemenType; //属性
    public ItemType itemType;      //アイテムの種類

    //属性はまた別にenumにて切り替えれるようにします
    public enum ElementType
    {
        Non,
        Fire,
        Ice,
        Lightning,
    }
    //アイテムタイプも同じくenum      
    public enum ItemType
    {
        Weapon,
        Consumable,
        Quest
    }
    //ここでリスト化時に渡す引数をあてがいます   
    public ItemList(string name, int id, string desc, int power, int def, int speed, int ls, ElementType etype, ItemType type)
    {
        itemName = name;
        itemID = id;
        //アイコンはnameとイコールにするのでアイコンがあるパス＋nameで取ってきます    
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        itemDesc = desc;
        itemPower = power;
        itemDefense = def;
        itemAttackSpeed = speed;
        itemLifeSteal = ls;
        elemenType = etype;
        itemType = type;
    }

}