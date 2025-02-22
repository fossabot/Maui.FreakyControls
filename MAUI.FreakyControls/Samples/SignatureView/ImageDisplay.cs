﻿using Maui.FreakyControls;
using Maui.FreakyControls.Extensions;
using System.Linq;

namespace Samples.SignatureView;

public class ImageDisplay : ContentPage
{
    public ImageDisplay(Stream stream)
    {
        var imageView = new ZoomImage
        {
            Aspect = Aspect.AspectFit,
            VerticalOptions = LayoutOptions.Fill,
            HorizontalOptions = LayoutOptions.Fill
        };
        Content = imageView;
        var imageSource = ImageSource.FromStream(() => stream);
        imageView.Source = imageSource;
    }
}