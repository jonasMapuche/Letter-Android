﻿using System;
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
    public class BotFragment : Fragment
    {
        public int PlayId => Arguments.GetInt("current_play_id", 0);

        public static BotFragment NewInstance(int playId) {
            var bundle = new Bundle();
            bundle.PutInt("current_play_id", playId);
            return new BotFragment { Arguments = bundle };
        }

        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_bot, container, false);
        }
    }
}