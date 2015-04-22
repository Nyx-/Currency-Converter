using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convertor_GUI {

    enum Currencies {AUD, CYN, DKK, EUR, INR, NZD, AED, UKP, USD, VND};

    static class Currency_Exchange{
        private static double[] xRates = {1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547};

        // Insert method or methods here


        public static double ConvertCurrency(int startValue, string startCode, string endCode){
            double currencyRateStart = 0, currencyRateEnd = 0;


            switch (startCode) {
                case "AUD": currencyRateStart = xRates[(int)Currencies.AUD];
                    break;
                case "CYN": currencyRateStart = xRates[(int)Currencies.CYN];
                    break;
                case "DKK": currencyRateStart = xRates[(int)Currencies.DKK];
                    break;
                case "EUR": currencyRateStart = xRates[(int)Currencies.EUR];
                    break;
                case "INR": currencyRateStart = xRates[(int)Currencies.INR];
                    break;
                case "NZD": currencyRateStart = xRates[(int)Currencies.NZD];
                    break;
                case "AED": currencyRateStart = xRates[(int)Currencies.AED];
                    break;
                case "UKP": currencyRateStart = xRates[(int)Currencies.UKP];
                    break;
                case "USD": currencyRateStart = xRates[(int)Currencies.USD];
                    break;
                case "VND": currencyRateStart = xRates[(int)Currencies.VND];
                    break;
            }

            switch (endCode) {
                case "AUD": currencyRateEnd = xRates[(int)Currencies.AUD];
                    break;
                case "CYN": currencyRateEnd = xRates[(int)Currencies.CYN];
                    break;
                case "DKK": currencyRateEnd = xRates[(int)Currencies.DKK];
                    break;
                case "EUR": currencyRateEnd = xRates[(int)Currencies.EUR];
                    break;
                case "INR": currencyRateEnd = xRates[(int)Currencies.INR];
                    break;
                case "NZD": currencyRateEnd = xRates[(int)Currencies.NZD];
                    break;
                case "AED": currencyRateEnd = xRates[(int)Currencies.AED];
                    break;
                case "UKP": currencyRateEnd = xRates[(int)Currencies.UKP];
                    break;
                case "USD": currencyRateEnd = xRates[(int)Currencies.USD];
                    break;
                case "VND": currencyRateEnd = xRates[(int)Currencies.VND];
                    break;
            }

            double value = startValue / currencyRateStart;
            value = value * currencyRateEnd;

            return value;

        }


        // Starting value / Currency rate = $AUD
        // $AUD * Currency rate = $Currency you want
        // Parameters = starting value, starting currency & ending currency


    }//end class
}//end namespace
