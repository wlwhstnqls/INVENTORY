using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button Back;
    public GameObject InventoryMenu;


    void Start()
    {
        Back.onClick.AddListener(OnClickBack);
    }

    public void OnClickBack()
    {
        UIManager.instance.UIMainMenu.Buttons.SetActive(true);
        InventoryMenu.SetActive(false);
    }
}
