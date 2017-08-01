﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace MaterialDesignColors.WpfExample
{
    /// <summary>
    /// Interaction logic for Chips.xaml
    /// </summary>
    public partial class Chips : UserControl
    {
        public Chips()
        {
            InitializeComponent();
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\User\Desktop\MaterialDesignXAMLToolKitNew\MaterialDesignInXamlToolkit\MainDemo.Wpf\Chips.xaml");
            this.XamlDisplayerPanel.Initialize(xmlDoc); ;

        }

        private void ButtonsDemoChip_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Chip clicked.");
        }

        private void ButtonsDemoChip_OnDeleteClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Chip delete clicked.");
        }

    }
}
