using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodTimer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI howManyW;
    [SerializeField] private List<GameObject> sawmills;
    [SerializeField] public int maxTimeWood;
    [SerializeField] public int maxWood;
    [SerializeField] public int howManyAddWood;
    public int howManyWood;
    float currTime;

    private void Start()
    {
        currTime = maxTimeWood;
        howManyW.text = "0";
    }
    private void Update()
    {
        for (int i = 0; i < sawmills.Count; i++)
        {
            if (sawmills[i].activeInHierarchy)
            {
                timerWood();
                howManyW.text = $"{howManyWood}";
            }
        }  
    }
    public void timerWood()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeWood;
            AddWood(howManyAddWood);
        }
        if (howManyWood > maxWood)
        {
            howManyWood = maxWood;
            //howManyW.text = $"{howManyWood}";
        }
    }
    public void AddWood(int value)
    {
        howManyWood += value;
        //howManyW.text = $"{howManyWood}";
    }
}
