using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Letter.Views
{
    [Obsolete]
    public class HomeFragment : Fragment
    {
        public int PlayId => Arguments.GetInt("current_play_id", 0);

        public static HomeFragment NewInstance(int playId)
        {
            var bundle = new Bundle();
            bundle.PutInt("current_play_id", playId);
            return new HomeFragment { Arguments = bundle };
        }

        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_home, container, false);
           
        }

    }
}