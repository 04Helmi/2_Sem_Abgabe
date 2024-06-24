using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractionScript : MonoBehaviour
{
    //Reference
    [SerializeField] UiController uiController;

    //Variable
    [SerializeField] private float cooldownTime;
    private bool isCooldown;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Walls") && isCooldown == false)
        {
            uiController.HeartReduction();
            isCooldown = true;
            StartCoroutine(CooldownTimer());
        }

        {
        if (collision.gameObject.CompareTag("Victory"))
            {
                SceneManager.LoadScene("SecondLevel");
                Debug.Log(true);
            }
        }
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(cooldownTime); 
        isCooldown = false;
    }
}
