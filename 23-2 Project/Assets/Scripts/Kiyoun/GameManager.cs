using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies = new GameObject[8];
    public GameObject heli;
    public GameObject player;
    public int score;
    void Start()
    {
        for(int i = 0; i < enemies.Length; i++){
            enemies[i].SetActive(false);
        }   
        heli.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = player.GetComponent<PlayerController>().score;
        if(score == 1){
            enemies[1].SetActive(true);
        }
        if(score == 2){
            enemies[2].SetActive(true);
        }
        if(score == 3){
            enemies[3].SetActive(true);
        }
        if(score == 4){
            enemies[4].SetActive(true);
            heli.SetActive(true);
            for(int i=0;i<6;i++){
                enemies[i].GetComponent<PatrolEnemy>().speed = 4.0f;
            }
        }
        if(score == 5){
            enemies[5].SetActive(true);
        }
        if(score == 6){
            enemies[6].SetActive(true);
        }
        if(score == 7){
            enemies[7].SetActive(true);
            for(int i=0;i<6 ;i++){
                enemies[i].GetComponent<PatrolEnemy>().speed = 8.0f;
            }
        }
    }
}
