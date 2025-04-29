using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFarmDescription : MonoBehaviour
{
    [SerializeField] private GameObject _descriptionFarm;
    private void OnMouseDown()
    {
        _descriptionFarm.SetActive(true);
    }
}
