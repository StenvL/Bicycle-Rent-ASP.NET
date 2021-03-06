﻿/*flexberryautogenerated="false"*/

namespace Bicycle_rent
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using System.Linq;
    using ICSSoft.STORMNET.Web.Tools.WGEFeatures;

    public partial class StartTransportE : BaseEditForm<TransportSession>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public StartTransportE()
            : base(TransportSession.Views.StartTransportE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Transport/StartTransportE.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            ctrlDriver.MasterViewName = Employee.Views.EmployeeL.Name;

            var ds = DataServiceProvider.DataService;

            // Нельзя перевозить краденные велосипеды:( .
            var queryBicycle = ds.Query<Bicycle>(Bicycle.Views.BicycleL.Name)
                .Where(item => item.IsFree && !item.State.Equals(BicycleState.Украден));
            ctrlTransportSessionString.AddLookUpSettings(
                Information.ExtractPropertyPath<TransportSessionString>(item => item.Bicycle),
                new LookUpSetting
                {
                    LimitFunction = LinqToLcs.GetLcs(queryBicycle.Expression, Bicycle.Views.BicycleL).LimitFunction
                }
            );

            // Перевозить может только водитель.
            var queryEmp = ds.Query<Employee>(Employee.Views.EmployeeL.Name)
                .Where(item => item.Position.Equals(Positions.Водитель));
            ctrlDriver.LimitFunction = LinqToLcs.GetLcs(queryEmp.Expression, Employee.Views.EmployeeL).LimitFunction;

        }

        /// <summary>
        /// Здесь лучше всего писать бизнес-логику, оперируя только объектом данных.
        /// </summary>
        protected override void PreApplyToControls()
        { 
        }

        /// <summary>
        /// Здесь лучше всего изменять свойства контролов на странице,
        /// которые не обрабатываются WebBinder.
        /// </summary>
        protected override void PostApplyToControls()
        {
            Page.Validate();
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }

        /// <summary>
        /// Валидация объекта для сохранения.
        /// </summary>
        /// <returns>true - продолжать сохранение, иначе - прекратить.</returns>
        protected override bool PreSaveObject()
        {
            return base.PreSaveObject();
        }

        /// <summary>
        /// Нетривиальная логика сохранения объекта.
        /// </summary>
        /// <returns>Объект данных, который сохранился.</returns>
        protected override DataObject SaveObject()
        {
            return base.SaveObject();
        }

        protected override void SaveBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (this.DataObject.TransportSessionString.GetAllObjects().Length != 0)
            {
                base.SaveBtn_Click(sender, e);
                TransportSession.UpdateBicyclesAfterSessionOpen(this.DataObject.TransportSessionString.GetAllObjects());
            }
            else
            {
                WebMessageBox.Show("Не выбран ни один велосипед");
            }
        }
    }
}