using UnityEngine;

namespace MVVM
{
    internal sealed class SampleView : View
    {
        private SampleModel model;

        private void Awake()
        {
            model = new();
        }

        private void Start()
        {
            TriggerAllModelCallbacks();
        }

        private void OnEnable()
        {
            EnableCallbacksForModel(model);

            ModelCallbacks.Add(new(nameof(SampleModel.FirstName), UpdateFirstName));
            ModelCallbacks.Add(new(nameof(SampleModel.FamilyName), UpdateFamilyName));
        }

        private void OnDisable()
        {
            DisableCallbacksForModel(model);

            ModelCallbacks.Clear();
        }

        private void UpdateFirstName()
        {
            Debug.LogError($"{nameof(OnPropertyChanged)}: {nameof(SampleModel.FirstName)} -> {model.FirstName}");
        }

        private void UpdateFamilyName()
        {
            Debug.LogError($"{nameof(OnPropertyChanged)}: {nameof(SampleModel.FamilyName)} -> {model.FamilyName}");
        }
    }
}