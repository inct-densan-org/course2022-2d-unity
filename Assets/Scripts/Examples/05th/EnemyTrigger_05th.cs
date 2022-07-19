using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger_05th : MonoBehaviour
{

    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;

    public bool IsGround() {
        if(isGroundEnter || isGroundStay) {
            isGround = true;
        } else if(isGroundExit) {
            isGround = false;
        }

        isGroundEnter = false;
        isGroundStay = false;
        isGroundExit = false;

        return isGround;
    }

    private void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.CompareTag("Ground")) {
            isGroundEnter = true;
        }
    }

    private void OnTriggerStay2D (Collider2D col) {
        if (col.gameObject.CompareTag("Ground")) {
            isGroundStay = true;
        }
    }

    private void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.CompareTag("Ground")) {
            isGroundExit = true;
        }
    }
}
