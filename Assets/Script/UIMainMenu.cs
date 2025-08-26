using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;  

public class UIMainMenu : MonoBehaviour
{
    public Button Status;
    public Button Inventory;
    public GameObject Buttons;

    [SerializeField] private Text ID;
    [SerializeField] private Text Level;
    [SerializeField] private Text Gold;


    void Start()
    {
        Status.onClick.AddListener(OnClickStatus);
        Inventory.onClick.AddListener(OnClickInventory);              
    }

    public void OnClickStatus()
    {        
        Buttons.SetActive(false);
        UIManager.instance.UIStatus.StatusMenu.SetActive(true);
        UIManager.instance.UIInventory.InventoryMenu.SetActive(false);     
    }

    public void OnClickInventory()
    {
        Buttons.SetActive(false);
        UIManager.instance.UIStatus.StatusMenu.SetActive(false);
        UIManager.instance.UIInventory.InventoryMenu.SetActive(true);
    }

}
