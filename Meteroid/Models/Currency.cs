// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<Currency>))]
public readonly partial record struct Currency(string Value) : IStringEnum<Currency>
{
    /// <summary><c>AED</c></summary>
    public static Currency Aed { get; } = new("AED");

    /// <summary><c>AFN</c></summary>
    public static Currency Afn { get; } = new("AFN");

    /// <summary><c>ALL</c></summary>
    public static Currency All { get; } = new("ALL");

    /// <summary><c>AMD</c></summary>
    public static Currency Amd { get; } = new("AMD");

    /// <summary><c>ANG</c></summary>
    public static Currency Ang { get; } = new("ANG");

    /// <summary><c>AOA</c></summary>
    public static Currency Aoa { get; } = new("AOA");

    /// <summary><c>ARS</c></summary>
    public static Currency Ars { get; } = new("ARS");

    /// <summary><c>AUD</c></summary>
    public static Currency Aud { get; } = new("AUD");

    /// <summary><c>AWG</c></summary>
    public static Currency Awg { get; } = new("AWG");

    /// <summary><c>AZN</c></summary>
    public static Currency Azn { get; } = new("AZN");

    /// <summary><c>BAM</c></summary>
    public static Currency Bam { get; } = new("BAM");

    /// <summary><c>BBD</c></summary>
    public static Currency Bbd { get; } = new("BBD");

    /// <summary><c>BDT</c></summary>
    public static Currency Bdt { get; } = new("BDT");

    /// <summary><c>BGN</c></summary>
    public static Currency Bgn { get; } = new("BGN");

    /// <summary><c>BHD</c></summary>
    public static Currency Bhd { get; } = new("BHD");

    /// <summary><c>BIF</c></summary>
    public static Currency Bif { get; } = new("BIF");

    /// <summary><c>BMD</c></summary>
    public static Currency Bmd { get; } = new("BMD");

    /// <summary><c>BND</c></summary>
    public static Currency Bnd { get; } = new("BND");

    /// <summary><c>BOB</c></summary>
    public static Currency Bob { get; } = new("BOB");

    /// <summary><c>BRL</c></summary>
    public static Currency Brl { get; } = new("BRL");

    /// <summary><c>BSD</c></summary>
    public static Currency Bsd { get; } = new("BSD");

    /// <summary><c>BTN</c></summary>
    public static Currency Btn { get; } = new("BTN");

    /// <summary><c>BWP</c></summary>
    public static Currency Bwp { get; } = new("BWP");

    /// <summary><c>BYN</c></summary>
    public static Currency Byn { get; } = new("BYN");

    /// <summary><c>BZD</c></summary>
    public static Currency Bzd { get; } = new("BZD");

    /// <summary><c>CAD</c></summary>
    public static Currency Cad { get; } = new("CAD");

    /// <summary><c>CDF</c></summary>
    public static Currency Cdf { get; } = new("CDF");

    /// <summary><c>CHF</c></summary>
    public static Currency Chf { get; } = new("CHF");

    /// <summary><c>CLP</c></summary>
    public static Currency Clp { get; } = new("CLP");

    /// <summary><c>CNH</c></summary>
    public static Currency Cnh { get; } = new("CNH");

    /// <summary><c>CNY</c></summary>
    public static Currency Cny { get; } = new("CNY");

    /// <summary><c>COP</c></summary>
    public static Currency Cop { get; } = new("COP");

    /// <summary><c>CRC</c></summary>
    public static Currency Crc { get; } = new("CRC");

    /// <summary><c>CUC</c></summary>
    public static Currency Cuc { get; } = new("CUC");

    /// <summary><c>CUP</c></summary>
    public static Currency Cup { get; } = new("CUP");

    /// <summary><c>CVE</c></summary>
    public static Currency Cve { get; } = new("CVE");

    /// <summary><c>CZK</c></summary>
    public static Currency Czk { get; } = new("CZK");

    /// <summary><c>DJF</c></summary>
    public static Currency Djf { get; } = new("DJF");

    /// <summary><c>DKK</c></summary>
    public static Currency Dkk { get; } = new("DKK");

    /// <summary><c>DOP</c></summary>
    public static Currency Dop { get; } = new("DOP");

    /// <summary><c>DZD</c></summary>
    public static Currency Dzd { get; } = new("DZD");

    /// <summary><c>EGP</c></summary>
    public static Currency Egp { get; } = new("EGP");

    /// <summary><c>ERN</c></summary>
    public static Currency Ern { get; } = new("ERN");

    /// <summary><c>ETB</c></summary>
    public static Currency Etb { get; } = new("ETB");

    /// <summary><c>EUR</c></summary>
    public static Currency Eur { get; } = new("EUR");

    /// <summary><c>FJD</c></summary>
    public static Currency Fjd { get; } = new("FJD");

    /// <summary><c>FKP</c></summary>
    public static Currency Fkp { get; } = new("FKP");

    /// <summary><c>GBP</c></summary>
    public static Currency Gbp { get; } = new("GBP");

    /// <summary><c>GEL</c></summary>
    public static Currency Gel { get; } = new("GEL");

    /// <summary><c>GHS</c></summary>
    public static Currency Ghs { get; } = new("GHS");

    /// <summary><c>GIP</c></summary>
    public static Currency Gip { get; } = new("GIP");

    /// <summary><c>GMD</c></summary>
    public static Currency Gmd { get; } = new("GMD");

    /// <summary><c>GNF</c></summary>
    public static Currency Gnf { get; } = new("GNF");

    /// <summary><c>GTQ</c></summary>
    public static Currency Gtq { get; } = new("GTQ");

    /// <summary><c>GYD</c></summary>
    public static Currency Gyd { get; } = new("GYD");

    /// <summary><c>HKD</c></summary>
    public static Currency Hkd { get; } = new("HKD");

    /// <summary><c>HNL</c></summary>
    public static Currency Hnl { get; } = new("HNL");

    /// <summary><c>HRK</c></summary>
    public static Currency Hrk { get; } = new("HRK");

    /// <summary><c>HTG</c></summary>
    public static Currency Htg { get; } = new("HTG");

    /// <summary><c>HUF</c></summary>
    public static Currency Huf { get; } = new("HUF");

    /// <summary><c>IDR</c></summary>
    public static Currency Idr { get; } = new("IDR");

    /// <summary><c>ILS</c></summary>
    public static Currency Ils { get; } = new("ILS");

    /// <summary><c>INR</c></summary>
    public static Currency Inr { get; } = new("INR");

    /// <summary><c>IQD</c></summary>
    public static Currency Iqd { get; } = new("IQD");

    /// <summary><c>IRR</c></summary>
    public static Currency Irr { get; } = new("IRR");

    /// <summary><c>ISK</c></summary>
    public static Currency Isk { get; } = new("ISK");

    /// <summary><c>JMD</c></summary>
    public static Currency Jmd { get; } = new("JMD");

    /// <summary><c>JOD</c></summary>
    public static Currency Jod { get; } = new("JOD");

    /// <summary><c>JPY</c></summary>
    public static Currency Jpy { get; } = new("JPY");

    /// <summary><c>KES</c></summary>
    public static Currency Kes { get; } = new("KES");

    /// <summary><c>KGS</c></summary>
    public static Currency Kgs { get; } = new("KGS");

    /// <summary><c>KHR</c></summary>
    public static Currency Khr { get; } = new("KHR");

    /// <summary><c>KMF</c></summary>
    public static Currency Kmf { get; } = new("KMF");

    /// <summary><c>KPW</c></summary>
    public static Currency Kpw { get; } = new("KPW");

    /// <summary><c>KRW</c></summary>
    public static Currency Krw { get; } = new("KRW");

    /// <summary><c>KWD</c></summary>
    public static Currency Kwd { get; } = new("KWD");

    /// <summary><c>KYD</c></summary>
    public static Currency Kyd { get; } = new("KYD");

    /// <summary><c>KZT</c></summary>
    public static Currency Kzt { get; } = new("KZT");

    /// <summary><c>LAK</c></summary>
    public static Currency Lak { get; } = new("LAK");

    /// <summary><c>LBP</c></summary>
    public static Currency Lbp { get; } = new("LBP");

    /// <summary><c>LKR</c></summary>
    public static Currency Lkr { get; } = new("LKR");

    /// <summary><c>LRD</c></summary>
    public static Currency Lrd { get; } = new("LRD");

    /// <summary><c>LSL</c></summary>
    public static Currency Lsl { get; } = new("LSL");

    /// <summary><c>LYD</c></summary>
    public static Currency Lyd { get; } = new("LYD");

    /// <summary><c>MAD</c></summary>
    public static Currency Mad { get; } = new("MAD");

    /// <summary><c>MDL</c></summary>
    public static Currency Mdl { get; } = new("MDL");

    /// <summary><c>MGA</c></summary>
    public static Currency Mga { get; } = new("MGA");

    /// <summary><c>MKD</c></summary>
    public static Currency Mkd { get; } = new("MKD");

    /// <summary><c>MMK</c></summary>
    public static Currency Mmk { get; } = new("MMK");

    /// <summary><c>MNT</c></summary>
    public static Currency Mnt { get; } = new("MNT");

    /// <summary><c>MOP</c></summary>
    public static Currency Mop { get; } = new("MOP");

    /// <summary><c>MRU</c></summary>
    public static Currency Mru { get; } = new("MRU");

    /// <summary><c>MUR</c></summary>
    public static Currency Mur { get; } = new("MUR");

    /// <summary><c>MVR</c></summary>
    public static Currency Mvr { get; } = new("MVR");

    /// <summary><c>MWK</c></summary>
    public static Currency Mwk { get; } = new("MWK");

    /// <summary><c>MXN</c></summary>
    public static Currency Mxn { get; } = new("MXN");

    /// <summary><c>MYR</c></summary>
    public static Currency Myr { get; } = new("MYR");

    /// <summary><c>MZN</c></summary>
    public static Currency Mzn { get; } = new("MZN");

    /// <summary><c>NAD</c></summary>
    public static Currency Nad { get; } = new("NAD");

    /// <summary><c>NGN</c></summary>
    public static Currency Ngn { get; } = new("NGN");

    /// <summary><c>NIO</c></summary>
    public static Currency Nio { get; } = new("NIO");

    /// <summary><c>NOK</c></summary>
    public static Currency Nok { get; } = new("NOK");

    /// <summary><c>NPR</c></summary>
    public static Currency Npr { get; } = new("NPR");

    /// <summary><c>NZD</c></summary>
    public static Currency Nzd { get; } = new("NZD");

    /// <summary><c>OMR</c></summary>
    public static Currency Omr { get; } = new("OMR");

    /// <summary><c>PAB</c></summary>
    public static Currency Pab { get; } = new("PAB");

    /// <summary><c>PEN</c></summary>
    public static Currency Pen { get; } = new("PEN");

    /// <summary><c>PGK</c></summary>
    public static Currency Pgk { get; } = new("PGK");

    /// <summary><c>PHP</c></summary>
    public static Currency Php { get; } = new("PHP");

    /// <summary><c>PKR</c></summary>
    public static Currency Pkr { get; } = new("PKR");

    /// <summary><c>PLN</c></summary>
    public static Currency Pln { get; } = new("PLN");

    /// <summary><c>PYG</c></summary>
    public static Currency Pyg { get; } = new("PYG");

    /// <summary><c>QAR</c></summary>
    public static Currency Qar { get; } = new("QAR");

    /// <summary><c>RON</c></summary>
    public static Currency Ron { get; } = new("RON");

    /// <summary><c>RSD</c></summary>
    public static Currency Rsd { get; } = new("RSD");

    /// <summary><c>RUB</c></summary>
    public static Currency Rub { get; } = new("RUB");

    /// <summary><c>RWF</c></summary>
    public static Currency Rwf { get; } = new("RWF");

    /// <summary><c>SAR</c></summary>
    public static Currency Sar { get; } = new("SAR");

    /// <summary><c>SBD</c></summary>
    public static Currency Sbd { get; } = new("SBD");

    /// <summary><c>SCR</c></summary>
    public static Currency Scr { get; } = new("SCR");

    /// <summary><c>SDG</c></summary>
    public static Currency Sdg { get; } = new("SDG");

    /// <summary><c>SEK</c></summary>
    public static Currency Sek { get; } = new("SEK");

    /// <summary><c>SGD</c></summary>
    public static Currency Sgd { get; } = new("SGD");

    /// <summary><c>SHP</c></summary>
    public static Currency Shp { get; } = new("SHP");

    /// <summary><c>SLL</c></summary>
    public static Currency Sll { get; } = new("SLL");

    /// <summary><c>SOS</c></summary>
    public static Currency Sos { get; } = new("SOS");

    /// <summary><c>SRD</c></summary>
    public static Currency Srd { get; } = new("SRD");

    /// <summary><c>SSP</c></summary>
    public static Currency Ssp { get; } = new("SSP");

    /// <summary><c>STD</c></summary>
    public static Currency Std { get; } = new("STD");

    /// <summary><c>STN</c></summary>
    public static Currency Stn { get; } = new("STN");

    /// <summary><c>SVC</c></summary>
    public static Currency Svc { get; } = new("SVC");

    /// <summary><c>SYP</c></summary>
    public static Currency Syp { get; } = new("SYP");

    /// <summary><c>SZL</c></summary>
    public static Currency Szl { get; } = new("SZL");

    /// <summary><c>THB</c></summary>
    public static Currency Thb { get; } = new("THB");

    /// <summary><c>TJS</c></summary>
    public static Currency Tjs { get; } = new("TJS");

    /// <summary><c>TMT</c></summary>
    public static Currency Tmt { get; } = new("TMT");

    /// <summary><c>TND</c></summary>
    public static Currency Tnd { get; } = new("TND");

    /// <summary><c>TOP</c></summary>
    public static Currency Top { get; } = new("TOP");

    /// <summary><c>TRY</c></summary>
    public static Currency Try { get; } = new("TRY");

    /// <summary><c>TTD</c></summary>
    public static Currency Ttd { get; } = new("TTD");

    /// <summary><c>TWD</c></summary>
    public static Currency Twd { get; } = new("TWD");

    /// <summary><c>TZS</c></summary>
    public static Currency Tzs { get; } = new("TZS");

    /// <summary><c>UAH</c></summary>
    public static Currency Uah { get; } = new("UAH");

    /// <summary><c>UGX</c></summary>
    public static Currency Ugx { get; } = new("UGX");

    /// <summary><c>USD</c></summary>
    public static Currency Usd { get; } = new("USD");

    /// <summary><c>UYU</c></summary>
    public static Currency Uyu { get; } = new("UYU");

    /// <summary><c>UZS</c></summary>
    public static Currency Uzs { get; } = new("UZS");

    /// <summary><c>VES</c></summary>
    public static Currency Ves { get; } = new("VES");

    /// <summary><c>VND</c></summary>
    public static Currency Vnd { get; } = new("VND");

    /// <summary><c>VUV</c></summary>
    public static Currency Vuv { get; } = new("VUV");

    /// <summary><c>WST</c></summary>
    public static Currency Wst { get; } = new("WST");

    /// <summary><c>XAF</c></summary>
    public static Currency Xaf { get; } = new("XAF");

    /// <summary><c>XCD</c></summary>
    public static Currency Xcd { get; } = new("XCD");

    /// <summary><c>XOF</c></summary>
    public static Currency Xof { get; } = new("XOF");

    /// <summary><c>XPF</c></summary>
    public static Currency Xpf { get; } = new("XPF");

    /// <summary><c>YER</c></summary>
    public static Currency Yer { get; } = new("YER");

    /// <summary><c>ZAR</c></summary>
    public static Currency Zar { get; } = new("ZAR");

    /// <summary><c>ZMW</c></summary>
    public static Currency Zmw { get; } = new("ZMW");

    /// <summary><c>ZWL</c></summary>
    public static Currency Zwl { get; } = new("ZWL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "AED"
                or "AFN"
                or "ALL"
                or "AMD"
                or "ANG"
                or "AOA"
                or "ARS"
                or "AUD"
                or "AWG"
                or "AZN"
                or "BAM"
                or "BBD"
                or "BDT"
                or "BGN"
                or "BHD"
                or "BIF"
                or "BMD"
                or "BND"
                or "BOB"
                or "BRL"
                or "BSD"
                or "BTN"
                or "BWP"
                or "BYN"
                or "BZD"
                or "CAD"
                or "CDF"
                or "CHF"
                or "CLP"
                or "CNH"
                or "CNY"
                or "COP"
                or "CRC"
                or "CUC"
                or "CUP"
                or "CVE"
                or "CZK"
                or "DJF"
                or "DKK"
                or "DOP"
                or "DZD"
                or "EGP"
                or "ERN"
                or "ETB"
                or "EUR"
                or "FJD"
                or "FKP"
                or "GBP"
                or "GEL"
                or "GHS"
                or "GIP"
                or "GMD"
                or "GNF"
                or "GTQ"
                or "GYD"
                or "HKD"
                or "HNL"
                or "HRK"
                or "HTG"
                or "HUF"
                or "IDR"
                or "ILS"
                or "INR"
                or "IQD"
                or "IRR"
                or "ISK"
                or "JMD"
                or "JOD"
                or "JPY"
                or "KES"
                or "KGS"
                or "KHR"
                or "KMF"
                or "KPW"
                or "KRW"
                or "KWD"
                or "KYD"
                or "KZT"
                or "LAK"
                or "LBP"
                or "LKR"
                or "LRD"
                or "LSL"
                or "LYD"
                or "MAD"
                or "MDL"
                or "MGA"
                or "MKD"
                or "MMK"
                or "MNT"
                or "MOP"
                or "MRU"
                or "MUR"
                or "MVR"
                or "MWK"
                or "MXN"
                or "MYR"
                or "MZN"
                or "NAD"
                or "NGN"
                or "NIO"
                or "NOK"
                or "NPR"
                or "NZD"
                or "OMR"
                or "PAB"
                or "PEN"
                or "PGK"
                or "PHP"
                or "PKR"
                or "PLN"
                or "PYG"
                or "QAR"
                or "RON"
                or "RSD"
                or "RUB"
                or "RWF"
                or "SAR"
                or "SBD"
                or "SCR"
                or "SDG"
                or "SEK"
                or "SGD"
                or "SHP"
                or "SLL"
                or "SOS"
                or "SRD"
                or "SSP"
                or "STD"
                or "STN"
                or "SVC"
                or "SYP"
                or "SZL"
                or "THB"
                or "TJS"
                or "TMT"
                or "TND"
                or "TOP"
                or "TRY"
                or "TTD"
                or "TWD"
                or "TZS"
                or "UAH"
                or "UGX"
                or "USD"
                or "UYU"
                or "UZS"
                or "VES"
                or "VND"
                or "VUV"
                or "WST"
                or "XAF"
                or "XCD"
                or "XOF"
                or "XPF"
                or "YER"
                or "ZAR"
                or "ZMW"
                or "ZWL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>AED</c></summary>
        public const string Aed = "AED";

        /// <summary><c>AFN</c></summary>
        public const string Afn = "AFN";

        /// <summary><c>ALL</c></summary>
        public const string All = "ALL";

        /// <summary><c>AMD</c></summary>
        public const string Amd = "AMD";

        /// <summary><c>ANG</c></summary>
        public const string Ang = "ANG";

        /// <summary><c>AOA</c></summary>
        public const string Aoa = "AOA";

        /// <summary><c>ARS</c></summary>
        public const string Ars = "ARS";

        /// <summary><c>AUD</c></summary>
        public const string Aud = "AUD";

        /// <summary><c>AWG</c></summary>
        public const string Awg = "AWG";

        /// <summary><c>AZN</c></summary>
        public const string Azn = "AZN";

        /// <summary><c>BAM</c></summary>
        public const string Bam = "BAM";

        /// <summary><c>BBD</c></summary>
        public const string Bbd = "BBD";

        /// <summary><c>BDT</c></summary>
        public const string Bdt = "BDT";

        /// <summary><c>BGN</c></summary>
        public const string Bgn = "BGN";

        /// <summary><c>BHD</c></summary>
        public const string Bhd = "BHD";

        /// <summary><c>BIF</c></summary>
        public const string Bif = "BIF";

        /// <summary><c>BMD</c></summary>
        public const string Bmd = "BMD";

        /// <summary><c>BND</c></summary>
        public const string Bnd = "BND";

        /// <summary><c>BOB</c></summary>
        public const string Bob = "BOB";

        /// <summary><c>BRL</c></summary>
        public const string Brl = "BRL";

        /// <summary><c>BSD</c></summary>
        public const string Bsd = "BSD";

        /// <summary><c>BTN</c></summary>
        public const string Btn = "BTN";

        /// <summary><c>BWP</c></summary>
        public const string Bwp = "BWP";

        /// <summary><c>BYN</c></summary>
        public const string Byn = "BYN";

        /// <summary><c>BZD</c></summary>
        public const string Bzd = "BZD";

        /// <summary><c>CAD</c></summary>
        public const string Cad = "CAD";

        /// <summary><c>CDF</c></summary>
        public const string Cdf = "CDF";

        /// <summary><c>CHF</c></summary>
        public const string Chf = "CHF";

        /// <summary><c>CLP</c></summary>
        public const string Clp = "CLP";

        /// <summary><c>CNH</c></summary>
        public const string Cnh = "CNH";

        /// <summary><c>CNY</c></summary>
        public const string Cny = "CNY";

        /// <summary><c>COP</c></summary>
        public const string Cop = "COP";

        /// <summary><c>CRC</c></summary>
        public const string Crc = "CRC";

        /// <summary><c>CUC</c></summary>
        public const string Cuc = "CUC";

        /// <summary><c>CUP</c></summary>
        public const string Cup = "CUP";

        /// <summary><c>CVE</c></summary>
        public const string Cve = "CVE";

        /// <summary><c>CZK</c></summary>
        public const string Czk = "CZK";

        /// <summary><c>DJF</c></summary>
        public const string Djf = "DJF";

        /// <summary><c>DKK</c></summary>
        public const string Dkk = "DKK";

        /// <summary><c>DOP</c></summary>
        public const string Dop = "DOP";

        /// <summary><c>DZD</c></summary>
        public const string Dzd = "DZD";

        /// <summary><c>EGP</c></summary>
        public const string Egp = "EGP";

        /// <summary><c>ERN</c></summary>
        public const string Ern = "ERN";

        /// <summary><c>ETB</c></summary>
        public const string Etb = "ETB";

        /// <summary><c>EUR</c></summary>
        public const string Eur = "EUR";

        /// <summary><c>FJD</c></summary>
        public const string Fjd = "FJD";

        /// <summary><c>FKP</c></summary>
        public const string Fkp = "FKP";

        /// <summary><c>GBP</c></summary>
        public const string Gbp = "GBP";

        /// <summary><c>GEL</c></summary>
        public const string Gel = "GEL";

        /// <summary><c>GHS</c></summary>
        public const string Ghs = "GHS";

        /// <summary><c>GIP</c></summary>
        public const string Gip = "GIP";

        /// <summary><c>GMD</c></summary>
        public const string Gmd = "GMD";

        /// <summary><c>GNF</c></summary>
        public const string Gnf = "GNF";

        /// <summary><c>GTQ</c></summary>
        public const string Gtq = "GTQ";

        /// <summary><c>GYD</c></summary>
        public const string Gyd = "GYD";

        /// <summary><c>HKD</c></summary>
        public const string Hkd = "HKD";

        /// <summary><c>HNL</c></summary>
        public const string Hnl = "HNL";

        /// <summary><c>HRK</c></summary>
        public const string Hrk = "HRK";

        /// <summary><c>HTG</c></summary>
        public const string Htg = "HTG";

        /// <summary><c>HUF</c></summary>
        public const string Huf = "HUF";

        /// <summary><c>IDR</c></summary>
        public const string Idr = "IDR";

        /// <summary><c>ILS</c></summary>
        public const string Ils = "ILS";

        /// <summary><c>INR</c></summary>
        public const string Inr = "INR";

        /// <summary><c>IQD</c></summary>
        public const string Iqd = "IQD";

        /// <summary><c>IRR</c></summary>
        public const string Irr = "IRR";

        /// <summary><c>ISK</c></summary>
        public const string Isk = "ISK";

        /// <summary><c>JMD</c></summary>
        public const string Jmd = "JMD";

        /// <summary><c>JOD</c></summary>
        public const string Jod = "JOD";

        /// <summary><c>JPY</c></summary>
        public const string Jpy = "JPY";

        /// <summary><c>KES</c></summary>
        public const string Kes = "KES";

        /// <summary><c>KGS</c></summary>
        public const string Kgs = "KGS";

        /// <summary><c>KHR</c></summary>
        public const string Khr = "KHR";

        /// <summary><c>KMF</c></summary>
        public const string Kmf = "KMF";

        /// <summary><c>KPW</c></summary>
        public const string Kpw = "KPW";

        /// <summary><c>KRW</c></summary>
        public const string Krw = "KRW";

        /// <summary><c>KWD</c></summary>
        public const string Kwd = "KWD";

        /// <summary><c>KYD</c></summary>
        public const string Kyd = "KYD";

        /// <summary><c>KZT</c></summary>
        public const string Kzt = "KZT";

        /// <summary><c>LAK</c></summary>
        public const string Lak = "LAK";

        /// <summary><c>LBP</c></summary>
        public const string Lbp = "LBP";

        /// <summary><c>LKR</c></summary>
        public const string Lkr = "LKR";

        /// <summary><c>LRD</c></summary>
        public const string Lrd = "LRD";

        /// <summary><c>LSL</c></summary>
        public const string Lsl = "LSL";

        /// <summary><c>LYD</c></summary>
        public const string Lyd = "LYD";

        /// <summary><c>MAD</c></summary>
        public const string Mad = "MAD";

        /// <summary><c>MDL</c></summary>
        public const string Mdl = "MDL";

        /// <summary><c>MGA</c></summary>
        public const string Mga = "MGA";

        /// <summary><c>MKD</c></summary>
        public const string Mkd = "MKD";

        /// <summary><c>MMK</c></summary>
        public const string Mmk = "MMK";

        /// <summary><c>MNT</c></summary>
        public const string Mnt = "MNT";

        /// <summary><c>MOP</c></summary>
        public const string Mop = "MOP";

        /// <summary><c>MRU</c></summary>
        public const string Mru = "MRU";

        /// <summary><c>MUR</c></summary>
        public const string Mur = "MUR";

        /// <summary><c>MVR</c></summary>
        public const string Mvr = "MVR";

        /// <summary><c>MWK</c></summary>
        public const string Mwk = "MWK";

        /// <summary><c>MXN</c></summary>
        public const string Mxn = "MXN";

        /// <summary><c>MYR</c></summary>
        public const string Myr = "MYR";

        /// <summary><c>MZN</c></summary>
        public const string Mzn = "MZN";

        /// <summary><c>NAD</c></summary>
        public const string Nad = "NAD";

        /// <summary><c>NGN</c></summary>
        public const string Ngn = "NGN";

        /// <summary><c>NIO</c></summary>
        public const string Nio = "NIO";

        /// <summary><c>NOK</c></summary>
        public const string Nok = "NOK";

        /// <summary><c>NPR</c></summary>
        public const string Npr = "NPR";

        /// <summary><c>NZD</c></summary>
        public const string Nzd = "NZD";

        /// <summary><c>OMR</c></summary>
        public const string Omr = "OMR";

        /// <summary><c>PAB</c></summary>
        public const string Pab = "PAB";

        /// <summary><c>PEN</c></summary>
        public const string Pen = "PEN";

        /// <summary><c>PGK</c></summary>
        public const string Pgk = "PGK";

        /// <summary><c>PHP</c></summary>
        public const string Php = "PHP";

        /// <summary><c>PKR</c></summary>
        public const string Pkr = "PKR";

        /// <summary><c>PLN</c></summary>
        public const string Pln = "PLN";

        /// <summary><c>PYG</c></summary>
        public const string Pyg = "PYG";

        /// <summary><c>QAR</c></summary>
        public const string Qar = "QAR";

        /// <summary><c>RON</c></summary>
        public const string Ron = "RON";

        /// <summary><c>RSD</c></summary>
        public const string Rsd = "RSD";

        /// <summary><c>RUB</c></summary>
        public const string Rub = "RUB";

        /// <summary><c>RWF</c></summary>
        public const string Rwf = "RWF";

        /// <summary><c>SAR</c></summary>
        public const string Sar = "SAR";

        /// <summary><c>SBD</c></summary>
        public const string Sbd = "SBD";

        /// <summary><c>SCR</c></summary>
        public const string Scr = "SCR";

        /// <summary><c>SDG</c></summary>
        public const string Sdg = "SDG";

        /// <summary><c>SEK</c></summary>
        public const string Sek = "SEK";

        /// <summary><c>SGD</c></summary>
        public const string Sgd = "SGD";

        /// <summary><c>SHP</c></summary>
        public const string Shp = "SHP";

        /// <summary><c>SLL</c></summary>
        public const string Sll = "SLL";

        /// <summary><c>SOS</c></summary>
        public const string Sos = "SOS";

        /// <summary><c>SRD</c></summary>
        public const string Srd = "SRD";

        /// <summary><c>SSP</c></summary>
        public const string Ssp = "SSP";

        /// <summary><c>STD</c></summary>
        public const string Std = "STD";

        /// <summary><c>STN</c></summary>
        public const string Stn = "STN";

        /// <summary><c>SVC</c></summary>
        public const string Svc = "SVC";

        /// <summary><c>SYP</c></summary>
        public const string Syp = "SYP";

        /// <summary><c>SZL</c></summary>
        public const string Szl = "SZL";

        /// <summary><c>THB</c></summary>
        public const string Thb = "THB";

        /// <summary><c>TJS</c></summary>
        public const string Tjs = "TJS";

        /// <summary><c>TMT</c></summary>
        public const string Tmt = "TMT";

        /// <summary><c>TND</c></summary>
        public const string Tnd = "TND";

        /// <summary><c>TOP</c></summary>
        public const string Top = "TOP";

        /// <summary><c>TRY</c></summary>
        public const string Try = "TRY";

        /// <summary><c>TTD</c></summary>
        public const string Ttd = "TTD";

        /// <summary><c>TWD</c></summary>
        public const string Twd = "TWD";

        /// <summary><c>TZS</c></summary>
        public const string Tzs = "TZS";

        /// <summary><c>UAH</c></summary>
        public const string Uah = "UAH";

        /// <summary><c>UGX</c></summary>
        public const string Ugx = "UGX";

        /// <summary><c>USD</c></summary>
        public const string Usd = "USD";

        /// <summary><c>UYU</c></summary>
        public const string Uyu = "UYU";

        /// <summary><c>UZS</c></summary>
        public const string Uzs = "UZS";

        /// <summary><c>VES</c></summary>
        public const string Ves = "VES";

        /// <summary><c>VND</c></summary>
        public const string Vnd = "VND";

        /// <summary><c>VUV</c></summary>
        public const string Vuv = "VUV";

        /// <summary><c>WST</c></summary>
        public const string Wst = "WST";

        /// <summary><c>XAF</c></summary>
        public const string Xaf = "XAF";

        /// <summary><c>XCD</c></summary>
        public const string Xcd = "XCD";

        /// <summary><c>XOF</c></summary>
        public const string Xof = "XOF";

        /// <summary><c>XPF</c></summary>
        public const string Xpf = "XPF";

        /// <summary><c>YER</c></summary>
        public const string Yer = "YER";

        /// <summary><c>ZAR</c></summary>
        public const string Zar = "ZAR";

        /// <summary><c>ZMW</c></summary>
        public const string Zmw = "ZMW";

        /// <summary><c>ZWL</c></summary>
        public const string Zwl = "ZWL";
    }

    static Currency IStringEnum<Currency>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator Currency(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
