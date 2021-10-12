using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Animator Anim;
    private NavMeshAgent agent;
   // private int speedPosition = 1;
    //[SerializeField] 
    private GameObject player;
    private bool isInitialized = false;
    private void Awake()
    {
        Anim = GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();

    }
    void Start()
    {

    }
    public void Initialize(GameObject player)
    {
        this.player = player;
        //offset = transform.position - player.transform.position;

        StartFollow();
    }

    // Update is called once per frame
    void StartFollow()
    {
        GetComponent<Animator>().enabled = true;
        //Anim.SetBool("Walk", true);
        isInitialized = true;
        //transform.position = Vector3.Lerp(transform.position, player.transform.position, speedPosition * Time.deltaTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, speedRotation * Time.deltaTime);
    }

    private void Update()
    {
        if (isInitialized)
        {
            agent.SetDestination(player.transform.position);
        }

    }
}
