using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendExpeditions : MonoBehaviour
{
    private bool canSending = true;

    [SerializeField] private TextMeshProUGUI howManySec;

    [SerializeField] private float startTime;
    private float curTime;

    private void Start()
    {
        curTime = startTime;
        canSending = true;
    }

    private void Update()
    {
        howManySec.text = $"{curTime}";
        if (curTime <= 0)
        {
            canSending = false;
        }
    }

    public void SendExpedition()
    {
        if (canSending)
        {
            curTime -= Time.deltaTime;
            canSending = false;
        }
    }
}
