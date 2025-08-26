using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button Back;
    public GameObject StatusBtn;
    public GameObject InventoryBtn;
    public GameObject InventoryMenu;


    void Start()
    {
        Back.onClick.AddListener(OnClickBack);
    }

    public void OnClickBack()
    {
        StatusBtn.SetActive(true);
        InventoryBtn.SetActive(true);
        InventoryMenu.SetActive(false);
    }
}
