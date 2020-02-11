using UnityEngine;
using System.Collections;


[System.Serializable]//この属性を使ってインスペクター上で表示
public class ItemStatus : MonoBehaviour
{
    [SerializeField] string itemName;        //名前
    [SerializeField] int itemID;             //アイテムID
    [SerializeField] string itemDesc;        //アイテムの説明文
    [SerializeField] Texture2D itemIcon;     //アイコン
    [SerializeField] int itemPower;          //攻撃力
    [SerializeField] int itemDefense;        //防御力
    [SerializeField] int itemAttackSpeed;    //攻撃速度
    [SerializeField] ElementType elemenType; //属性
    [SerializeField] ItemType itemType;      //アイテムの種類

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
    
    public ItemStatus(string name, int id, string desc, int power, int def, int speed, ElementType etype, ItemType type)
    {
        itemName = name;
        itemID = id;
        //アイコンはnameとイコールにするのでアイコンがあるパス＋nameで取ってきます    
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        itemDesc = desc;
        itemPower = power;
        itemDefense = def;
        itemAttackSpeed = speed;
        elemenType = etype;
        itemType = type;
    }

    public string GetItemName(){ return itemName; }
    public int GetID() { return itemID; }
    public string GetDesc() { return itemDesc; }
    public int GetPower() { return itemPower; }
    public int GetDef() { return itemDefense; }
    public int GetSpeed() { return itemAttackSpeed; }
    public ElementType GetElementType() { return elemenType; }
    public ItemType GetItemType() { return itemType; }
}