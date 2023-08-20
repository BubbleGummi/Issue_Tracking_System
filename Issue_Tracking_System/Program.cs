using Issue_Tracking_System.Contexts;
using Issue_Tracking_System.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.ComponentModel.Design;
using Issue_Tracking_System.Services;

namespace Issue_Tracking_System
{
    class Program
    {
        static async Task Main(string[] args)
        {
            MenuService menu = new MenuService(); 
             while(true)
            {
                await menu.MainMenu();
            }
        }
    }
}
