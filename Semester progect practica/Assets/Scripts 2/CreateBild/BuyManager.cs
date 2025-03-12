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
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeInHierarchy)
            {
            }
            else
            {
                buyMenu.SetActive(true);
            }
        }
    }
    private void OnClick()
    {
        buyMenu.SetActive(false);
    }
}
