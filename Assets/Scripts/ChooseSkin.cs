using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSkin : MonoBehaviour
{
    public GameObject yellowBird;
    public GameObject blueBird;
    public GameObject redBird;

    public void SkinLoad(int nbSkin)
    {
        switch (nbSkin)
        {
            case 1:
                yellowBird.SetActive(true);
                blueBird.SetActive(false);
                redBird.SetActive(false);
                break;
            case 2:
                yellowBird.SetActive(false);
                blueBird.SetActive(true);
                redBird.SetActive(false);
                break;
            case 3:
                yellowBird.SetActive(false);
                blueBird.SetActive(false);
                redBird.SetActive(true);
                break;
            default: // yellow bird set by default
                yellowBird.SetActive(true);
                blueBird.SetActive(false);
                redBird.SetActive(false);
                break;
        }
    }
}
