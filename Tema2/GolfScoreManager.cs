using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class GolfScoreManager : MonoBehaviour
{
    public int hitCount = 0; //pentru scor
    public TextMeshPro scoreText; //TextMeshPro

    
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("GolfBall")){
            hitCount++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText(){
        if (scoreText != null){
            scoreText.text = "Scor: " + hitCount;
        }
    }
}


