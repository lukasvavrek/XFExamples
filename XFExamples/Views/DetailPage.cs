﻿using System;

using Xamarin.Forms;

namespace XFExamples.Views
{
    public class DetailPage : ContentPage
    {
        public DetailPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

