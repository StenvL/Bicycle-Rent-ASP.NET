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
    using ICSSoft.STORMNET.Business;


    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Transport session.
    /// </summary>
    // *** Start programmer edit section *** (TransportSession CustomAttributes)

    // *** End programmer edit section *** (TransportSession CustomAttributes)
    [AutoAltered()]
    [Caption("Сессия перевозки")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("FinishTransportE", new string[] {
            "EndPoint as \'Точка финиша\'",
            "StartDate",
            "FinishDate",
            "State",
            "Car",
            "StartPoint",
            "Driver"}, Hidden=new string[] {
            "StartDate",
            "FinishDate",
            "State",
            "Car",
            "StartPoint",
            "Driver"})]
    [AssociatedDetailViewAttribute("FinishTransportE", "TransportSessionString", "TransportSessionStringE", true, "", "Велосипеды", false, new string[] {
            ""})]
    [MasterViewDefineAttribute("FinishTransportE", "EndPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [View("FinishTransportL", new string[] {
            "Car.Number as \'Автомобиль\'",
            "Driver.FullName as \'Водитель\'",
            "StartDate as \'Время выезда\'",
            "StartPoint.Address as \'Точка старта\'",
            "State as \'Статус\'"})]
    [AssociatedDetailViewAttribute("FinishTransportL", "TransportSessionString", "TransportSessionStringL", true, "", "Велосипеды", true, new string[] {
            ""})]
    [View("StartTransportE", new string[] {
            "Driver as \'Водитель\'",
            "Car as \'Автомобиль\'",
            "StartPoint as \'Точка старта\'"})]
    [AssociatedDetailViewAttribute("StartTransportE", "TransportSessionString", "TransportSessionStringE", true, "", "Велосипеды", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("StartTransportE", "Driver", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("StartTransportE", "Car", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Number")]
    [MasterViewDefineAttribute("StartTransportE", "StartPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [View("TransportSessionE", new string[] {
            "Driver as \'Водитель\'",
            "Car as \'Автомобиль\'",
            "StartPoint as \'Начальный пункт\'",
            "StartDate as \'Время выезда\'",
            "EndPoint as \'Конечный пункт\'",
            "FinishDate as \'Время приезда\'"})]
    [AssociatedDetailViewAttribute("TransportSessionE", "TransportSessionString", "TransportSessionStringE", true, "", "Велосипеды", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("TransportSessionE", "Driver", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "FullName")]
    [MasterViewDefineAttribute("TransportSessionE", "Car", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Number")]
    [MasterViewDefineAttribute("TransportSessionE", "StartPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [MasterViewDefineAttribute("TransportSessionE", "EndPoint", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Address")]
    [View("TransportSessionL", new string[] {
            "Driver.FullName as \'Водитель\'",
            "Car.Number as \'Автомобиль\'",
            "StartPoint.Address as \'Начальный пункт\'",
            "StartDate as \'Время выезда\'",
            "EndPoint.Address as \'Конечный пункт\'",
            "FinishDate as \'Время приезда\'",
            "State as \'Статус\'"})]
    [AssociatedDetailViewAttribute("TransportSessionL", "TransportSessionString", "TransportSessionStringL", true, "", "Велосипеды", true, new string[] {
            ""})]
    public class TransportSession : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fStartDate = System.DateTime.Now;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fFinishDate;
        
        private Bicycle_rent.SessionState fState;
        
        private Bicycle_rent.Car fCar;
        
        private Bicycle_rent.Point fStartPoint;
        
        private Bicycle_rent.Employee fDriver;
        
        private Bicycle_rent.Point fEndPoint;
        
        private Bicycle_rent.DetailArrayOfTransportSessionString fTransportSessionString;
        
        // *** Start programmer edit section *** (TransportSession CustomMembers)

        // *** End programmer edit section *** (TransportSession CustomMembers)

        
        /// <summary>
        /// StartDate.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.StartDate CustomAttributes)

        // *** End programmer edit section *** (TransportSession.StartDate CustomAttributes)
        [NotNull()]
        public virtual System.DateTime StartDate
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.StartDate Get start)

                // *** End programmer edit section *** (TransportSession.StartDate Get start)
                System.DateTime result = this.fStartDate;
                // *** Start programmer edit section *** (TransportSession.StartDate Get end)

                // *** End programmer edit section *** (TransportSession.StartDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.StartDate Set start)

                // *** End programmer edit section *** (TransportSession.StartDate Set start)
                this.fStartDate = value;
                // *** Start programmer edit section *** (TransportSession.StartDate Set end)

                // *** End programmer edit section *** (TransportSession.StartDate Set end)
            }
        }
        
        /// <summary>
        /// FinishDate.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.FinishDate CustomAttributes)

        // *** End programmer edit section *** (TransportSession.FinishDate CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime FinishDate
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.FinishDate Get start)

                // *** End programmer edit section *** (TransportSession.FinishDate Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fFinishDate;
                // *** Start programmer edit section *** (TransportSession.FinishDate Get end)

                // *** End programmer edit section *** (TransportSession.FinishDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.FinishDate Set start)

                // *** End programmer edit section *** (TransportSession.FinishDate Set start)
                this.fFinishDate = value;
                // *** Start programmer edit section *** (TransportSession.FinishDate Set end)

                // *** End programmer edit section *** (TransportSession.FinishDate Set end)
            }
        }
        
        /// <summary>
        /// State.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.State CustomAttributes)

        // *** End programmer edit section *** (TransportSession.State CustomAttributes)
        [NotNull()]
        public virtual Bicycle_rent.SessionState State
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.State Get start)

                // *** End programmer edit section *** (TransportSession.State Get start)
                Bicycle_rent.SessionState result = this.fState;
                // *** Start programmer edit section *** (TransportSession.State Get end)

                // *** End programmer edit section *** (TransportSession.State Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.State Set start)

                // *** End programmer edit section *** (TransportSession.State Set start)
                this.fState = value;
                // *** Start programmer edit section *** (TransportSession.State Set end)

                // *** End programmer edit section *** (TransportSession.State Set end)
            }
        }
        
        /// <summary>
        /// Transport session.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.Car CustomAttributes)

        // *** End programmer edit section *** (TransportSession.Car CustomAttributes)
        [PropertyStorage(new string[] {
                "Car"})]
        [NotNull()]
        public virtual Bicycle_rent.Car Car
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.Car Get start)

                // *** End programmer edit section *** (TransportSession.Car Get start)
                Bicycle_rent.Car result = this.fCar;
                // *** Start programmer edit section *** (TransportSession.Car Get end)

                // *** End programmer edit section *** (TransportSession.Car Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.Car Set start)

                // *** End programmer edit section *** (TransportSession.Car Set start)
                this.fCar = value;
                // *** Start programmer edit section *** (TransportSession.Car Set end)

                // *** End programmer edit section *** (TransportSession.Car Set end)
            }
        }
        
        /// <summary>
        /// Transport session.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.StartPoint CustomAttributes)

        // *** End programmer edit section *** (TransportSession.StartPoint CustomAttributes)
        [PropertyStorage(new string[] {
                "StartPoint"})]
        [NotNull()]
        public virtual Bicycle_rent.Point StartPoint
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.StartPoint Get start)

                // *** End programmer edit section *** (TransportSession.StartPoint Get start)
                Bicycle_rent.Point result = this.fStartPoint;
                // *** Start programmer edit section *** (TransportSession.StartPoint Get end)

                // *** End programmer edit section *** (TransportSession.StartPoint Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.StartPoint Set start)

                // *** End programmer edit section *** (TransportSession.StartPoint Set start)
                this.fStartPoint = value;
                // *** Start programmer edit section *** (TransportSession.StartPoint Set end)

                // *** End programmer edit section *** (TransportSession.StartPoint Set end)
            }
        }
        
        /// <summary>
        /// Transport session.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.Driver CustomAttributes)

        // *** End programmer edit section *** (TransportSession.Driver CustomAttributes)
        [PropertyStorage(new string[] {
                "Driver"})]
        [NotNull()]
        public virtual Bicycle_rent.Employee Driver
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.Driver Get start)

                // *** End programmer edit section *** (TransportSession.Driver Get start)
                Bicycle_rent.Employee result = this.fDriver;
                // *** Start programmer edit section *** (TransportSession.Driver Get end)

                // *** End programmer edit section *** (TransportSession.Driver Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.Driver Set start)

                // *** End programmer edit section *** (TransportSession.Driver Set start)
                this.fDriver = value;
                // *** Start programmer edit section *** (TransportSession.Driver Set end)

                // *** End programmer edit section *** (TransportSession.Driver Set end)
            }
        }
        
        /// <summary>
        /// Transport session.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.EndPoint CustomAttributes)

        // *** End programmer edit section *** (TransportSession.EndPoint CustomAttributes)
        [PropertyStorage(new string[] {
                "EndPoint"})]
        public virtual Bicycle_rent.Point EndPoint
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.EndPoint Get start)

                // *** End programmer edit section *** (TransportSession.EndPoint Get start)
                Bicycle_rent.Point result = this.fEndPoint;
                // *** Start programmer edit section *** (TransportSession.EndPoint Get end)

                // *** End programmer edit section *** (TransportSession.EndPoint Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.EndPoint Set start)

                // *** End programmer edit section *** (TransportSession.EndPoint Set start)
                this.fEndPoint = value;
                // *** Start programmer edit section *** (TransportSession.EndPoint Set end)

                // *** End programmer edit section *** (TransportSession.EndPoint Set end)
            }
        }
        
        /// <summary>
        /// Transport session.
        /// </summary>
        // *** Start programmer edit section *** (TransportSession.TransportSessionString CustomAttributes)

        // *** End programmer edit section *** (TransportSession.TransportSessionString CustomAttributes)
        public virtual Bicycle_rent.DetailArrayOfTransportSessionString TransportSessionString
        {
            get
            {
                // *** Start programmer edit section *** (TransportSession.TransportSessionString Get start)

                // *** End programmer edit section *** (TransportSession.TransportSessionString Get start)
                if ((this.fTransportSessionString == null))
                {
                    this.fTransportSessionString = new Bicycle_rent.DetailArrayOfTransportSessionString(this);
                }
                Bicycle_rent.DetailArrayOfTransportSessionString result = this.fTransportSessionString;
                // *** Start programmer edit section *** (TransportSession.TransportSessionString Get end)

                // *** End programmer edit section *** (TransportSession.TransportSessionString Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TransportSession.TransportSessionString Set start)

                // *** End programmer edit section *** (TransportSession.TransportSessionString Set start)
                this.fTransportSessionString = value;
                // *** Start programmer edit section *** (TransportSession.TransportSessionString Set end)

                // *** End programmer edit section *** (TransportSession.TransportSessionString Set end)
            }
        }

        /// <summary>
        /// Обновляет состояние велосипедов после открытия сессии.
        /// </summary>
        public static void UpdateBicyclesAfterSessionOpen(DataObject[] details)
        {
            foreach (var d in details)
            {
                var ds = (SQLDataService)DataServiceProvider.DataService;
                var bicycle = new Bicycle();
                bicycle.SetExistObjectPrimaryKey(((TransportSessionString)d).Bicycle.__PrimaryKey);
                ds.LoadObject(bicycle);
                bicycle.CurPoint = null;
                bicycle.IsFree = false;
                ds.UpdateObject(bicycle);
            }
        }

        /// <summary>
        /// Закрывает сессию.
        /// </summary>
        public static void CloseSession(TransportSession session)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            session.FinishDate = ICSSoft.STORMNET.UserDataTypes.NullableDateTime.Now;
            session.State = SessionState.Закрыта;
            ds.UpdateObject(session);

            var details = session.TransportSessionString.GetAllObjects();
            foreach (var d in details)
            {
                var bicycle = new Bicycle();
                bicycle.SetExistObjectPrimaryKey(((TransportSessionString)d).Bicycle.__PrimaryKey);
                ds.LoadObject(bicycle);
                bicycle.CurPoint = session.EndPoint;
                bicycle.IsFree = true;
                ds.UpdateObject(bicycle);
            }
        }
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "FinishTransportE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FinishTransportE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FinishTransportE", typeof(Bicycle_rent.TransportSession));
                }
            }
            
            /// <summary>
            /// "FinishTransportL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FinishTransportL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FinishTransportL", typeof(Bicycle_rent.TransportSession));
                }
            }
            
            /// <summary>
            /// "StartTransportE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View StartTransportE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("StartTransportE", typeof(Bicycle_rent.TransportSession));
                }
            }
            
            /// <summary>
            /// "TransportSessionE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TransportSessionE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TransportSessionE", typeof(Bicycle_rent.TransportSession));
                }
            }
            
            /// <summary>
            /// "TransportSessionL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TransportSessionL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TransportSessionL", typeof(Bicycle_rent.TransportSession));
                }
            }
        }
    }
}
