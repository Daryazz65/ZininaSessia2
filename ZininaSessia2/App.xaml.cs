using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZininaSessia2.Model;

namespace ZininaSessia2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static user25Entities _context;
        public static user25Entities GetContext()
        {
            if (_context == null)
            {
                _context = new user25Entities();
            }
            return _context;
        }
    }
}