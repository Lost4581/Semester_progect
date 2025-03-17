using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyManager : MonoBehaviour
{
    [SerializeField] private GameObject buyMenu;
    [SerializeField] private Button backButton;
    [SerializeField] private Bilder _bilder;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClick);
    }
    private void OnMouseDown()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeInHierarchy)
            {
                buyMenu.SetActive(false);
                break;
            }
            else
            {
                buyMenu.SetActive(true);
            }
        }
        _bilder.SetCurrentSelection(this);
    }
    private void OnClick()
    {
        buyMenu.SetActive(false);
    }
}
