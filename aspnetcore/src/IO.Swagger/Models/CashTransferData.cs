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
    public partial class CashTransferData : IEquatable<CashTransferData>
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
        /// Gets or Sets BuyValue
        /// </summary>

        [DataMember(Name="buyValue")]
        public double? BuyValue { get; set; }

        /// <summary>
        /// Gets or Sets SellValue
        /// </summary>

        [DataMember(Name="sellValue")]
        public double? SellValue { get; set; }

        /// <summary>
        /// Gets or Sets BuyAccountId
        /// </summary>

        [DataMember(Name="buyAccountId")]
        public int? BuyAccountId { get; set; }

        /// <summary>
        /// Gets or Sets SellAccountId
        /// </summary>

        [DataMember(Name="sellAccountId")]
        public int? SellAccountId { get; set; }

        /// <summary>
        /// Gets or Sets FundId
        /// </summary>

        [DataMember(Name="fundId")]
        public int? FundId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashTransferData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  BuyValue: ").Append(BuyValue).Append("\n");
            sb.Append("  SellValue: ").Append(SellValue).Append("\n");
            sb.Append("  BuyAccountId: ").Append(BuyAccountId).Append("\n");
            sb.Append("  SellAccountId: ").Append(SellAccountId).Append("\n");
            sb.Append("  FundId: ").Append(FundId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CashTransferData)obj);
        }

        /// <summary>
        /// Returns true if CashTransferData instances are equal
        /// </summary>
        /// <param name="other">Instance of CashTransferData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashTransferData other)
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
                    BuyValue == other.BuyValue ||
                    BuyValue != null &&
                    BuyValue.Equals(other.BuyValue)
                ) && 
                (
                    SellValue == other.SellValue ||
                    SellValue != null &&
                    SellValue.Equals(other.SellValue)
                ) && 
                (
                    BuyAccountId == other.BuyAccountId ||
                    BuyAccountId != null &&
                    BuyAccountId.Equals(other.BuyAccountId)
                ) && 
                (
                    SellAccountId == other.SellAccountId ||
                    SellAccountId != null &&
                    SellAccountId.Equals(other.SellAccountId)
                ) && 
                (
                    FundId == other.FundId ||
                    FundId != null &&
                    FundId.Equals(other.FundId)
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
                    if (BuyValue != null)
                    hashCode = hashCode * 59 + BuyValue.GetHashCode();
                    if (SellValue != null)
                    hashCode = hashCode * 59 + SellValue.GetHashCode();
                    if (BuyAccountId != null)
                    hashCode = hashCode * 59 + BuyAccountId.GetHashCode();
                    if (SellAccountId != null)
                    hashCode = hashCode * 59 + SellAccountId.GetHashCode();
                    if (FundId != null)
                    hashCode = hashCode * 59 + FundId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CashTransferData left, CashTransferData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CashTransferData left, CashTransferData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
