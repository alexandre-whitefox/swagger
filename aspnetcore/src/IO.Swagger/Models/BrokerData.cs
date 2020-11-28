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
    public partial class BrokerData : IEquatable<BrokerData>
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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets BrokerageType
        /// </summary>
        [DataMember(Name="brokerageType")]
        public IdN BrokerageType { get; set; }

        /// <summary>
        /// Gets or Sets StockExchange
        /// </summary>
        [DataMember(Name="stockExchange")]
        public IdN StockExchange { get; set; }

        /// <summary>
        /// Gets or Sets Brokerage
        /// </summary>
        [DataMember(Name="brokerage")]
        public double? Brokerage { get; set; }

        /// <summary>
        /// Gets or Sets SignificantDigits
        /// </summary>
        [DataMember(Name="significantDigits")]
        public int? SignificantDigits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrokerData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  BrokerageType: ").Append(BrokerageType).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  Brokerage: ").Append(Brokerage).Append("\n");
            sb.Append("  SignificantDigits: ").Append(SignificantDigits).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrokerData)obj);
        }

        /// <summary>
        /// Returns true if BrokerData instances are equal
        /// </summary>
        /// <param name="other">Instance of BrokerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerData other)
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
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    BrokerageType == other.BrokerageType ||
                    BrokerageType != null &&
                    BrokerageType.Equals(other.BrokerageType)
                ) && 
                (
                    StockExchange == other.StockExchange ||
                    StockExchange != null &&
                    StockExchange.Equals(other.StockExchange)
                ) && 
                (
                    Brokerage == other.Brokerage ||
                    Brokerage != null &&
                    Brokerage.Equals(other.Brokerage)
                ) && 
                (
                    SignificantDigits == other.SignificantDigits ||
                    SignificantDigits != null &&
                    SignificantDigits.Equals(other.SignificantDigits)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (BrokerageType != null)
                    hashCode = hashCode * 59 + BrokerageType.GetHashCode();
                    if (StockExchange != null)
                    hashCode = hashCode * 59 + StockExchange.GetHashCode();
                    if (Brokerage != null)
                    hashCode = hashCode * 59 + Brokerage.GetHashCode();
                    if (SignificantDigits != null)
                    hashCode = hashCode * 59 + SignificantDigits.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrokerData left, BrokerData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrokerData left, BrokerData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
