/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.19
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
    public partial class LoanData : IEquatable<LoanData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>

        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>

        [DataMember(Name="rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Gets or Sets TradeDate
        /// </summary>

        [DataMember(Name="tradeDate")]
        public DateTime? TradeDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>

        [DataMember(Name="expiryDate")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets BrokerId
        /// </summary>

        [DataMember(Name="brokerId")]
        public int? BrokerId { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>

        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets RolloverNumber
        /// </summary>

        [DataMember(Name="rolloverNumber")]
        public long? RolloverNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BrokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  RolloverNumber: ").Append(RolloverNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoanData)obj);
        }

        /// <summary>
        /// Returns true if LoanData instances are equal
        /// </summary>
        /// <param name="other">Instance of LoanData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanData other)
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
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Rate == other.Rate ||
                    Rate != null &&
                    Rate.Equals(other.Rate)
                ) && 
                (
                    TradeDate == other.TradeDate ||
                    TradeDate != null &&
                    TradeDate.Equals(other.TradeDate)
                ) && 
                (
                    ExpiryDate == other.ExpiryDate ||
                    ExpiryDate != null &&
                    ExpiryDate.Equals(other.ExpiryDate)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    BrokerId == other.BrokerId ||
                    BrokerId != null &&
                    BrokerId.Equals(other.BrokerId)
                ) && 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
                ) && 
                (
                    RolloverNumber == other.RolloverNumber ||
                    RolloverNumber != null &&
                    RolloverNumber.Equals(other.RolloverNumber)
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
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (Rate != null)
                    hashCode = hashCode * 59 + Rate.GetHashCode();
                    if (TradeDate != null)
                    hashCode = hashCode * 59 + TradeDate.GetHashCode();
                    if (ExpiryDate != null)
                    hashCode = hashCode * 59 + ExpiryDate.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (BrokerId != null)
                    hashCode = hashCode * 59 + BrokerId.GetHashCode();
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                    if (RolloverNumber != null)
                    hashCode = hashCode * 59 + RolloverNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoanData left, LoanData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoanData left, LoanData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
