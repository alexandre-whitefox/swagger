/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.10
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
    public partial class TradeData : IEquatable<TradeData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>

        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>

        [DataMember(Name="settlementDate")]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>

        [DataMember(Name="quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>

        [DataMember(Name="price")]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets TotalFee
        /// </summary>

        [DataMember(Name="totalFee")]
        public double? TotalFee { get; set; }

        /// <summary>
        /// Gets or Sets TotalBrokerage
        /// </summary>

        [DataMember(Name="totalBrokerage")]
        public double? TotalBrokerage { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>

        [DataMember(Name="security")]
        public string Security { get; set; }

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
        /// Gets or Sets MemberId
        /// </summary>

        [DataMember(Name="memberId")]
        public int? MemberId { get; set; }

        /// <summary>
        /// Gets or Sets FxType
        /// </summary>

        [DataMember(Name="fxType")]
        public int? FxType { get; set; }

        /// <summary>
        /// Gets or Sets Integrated
        /// </summary>

        [DataMember(Name="integrated")]
        public bool? Integrated { get; set; }

        /// <summary>
        /// Gets or Sets Canceling
        /// </summary>

        [DataMember(Name="canceling")]
        public bool? Canceling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TotalFee: ").Append(TotalFee).Append("\n");
            sb.Append("  TotalBrokerage: ").Append(TotalBrokerage).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  StockExchangeId: ").Append(StockExchangeId).Append("\n");
            sb.Append("  BrokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  FxType: ").Append(FxType).Append("\n");
            sb.Append("  Integrated: ").Append(Integrated).Append("\n");
            sb.Append("  Canceling: ").Append(Canceling).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TradeData)obj);
        }

        /// <summary>
        /// Returns true if TradeData instances are equal
        /// </summary>
        /// <param name="other">Instance of TradeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeData other)
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
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    SettlementDate == other.SettlementDate ||
                    SettlementDate != null &&
                    SettlementDate.Equals(other.SettlementDate)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
                ) && 
                (
                    TotalFee == other.TotalFee ||
                    TotalFee != null &&
                    TotalFee.Equals(other.TotalFee)
                ) && 
                (
                    TotalBrokerage == other.TotalBrokerage ||
                    TotalBrokerage != null &&
                    TotalBrokerage.Equals(other.TotalBrokerage)
                ) && 
                (
                    Security == other.Security ||
                    Security != null &&
                    Security.Equals(other.Security)
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
                    MemberId == other.MemberId ||
                    MemberId != null &&
                    MemberId.Equals(other.MemberId)
                ) && 
                (
                    FxType == other.FxType ||
                    FxType != null &&
                    FxType.Equals(other.FxType)
                ) && 
                (
                    Integrated == other.Integrated ||
                    Integrated != null &&
                    Integrated.Equals(other.Integrated)
                ) && 
                (
                    Canceling == other.Canceling ||
                    Canceling != null &&
                    Canceling.Equals(other.Canceling)
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
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (SettlementDate != null)
                    hashCode = hashCode * 59 + SettlementDate.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (TotalFee != null)
                    hashCode = hashCode * 59 + TotalFee.GetHashCode();
                    if (TotalBrokerage != null)
                    hashCode = hashCode * 59 + TotalBrokerage.GetHashCode();
                    if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
                    if (StockExchangeId != null)
                    hashCode = hashCode * 59 + StockExchangeId.GetHashCode();
                    if (BrokerId != null)
                    hashCode = hashCode * 59 + BrokerId.GetHashCode();
                    if (MemberId != null)
                    hashCode = hashCode * 59 + MemberId.GetHashCode();
                    if (FxType != null)
                    hashCode = hashCode * 59 + FxType.GetHashCode();
                    if (Integrated != null)
                    hashCode = hashCode * 59 + Integrated.GetHashCode();
                    if (Canceling != null)
                    hashCode = hashCode * 59 + Canceling.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TradeData left, TradeData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TradeData left, TradeData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
