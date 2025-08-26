using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button Back;
    public GameObject StatusMenu;
    [SerializeField] private Text Attack;
    [SerializeField] private Text Defense;
    [SerializeField] private Text HP;
    [SerializeField] private Text Critical;


    void Start()
    {
        Back.onClick.AddListener(OnClickBack);
    }

    public void OnClickBack()
    {
        UIManager.instance.UIMainMenu.Buttons.SetActive(true);
        StatusMenu.SetActive(false);
    }

}
