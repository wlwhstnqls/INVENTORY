using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISlot : MonoBehaviour
{
   
    public int index;
    public UIInventory inventory;
    

    void Start()
    {
        SetItem();
    }
    void SetItem()
    {
        GameObject item = Resources.Load<GameObject>("Prefabs/Item");
        Instantiate(item, this.transform.position, Quaternion.identity, this.transform);
    }

    void RefreshUI()
    {

    }
}
