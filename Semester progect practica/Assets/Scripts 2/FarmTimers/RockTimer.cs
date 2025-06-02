using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockTimer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI howManyR;
    [SerializeField] private List<GameObject> quarrys;
    [SerializeField] private int maxTimeRock;
    [SerializeField] private int maxRock;
    [SerializeField] public int howManyAddRock;
    public int howManyRock;
    float currTime;

    private void Start()
    {
        currTime = maxTimeRock;
        howManyR.text = "0";
    }
    private void Update()
    {
        for (int i = 0; i < quarrys.Count; i++)
        {
            if (quarrys[i].activeInHierarchy)
            {
                timerRock();
            }
        } 
    }
    public void timerRock()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeRock;
            AddRock(howManyAddRock);
        }
        if (howManyRock > maxRock)
        {
            howManyRock = maxRock;
            howManyR.text = $"{howManyRock}";
        }
    }
    public void AddRock(int value)
    {
        howManyRock += value;
        howManyR.text = $"{howManyRock}";
    }
}

