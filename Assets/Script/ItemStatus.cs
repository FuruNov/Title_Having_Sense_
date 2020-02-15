using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemStatus : MonoBehaviour
{
    [SerializeField] private string itemName;       //名前
    [SerializeField] private int itemID;            //アイテムID
    [SerializeField] private string itemDesc;       //アイテムの説明文
    [SerializeField] private Texture2D itemIcon;    //アイコン
    [SerializeField] private Image itemImageUI;     //UI用
    [SerializeField] private int itemPower;         //攻撃力
    [SerializeField] private int itemDefense;       //防御力
    [SerializeField] private int itemWeight;        //重さ
    [SerializeField] private int HavingLimit;       //所持制限
    [SerializeField] private ItemType itemType;
    [SerializeField] private SubItemType subitemType; 

    //アイテムタイプも同じくenum      
    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        Quest,
        Field
    }

    public enum SubItemType
    {
        Non,

      //Weapon
        Sword,
        Spear,
        Axe,
        Bow,

      //Armor
        Head,
        Body,
        Leg
    }
    
    public ItemStatus(string name, int id, string desc, int power, int def, int speed, ItemType type, SubItemType stype)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemDefense = def;
        HavingLimit = speed;
        itemType = type;
        subitemType = stype;
    }

    public string GetItemName(){ return itemName; }
    public int GetID() { return itemID; }
    public string GetDesc() { return itemDesc; }
    public int GetPower() { return itemPower; }
    public int GetDefense() { return itemDefense; }
    public int GetWeight() { return itemWeight; }
    public int GetHavingLimit() { return HavingLimit; }
    public ItemType GetItemType() { return itemType; }
    public SubItemType GetSubItemType() { return subitemType; }
}