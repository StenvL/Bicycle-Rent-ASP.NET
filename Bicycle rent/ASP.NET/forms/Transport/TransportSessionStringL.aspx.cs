﻿/*flexberryautogenerated="false"*/
namespace Bicycle_rent
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class TransportSessionStringL : BaseListForm<TransportSessionString>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public TransportSessionStringL() : base(TransportSessionString.Views.TransportSessionStringL)
        {
            EditPage = TransportSessionStringE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Transport/TransportSessionStringL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
