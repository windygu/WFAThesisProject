﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace WFAThesisProject
{
    public partial class MainController
    {
        /// <summary>
        /// defining the main buttons positioning, visibility, define the events of connected elements
        /// </summary>
        public void initializeMainWindowElementsByRightsOfUser(SetOfUserRights setOfUserRights)
        {
            actServiceForSubEvents = FormMainServiceMode.OPENING;
            mainWindow.VisibleChanged += (s, o) =>
            {
                loadInGridToShowProperContent();
            };
            adjustOpeningWindow();
            //Point startOfServicesTile = new Point(230, 55);
            Point mainButtonStartPoint = new Point(23, 150);
            if (setOfUserRights.getuR7_ProductsMan() != RightLevels.NONE)
            {
                Control contrTileProducts = mainWindow.Controls.Find("mTileProductMan", true).First();
                contrTileProducts.Location = mainButtonStartPoint;
                contrTileProducts.Visible = true;
                mainButtonStartPoint.Y += 60;
                initProductsServBasicEvents(setOfUserRights, contrTileProducts);
            }
            if (setOfUserRights.getuR8_ReqMan() != RightLevels.NONE)
            {
                Control contrTileRequests = mainWindow.Controls.Find("mTileRequestMan", true).First();
                contrTileRequests.Location = mainButtonStartPoint;
                contrTileRequests.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            if (setOfUserRights.getuR9_Order() != RightLevels.NONE)
            {
                Control contrTileOrdering = mainWindow.Controls.Find("mTileOrderMan", true).First();
                contrTileOrdering.Location = mainButtonStartPoint;
                contrTileOrdering.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            if (setOfUserRights.getuR10_Subcontr() != RightLevels.NONE)
            {
                Control contrTileSubcontr = mainWindow.Controls.Find("mTileSubcontrMan", true).First();
                contrTileSubcontr.Location = mainButtonStartPoint;
                contrTileSubcontr.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            if (setOfUserRights.getuR4_UserGlobal() != RightLevels.NONE)
            {
                Control contrTileUserGlobal = mainWindow.Controls.Find("mTileUsersMan", true).First();
                contrTileUserGlobal.Location = mainButtonStartPoint;
                contrTileUserGlobal.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            if (setOfUserRights.getuR5_RightMan() != RightLevels.NONE)
            {
                Control contrTileRightsMan = mainWindow.Controls.Find("mTileRightsMan", true).First();
                contrTileRightsMan.Location = mainButtonStartPoint;
                contrTileRightsMan.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            if (setOfUserRights.getuR6_AccidGlobal() != RightLevels.NONE)
            {
                Control contrTileAccidents = mainWindow.Controls.Find("mTileAccidentMan", true).First();
                contrTileAccidents.Location = mainButtonStartPoint;
                contrTileAccidents.Visible = true;
                mainButtonStartPoint.Y += 60;
            }
            Control contrExit = mainWindow.Controls.Find("mTileExit", true).First();
            contrExit.Location = mainButtonStartPoint;
            contrExit.Click += (s, o) =>
            {
                mainWindow.Close();
            };
            contrExit.Visible = true;
        }

        private void adjustOpeningWindow()
        {
            
        }
    }
}
