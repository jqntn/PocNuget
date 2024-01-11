using System;

namespace MVVM
{
    internal record ModelCallback(string PropertyName, Action PropertyChanged);
}

namespace System.Runtime.CompilerServices { public class IsExternalInit { } }