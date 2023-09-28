using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Demo
{
    public class UIAxieSetting : MonoBehaviour
    {
        [SerializeField] private Dropdown dropdown;
        [SerializeField] private Button preBtn; 
        [SerializeField] private Button nextBtn;

        private AxieStarter axie;

        private void Start()
        {
            axie = FindObjectOfType<AxieStarter>();

            dropdown.options = new List<Dropdown.OptionData>()
            {
                new Dropdown.OptionData("Buba"),
                new Dropdown.OptionData("Pomodoro"),
                new Dropdown.OptionData("Puffy"),
            };

            dropdown.onValueChanged.AddListener(
                (arg0) => {
                    axie?.ChangeAxie(arg0);
            });

            preBtn.onClick.AddListener(() =>
            {
                dropdown.value -= 1;
            });

            nextBtn.onClick.AddListener(() =>
            {
                dropdown.value += 1;
            });
        }
    }
}

