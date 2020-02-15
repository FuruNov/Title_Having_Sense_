using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDirectory : MonoBehaviour
{
    //ソート用のList
    [SerializeField] List<ItemStatus> item = new List<ItemStatus>();

    /*0*/
    [SerializeField] List<ItemStatus> Weapon;
    /*1*/
    [SerializeField] List<ItemStatus> WeaponPower;
    [SerializeField] List<ItemStatus> WeaponDefense;
    [SerializeField] List<ItemStatus> WeaponWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Sword;
    /*2*/
    [SerializeField] List<ItemStatus> SwordPower;
    [SerializeField] List<ItemStatus> SwordDefense;
    [SerializeField] List<ItemStatus> SwordWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Spear;
    /*2*/
    [SerializeField] List<ItemStatus> SpearPower;
    [SerializeField] List<ItemStatus> SpearDefense;
    [SerializeField] List<ItemStatus> SpearWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Axe;
    /*2*/
    [SerializeField] List<ItemStatus> AxePower;
    [SerializeField] List<ItemStatus> AxeDefense;
    [SerializeField] List<ItemStatus> AxeWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Bow;
    /*2*/
    [SerializeField] List<ItemStatus> BowPower;
    [SerializeField] List<ItemStatus> BowDefense;
    [SerializeField] List<ItemStatus> BowWeight;

    /*0*/
    [SerializeField] List<ItemStatus> Armor;

    /*1*/
    [SerializeField] List<ItemStatus> ArmorPower;
    [SerializeField] List<ItemStatus> ArmorDefense;
    [SerializeField] List<ItemStatus> ArmorWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Head;
    /*2*/
    [SerializeField] List<ItemStatus> HeadPower;
    [SerializeField] List<ItemStatus> HeadDefense;
    [SerializeField] List<ItemStatus> HeadWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Body;
    /*2*/
    [SerializeField] List<ItemStatus> BodyPower;
    [SerializeField] List<ItemStatus> BodyDefense;
    [SerializeField] List<ItemStatus> BodyWeight;

    /*1*/
    [SerializeField] List<ItemStatus> Leg;
    /*2*/
    [SerializeField] List<ItemStatus> LegPower;
    [SerializeField] List<ItemStatus> LegDefense;
    [SerializeField] List<ItemStatus> LegWeight;

    /*0*/
    [SerializeField] List<ItemStatus> Consumable;
    [SerializeField] List<ItemStatus> Quest;
    [SerializeField] List<ItemStatus> Field;

    // Start is called before the first frame update
    void Start() { Sorting(); }

    // Update is called once per frame
    void Update()
    {

    }

    void Sorting()
    {

        //IDの昇順にソート
        item.Sort((a, b) => a.GetID() - b.GetID());

        Weapon.Clear();
        Armor.Clear();
        Consumable.Clear();
        Quest.Clear();
        Field.Clear();

        //アイテムをカテゴリごとにソート
        foreach (ItemStatus it in item)
        {
            switch (it.GetItemType())
            {
                case ItemStatus.ItemType.Weapon: Weapon.Add(it); break;
                case ItemStatus.ItemType.Armor: Armor.Add(it); break;
                case ItemStatus.ItemType.Consumable: Consumable.Add(it); break;
                case ItemStatus.ItemType.Quest: Quest.Add(it); break;
                case ItemStatus.ItemType.Field: Field.Add(it); break;
            }
        }

        //-------------------------------------------------

        //武器をステータスごとに降順ソート
        foreach (ItemStatus wp in Weapon)
        {
            WeaponPower.Add(wp);
            WeaponPower.Sort((a, b) => b.GetPower() - a.GetPower());

            WeaponDefense.Add(wp);
            WeaponDefense.Sort((a, b) => b.GetDefense() - a.GetDefense());

            WeaponWeight.Add(wp);
            WeaponWeight.Sort((a, b) => b.GetWeight() - a.GetWeight());
        }

        //武器種ごとにステータスでソート        
        foreach (ItemStatus wp in Weapon)
        {
            switch (wp.GetSubItemType())
            {
                case ItemStatus.SubItemType.Sword: Sword.Add(wp); break;
                case ItemStatus.SubItemType.Spear: Spear.Add(wp); break;
                case ItemStatus.SubItemType.Axe: Axe.Add(wp); break;
                case ItemStatus.SubItemType.Bow: Bow.Add(wp); break;
            }

        }

        foreach (ItemStatus wp in WeaponPower)
        {
            switch (wp.GetSubItemType())
            {
                case ItemStatus.SubItemType.Sword: SwordPower.Add(wp); break;
                case ItemStatus.SubItemType.Spear: SpearPower.Add(wp); break;
                case ItemStatus.SubItemType.Axe: AxePower.Add(wp); break;
                case ItemStatus.SubItemType.Bow: BowPower.Add(wp); break;
            }

        }

        foreach (ItemStatus wp in WeaponDefense)
        {
            switch (wp.GetSubItemType())
            {
                case ItemStatus.SubItemType.Sword: SwordDefense.Add(wp); break;
                case ItemStatus.SubItemType.Spear: SpearDefense.Add(wp); break;
                case ItemStatus.SubItemType.Axe: AxeDefense.Add(wp); break;
                case ItemStatus.SubItemType.Bow: BowDefense.Add(wp); break;
            }

        }

        foreach (ItemStatus wp in WeaponWeight)
        {
            switch (wp.GetSubItemType())
            {
                case ItemStatus.SubItemType.Sword: SwordWeight.Add(wp); break;
                case ItemStatus.SubItemType.Spear: SpearWeight.Add(wp); break;
                case ItemStatus.SubItemType.Axe: AxeWeight.Add(wp); break;
                case ItemStatus.SubItemType.Bow: BowWeight.Add(wp); break;
            }

        }

        //----------------------------------------------------------------------

        //防具をステータスごとに降順ソート
        foreach (ItemStatus ar in Armor)
        {
            ArmorPower.Add(ar);
            ArmorPower.Sort((a, b) => b.GetPower() - a.GetPower());

            ArmorDefense.Add(ar);
            ArmorDefense.Sort((a, b) => b.GetDefense() - a.GetDefense());

            ArmorWeight.Add(ar);
            ArmorWeight.Sort((a, b) => b.GetWeight() - a.GetWeight());
        }

        //防具の部位ごとにソート
        foreach (ItemStatus ar in Armor)
        {
            switch (ar.GetSubItemType())
            {
                case ItemStatus.SubItemType.Head: Head.Add(ar); break;
                case ItemStatus.SubItemType.Body: Body.Add(ar); break;
                case ItemStatus.SubItemType.Leg: Leg.Add(ar); break;
            }
        }

        foreach (ItemStatus ar in ArmorPower)
        {
            switch (ar.GetSubItemType())
            {
                case ItemStatus.SubItemType.Head: HeadPower.Add(ar); break;
                case ItemStatus.SubItemType.Body: BodyPower.Add(ar); break;
                case ItemStatus.SubItemType.Leg: LegPower.Add(ar); break;
            }
        }

        foreach (ItemStatus ar in ArmorDefense)
        {
            switch (ar.GetSubItemType())
            {
                case ItemStatus.SubItemType.Head: HeadDefense.Add(ar); break;
                case ItemStatus.SubItemType.Body: BodyDefense.Add(ar); break;
                case ItemStatus.SubItemType.Leg: LegDefense.Add(ar); break;
            }
        }

        foreach (ItemStatus ar in ArmorWeight)
        {
            switch (ar.GetSubItemType())
            {
                case ItemStatus.SubItemType.Head: HeadWeight.Add(ar); break;
                case ItemStatus.SubItemType.Body: BodyWeight.Add(ar); break;
                case ItemStatus.SubItemType.Leg: LegWeight.Add(ar); break;
            }
        }
    }

    public List<ItemStatus> GetItemList(){
        return item;
    }
}
