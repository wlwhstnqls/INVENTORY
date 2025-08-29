using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button Back;
    public GameObject InventoryMenu;

    public UISlot[] Slots;
    public Transform SlotPanel;
    public GameObject equipButton;

    public Item[] item;
    


    void Start()
    {
        Back.onClick.AddListener(OnClickBack);
        Slots = new UISlot[SlotPanel.childCount];

        for (int i = 0; i < SlotPanel.childCount; i++)
        {
            Slots[i] = SlotPanel.GetChild(i).GetComponent<UISlot>();
            Slots[i].index = i;
            Slots[i].inventory = this;
        }
    }

    public void OnClickBack()
    {
        UIManager.instance.UIMainMenu.Buttons.SetActive(true);
        InventoryMenu.SetActive(false);
    }
}
