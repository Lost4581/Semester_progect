using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bilder : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameras;
    [SerializeField] private List<GameObject> cells;
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _buyMenu;
    public bool activeArsenal = false;
    public bool activeBarracks = false;
    public bool activeComposition = false;
    public bool activeHouse = false;
    public bool activeMine = false;
    public bool activeQuarry = false;
    public bool activeSawmill = false;
    public bool activeScout = false;

    public void activationArsenal()
    {
        activeArsenal = true;
        activeBarracks = false;
        activeComposition = false;
        activeHouse = false;
        activeMine = false;
        activeQuarry = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationBarracks()
    {
        activeBarracks = true;
        activeArsenal = false;
        activeComposition = false;
        activeHouse = false;
        activeMine = false;
        activeQuarry = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationComposition()
    {
        activeComposition = true;
        activeBarracks = false;
        activeArsenal = false;
        activeHouse = false;
        activeMine = false;
        activeQuarry = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationHouse()
    {
        activeHouse = true;
        activeBarracks = false;
        activeArsenal = false;
        activeComposition = false;
        activeMine = false;
        activeQuarry = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationMine()
    {
        activeMine = true;
        activeHouse = false;
        activeBarracks = false;
        activeArsenal = false;
        activeComposition = false;
        activeQuarry = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationQuarry()
    {
        activeQuarry = true;
        activeHouse = false;
        activeBarracks = false;
        activeArsenal = false;
        activeComposition = false;
        activeMine = false;
        activeSawmill = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationSawmill()
    {
        activeSawmill = true;
        activeHouse = false;
        activeBarracks = false;
        activeArsenal = false;
        activeComposition = false;
        activeMine = false;
        activeQuarry = false;
        activeScout = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void activationScout()
    {
        activeScout = true;
        activeHouse = false;
        activeBarracks = false;
        activeArsenal = false;
        activeComposition = false;
        activeMine = false;
        activeQuarry = false;
        activeSawmill = false;

        _button.SetActive(false);
        _camera.SetActive(true);
        _buyMenu.SetActive(false);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = true;
        }
    }
}
