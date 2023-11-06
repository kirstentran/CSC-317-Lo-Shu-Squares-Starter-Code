using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Program_4_Idea_Lo_Shu_Squares
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}