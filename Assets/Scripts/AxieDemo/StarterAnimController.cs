using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AxieStarter3D
{
    public class StarterAnimController : MonoBehaviour
    {
        public class AnimName
        {
            public const string Idle = "Idle";
            public const string IdleAttack = "IdleAttack";
            public const string IdleGetHit = "IdleGetHit";
            public const string IdleCarryItem = "IdleCarryItem";

            public const string Walk = "Walk";
            public const string WalkAttack = "WalkAttack";
            public const string WalkCarryItem = "WalkCarryItem";

            public const string Run = "Run";
            public const string RunAttack = "RunAttack";
            public const string RunGetHit = "RunGetHit"; 
            public const string RunCarryItem = "RunCarryItem"; 

            public const string IdleJump = "Jump";
            public const string WalkJump = "WalkJump";
            public const string RunJump = "RunJump";
        }

        public Animator animator;

        private void Awake()
        {
            if (animator==null)
                animator = GetComponent<Animator>();
        }

        public void PlayAnim(string animName)
        {
            if (animator != null)
            {
                animator.Play(animName);
            }
            else
            {
                Debug.LogError("Animator is NULL");
            }
        }
    }

}
