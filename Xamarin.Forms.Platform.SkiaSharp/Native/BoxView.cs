﻿using SkiaSharp;

namespace Xamarin.Forms.Platform.SkiaSharp.Native
{
    public class BoxView : SKView
    {
        SKColor _color;
        SKPoint _cornerRadius;

        public SKColor Color
        {
            get => _color;
            set
            {
                _color = value;
                Invalidate();
            }
        }

        public SKPoint CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                Invalidate();
            }
        }

        protected override void Render(SKCanvas canvas, SKRect frame)
        {
            base.Render(canvas, frame);

            using (var paint = new SKPaint { IsAntialias = true })
            {
                paint.Color = Color;
                canvas.DrawRoundRect(AbsoluteFrame, CornerRadius.X, CornerRadius.Y, paint);
            }
        }
    }
}