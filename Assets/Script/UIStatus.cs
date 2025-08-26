using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button Back;
    public GameObject StatusBtn;
    public GameObject InventoryBtn;
    public GameObject StatusMenu;

   
    void Start()
    {
        Back.onClick.AddListener(OnClickBack);
    }

    public void OnClickBack()
    {
        StatusBtn.SetActive(true);
        InventoryBtn.SetActive(true);
        StatusMenu.SetActive(false);
    }

}
