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
    /// Human.
    /// </summary>
    // *** Start programmer edit section *** (Human CustomAttributes)

    // *** End programmer edit section *** (Human CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("HumanE", new string[] {
            "FullName as \'Full name\'",
            "Gender as \'Gender\'"})]
    [View("HumanL", new string[] {
            "FullName as \'Full name\'",
            "Gender as \'Gender\'"})]
    public class Human : ICSSoft.STORMNET.DataObject
    {
        
        private string fFullName;
        
        private Bicycle_rent.Genders fGender;
        
        // *** Start programmer edit section *** (Human CustomMembers)

        // *** End programmer edit section *** (Human CustomMembers)

        
        /// <summary>
        /// FullName.
        /// </summary>
        // *** Start programmer edit section *** (Human.FullName CustomAttributes)

        // *** End programmer edit section *** (Human.FullName CustomAttributes)
        [StrLen(150)]
        [NotNull()]
        public virtual string FullName
        {
            get
            {
                // *** Start programmer edit section *** (Human.FullName Get start)

                // *** End programmer edit section *** (Human.FullName Get start)
                string result = this.fFullName;
                // *** Start programmer edit section *** (Human.FullName Get end)

                // *** End programmer edit section *** (Human.FullName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Human.FullName Set start)

                // *** End programmer edit section *** (Human.FullName Set start)
                this.fFullName = value;
                // *** Start programmer edit section *** (Human.FullName Set end)

                // *** End programmer edit section *** (Human.FullName Set end)
            }
        }
        
        /// <summary>
        /// Gender.
        /// </summary>
        // *** Start programmer edit section *** (Human.Gender CustomAttributes)

        // *** End programmer edit section *** (Human.Gender CustomAttributes)
        [NotNull()]
        public virtual Bicycle_rent.Genders Gender
        {
            get
            {
                // *** Start programmer edit section *** (Human.Gender Get start)

                // *** End programmer edit section *** (Human.Gender Get start)
                Bicycle_rent.Genders result = this.fGender;
                // *** Start programmer edit section *** (Human.Gender Get end)

                // *** End programmer edit section *** (Human.Gender Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Human.Gender Set start)

                // *** End programmer edit section *** (Human.Gender Set start)
                this.fGender = value;
                // *** Start programmer edit section *** (Human.Gender Set end)

                // *** End programmer edit section *** (Human.Gender Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "HumanE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View HumanE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("HumanE", typeof(Bicycle_rent.Human));
                }
            }
            
            /// <summary>
            /// "HumanL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View HumanL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("HumanL", typeof(Bicycle_rent.Human));
                }
            }
        }
    }
}
