using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bilder : MonoBehaviour
{
    public bool activeArsenal = false;
    public bool activeBarracks = false;
    public bool activeComposition = false;
    public bool activeFarm = false;
    public bool activeHouse = false;
    public bool activeMine = false;
    public bool activeQuarry = false;
    public bool activeSawmill = false;
    public bool activeScout = false;

    public void activationArsenal() => activeArsenal = true;
    public void activationBarracks() => activeBarracks = true;
    public void activationComposition() => activeComposition = true;
    public void activationFarm() => activeFarm = true;
    public void activationHouse() => activeHouse = true;
    public void activationMine() => activeMine = true;
    public void activationQuarry() => activeQuarry = true;
    public void activationSawmill() => activeSawmill = true;
    public void activationScout() => activeScout = true;
}
