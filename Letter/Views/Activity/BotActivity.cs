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
using Letter.Views;

namespace Letter
{
    [Activity(Label = "BotActivity")]
    public class BotActivity : FragmentActivity
    {
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var playId = Intent.Extras.GetInt("current_play_id", 0);

            BotFragment detailsFrag = BotFragment.NewInstance(playId);
            SupportFragmentManager.BeginTransaction()
                            .Add((AndroidX.Fragment.App.Fragment)Android.Resource.Id.Content, (string)detailsFrag)
                            .Commit();
        }
    }
}