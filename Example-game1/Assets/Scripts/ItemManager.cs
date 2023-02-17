using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviourSingleton<ItemManager>
{
    public Player player;
    int gold;
    public void OnItemPickup(Item item)
    {
        gold = 0;
        Items.Add(item);
        Debug.Log("Item Picked up");
        item.Use();
        foreach(Item item2 in Items)
        {
            gold += item2.cost;
           
        }
        Debug.Log("All items cost" + gold);
        if (item.label == "Armor")
        {
            player.EquipArmor();
        }
        if (item.label == "Helmet")
        {
            //player.EquipHelmet();
        }
        if (item.label == "Gloves")
        {
            //player.EquipGloves();
        }
        if (item.label == "Boots")
        {
            //player.EquipBoots();
        }
        if (item.label == "Sword")
        {
            //player.EquipSword();
        }
       

    }
    public List<Item> Items;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
