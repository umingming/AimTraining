﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Runch.Data;
using Runch.View;

namespace Runch
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //new SearchForm().Show();
            //new ListForm().Show();
            //new CategoryForm().Show();
            new LoginForm().Show();
            //new JoinForm().Show();
            //new AddForm().Show();
            Application.Run();
        }


    }
}
