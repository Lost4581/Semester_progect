using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockTimer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI howManyR;
    [SerializeField] private List<GameObject> quarrys;
    [SerializeField] public int maxTimeRock;
    [SerializeField] public int maxRock;
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
                howManyR.text = $"{howManyRock}";
            }
        }
        if (howManyRock > maxRock)
        {
            howManyRock = maxRock;
            howManyR.text = $"{howManyRock}";
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
    }
    public void AddRock(int value)
    {
        howManyRock += value;
    }
}

