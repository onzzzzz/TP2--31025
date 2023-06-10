using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JellyCount : MonoBehaviour
{

    TMPro.TMP_Text healthtext;
    public static int healthcount;
    
    void Awake()
    {
        healthtext = GetComponent<TMPro.TMP_Text>();   
    }

    void Start()
    {
        healthcount = 3;
        UpdateHealth();
    }

    void OnEnable() => Jelly.OnCollided += OnCollidedHealth;
    void OnDisable() =>  Jelly.OnCollided -= OnCollidedHealth;

    void UpdateHealth()
    {
        healthtext.text = $" Health : {healthcount} " ;
    }

    void OnCollidedHealth()
    {
        healthcount --;
        UpdateHealth();
        CheckHealth();
        
    }

    void GameOverNow()
    {
        SceneManager.LoadScene(4);
    }

    void CheckHealth() {
            if (healthcount <= 0 )
        {
            Invoke("GameOverNow", 2f);
        } else 
        { 
            return ;
        }
        }
}

