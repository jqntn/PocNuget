using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace MVVM
{
    internal abstract class View : MonoBehaviour
    {
        protected List<ModelCallback> ModelCallbacks = new();

        protected void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            foreach (var mc in ModelCallbacks)
                if (args.PropertyName == mc.PropertyName || args.PropertyName == Model.ALL)
                    mc.PropertyChanged?.Invoke();
        }

        protected void EnableCallbacksForModel(in Model model)
        {
            model.PropertyChanged += OnPropertyChanged;
        }

        protected void DisableCallbacksForModel(in Model model)
        {
            model.PropertyChanged -= OnPropertyChanged;
        }

        protected void TriggerAllModelCallbacks()
        {
            OnPropertyChanged(this, Model.AllChanged);
        }
    }
}