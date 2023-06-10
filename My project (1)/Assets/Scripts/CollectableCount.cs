using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    public AudioSource audioData3;
    public GameObject levelMessage;
    
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
        audioData3 = GetComponent<AudioSource>(); 
    }

    void Start()
    {
        levelMessage.SetActive(false);
        UpdateCount();
    }

    void OnEnable() => Collectable.OnCollected += OnCollectableCollected;
    void OnDisable() =>  Collectable.OnCollected -= OnCollectableCollected;
     
    void OnCollectableCollected()
    {
        Collectable.count ++;
        TotalPoints.score ++;
        UpdateCount();
        LevelJump();

    }

    void UpdateCount()
    {
        text.text = $"{Collectable.count} / {Collectable.total}  Total score: {TotalPoints.score}" ;
    }


    void NextLevel()
    {
        Collectable.count = 0;
        Collectable.total = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    void LevelJump()
    {
        if (Collectable.count >= Collectable.total)
        {
            audioData3.Play();
            levelMessage.SetActive(true);
            Invoke("NextLevel",2f);
           

        } 
    }

}
