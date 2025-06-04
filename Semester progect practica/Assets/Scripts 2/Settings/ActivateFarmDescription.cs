using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivateFarmDescription : MonoBehaviour
{
    [SerializeField] private WheatTimer wheatTimer;

    [SerializeField] private GameObject _descriptionFarm;
    [SerializeField] public TextMeshProUGUI infoAboutResourses;

    private void OnMouseDown()
    {
        _descriptionFarm.SetActive(true);
        infoAboutResourses.text = $"Пшеница:\nДобывается в сек {wheatTimer.howManyAddWheat}";
    }
}
