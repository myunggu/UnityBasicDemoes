using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoReaction()
    {
        GetComponent<Animator>().SetTrigger("Reaction");
    }

    public void DoWalk()
    {
        GetComponent<Animator>().SetTrigger("Walk");
    }

    public void DoWalkAndMove()
    {
        GetComponent<Animator>().SetTrigger("WalkAndMove");
    }
}
