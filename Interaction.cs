using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

    public NavMeshAgent playerAgent;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent) {

        this.playerAgent = playerAgent;
        playerAgent.destination = this.transform.position;
    }
	
}

