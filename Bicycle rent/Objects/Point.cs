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

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Point.
    /// </summary>
    // *** Start programmer edit section *** (Point CustomAttributes)

    // *** End programmer edit section *** (Point CustomAttributes)
    [AutoAltered()]
    [Caption("Точка проката")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("PointE", new string[] {
            "Address as \'Адрес\'"})]
    [View("PointL", new string[] {
            "Address as \'Адрес\'"})]
    public class Point : ICSSoft.STORMNET.DataObject
    {
        
        private string fAddress;
        
        // *** Start programmer edit section *** (Point CustomMembers)

        // *** End programmer edit section *** (Point CustomMembers)

        
        /// <summary>
        /// Address.
        /// </summary>
        // *** Start programmer edit section *** (Point.Address CustomAttributes)

        // *** End programmer edit section *** (Point.Address CustomAttributes)
        [StrLen(150)]
        [NotNull()]
        public virtual string Address
        {
            get
            {
                // *** Start programmer edit section *** (Point.Address Get start)

                // *** End programmer edit section *** (Point.Address Get start)
                string result = this.fAddress;
                // *** Start programmer edit section *** (Point.Address Get end)

                // *** End programmer edit section *** (Point.Address Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Point.Address Set start)

                // *** End programmer edit section *** (Point.Address Set start)
                this.fAddress = value;
                // *** Start programmer edit section *** (Point.Address Set end)

                // *** End programmer edit section *** (Point.Address Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "PointE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PointE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PointE", typeof(Bicycle_rent.Point));
                }
            }
            
            /// <summary>
            /// "PointL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PointL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PointL", typeof(Bicycle_rent.Point));
                }
            }
        }
    }
}
