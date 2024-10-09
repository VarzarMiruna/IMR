using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Distanta : MonoBehaviour
{
    public GameObject imageTarget1;
    public GameObject imageTarget2;
    public float maxDistance = 0.15f;

    private bool attackTriggerActivated = false;

    private void Update()
    {
        float distance = Vector3.Distance(imageTarget1.transform.position, imageTarget2.transform.position);
        var imageTarget1Animator = imageTarget1.GetComponentInChildren<Animator>();
        var imageTarget2Animator = imageTarget2.GetComponentInChildren<Animator>();

        if (!attackTriggerActivated && distance < maxDistance)
        {
            if (imageTarget1Animator != null && imageTarget2Animator != null)
            {
                imageTarget1Animator.SetTrigger("Idle");
                imageTarget2Animator.SetTrigger("Idle");
                imageTarget1Animator.SetTrigger("Attack");
                imageTarget2Animator.SetTrigger("Attack");
                attackTriggerActivated = true;
            }
        }
        else if (attackTriggerActivated && distance >= maxDistance)
        {
            if (imageTarget1Animator != null && imageTarget2Animator != null)
            {
                imageTarget1Animator.SetTrigger("Idle");
                imageTarget2Animator.SetTrigger("Idle");
                attackTriggerActivated = false;
            }
        }
    }
}