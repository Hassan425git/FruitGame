using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("F"))
        {
            //Destroy(other.gameObject);
            other.GetComponent<FPlayer>().Initialize(gameObject);
        }
    }
}
