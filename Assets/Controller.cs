using UnityEngine;
using System.Collections;

[System.Serializable]
public enum MoveState {
    Stopped,
    Walking,
    Running
}

[System.Serializable]
public enum JumpState {
    Grounded,
    Jump,
    Jumping,
    Landing
}

[System.Serializable]
public enum Team {
    Hider,
    Seeker
}

[System.Serializable]
public class MovementVariables {
    
}

[System.Serializable]
public class InputMappings {
    // probably want to move this to a script that sits on the camera.  the
    // script would also provide a remap-keys dialog in the options menu and
    // could hopefully be reused in other projects
    public string sprint = "shift";
    public string jump = "space";
    // double tap wasd to juke?
}

public class Controller : MonoBehaviour {
    public JumpState jump;
    public MoveState move;
    public Team team;
    public InputMappings keymap;
    
    Vector3 velocity;

	// Use this for initialization
	void Start() {
	    
	}
	
	// Update is called once per frame
	void Update() {
	    UpdateMoveState();
	}
    
    private UpdateMoveState() {
        // gets the direction for the mapped movement keys
        velocity = Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // handle the jump key and sprint key
        if (Input.GetKeyDown(keymap.jump)) {
            UpdateJumpState();
        }
        if (Input.GetKeyDown(keymap.sprint)) {
           velocity = velocity + Vector3.up;
        }
        // try and have it check (like in character motor) if jump button pressed in last few seconds (0.2 is their number)
        // if they just landed give a boost jump? make the player feel powerful with some skill button presses?
    }
    
    private UpdateJumpState() {
        
    }

    public void IsGrounded() {

    }
}
