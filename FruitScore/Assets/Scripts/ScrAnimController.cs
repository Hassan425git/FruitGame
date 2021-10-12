using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAnimController : MonoBehaviour
{
    public Animator anim;
    public GameObject[] fruit;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        int fruitEaten = 0;
        for (int i = 0; i < fruit.Length; i++) {
            if (!fruit[i]) {
                fruitEaten++;
            }
        }

        if (fruitEaten == fruit.Length) {
            anim.Play("doorAnimation");
        }
    }
}