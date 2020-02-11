using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListDisplay : MonoBehaviour
{
    [SerializeField] Image[] Itemimage;
    [SerializeField] Player player;

    // Start is called before the first frame update
    void Start() { Itemimage = new Image[5]; }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move_select()
    {

    }

    void Useitem_select()
    {

    }
}
