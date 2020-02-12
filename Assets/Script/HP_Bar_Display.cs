using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Bar_Display : MonoBehaviour
{
    [SerializeField] private Slider HP_Bar;
    [SerializeField] private Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HP_Bar.value = player.getHP();
        HP_Bar.maxValue = player.getMax_HP();
    }
}
