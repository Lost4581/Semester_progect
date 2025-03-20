using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IronTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyI;
    [SerializeField] private List<GameObject> mines;
    [SerializeField] private int maxTimeIron;
    [SerializeField] private int howManyIron;
    [SerializeField] private int maxIron;
    [SerializeField] private int howManyAddIron;
    float currTime;

    private void Start()
    {
        currTime = maxTimeIron;
        howManyI.text = "0";
    }
    private void Update()
    {
        for (int i = 0; i < mines.Count; i++)
        {
            if (mines[i].activeInHierarchy)
            {
                timerIron();
            }
        }
    }
    public void timerIron()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeIron;
            AddIron(howManyAddIron);
        }
        if (howManyIron > maxIron)
        {
            howManyIron = maxIron;
            howManyI.text = $"{howManyIron}";
        }
    }
    public void AddIron(int value)
    {
        howManyIron += value;
        howManyI.text = $"{howManyIron}";
    }
}

