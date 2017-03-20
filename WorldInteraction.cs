using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour {
    NavMeshAgent PlayerAgent;

    void Start() {
        PlayerAgent = GetComponent<NavMeshAgent>();
    }


    void Update() {
        //If the left mouse button is down and the cursor is over a game object, calls getInteraction
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) { 
            getInteraction();
        }

    }

    void getInteraction() {
        //Creates a ray from the camer to a the mouse position
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Finds what the ray hits
        RaycastHit interactionInfo;
        //If the ray hits and object
        if (Physics.Raycast(interactionRay,out interactionInfo, Mathf.Infinity)) {
            
            GameObject interactedObject = interactionInfo.collider.gameObject;
            // if the tag = interactable object then this runs
            if (interactedObject.tag == "Interactable Object")
            {
                interactedObject.GetComponent<Interaction>().MoveToInteraction(PlayerAgent);
            }
            //if the tag is not interactable object or there is no tag, then this runs
            else
            {
                //moves the player to the location
                PlayerAgent.destination = interactionInfo.point;
            }
        }
    }

}
