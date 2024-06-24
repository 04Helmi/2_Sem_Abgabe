using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    //Reference
    [SerializeField] private Image herz;
    [SerializeField] private Image herz1;
    [SerializeField] private Image herz2;

    [SerializeField] private Image anti;
    [SerializeField] private Image anti2;
    [SerializeField] private Image anti3;


    public void HeartReduction ()
    {
        if (herz2.enabled)
        { 
            herz2.enabled = false;
            anti3.enabled = true;
        }
        else if (herz1.enabled) 
        {
            herz1.enabled = false;
            anti2 .enabled = true;
        }
        else if (herz.enabled)
        {
            herz.enabled = false;
            anti.enabled = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        
        
    }

}
