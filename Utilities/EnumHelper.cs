using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Enumeration;

namespace EquityStudioAPI.Utilities
{
    
    public enum FinboxObject
    {
        price_to_sales_ltm,
        ev_to_ebitda_ltm,
        fcf_yield_ltm,
        roe,
        dividend
    };

    [Flags]
    public enum IexObject
    {
        balancesheet,
        cashflow,
        financials,
        company,
        dividends,
        earnings,
        estimates,
        income,
        stats,
        news,
        peers,
        recommendationtrends
    };

    [Flags]
    public enum QuandlObject
    {
        SP500_PSR_YEAR,
        SP500_DIV_GROWTH_YEAR,
        SP500_DIV_YIELD_YEAR,
        YIELD
    };

    [Flags]
    public enum AlphaVObject
    {
        SECTOR
    };
    public static partial class Helpers
    {
        

        public static string CleanString(string s, string c)
        {
            if (s.IndexOf(c) >= 0) s = s.Remove(s.IndexOf(c), 1);
            return s;
        }

        public static IexObject SelectEnum(string s, IexObject iex)
        {
            s = CleanString(s, "-");

            if (Enum.TryParse(s, true, out iex))
            {
                if (Enum.IsDefined(typeof(IexObject), iex))
                {
                    return iex;
                }
            }

            return iex;
        }

        public static FinboxObject SelectEnum(string s, FinboxObject fbx)
        {
            s = CleanString(s, "-");
            if (Enum.TryParse(s, out fbx))
            {
                if (Enum.IsDefined(typeof(FinboxObject), fbx))
                {
                    return fbx;
                }
            }

            return fbx;
        }

        public static QuandlObject SelectEnum(string s, QuandlObject qdl)
        {
            s = CleanString(s, "-");

            if (Enum.TryParse(s, out qdl))
            {
                if (Enum.IsDefined(typeof(QuandlObject), qdl))
                {
                    return qdl;
                }
            }

            return qdl;
        }

        public static AlphaVObject SelectEnum(string s, AlphaVObject apv)
        {
            s = CleanString(s, "-");

            if (Enum.TryParse(s, out apv))
            {
                if (Enum.IsDefined(typeof(AlphaVObject), apv))
                {
                    return apv;
                }
            }

            return apv;
        }
    }
}
