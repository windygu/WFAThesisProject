﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAThesisProject
{
    public partial class MainController
    {
        /// <summary>
        /// loads in the proper metroGridView content depends on the mode of the service
        /// </summary>
        private void loadAppropiateRequestGridView()
        {
            if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANActive)
            {
                mgrid.DataSource = requestService.createDataTableNormalRequests();
                mgrid.Columns[3].Width = 200;   //name column
                mgrid.Columns[6].Width = 70;   //amount column
                infoLabel.Text = "Kéréskezelés\nJelenlegi kérések";
            }
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANCalledOff)
            {
                mgrid.DataSource = requestService.createDataTableCalledOffRequests();
                mgrid.Columns[3].Width = 200;   //name column
                infoLabel.Text = "Kéréskezelés\nVisszavont kérések";
            }
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANDeleted)
            {
                mgrid.DataSource = requestService.createDataTableDeletedRequests();
                mgrid.Columns[3].Width = 200;   //name column
                infoLabel.Text = "Kéréskezelés\nTörölt kérések";
            }
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANGivenOut)
            {
                mgrid.DataSource = requestService.createDataTableGivenOutRequests();
                mgrid.Columns[3].Width = 200;   //name column
                infoLabel.Text = "Kéréskezelés\nTeljesített kérések";
            }
        }
        /// <summary>
        /// decide, which command line view is actually needed depend on the mode if the service
        /// </summary>
        private void loadAppropiateRequestCommandLineView()
        {
            panelOfCommLine.Visible = true;
            if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANActive)
                loadInTheActiveRequestCommandView();
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANCalledOff)
                loadInTheACalledOffRequestCommandView();
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANDeleted)
                loadInTheDeletedRequestConnandView();
            else if (actServiceForSubEvents == FormMainServiceMode.REQUESTSMANGivenOut)
                loadInTheGivenOutRequestCommandView();
        }
        /// <summary>
        /// adjust the commandline view when it is in active request manage mode
        /// </summary>
        private void loadInTheActiveRequestCommandView()
        {
            btn1.Enabled = true;
            btn1.Visible = true;
            btn1.Text = "Módosítás";
            ((MetroFramework.Controls.MetroTile)btn1).Style = MetroFramework.MetroColorStyle.Lime;
            btn2.Enabled = true;
            btn2.Visible = true;
            btn2.Text = "Kiadás";
            ((MetroFramework.Controls.MetroTile)btn2).Style = MetroFramework.MetroColorStyle.Lime;
            btn3.Enabled = true;
            btn3.Visible = true;
            btn3.Text = "Törlés";
            ((MetroFramework.Controls.MetroTile)btn3).Style = MetroFramework.MetroColorStyle.Red;
            btn4.Enabled = true;
            btn4.Visible = true;
            btn4.Text = "Visszavont kérések";
            ((MetroFramework.Controls.MetroTile)btn4).Style = MetroFramework.MetroColorStyle.Silver;
            btn5.Visible = false;
            btn6.Visible = false;
        }

        private void loadInTheACalledOffRequestCommandView()
        {
            btn1.Enabled = false;
            btn1.Text = "Módosítás";
            ((MetroFramework.Controls.MetroTile)btn1).Style = MetroFramework.MetroColorStyle.Lime;
            btn2.Enabled = false;
            btn2.Text = "Kiadás";
            ((MetroFramework.Controls.MetroTile)btn2).Style = MetroFramework.MetroColorStyle.Lime;
            btn3.Enabled = false;
            btn3.Text = "Törlés";
            ((MetroFramework.Controls.MetroTile)btn3).Style = MetroFramework.MetroColorStyle.Red;
            btn4.Enabled = true;
            btn4.Text = "Törölt kérések";
            ((MetroFramework.Controls.MetroTile)btn4).Style = MetroFramework.MetroColorStyle.Silver;

        }

        private void loadInTheDeletedRequestConnandView()
        {
            btn1.Enabled = false;
            btn1.Text = "Módosítás";
            ((MetroFramework.Controls.MetroTile)btn1).Style = MetroFramework.MetroColorStyle.Lime;
            btn2.Enabled = false;
            btn2.Text = "Kiadás";
            ((MetroFramework.Controls.MetroTile)btn2).Style = MetroFramework.MetroColorStyle.Lime;
            btn3.Enabled = true;
            btn3.Text = "Visszaállítás";
            ((MetroFramework.Controls.MetroTile)btn3).Style = MetroFramework.MetroColorStyle.Purple;
            btn4.Enabled = true;
            btn4.Text = "Teljesített kérések";
            ((MetroFramework.Controls.MetroTile)btn4).Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void loadInTheGivenOutRequestCommandView()
        {
            btn1.Enabled = false;
            btn1.Text = "Módosítás";
            ((MetroFramework.Controls.MetroTile)btn1).Style = MetroFramework.MetroColorStyle.Lime;
            btn2.Enabled = true;
            btn2.Text = "Visszavétel";
            ((MetroFramework.Controls.MetroTile)btn2).Style = MetroFramework.MetroColorStyle.Teal;
            btn3.Enabled = false;
            btn3.Text = "Visszaállítás";
            ((MetroFramework.Controls.MetroTile)btn3).Style = MetroFramework.MetroColorStyle.Purple;
            btn4.Enabled = true;
            btn4.Text = "Aktív kérések";
            ((MetroFramework.Controls.MetroTile)btn4).Style = MetroFramework.MetroColorStyle.Silver;
        }





    }
}
