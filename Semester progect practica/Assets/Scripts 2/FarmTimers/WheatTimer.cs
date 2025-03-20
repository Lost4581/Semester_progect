using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatTimer: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyW;
    [SerializeField] private List<GameObject> farms;
    [SerializeField] private int maxTimeWheat;
    [SerializeField] private int howManyWheat;
    [SerializeField] private int maxWheat;
    [SerializeField] private int howManyAddWheat;
    float currTime;

    private void Start()
    {
        currTime = maxTimeWheat;
        howManyW.text = "0";
    }
    private void Update()
    {
        for (int i = 0; i < farms.Count; i++)
        {
            if (farms[i].activeInHierarchy)
            {
                timerWheat();
            }
        }  
    }
    public void timerWheat()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeWheat;
            AddWheat(howManyAddWheat);
        }
        if (howManyWheat > maxWheat)
        {
            howManyWheat = maxWheat;
            howManyW.text = $"{howManyWheat}";
        }
    }
    public void AddWheat(int value)
    {
        howManyWheat += value;
        howManyW.text = $"{howManyWheat}";
    }
}
