using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EC3_MinorHealth : MonoBehaviour
{
    public int difficultyModifier = 1; 
    public int Health = 160;
    public int damage = 30;
    public GameObject Enemy;
    public AudioSource EnemyHit;
    public TextMeshProUGUI Currency;
    public int EnemyVal;
    int curr;

    void Update() {
        if (Health <= 0) {
            Currency.text = (curr+EnemyVal).ToString();
            Destroy(Enemy);
        }
        curr = int.Parse(Currency.text);
    }

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Arrow") {
            Health -= damage;
            EnemyHit.Play();
        }
    }
}
