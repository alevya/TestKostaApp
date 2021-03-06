﻿using System;
using System.Windows.Forms;
using MainApp.Common;

namespace MainApp.View
{
    internal interface IMainView :IView
    {
        event Action SelectPage;
        void ShowError(string msgError);
        TabControl MainTab { get; }
    }
}
