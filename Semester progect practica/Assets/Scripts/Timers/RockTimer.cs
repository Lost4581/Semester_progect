using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyR;
    [SerializeField] private int maxTimeRock;
    [SerializeField] GameObject mine1;
    [SerializeField] GameObject mine2;
    [SerializeField] GameObject mine3;
    [SerializeField] GameObject mine4;
    [SerializeField] GameObject mine5;
    [SerializeField] GameObject mine6;
    [SerializeField] GameObject mine7;
    [SerializeField] GameObject mine8;
    [SerializeField] GameObject mine9;
    public int howManyRock;
    public int maxRock;
    float currTime;

    private void Start()
    {
        currTime = maxTimeRock;
        howManyR.text = "0";
    }
    private void Update()
    {
        if (mine1.activeInHierarchy || mine2.activeInHierarchy || mine3.activeInHierarchy || mine4.activeInHierarchy || mine5.activeInHierarchy 
        || mine6.activeInHierarchy || mine7.activeInHierarchy || mine8.activeInHierarchy || mine9.activeInHierarchy)
        {
            timerRock();
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
            AddRock(1);
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

