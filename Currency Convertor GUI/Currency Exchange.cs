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
            
              
            /*
            switch (startCode) {
                case "Australia (AUD)": currencyRateStart = xRates[(int)Currencies.AUD];
                    break;
                case "China (CYN)": currencyRateStart = xRates[(int)Currencies.CYN];
                    break;
                case "Denmark (DKK)": currencyRateStart = xRates[(int)Currencies.DKK];
                    break;
                case "Europe (EUR)": currencyRateStart = xRates[(int)Currencies.EUR];
                    break;
                case "India (INR)": currencyRateStart = xRates[(int)Currencies.INR];
                    break;
                case "New Zealand (NZD)": currencyRateStart = xRates[(int)Currencies.NZD];
                    break;
                case "United Arab Emirates (AED)": currencyRateStart = xRates[(int)Currencies.AED];
                    break;
                case "United Kingdom (UKP)": currencyRateStart = xRates[(int)Currencies.UKP];
                    break;
                case "United States (USD)": currencyRateStart = xRates[(int)Currencies.USD];
                    break;
                case "Vietnam (VND)": currencyRateStart = xRates[(int)Currencies.VND];
                    break;
            }

            switch (endCode) {
                case "Australia (AUD)": currencyRateEnd = xRates[(int)Currencies.AUD];
                    break;
                case "China (CYN)": currencyRateEnd = xRates[(int)Currencies.CYN];
                    break;
                case "Denmark (DKK)": currencyRateEnd = xRates[(int)Currencies.DKK];
                    break;
                case "Europe (EUR)": currencyRateEnd = xRates[(int)Currencies.EUR];
                    break;
                case "India (INR)": currencyRateEnd = xRates[(int)Currencies.INR];
                    break;
                case "New Zealand (NZD)": currencyRateEnd = xRates[(int)Currencies.NZD];
                    break;
                case "United Arab Emirates (AED)": currencyRateEnd = xRates[(int)Currencies.AED];
                    break;
                case "United Kingdom (UKP)": currencyRateEnd = xRates[(int)Currencies.UKP];
                    break;
                case "United States (USD)": currencyRateEnd = xRates[(int)Currencies.USD];
                    break;
                case "Vietnam (VND)": currencyRateEnd = xRates[(int)Currencies.VND];
                    break;
            }
            */

            double value = startValue / currencyRateStart;
            value = value * currencyRateEnd;

            return value;

        }


        public static string CurrencyCode(string input){
            string code = "";
            
            switch (input) {
                case "Australia (AUD)": code = "AUD";
                    break;
                case "China (CYN)": code = "CYN";
                    break;
                case "Denmark (DKK)": code = "DKK";
                    break;
                case "Europe (EUR)": code = "EUR";
                    break;
                case "India (INR)": code = "INR";
                    break;
                case "New Zealand (NZD)": code = "NZD";
                    break;
                case "United Arab Emirates (AED)": code = "AED";
                    break;
                case "United Kingdom (UKP)": code = "UKP";
                    break;
                case "United States (USD)": code = "USD";
                    break;
                case "Vietnam (VND)": code = "VND";
                    break;
            }
            return code;
        }

        // Starting value / Currency rate = $AUD
        // $AUD * Currency rate = $Currency you want
        // Parameters = starting value, starting currency & ending currency


    }//end class
}//end namespace
