﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Skin_disease
{

public partial class SecondPage : ContentPage
{
    public SecondPage(string S)
    {
            InitializeComponent();
            Img.Source = S;
    }
}
}