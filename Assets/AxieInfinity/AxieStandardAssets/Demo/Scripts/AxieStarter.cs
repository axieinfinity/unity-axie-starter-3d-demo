using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public class AxieStarter : MonoBehaviour
    {
        [SerializeField] private GameObject[] axies;
        private Animator animator;

        public Action<int> OnChangedAxie;
        public Action<string> OnPlayedAnim;

        public static List<string> AnimNames = new List<string>
        {
            "Idle",
            "IdleAttack",
            "IdleGetHit",
            "IdleCarryItem",
            "Walk",
            "WalkAttack",
            "WalkCarryItem",
            "Run",
            "RunAttack",
            "RunGetHit",
            "RunCarryItem",
            "Jump",
            "WalkJump",
            "RunJump"
        };

        private void Start()
        {
            ChangeAxie(0);
        }

        public void ChangeAxie(int index)
        {
            if (index < axies.Length)
            {
                for (int i=0; i< axies.Length; i++)
                {
                    axies[i].SetActive(i == index);
                }
                animator = axies[index].GetComponent<Animator>();
                OnChangedAxie?.Invoke(index);
            }
        }

        public void PlayAnim(string anim)
        {
            if (animator != null)
            {
                animator.Play(anim);
                OnPlayedAnim?.Invoke(anim);
            }
        }

    }
}

