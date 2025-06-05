using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatTimer: MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI howManyW;
    [SerializeField] private List<GameObject> farms;
    [SerializeField] public int maxTimeWheat;
    [SerializeField] public int maxWheat;
    [SerializeField] public int maxPeasant;
    [SerializeField] public int howManyAddWheat;
    public int howManyWheat;
    public float howManyPeasant;
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
                howManyW.text = $"{howManyWheat}";
            }
        }
        if (howManyWheat > maxWheat)
        {
            howManyWheat = maxWheat;
            howManyW.text = $"{howManyWheat}";
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
    }
    public void AddWheat(int value)
    {
        howManyWheat += value;
    }
}
