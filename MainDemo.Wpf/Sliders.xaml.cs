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
using CodeDisplayer;

namespace MaterialDesignColors.WpfExample
{
    /// <summary>
    /// Interaction logic for Sliders.xaml
    /// </summary>
    public partial class Sliders : UserControl
    {
        public Sliders()
        {
            InitializeComponent();
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\User\Desktop\MaterialDesignXAMLToolKitNew\MaterialDesignInXamlToolkit\MainDemo.Wpf\Sliders.xaml");
            this.XamlDisplayerPanel.Initialize(xmlDoc);            ;
        }
    }
}
