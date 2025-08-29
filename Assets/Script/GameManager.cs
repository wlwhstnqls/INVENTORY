using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
   public Charater player { get; set; }

    


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Charater("Hero", 1, 100, 10, 5, 1, 50);
        UIManager.instance.UIMainMenu.CharacterInfo(player);
        UIManager.instance.UIStatus.CharInfo(player);
    }

}
