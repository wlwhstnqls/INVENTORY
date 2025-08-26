using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;  

public class UIMainMenu : MonoBehaviour
{
    public Button Status;
    public Button Inventory;
    public GameObject StatusBtn;
    public GameObject InventoryBtn;
    public GameObject StatusPanel;
    public GameObject InventoryPanel;

    void Start()
    {
        Status.onClick.AddListener(OnClickStatus);
        Inventory.onClick.AddListener(OnClickInventory);

        StatusPanel.SetActive(false);
        InventoryPanel.SetActive(false);
    }

    public void OnClickStatus()
    {
        StatusBtn.SetActive(false);
        InventoryBtn.SetActive(false);
        StatusPanel.SetActive(true);          
        InventoryPanel.SetActive(false);     
    }

    public void OnClickInventory()
    {
        StatusBtn.SetActive(false);
        InventoryBtn.SetActive(false);
        StatusPanel.SetActive(false);        
        InventoryPanel.SetActive(true);       
    }

}
