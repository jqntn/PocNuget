using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace MVVM
{
    internal abstract class View<T> : MonoBehaviour where T : Model
    {
        protected T model;

        protected List<ModelCallback> ModelCallbacks = new();

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            foreach (var mc in ModelCallbacks)
                if (args.PropertyName == mc.PropertyName || args == Model.AllChanged)
                    mc.PropertyChanged?.Invoke();
        }

        protected void EnableModelCallbacks()
        {
            model.PropertyChanged += OnPropertyChanged;
        }

        protected void DisableModelCallbacks()
        {
            model.PropertyChanged -= OnPropertyChanged;
        }

        protected void TriggerAllModelCallbacks()
        {
            OnPropertyChanged(this, Model.AllChanged);
        }
    }
}