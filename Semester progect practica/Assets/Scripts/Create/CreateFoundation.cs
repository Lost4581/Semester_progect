using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFoundation : MonoBehaviour
{
    [SerializeField] GameObject foundationMain;
    [SerializeField] GameObject buyFoundation;
    [SerializeField] GameObject buyFoundationBG;
    [SerializeField] GameObject wherePutFoundation;
    [SerializeField] GameObject foundation1;
    [SerializeField] GameObject foundation2;
    [SerializeField] GameObject foundation3;
    [SerializeField] GameObject foundation4;    
    [SerializeField] GameObject foundation5;
    [SerializeField] GameObject foundation6;    
    [SerializeField] GameObject foundation7;
    [SerializeField] GameObject foundation8;    
    [SerializeField] GameObject foundation9;

    public void OnClick()
    {
        foundationMain.SetActive(true);
        wherePutFoundation.SetActive(false);

        if (foundation1.activeInHierarchy && foundation2.activeInHierarchy && foundation3.activeInHierarchy && foundation4.activeInHierarchy && foundation5.activeInHierarchy
        && foundation6.activeInHierarchy && foundation7.activeInHierarchy && foundation8.activeInHierarchy && foundation9.activeInHierarchy)
        {
            buyFoundation.SetActive(false);
            buyFoundationBG.SetActive(true);
        }
    }
}
