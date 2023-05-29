using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public BaseState activeState;
    public PatrolState patrolstate;
    public void Initialise()
    {
        patrolstate = new PatrolState();
        ChangeState(patrolstate);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activeState!=null)
        {
            activeState.Perform();
        }
    }
    public void ChangeState(BaseState newState)
    {
        if (activeState != null)
        { activeState.Exit(); }
        activeState = newState;
        if(activeState!=null)
        {
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }

    }
   
}
