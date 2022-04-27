using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    [SerializeField] private Animator avatarAnimation;

    // Start is called before the first frame update
    void Start()
    {
        avatarAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(avatarAnimation != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                avatarAnimation.SetTrigger("ReadyTrigger");
            }

            if (Input.GetKey(KeyCode.J))
            {
                avatarAnimation.SetTrigger("JumpTrigger");
            }

            if (Input.GetKey(KeyCode.R))
            {
                avatarAnimation.SetTrigger("RunTrigger");
            }

            if (Input.GetKey(KeyCode.K))
            {
                avatarAnimation.SetTrigger("DefeatedTrigger");
            }

            if (Input.GetKey(KeyCode.H))
            {
                avatarAnimation.SetTrigger("ExcitedTrigger");
            }

            if (Input.GetKey(KeyCode.I))
            {
                avatarAnimation.SetTrigger("IdleTrigger");
            }
        }
    }
}

