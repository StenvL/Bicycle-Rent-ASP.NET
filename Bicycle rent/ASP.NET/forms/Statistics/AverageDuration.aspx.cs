﻿/*flexberryautogenerated="false"*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using System.Linq;
using ICSSoft.STORMNET.Web.AjaxControls;

namespace Bicycle_rent
{
    public partial class AverageDuration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlBicycle.MasterTypeName = typeof(Bicycle).AssemblyQualifiedName;
            ctrlBicycle.MasterViewName = Bicycle.Views.BicycleL.Name;
            ctrlBicycle.PropertyToShow = "Number";
        }

        protected void btnCalcResult_Click(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            if (ctrlBicycle.SelectedMasterPK != "")
            {
                var bicycle = new Bicycle();
                bicycle.SetExistObjectPrimaryKey(ctrlBicycle.SelectedMasterPK);
                ds.LoadObject(bicycle);

                var averageTime = Statistics.GetAverageRentTime(bicycle);
                lblResult.Text =
                    $"Средняя продолжительность проката: {averageTime.ToLongTimeString() }.";
            }
            else
            {
                WebMessageBox.Show("Выберите велосипед.");
            }
        }
    }
}
