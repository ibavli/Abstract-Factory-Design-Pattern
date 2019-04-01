using Abstract_Factory_Design_Pattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.WinFormScreenGenerate
{
    public class WinForm : IPage
    {
        // Gerçek uygulamımızda burada veritabanımızdaki bilgilere göre sayfalar oluşturulacaktır.
        public void BuildPage()
        {
            Console.WriteLine("Win Form Oluşturuldu.");
        }
    }
}
