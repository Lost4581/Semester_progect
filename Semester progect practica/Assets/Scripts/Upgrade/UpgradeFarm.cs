using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeFarm : MonoBehaviour
{
    public WheatTimer howManyWheat;
    public WheatTimer addWheat;
    public WoodTimer maxTimeWheat;
    public WoodTimer howManyWood;
    public RockTimer howManyRock;
    public IronTimer howManyIron;
    [SerializeField] private TextMeshProUGUI howMany;
    [SerializeField] private TextMeshProUGUI howLong;
    [SerializeField] private TextMeshProUGUI sellPrice1;
    [SerializeField] private TextMeshProUGUI sellPrice2;
    public int sellPrice1Int;
    public int sellPrice2Int;

    private void Start()
    {
        howMany.text = $"{addWheat}";
        howLong.text = $"{maxTimeWheat}";

    }

    public void OnClick()
    {
        //howManyW.text = $"{howManyWheat}";
    }
}
