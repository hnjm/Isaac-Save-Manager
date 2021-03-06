﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IsaacSaveManager;

namespace IsaacManagerUI
{
    /// <summary>
    /// Interaction logic for TextEntryWindow.xaml
    /// </summary>
    public partial class TextEntryWindow : Window
    {
        public TextEntryWindow()
        {
            this.DataContext = new TextEntryWindowViewModel();
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            ((TextEntryWindowViewModel)this.DataContext).Name = null;
            this.Close();
        }
    }
}
