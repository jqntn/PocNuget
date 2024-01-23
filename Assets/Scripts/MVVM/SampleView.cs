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

            ModelCallbacks.Add(new(nameof(SampleModel.SubChild), () => Debug.LogError($"OnPropertyChanged: {nameof(SampleModel.SubChild)} -> {model.Parent.Child.SubChild.i}")));
        }

        private void Start()
        {
            TriggerAllModelCallbacks();

            model.SubChild = new SubChild { i = 1 };
        }

        private void OnEnable()
        {
            EnableModelCallbacks();
        }

        private void OnDisable()
        {
            DisableModelCallbacks();
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