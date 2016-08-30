﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicycle_rent
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET.Business;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Rent session.
    /// </summary>
    // *** Start programmer edit section *** (RentSession CustomAttributes)

    // *** End programmer edit section *** (RentSession CustomAttributes)
    [AutoAltered()]
    [Caption("Сессия проката")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("GiveBicycleE", new string[] {
            "Bicycle as \'Велосипед\'",
            "Client as \'Клиент\'",
            "EmployeeGive as \'Выдал\'"})]
    [MasterViewDefineAttribute("GiveBicycleE", "Bicycle", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Number")]
    [MasterViewDefineAttribute("GiveBicycleE", "Client", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("GiveBicycleE", "EmployeeGive", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [View("RentSessionE", new string[] {
            "StartDate as \'Дата выдачи\'",
            "FinishDate as \'Дата сдачи\'",
            "Cost as \'Стоимость\'",
            "Fine as \'Штраф\'",
            "SessionState as \'Статус\'",
            "Client as \'Клиент\'",
            "StartPoint as \'Точка выдачи\'",
            "EndPoint as \'Точка сдачи\'",
            "EmployeeGive as \'Выдал\'",
            "Bicycle as \'Велосипед\'",
            "EmployeeTake as \'Принял\'",
            "FinalBicycleState as \'Состояние велосипеда\'",
            "Bicycle.Type"}, Hidden=new string[] {
            "Bicycle.Type"})]
    [MasterViewDefineAttribute("RentSessionE", "Client", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("RentSessionE", "StartPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [MasterViewDefineAttribute("RentSessionE", "EndPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [MasterViewDefineAttribute("RentSessionE", "EmployeeGive", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("RentSessionE", "Bicycle", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Number")]
    [MasterViewDefineAttribute("RentSessionE", "EmployeeTake", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [View("RentSessionL", new string[] {
            "Bicycle.Number as \'Велосипед\'",
            "EmployeeGive.FullName as \'Выдал\'",
            "StartPoint.Address as \'Точка выдачи\'",
            "Client.DocData as \'Документ\'",
            "SessionState as \'Статус\'",
            "StartDate as \'Дата выдачи\'",
            "FinishDate as \'Дата сдачи\'",
            "EmployeeTake.FullName as \'Принял\'",
            "EndPoint.Address as \'Точка сдачи\'",
            "Cost as \'Стоимость\'",
            "Fine as \'Штраф\'",
            "FinalBicycleState as \'Состояние велосипеда\'"})]
    [View("TakeBicycleE", new string[] {
            "EmployeeTake as \'Принял\'",
            "EndPoint as \'Точка сдачи\'",
            "Fine as \'Штраф\'",
            "FinalBicycleState as \'Состояние велосипеда\'",
            "StartDate",
            "FinishDate",
            "Cost",
            "Client",
            "StartPoint",
            "EmployeeGive",
            "Bicycle",
            "Bicycle.CostPerMinute",
            "SessionState"}, Hidden=new string[] {
            "StartDate",
            "FinishDate",
            "Cost",
            "Client",
            "StartPoint",
            "EmployeeGive",
            "Bicycle",
            "Bicycle.CostPerMinute",
            "SessionState"})]
    [MasterViewDefineAttribute("TakeBicycleE", "EmployeeTake", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("TakeBicycleE", "EndPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [View("TakeBicycleL", new string[] {
            "Bicycle.Number as \'Велосипед\'",
            "Client.DocData as \'Клиент\'",
            "StartPoint.Address as \'Точка выдачи\'",
            "StartDate as \'Дата выдачи\'",
            "SessionState as \'Статус\'"})]
    public class RentSession : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fStartDate = System.DateTime.Now;
        
        private DateTime? fFinishDate;
        
        private double fCost;
        
        private double fFine = 0D;
        
        private Bicycle_rent.SessionState fSessionState;
        
        private Bicycle_rent.BicycleState fFinalBicycleState;
        
        private Bicycle_rent.Bicycle fBicycle;
        
        private Bicycle_rent.Employee fEmployeeTake;
        
        private Bicycle_rent.Client fClient;
        
        private Bicycle_rent.Point fEndPoint;
        
        private Bicycle_rent.Point fStartPoint;
        
        private Bicycle_rent.Employee fEmployeeGive;
        
        // *** Start programmer edit section *** (RentSession CustomMembers)
        /// <summary>
        /// Обновляет состояние велосипедов после открытия сессии.
        /// </summary>
        public static void UpdateBicycleAfterSessionOpen(RentSession session)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;

            var bicycle = new Bicycle();
            bicycle.SetExistObjectPrimaryKey(session.Bicycle.__PrimaryKey);
            ds.LoadObject(bicycle);

            bicycle.CurPoint = null;
            bicycle.IsFree = false;
            ds.UpdateObject(bicycle);
        }

        /// <summary>
        /// Закрывает сессию.
        /// </summary>
        public static void CloseSession(RentSession session)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;

            if (session.FinalBicycleState.Equals(BicycleState.Украден))
            {
                session.EmployeeTake = null;
                session.EndPoint = null;
                session.FinishDate = null;
                session.Cost = 0;
                session.SessionState = SessionState.Закрыта;
            }
            else
            {
                session.FinishDate = DateTime.Now;
                session.Cost = System.Math.Round((session.FinishDate.Value - session.StartDate)
                    .TotalMinutes) * session.Bicycle.CostPerMinute;
                session.SessionState = SessionState.Закрыта;
            }

            var bicycle = new Bicycle();
            bicycle.SetExistObjectPrimaryKey(session.Bicycle.__PrimaryKey);
            ds.LoadObject(bicycle);
            bicycle.State = session.FinalBicycleState;
            bicycle.CurPoint = session.EndPoint;
            bicycle.IsFree = true;

            var updObjs = new DataObject[] { session, bicycle };
            ds.UpdateObjects(ref updObjs);
        }

        // *** End programmer edit section *** (RentSession CustomMembers)

        
        /// <summary>
        /// StartDate.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.StartDate CustomAttributes)

        // *** End programmer edit section *** (RentSession.StartDate CustomAttributes)
        [NotNull()]
        public virtual System.DateTime StartDate
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.StartDate Get start)

                // *** End programmer edit section *** (RentSession.StartDate Get start)
                System.DateTime result = this.fStartDate;
                // *** Start programmer edit section *** (RentSession.StartDate Get end)

                // *** End programmer edit section *** (RentSession.StartDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.StartDate Set start)

                // *** End programmer edit section *** (RentSession.StartDate Set start)
                this.fStartDate = value;
                // *** Start programmer edit section *** (RentSession.StartDate Set end)

                // *** End programmer edit section *** (RentSession.StartDate Set end)
            }
        }
        
        /// <summary>
        /// FinishDate.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.FinishDate CustomAttributes)

        // *** End programmer edit section *** (RentSession.FinishDate CustomAttributes)
        public virtual DateTime? FinishDate
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.FinishDate Get start)

                // *** End programmer edit section *** (RentSession.FinishDate Get start)
                DateTime? result = this.fFinishDate;
                // *** Start programmer edit section *** (RentSession.FinishDate Get end)

                // *** End programmer edit section *** (RentSession.FinishDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.FinishDate Set start)

                // *** End programmer edit section *** (RentSession.FinishDate Set start)
                this.fFinishDate = value;
                // *** Start programmer edit section *** (RentSession.FinishDate Set end)

                // *** End programmer edit section *** (RentSession.FinishDate Set end)
            }
        }
        
        /// <summary>
        /// Cost.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.Cost CustomAttributes)

        // *** End programmer edit section *** (RentSession.Cost CustomAttributes)
        public virtual double Cost
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.Cost Get start)

                // *** End programmer edit section *** (RentSession.Cost Get start)
                double result = this.fCost;
                // *** Start programmer edit section *** (RentSession.Cost Get end)

                // *** End programmer edit section *** (RentSession.Cost Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.Cost Set start)

                // *** End programmer edit section *** (RentSession.Cost Set start)
                this.fCost = value;
                // *** Start programmer edit section *** (RentSession.Cost Set end)

                // *** End programmer edit section *** (RentSession.Cost Set end)
            }
        }
        
        /// <summary>
        /// Fine.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.Fine CustomAttributes)

        // *** End programmer edit section *** (RentSession.Fine CustomAttributes)
        public virtual double Fine
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.Fine Get start)

                // *** End programmer edit section *** (RentSession.Fine Get start)
                double result = this.fFine;
                // *** Start programmer edit section *** (RentSession.Fine Get end)

                // *** End programmer edit section *** (RentSession.Fine Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.Fine Set start)

                // *** End programmer edit section *** (RentSession.Fine Set start)
                this.fFine = value;
                // *** Start programmer edit section *** (RentSession.Fine Set end)

                // *** End programmer edit section *** (RentSession.Fine Set end)
            }
        }
        
        /// <summary>
        /// SessionState.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.SessionState CustomAttributes)

        // *** End programmer edit section *** (RentSession.SessionState CustomAttributes)
        public virtual Bicycle_rent.SessionState SessionState
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.SessionState Get start)

                // *** End programmer edit section *** (RentSession.SessionState Get start)
                Bicycle_rent.SessionState result = this.fSessionState;
                // *** Start programmer edit section *** (RentSession.SessionState Get end)

                // *** End programmer edit section *** (RentSession.SessionState Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.SessionState Set start)

                // *** End programmer edit section *** (RentSession.SessionState Set start)
                this.fSessionState = value;
                // *** Start programmer edit section *** (RentSession.SessionState Set end)

                // *** End programmer edit section *** (RentSession.SessionState Set end)
            }
        }
        
        /// <summary>
        /// FinalBicycleState.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.FinalBicycleState CustomAttributes)

        // *** End programmer edit section *** (RentSession.FinalBicycleState CustomAttributes)
        public virtual Bicycle_rent.BicycleState FinalBicycleState
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.FinalBicycleState Get start)

                // *** End programmer edit section *** (RentSession.FinalBicycleState Get start)
                Bicycle_rent.BicycleState result = this.fFinalBicycleState;
                // *** Start programmer edit section *** (RentSession.FinalBicycleState Get end)

                // *** End programmer edit section *** (RentSession.FinalBicycleState Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.FinalBicycleState Set start)

                // *** End programmer edit section *** (RentSession.FinalBicycleState Set start)
                this.fFinalBicycleState = value;
                // *** Start programmer edit section *** (RentSession.FinalBicycleState Set end)

                // *** End programmer edit section *** (RentSession.FinalBicycleState Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.Bicycle CustomAttributes)

        // *** End programmer edit section *** (RentSession.Bicycle CustomAttributes)
        [PropertyStorage(new string[] {
                "Bicycle"})]
        [NotNull()]
        public virtual Bicycle_rent.Bicycle Bicycle
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.Bicycle Get start)

                // *** End programmer edit section *** (RentSession.Bicycle Get start)
                Bicycle_rent.Bicycle result = this.fBicycle;
                // *** Start programmer edit section *** (RentSession.Bicycle Get end)

                // *** End programmer edit section *** (RentSession.Bicycle Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.Bicycle Set start)

                // *** End programmer edit section *** (RentSession.Bicycle Set start)
                this.fBicycle = value;
                // *** Start programmer edit section *** (RentSession.Bicycle Set end)

                // *** End programmer edit section *** (RentSession.Bicycle Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.EmployeeTake CustomAttributes)

        // *** End programmer edit section *** (RentSession.EmployeeTake CustomAttributes)
        [PropertyStorage(new string[] {
                "EmployeeTake"})]
        public virtual Bicycle_rent.Employee EmployeeTake
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.EmployeeTake Get start)

                // *** End programmer edit section *** (RentSession.EmployeeTake Get start)
                Bicycle_rent.Employee result = this.fEmployeeTake;
                // *** Start programmer edit section *** (RentSession.EmployeeTake Get end)

                // *** End programmer edit section *** (RentSession.EmployeeTake Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.EmployeeTake Set start)

                // *** End programmer edit section *** (RentSession.EmployeeTake Set start)
                this.fEmployeeTake = value;
                // *** Start programmer edit section *** (RentSession.EmployeeTake Set end)

                // *** End programmer edit section *** (RentSession.EmployeeTake Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.Client CustomAttributes)

        // *** End programmer edit section *** (RentSession.Client CustomAttributes)
        [PropertyStorage(new string[] {
                "Client"})]
        [NotNull()]
        public virtual Bicycle_rent.Client Client
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.Client Get start)

                // *** End programmer edit section *** (RentSession.Client Get start)
                Bicycle_rent.Client result = this.fClient;
                // *** Start programmer edit section *** (RentSession.Client Get end)

                // *** End programmer edit section *** (RentSession.Client Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.Client Set start)

                // *** End programmer edit section *** (RentSession.Client Set start)
                this.fClient = value;
                // *** Start programmer edit section *** (RentSession.Client Set end)

                // *** End programmer edit section *** (RentSession.Client Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.EndPoint CustomAttributes)

        // *** End programmer edit section *** (RentSession.EndPoint CustomAttributes)
        [PropertyStorage(new string[] {
                "EndPoint"})]
        public virtual Bicycle_rent.Point EndPoint
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.EndPoint Get start)

                // *** End programmer edit section *** (RentSession.EndPoint Get start)
                Bicycle_rent.Point result = this.fEndPoint;
                // *** Start programmer edit section *** (RentSession.EndPoint Get end)

                // *** End programmer edit section *** (RentSession.EndPoint Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.EndPoint Set start)

                // *** End programmer edit section *** (RentSession.EndPoint Set start)
                this.fEndPoint = value;
                // *** Start programmer edit section *** (RentSession.EndPoint Set end)

                // *** End programmer edit section *** (RentSession.EndPoint Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.StartPoint CustomAttributes)

        // *** End programmer edit section *** (RentSession.StartPoint CustomAttributes)
        [PropertyStorage(new string[] {
                "StartPoint"})]
        [NotNull()]
        public virtual Bicycle_rent.Point StartPoint
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.StartPoint Get start)

                // *** End programmer edit section *** (RentSession.StartPoint Get start)
                Bicycle_rent.Point result = this.fStartPoint;
                // *** Start programmer edit section *** (RentSession.StartPoint Get end)

                // *** End programmer edit section *** (RentSession.StartPoint Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.StartPoint Set start)

                // *** End programmer edit section *** (RentSession.StartPoint Set start)
                this.fStartPoint = value;
                // *** Start programmer edit section *** (RentSession.StartPoint Set end)

                // *** End programmer edit section *** (RentSession.StartPoint Set end)
            }
        }
        
        /// <summary>
        /// Rent session.
        /// </summary>
        // *** Start programmer edit section *** (RentSession.EmployeeGive CustomAttributes)

        // *** End programmer edit section *** (RentSession.EmployeeGive CustomAttributes)
        [PropertyStorage(new string[] {
                "EmployeeGive"})]
        [NotNull()]
        public virtual Bicycle_rent.Employee EmployeeGive
        {
            get
            {
                // *** Start programmer edit section *** (RentSession.EmployeeGive Get start)

                // *** End programmer edit section *** (RentSession.EmployeeGive Get start)
                Bicycle_rent.Employee result = this.fEmployeeGive;
                // *** Start programmer edit section *** (RentSession.EmployeeGive Get end)

                // *** End programmer edit section *** (RentSession.EmployeeGive Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (RentSession.EmployeeGive Set start)

                // *** End programmer edit section *** (RentSession.EmployeeGive Set start)
                this.fEmployeeGive = value;
                // *** Start programmer edit section *** (RentSession.EmployeeGive Set end)

                // *** End programmer edit section *** (RentSession.EmployeeGive Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "GiveBicycleE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View GiveBicycleE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("GiveBicycleE", typeof(Bicycle_rent.RentSession));
                }
            }
            
            /// <summary>
            /// "RentSessionE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View RentSessionE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("RentSessionE", typeof(Bicycle_rent.RentSession));
                }
            }
            
            /// <summary>
            /// "RentSessionL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View RentSessionL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("RentSessionL", typeof(Bicycle_rent.RentSession));
                }
            }
            
            /// <summary>
            /// "TakeBicycleE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TakeBicycleE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TakeBicycleE", typeof(Bicycle_rent.RentSession));
                }
            }
            
            /// <summary>
            /// "TakeBicycleL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TakeBicycleL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TakeBicycleL", typeof(Bicycle_rent.RentSession));
                }
            }
        }
    }
}
