using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FootstepAudio : MonoBehaviour
{
    public AudioSource footstepsSound;


        // The minimum distance the object must move before the sound is played
        public float minMoveDistance = 0.1f;

        // The position of the object in the previous frame
        private Vector3 previousPosition;

        // Start is called before the first frame update
        void Start()
        {
            // Store the initial position of the object
            previousPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            // Calculate the distance the object has moved since the last frame
            float moveDistance = Vector3.Distance(transform.position, previousPosition);

        // If the object has moved more than the minimum distance
        if (moveDistance >= minMoveDistance)
        {
            // Play the sound
            footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }
            // Store the current position of the object for the next frame
            previousPosition = transform.position;
        }
}
    





    /*private float lastY;
    private float lastX;

    void Start()
    {
        lastY = gameObject.transform.position.y;
        lastX = gameObject.transform.position.x;

    }

    void Update()
    {
        if (lastY < gameObject.transform.position.y)
        {
            footstepsSound.enabled = true;
            Debug.Log("Y position is increasing");
        }
        else
        {
            footstepsSound.enabled = true;
        }
        
        lastY = gameObject.transform.position.y;

        if (lastX < gameObject.transform.position.x)
        {
            footstepsSound.enabled = true;
            Debug.Log("X Position is increasing");
        }
        else
        {
            footstepsSound.enabled = true;
        }
        lastX = gameObject.transform.position.x;
    }*/


    /*PlayerControls controls;
    Vector2 move;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Movement.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Movement.Move.canceled += ctx => move = Vector2.zero;
    }

    void Update()
    {

        if (move != Vector2.zero) 
            footstepsSound.enabled = true;
        else
        {
            footstepsSound.enabled = false;
        }

    }*/

