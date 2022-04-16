using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Menu Item", menuName = "ClickerGame/Settings/Menu/Menu Item", order = 0)]
public class MenuItemSetting : ScriptableObject
{
    [SerializeField] private string _text;
    [SerializeField] private Sprite _image;
    [SerializeField] private MenuElement _menuElement;
    
    public string Text => _text;
    public Sprite Image => _image;
    public MenuElement MenuElement => _menuElement;
}
