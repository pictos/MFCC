﻿using MFCC.Pages;

namespace MFCC;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ImageControlPage), typeof(ImageControlPage));
    }
}
