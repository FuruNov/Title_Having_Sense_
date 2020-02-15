using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HavingItemList : MonoBehaviour
{
    [SerializeField] private ItemDirectory itemDirectory;
    [SerializeField] private Player player; //所持プレイヤー
    private Dictionary<string, int> NumberOfItem; //アイテムの名前と所持数を管理
    [SerializeField] private List<ItemStatus> HavingItem; //所持しているアイテムのリスト

    // Start is called before the first frame update
    void Start() { foreach ( ItemStatus i in itemDirectory.GetItemList() ) { NumberOfItem[i.GetItemName()] = 0;  } }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SortHavingList()
    {
        HavingItem.Clear();
        foreach (ItemStatus i in itemDirectory.GetItemList()) 
        { 
            if(NumberOfItem[i.GetItemName()] != 0) { HavingItem.Add(i); }
        }
    }
}
