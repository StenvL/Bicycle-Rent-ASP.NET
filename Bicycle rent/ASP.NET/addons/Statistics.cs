using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bicycle_rent
{
    public class Statistics
    {
        /// <summary>
        /// Возвращает среднее время проката велосипеда.
        /// </summary>
        public static DateTime? GetAverageRentTime(Bicycle bicycle)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var sessions = ds.Query<RentSession>(RentSession.Views.RentSessionE.Name)
                .Where(item => item.Bicycle == bicycle);

            if (sessions.Count() != 0)
            {
                var counter = DateTime.MinValue;
                foreach (var session in sessions)
                {
                    counter += (System.DateTime.Parse(session.FinishDate.ToString()) - session.StartDate);
                }

                return new DateTime((counter.Ticks / sessions.Count()));
            }
            else return null;
        }

        /// <summary>
        /// Возвращает количество взятий в прокат велосипедов выбранного типа.
        /// </summary>
        public static int RentsCount(BicycleType type)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            return ds.Query<RentSession>(RentSession.Views.RentSessionE.Name)
                .Count(item => item.Bicycle.Type.Equals(type));
        }
    }
}