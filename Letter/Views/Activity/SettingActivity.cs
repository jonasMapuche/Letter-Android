using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace Letter.Views.Activity
{
    [Activity(Label = "SettingActivity")]
    public class SettingActivity : FragmentActivity
    {
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            int playId = Intent.Extras.GetInt("current_play_id", 0);

            SettingFragment detailsFrag = SettingFragment.NewInstance(playId);
            SupportFragmentManager.BeginTransaction()
                            .Add((AndroidX.Fragment.App.Fragment)Android.Resource.Id.Content, (string)detailsFrag)
                            .Commit();
        }
    }
}