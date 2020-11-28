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
    public partial class StatementYearRefTickerDateParameter : IEquatable<StatementYearRefTickerDateParameter>
    { 
        /// <summary>
        /// Gets or Sets SecurityId
        /// </summary>
        [DataMember(Name="securityId")]
        public int? SecurityId { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Usd
        /// </summary>
        [DataMember(Name="usd")]
        public int? Usd { get; set; }

        /// <summary>
        /// Gets or Sets NoUsdRateValue
        /// </summary>
        [DataMember(Name="noUsdRateValue")]
        public int? NoUsdRateValue { get; set; }

        /// <summary>
        /// Gets or Sets StatementId
        /// </summary>
        [DataMember(Name="statementId")]
        public int? StatementId { get; set; }

        /// <summary>
        /// Gets or Sets Statement
        /// </summary>
        [DataMember(Name="statement")]
        public string Statement { get; set; }

        /// <summary>
        /// Gets or Sets YearRef
        /// </summary>
        [DataMember(Name="yearRef")]
        public int? YearRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementYearRefTickerDateParameter {\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Usd: ").Append(Usd).Append("\n");
            sb.Append("  NoUsdRateValue: ").Append(NoUsdRateValue).Append("\n");
            sb.Append("  StatementId: ").Append(StatementId).Append("\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
            sb.Append("  YearRef: ").Append(YearRef).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StatementYearRefTickerDateParameter)obj);
        }

        /// <summary>
        /// Returns true if StatementYearRefTickerDateParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of StatementYearRefTickerDateParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementYearRefTickerDateParameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SecurityId == other.SecurityId ||
                    SecurityId != null &&
                    SecurityId.Equals(other.SecurityId)
                ) && 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Usd == other.Usd ||
                    Usd != null &&
                    Usd.Equals(other.Usd)
                ) && 
                (
                    NoUsdRateValue == other.NoUsdRateValue ||
                    NoUsdRateValue != null &&
                    NoUsdRateValue.Equals(other.NoUsdRateValue)
                ) && 
                (
                    StatementId == other.StatementId ||
                    StatementId != null &&
                    StatementId.Equals(other.StatementId)
                ) && 
                (
                    Statement == other.Statement ||
                    Statement != null &&
                    Statement.Equals(other.Statement)
                ) && 
                (
                    YearRef == other.YearRef ||
                    YearRef != null &&
                    YearRef.Equals(other.YearRef)
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
                    if (SecurityId != null)
                    hashCode = hashCode * 59 + SecurityId.GetHashCode();
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Usd != null)
                    hashCode = hashCode * 59 + Usd.GetHashCode();
                    if (NoUsdRateValue != null)
                    hashCode = hashCode * 59 + NoUsdRateValue.GetHashCode();
                    if (StatementId != null)
                    hashCode = hashCode * 59 + StatementId.GetHashCode();
                    if (Statement != null)
                    hashCode = hashCode * 59 + Statement.GetHashCode();
                    if (YearRef != null)
                    hashCode = hashCode * 59 + YearRef.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StatementYearRefTickerDateParameter left, StatementYearRefTickerDateParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StatementYearRefTickerDateParameter left, StatementYearRefTickerDateParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
