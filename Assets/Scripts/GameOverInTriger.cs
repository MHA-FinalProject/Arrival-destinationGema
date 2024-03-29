using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTriger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    //[SerializeField] string StrongtriggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("Game over!");
            Application.Quit();
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }

}
