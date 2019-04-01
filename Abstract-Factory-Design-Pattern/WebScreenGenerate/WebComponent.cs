﻿using Abstract_Factory_Design_Pattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.WebScreenGenerate
{
    public class WebComponent : IComponent
    {
        public void BuildComponent()
        {
            // Gerçek uygulamımızda burada veritabanımızdaki bilgilere göre componentler oluşturulacaktır.
            Console.WriteLine("Web TextBox Oluşturuldu.");
            Console.WriteLine("Web Label Oluşturuldu.");
        }
    }
}
