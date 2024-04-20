using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Functions
{
    public static class NavBarManager
    {
        public static void SetEmployeeButtonVisibility(Button button, Role userRole)
        {
            switch(userRole)
            {
                case Role.Admin:
                    button.Visible = true;
                    break;
                case Role.Employee:
                    button.Visible = true;
                    break;
                default:
                    button.Visible = false;
                    break;
            }
        }

        public static void SetAdminButtonVisibility(Button button, Role userRole)
        {
            switch (userRole)
            {
                case Role.Admin:
                    button.Visible = true;
                    break;
                default:
                    button.Visible = false;
                    break;
            }
        }
    }
}
