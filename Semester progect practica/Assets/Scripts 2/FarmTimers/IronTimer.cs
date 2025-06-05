using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IronTimer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI howManyI;
    [SerializeField] private List<GameObject> mines;
    [SerializeField] public int maxTimeIron;
    [SerializeField] public int maxIron;
    [SerializeField] public int howManyAddIron;
    public int howManyIron;
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
                howManyI.text = $"{howManyIron}";
            }
        }
        if (howManyIron > maxIron)
        {
            howManyIron = maxIron;
            howManyI.text = $"{howManyIron}";
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
    }
    public void AddIron(int value)
    {
        howManyIron += value;
    }
}

