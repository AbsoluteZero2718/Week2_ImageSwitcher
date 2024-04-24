using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Expansions
{
    ARR,
    HW,
    SB,
    SHB,
    EW,
    DT
}
public class Switcher : MonoBehaviour
{
    public GameObject[] images;
    public Expansions E_Expansions;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(E_Expansions)
        {
            case Expansions.ARR:
                images[0].SetActive(true);
                images[1].SetActive(false);
                images[2].SetActive(false);
                images[3].SetActive(false);
                images[4].SetActive(false);
                images[5].SetActive(false);
                break;
            case Expansions.HW:
                images[0].SetActive(false);
                images[1].SetActive(true);
                images[2].SetActive(false);
                images[3].SetActive(false);
                images[4].SetActive(false);
                images[5].SetActive(false);
                break;
            case Expansions.SB:
                images[0].SetActive(false);
                images[1].SetActive(false);
                images[2].SetActive(true);
                images[3].SetActive(false);
                images[4].SetActive(false);
                images[5].SetActive(false);
                break;
            case Expansions.SHB:
                images[0].SetActive(false);
                images[1].SetActive(false);
                images[2].SetActive(false);
                images[3].SetActive(true);
                images[4].SetActive(false);
                images[5].SetActive(false);
                break;
            case Expansions.EW:
                images[0].SetActive(false);
                images[1].SetActive(false);
                images[2].SetActive(false);
                images[3].SetActive(false);
                images[4].SetActive(true);
                images[5].SetActive(false);
                break;
            case Expansions.DT:
                images[0].SetActive(false);
                images[1].SetActive(false);
                images[2].SetActive(false);
                images[3].SetActive(false);
                images[4].SetActive(false);
                images[5].SetActive(true);
                break;
            default:
                break;
        }
    }
}
