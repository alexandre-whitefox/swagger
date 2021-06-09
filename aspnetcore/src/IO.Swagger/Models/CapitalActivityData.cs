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
    public partial class CapitalActivityData : IEquatable<CapitalActivityData>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets InvestimentCode
        /// </summary>
        [DataMember(Name="investimentCode")]
        public int? InvestimentCode { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Factor
        /// </summary>
        [DataMember(Name="factor")]
        public double? Factor { get; set; }

        /// <summary>
        /// Gets or Sets ShareClassId
        /// </summary>
        [DataMember(Name="shareClassId")]
        public int? ShareClassId { get; set; }

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
            sb.Append("class CapitalActivityData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvestimentCode: ").Append(InvestimentCode).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  ShareClassId: ").Append(ShareClassId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CapitalActivityData)obj);
        }

        /// <summary>
        /// Returns true if CapitalActivityData instances are equal
        /// </summary>
        /// <param name="other">Instance of CapitalActivityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapitalActivityData other)
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
                    InvestimentCode == other.InvestimentCode ||
                    InvestimentCode != null &&
                    InvestimentCode.Equals(other.InvestimentCode)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    Factor == other.Factor ||
                    Factor != null &&
                    Factor.Equals(other.Factor)
                ) && 
                (
                    ShareClassId == other.ShareClassId ||
                    ShareClassId != null &&
                    ShareClassId.Equals(other.ShareClassId)
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
                    if (InvestimentCode != null)
                    hashCode = hashCode * 59 + InvestimentCode.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (Factor != null)
                    hashCode = hashCode * 59 + Factor.GetHashCode();
                    if (ShareClassId != null)
                    hashCode = hashCode * 59 + ShareClassId.GetHashCode();
                    if (FundId != null)
                    hashCode = hashCode * 59 + FundId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CapitalActivityData left, CapitalActivityData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CapitalActivityData left, CapitalActivityData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
