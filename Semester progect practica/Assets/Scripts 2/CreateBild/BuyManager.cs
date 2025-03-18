using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyManager : MonoBehaviour
{
    [SerializeField] private GameObject buyMenu;
    [SerializeField] private Button backButton;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClick);
    }
    private void OnMouseDown()
    {
        buyMenu.SetActive(true);
    }
    private void OnClick()
    {
        buyMenu.SetActive(false);
    }
}
