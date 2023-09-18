using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Demo
{
    public class UIAnimSetting : MonoBehaviour
    {
        [SerializeField] private Dropdown dropdown;
        [SerializeField] private Button preBtn;
        [SerializeField] private Button nextBtn;

        private AxieStarter axie;

        private void Start()
        {
            axie = FindObjectOfType<AxieStarter>();

            if (axie == null) return;

            var options = new List<Dropdown.OptionData>();
            AxieStarter.AnimNames.ForEach(x =>
            {
                var op = new Dropdown.OptionData();
                op.text = x;
                options.Add(op);
            });

            dropdown.options = options;

            dropdown.onValueChanged.AddListener(
                (arg0) => {
                    axie?.PlayAnim(dropdown.options[arg0].text);
                });

            preBtn.onClick.AddListener(() =>
            {
                dropdown.value -= 1;
            });

            nextBtn.onClick.AddListener(() =>
            {
                dropdown.value += 1;
            });


            axie.OnChangedAxie += (arg0) =>
             {
                 dropdown.SetValueWithoutNotify(0);
             };
        }
    }
}
