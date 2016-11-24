﻿using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace $rootnamespace$
{
    [MvxFragment(typeof(MyViewModel), Resource.Id.my_resource_id)]
[Register("$rootnamespace$.MyFragmentName")]
public class Fragment : MvxFragment<MyViewModel>
{
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        var ignore = base.OnCreateView(inflater, container, savedInstanceState);

        // If your bindings for this fragment are done in XML, you need to call this.BindingInflate. If not, call inflater.Inflate instead. The two are never both necessary -- remove the one you don't need
        var view = this.BindingInflate(Resource.Layout.my_fragment_layout, null);
        var view = inflater.Inflate(Resource.Layout.my_fragment_layout, null);

        return view;
    }
}
}
