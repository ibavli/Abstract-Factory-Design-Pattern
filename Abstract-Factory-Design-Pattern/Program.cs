﻿using Abstract_Factory_Design_Pattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractGenerateScreen screenGenerator = new GenerateWebScreen();
            IPage webPage = screenGenerator.CreatePage();
            webPage.BuildPage();
            IComponent webComponent = screenGenerator.CreateComponent();
            webComponent.BuildComponent();

            Console.WriteLine("\n\n");
            screenGenerator = new GenerateWinFormScreen();
            IPage winForm = screenGenerator.CreatePage();
            winForm.BuildPage();
            IComponent winFormComponent = screenGenerator.CreateComponent();
            winFormComponent.BuildComponent();

            Console.WriteLine("\n\n");
            screenGenerator = new GenerateXScreen();
            IPage xPage = screenGenerator.CreatePage();
            xPage.BuildPage();
            IComponent xComponent = screenGenerator.CreateComponent();
            xComponent.BuildComponent();

            Console.ReadLine();
        }
    }
}
