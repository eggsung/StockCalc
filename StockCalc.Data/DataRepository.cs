using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data
{
    public class DataRepository
    {
        #region StockData

        private static StockData _stock;

        public static StockData Stock
        {
            get
            {
                if (_stock == null)
                    _stock = new StockData();

                return _stock;
            }
        }

        #endregion

        #region PriceData

        private static PriceData _price;

        public static PriceData Price
        {
            get
            {
                if (_price == null)
                    _price = new PriceData();

                return _price;
            }
        }

        #endregion

        #region ResultData

        private static ResultData _result;

        public static ResultData Result
        {
            get
            {
                if (_result == null)
                    _result = new ResultData();

                return _result;
            }
        }

        #endregion

        #region TradeData

        private static TradeData _trade;

        public static TradeData Trade
        {
            get
            {
                if (_trade == null)
                    _trade = new TradeData();

                return _trade;
            }
        }

        #endregion
    }
}
