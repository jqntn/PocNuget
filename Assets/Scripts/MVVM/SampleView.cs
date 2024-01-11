using UnityEngine;

namespace MVVM
{
    internal sealed class SampleView : View<SampleModel>
    {
        private void Awake()
        {
            model = new();

            ModelCallbacks.Add(new(nameof(SampleModel.FirstName), UpdateFirstName));
            ModelCallbacks.Add(new(nameof(SampleModel.FamilyName), UpdateFamilyName));
        }

        private void Start()
        {
            TriggerAllModelCallbacks();
        }

        private void OnEnable()
        {
            EnableCallbacksForModel();
        }

        private void OnDisable()
        {
            DisableCallbacksForModel();
        }

        private void UpdateFirstName()
        {
            Debug.LogError($"OnPropertyChanged: {nameof(SampleModel.FirstName)} -> {model.FirstName}");
        }

        private void UpdateFamilyName()
        {
            Debug.LogError($"OnPropertyChanged: {nameof(SampleModel.FamilyName)} -> {model.FamilyName}");
        }
    }
}