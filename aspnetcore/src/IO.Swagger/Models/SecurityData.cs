/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SecurityData : IEquatable<SecurityData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PositionImpactDays
        /// </summary>
        [DataMember(Name="positionImpactDays")]
        public int? PositionImpactDays { get; set; }

        /// <summary>
        /// Gets or Sets DaysToSettlement
        /// </summary>
        [DataMember(Name="daysToSettlement")]
        public int? DaysToSettlement { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="expiryDate")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets Strike
        /// </summary>
        [DataMember(Name="strike")]
        public double? Strike { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Isin
        /// </summary>
        [DataMember(Name="isin")]
        public string Isin { get; set; }

        /// <summary>
        /// Gets or Sets SecurityClassId
        /// </summary>
        [DataMember(Name="securityClassId")]
        public int? SecurityClassId { get; set; }

        /// <summary>
        /// Gets or Sets DailyAdjustment
        /// </summary>
        [DataMember(Name="dailyAdjustment")]
        public int? DailyAdjustment { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets AdrUnderline
        /// </summary>
        [DataMember(Name="adrUnderline")]
        public int? AdrUnderline { get; set; }

        /// <summary>
        /// Gets or Sets AdrUnderlineQuantity
        /// </summary>
        [DataMember(Name="adrUnderlineQuantity")]
        public int? AdrUnderlineQuantity { get; set; }

        /// <summary>
        /// Gets or Sets BaseSecurityPrice
        /// </summary>
        [DataMember(Name="baseSecurityPrice")]
        public bool? BaseSecurityPrice { get; set; }

        /// <summary>
        /// Gets or Sets ImportPrice
        /// </summary>
        [DataMember(Name="importPrice")]
        public bool? ImportPrice { get; set; }

        /// <summary>
        /// Gets or Sets ProviderCode
        /// </summary>
        [DataMember(Name="providerCode")]
        public string ProviderCode { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="countryId")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currencyId")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets StockExchangeId
        /// </summary>
        [DataMember(Name="stockExchangeId")]
        public int? StockExchangeId { get; set; }

        /// <summary>
        /// Gets or Sets GicsSubIndustryId
        /// </summary>
        [DataMember(Name="gicsSubIndustryId")]
        public int? GicsSubIndustryId { get; set; }

        /// <summary>
        /// Gets or Sets BaseSecurity
        /// </summary>
        [DataMember(Name="baseSecurity")]
        public string BaseSecurity { get; set; }

        /// <summary>
        /// Gets or Sets LocalSecurity
        /// </summary>
        [DataMember(Name="localSecurity")]
        public string LocalSecurity { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets SectorId
        /// </summary>
        [DataMember(Name="sectorId")]
        public int? SectorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PositionImpactDays: ").Append(PositionImpactDays).Append("\n");
            sb.Append("  DaysToSettlement: ").Append(DaysToSettlement).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  SecurityClassId: ").Append(SecurityClassId).Append("\n");
            sb.Append("  DailyAdjustment: ").Append(DailyAdjustment).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  AdrUnderline: ").Append(AdrUnderline).Append("\n");
            sb.Append("  AdrUnderlineQuantity: ").Append(AdrUnderlineQuantity).Append("\n");
            sb.Append("  BaseSecurityPrice: ").Append(BaseSecurityPrice).Append("\n");
            sb.Append("  ImportPrice: ").Append(ImportPrice).Append("\n");
            sb.Append("  ProviderCode: ").Append(ProviderCode).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  StockExchangeId: ").Append(StockExchangeId).Append("\n");
            sb.Append("  GicsSubIndustryId: ").Append(GicsSubIndustryId).Append("\n");
            sb.Append("  BaseSecurity: ").Append(BaseSecurity).Append("\n");
            sb.Append("  LocalSecurity: ").Append(LocalSecurity).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  SectorId: ").Append(SectorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SecurityData)obj);
        }

        /// <summary>
        /// Returns true if SecurityData instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    PositionImpactDays == other.PositionImpactDays ||
                    PositionImpactDays != null &&
                    PositionImpactDays.Equals(other.PositionImpactDays)
                ) && 
                (
                    DaysToSettlement == other.DaysToSettlement ||
                    DaysToSettlement != null &&
                    DaysToSettlement.Equals(other.DaysToSettlement)
                ) && 
                (
                    ExpiryDate == other.ExpiryDate ||
                    ExpiryDate != null &&
                    ExpiryDate.Equals(other.ExpiryDate)
                ) && 
                (
                    Strike == other.Strike ||
                    Strike != null &&
                    Strike.Equals(other.Strike)
                ) && 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
                ) && 
                (
                    Isin == other.Isin ||
                    Isin != null &&
                    Isin.Equals(other.Isin)
                ) && 
                (
                    SecurityClassId == other.SecurityClassId ||
                    SecurityClassId != null &&
                    SecurityClassId.Equals(other.SecurityClassId)
                ) && 
                (
                    DailyAdjustment == other.DailyAdjustment ||
                    DailyAdjustment != null &&
                    DailyAdjustment.Equals(other.DailyAdjustment)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    AdrUnderline == other.AdrUnderline ||
                    AdrUnderline != null &&
                    AdrUnderline.Equals(other.AdrUnderline)
                ) && 
                (
                    AdrUnderlineQuantity == other.AdrUnderlineQuantity ||
                    AdrUnderlineQuantity != null &&
                    AdrUnderlineQuantity.Equals(other.AdrUnderlineQuantity)
                ) && 
                (
                    BaseSecurityPrice == other.BaseSecurityPrice ||
                    BaseSecurityPrice != null &&
                    BaseSecurityPrice.Equals(other.BaseSecurityPrice)
                ) && 
                (
                    ImportPrice == other.ImportPrice ||
                    ImportPrice != null &&
                    ImportPrice.Equals(other.ImportPrice)
                ) && 
                (
                    ProviderCode == other.ProviderCode ||
                    ProviderCode != null &&
                    ProviderCode.Equals(other.ProviderCode)
                ) && 
                (
                    CountryId == other.CountryId ||
                    CountryId != null &&
                    CountryId.Equals(other.CountryId)
                ) && 
                (
                    CurrencyId == other.CurrencyId ||
                    CurrencyId != null &&
                    CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    StockExchangeId == other.StockExchangeId ||
                    StockExchangeId != null &&
                    StockExchangeId.Equals(other.StockExchangeId)
                ) && 
                (
                    GicsSubIndustryId == other.GicsSubIndustryId ||
                    GicsSubIndustryId != null &&
                    GicsSubIndustryId.Equals(other.GicsSubIndustryId)
                ) && 
                (
                    BaseSecurity == other.BaseSecurity ||
                    BaseSecurity != null &&
                    BaseSecurity.Equals(other.BaseSecurity)
                ) && 
                (
                    LocalSecurity == other.LocalSecurity ||
                    LocalSecurity != null &&
                    LocalSecurity.Equals(other.LocalSecurity)
                ) && 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    SectorId == other.SectorId ||
                    SectorId != null &&
                    SectorId.Equals(other.SectorId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (PositionImpactDays != null)
                    hashCode = hashCode * 59 + PositionImpactDays.GetHashCode();
                    if (DaysToSettlement != null)
                    hashCode = hashCode * 59 + DaysToSettlement.GetHashCode();
                    if (ExpiryDate != null)
                    hashCode = hashCode * 59 + ExpiryDate.GetHashCode();
                    if (Strike != null)
                    hashCode = hashCode * 59 + Strike.GetHashCode();
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                    if (Isin != null)
                    hashCode = hashCode * 59 + Isin.GetHashCode();
                    if (SecurityClassId != null)
                    hashCode = hashCode * 59 + SecurityClassId.GetHashCode();
                    if (DailyAdjustment != null)
                    hashCode = hashCode * 59 + DailyAdjustment.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (AdrUnderline != null)
                    hashCode = hashCode * 59 + AdrUnderline.GetHashCode();
                    if (AdrUnderlineQuantity != null)
                    hashCode = hashCode * 59 + AdrUnderlineQuantity.GetHashCode();
                    if (BaseSecurityPrice != null)
                    hashCode = hashCode * 59 + BaseSecurityPrice.GetHashCode();
                    if (ImportPrice != null)
                    hashCode = hashCode * 59 + ImportPrice.GetHashCode();
                    if (ProviderCode != null)
                    hashCode = hashCode * 59 + ProviderCode.GetHashCode();
                    if (CountryId != null)
                    hashCode = hashCode * 59 + CountryId.GetHashCode();
                    if (CurrencyId != null)
                    hashCode = hashCode * 59 + CurrencyId.GetHashCode();
                    if (StockExchangeId != null)
                    hashCode = hashCode * 59 + StockExchangeId.GetHashCode();
                    if (GicsSubIndustryId != null)
                    hashCode = hashCode * 59 + GicsSubIndustryId.GetHashCode();
                    if (BaseSecurity != null)
                    hashCode = hashCode * 59 + BaseSecurity.GetHashCode();
                    if (LocalSecurity != null)
                    hashCode = hashCode * 59 + LocalSecurity.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (SectorId != null)
                    hashCode = hashCode * 59 + SectorId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SecurityData left, SecurityData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SecurityData left, SecurityData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
