﻿/*flexberryautogenerated="false"*/
namespace Bicycle_rent
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class TransportSessionL : BaseListForm<TransportSession>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public TransportSessionL() : base(TransportSession.Views.TransportSessionL)
        {
            EditPage = TransportSessionE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Transport/TransportSessionL.aspx"; }
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
