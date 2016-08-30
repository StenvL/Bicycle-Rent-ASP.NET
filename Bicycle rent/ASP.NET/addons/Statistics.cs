using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
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
        public static DateTime GetAverageRentTime(Bicycle bicycle)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var sessions = ds.Query<RentSession>(RentSession.Views.RentSessionE.Name)
                .Where(item => item.Bicycle == bicycle && item.FinishDate != null).ToList();
            if (sessions.Count != 0)
            {
                return new DateTime(sessions.Sum(item => 
                    item.FinishDate.Value.Ticks - item.StartDate.Ticks) / sessions.Count);
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Возвращает количество взятий в прокат велосипедов выбранного типа.
        /// </summary>
        public static int GetRentsCount(BicycleType type)
        {
            var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(RentSession), RentSession.Views.RentSessionE);
            var ld = SQLWhereLanguageDef.LanguageDef;
            var func = ld.GetFunction(
                ld.funcEQ,
                new VariableDef(
                    ld.StringType,
                    Information.ExtractPropertyPath<RentSession>(item => item.Bicycle.Type)
                ),
                EnumCaption.GetCaptionFor(type)
            );
            lcs.LimitFunction = func;
            var ds = (SQLDataService)DataServiceProvider.DataService;
            return ds.LoadObjects(lcs).Length;

            //return ds.Query<RentSession>(RentSession.Views.RentSessionE.Name)
            //    .Count(item => item.Bicycle.Type.Equals(type));
        }

        /// <summary>
        /// Возвращает кортеж из количеств испорченных и украденных велосипедов за отрезок времени.
        /// </summary>
        public static Tuple<int, int> GetRuinedBicycles(DateTime dateFrom, DateTime dateUntil)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var sessions = ds.Query<RentSession>(RentSession.Views.RentSessionE.Name);

            int damagedBicycles = sessions.Count(item =>
                item.FinalBicycleState.Equals(BicycleState.Неисправен) &&
                item.StartDate >= dateFrom && 
                item.FinishDate.Value <= dateUntil
            );
            int stolenBicycles = sessions.Count(item => 
                item.FinalBicycleState.Equals(BicycleState.Украден) &&
                item.StartDate >= dateFrom &&
                item.FinishDate.Value <= dateUntil
            );

            return new Tuple<int, int>(damagedBicycles, stolenBicycles);
        }

        /// <summary>
        /// Возвращает прибыль на точке за отрезок времени.
        /// </summary>
        public static double GetPointProfit(DateTime dateFrom, DateTime dateUntil, Point point)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;

            var sessions = ds.Query<RentSession>(RentSession.Views.RentSessionE.Name)
                .Where(item => 
                    item.StartPoint == point && 
                    item.SessionState.Equals(SessionState.Закрыта) &&
                    item.StartDate >= dateFrom &&
                    item.FinishDate <= dateUntil).ToList();

            return sessions.Sum(item => item.Cost + item.Fine);
        }

        public static int TransportedBicyclesCount(DateTime dateFrom, DateTime dateUntil)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var sessions = ds.Query<TransportSession>(TransportSession.Views.TransportSessionL.Name)
                .Where(item =>
                    item.State.Equals(SessionState.Закрыта) &&
                    item.StartDate >= dateFrom &&
                    item.FinishDate <= dateUntil).ToList();
            return sessions.Sum(item => item.TransportSessionString.Count);
        }
    }
}