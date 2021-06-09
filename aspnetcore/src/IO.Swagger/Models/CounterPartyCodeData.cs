/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.9
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
    public partial class CounterPartyCodeData : IEquatable<CounterPartyCodeData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalCode
        /// </summary>
        [DataMember(Name="principalCode")]
        public string PrincipalCode { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalCodeDtc
        /// </summary>
        [DataMember(Name="principalCodeDtc")]
        public string PrincipalCodeDtc { get; set; }

        /// <summary>
        /// Gets or Sets BloombergCode
        /// </summary>
        [DataMember(Name="bloombergCode")]
        public string BloombergCode { get; set; }

        /// <summary>
        /// Gets or Sets StockExchangeId
        /// </summary>
        [DataMember(Name="stockExchangeId")]
        public int? StockExchangeId { get; set; }

        /// <summary>
        /// Gets or Sets BrokerId
        /// </summary>
        [DataMember(Name="brokerId")]
        public int? BrokerId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="countryId")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets ClearingCode
        /// </summary>
        [DataMember(Name="clearingCode")]
        public string ClearingCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Broker
        /// </summary>
        [DataMember(Name="broker")]
        public string Broker { get; set; }

        /// <summary>
        /// Gets or Sets StockExchange
        /// </summary>
        [DataMember(Name="stockExchange")]
        public string StockExchange { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalAccount
        /// </summary>
        [DataMember(Name="principalAccount")]
        public string PrincipalAccount { get; set; }

        /// <summary>
        /// Gets or Sets ClearingAccount
        /// </summary>
        [DataMember(Name="clearingAccount")]
        public string ClearingAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CounterPartyCodeData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PrincipalCode: ").Append(PrincipalCode).Append("\n");
            sb.Append("  PrincipalCodeDtc: ").Append(PrincipalCodeDtc).Append("\n");
            sb.Append("  BloombergCode: ").Append(BloombergCode).Append("\n");
            sb.Append("  StockExchangeId: ").Append(StockExchangeId).Append("\n");
            sb.Append("  BrokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  ClearingCode: ").Append(ClearingCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Broker: ").Append(Broker).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  PrincipalAccount: ").Append(PrincipalAccount).Append("\n");
            sb.Append("  ClearingAccount: ").Append(ClearingAccount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CounterPartyCodeData)obj);
        }

        /// <summary>
        /// Returns true if CounterPartyCodeData instances are equal
        /// </summary>
        /// <param name="other">Instance of CounterPartyCodeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterPartyCodeData other)
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
                    PrincipalCode == other.PrincipalCode ||
                    PrincipalCode != null &&
                    PrincipalCode.Equals(other.PrincipalCode)
                ) && 
                (
                    PrincipalCodeDtc == other.PrincipalCodeDtc ||
                    PrincipalCodeDtc != null &&
                    PrincipalCodeDtc.Equals(other.PrincipalCodeDtc)
                ) && 
                (
                    BloombergCode == other.BloombergCode ||
                    BloombergCode != null &&
                    BloombergCode.Equals(other.BloombergCode)
                ) && 
                (
                    StockExchangeId == other.StockExchangeId ||
                    StockExchangeId != null &&
                    StockExchangeId.Equals(other.StockExchangeId)
                ) && 
                (
                    BrokerId == other.BrokerId ||
                    BrokerId != null &&
                    BrokerId.Equals(other.BrokerId)
                ) && 
                (
                    CountryId == other.CountryId ||
                    CountryId != null &&
                    CountryId.Equals(other.CountryId)
                ) && 
                (
                    ClearingCode == other.ClearingCode ||
                    ClearingCode != null &&
                    ClearingCode.Equals(other.ClearingCode)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                ) && 
                (
                    Broker == other.Broker ||
                    Broker != null &&
                    Broker.Equals(other.Broker)
                ) && 
                (
                    StockExchange == other.StockExchange ||
                    StockExchange != null &&
                    StockExchange.Equals(other.StockExchange)
                ) && 
                (
                    PrincipalAccount == other.PrincipalAccount ||
                    PrincipalAccount != null &&
                    PrincipalAccount.Equals(other.PrincipalAccount)
                ) && 
                (
                    ClearingAccount == other.ClearingAccount ||
                    ClearingAccount != null &&
                    ClearingAccount.Equals(other.ClearingAccount)
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
                    if (PrincipalCode != null)
                    hashCode = hashCode * 59 + PrincipalCode.GetHashCode();
                    if (PrincipalCodeDtc != null)
                    hashCode = hashCode * 59 + PrincipalCodeDtc.GetHashCode();
                    if (BloombergCode != null)
                    hashCode = hashCode * 59 + BloombergCode.GetHashCode();
                    if (StockExchangeId != null)
                    hashCode = hashCode * 59 + StockExchangeId.GetHashCode();
                    if (BrokerId != null)
                    hashCode = hashCode * 59 + BrokerId.GetHashCode();
                    if (CountryId != null)
                    hashCode = hashCode * 59 + CountryId.GetHashCode();
                    if (ClearingCode != null)
                    hashCode = hashCode * 59 + ClearingCode.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                    if (Broker != null)
                    hashCode = hashCode * 59 + Broker.GetHashCode();
                    if (StockExchange != null)
                    hashCode = hashCode * 59 + StockExchange.GetHashCode();
                    if (PrincipalAccount != null)
                    hashCode = hashCode * 59 + PrincipalAccount.GetHashCode();
                    if (ClearingAccount != null)
                    hashCode = hashCode * 59 + ClearingAccount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CounterPartyCodeData left, CounterPartyCodeData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CounterPartyCodeData left, CounterPartyCodeData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
