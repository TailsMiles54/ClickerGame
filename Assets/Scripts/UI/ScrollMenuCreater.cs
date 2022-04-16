using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScrollMenuCreater : MonoBehaviour
{
    public GameObject MenuButtonPrefab;
    public GameObject ParentObject;

    public List<MenuItemSetting> ListMenuSettings;

    public void Start()
    {
        CreateScrollElements();
    }

    private void CreateScrollElements()
    {
        foreach (var item in ListMenuSettings)
        {
            var menuButton = MenuButtonPrefab;
            menuButton.GetComponent<ScrollButton>().Image.sprite = item.Image;
            menuButton.GetComponent<ScrollButton>().TextMeshPro.text = item.Text;
            Instantiate(MenuButtonPrefab, ParentObject.transform);
        }
    }
}

public class ScrollButtonElement
{
    
} 
