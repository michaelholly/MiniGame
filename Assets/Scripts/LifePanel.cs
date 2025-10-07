using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private Image[] lifeImages = new Image[3];
    public void UpdateLifePanel(int lives)
    {
        if (lives >= 3)
        {
            lifeImages[0].enabled = true;
            lifeImages[1].enabled = true;
            lifeImages[2].enabled = true;
        }
        else if (lives == 2)
        {
            lifeImages[0].enabled = true;
            lifeImages[1].enabled = true;
            lifeImages[2].enabled = false;
        }
        else if(lives == 1)
        {
            lifeImages[0].enabled = true;
            lifeImages[1].enabled = false;
            lifeImages[2].enabled = false;
        }
        else
        {
            lifeImages[0].enabled = false;
            lifeImages[1].enabled = false;
            lifeImages[2].enabled = false;
        }
    }
}
