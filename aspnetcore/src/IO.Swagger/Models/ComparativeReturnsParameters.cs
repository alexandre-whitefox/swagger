/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.23
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
    public partial class ComparativeReturnsParameters : IEquatable<ComparativeReturnsParameters>
    { 
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>

        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>

        [DataMember(Name="endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Months
        /// </summary>

        [DataMember(Name="months")]
        public bool? Months { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>

        [DataMember(Name="currencyId")]
        public decimal? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Variable1
        /// </summary>

        [DataMember(Name="variable1")]
        public decimal? Variable1 { get; set; }

        /// <summary>
        /// Gets or Sets Variable2
        /// </summary>

        [DataMember(Name="variable2")]
        public decimal? Variable2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComparativeReturnsParameters {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Variable1: ").Append(Variable1).Append("\n");
            sb.Append("  Variable2: ").Append(Variable2).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ComparativeReturnsParameters)obj);
        }

        /// <summary>
        /// Returns true if ComparativeReturnsParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of ComparativeReturnsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComparativeReturnsParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    Months == other.Months ||
                    Months != null &&
                    Months.Equals(other.Months)
                ) && 
                (
                    CurrencyId == other.CurrencyId ||
                    CurrencyId != null &&
                    CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    Variable1 == other.Variable1 ||
                    Variable1 != null &&
                    Variable1.Equals(other.Variable1)
                ) && 
                (
                    Variable2 == other.Variable2 ||
                    Variable2 != null &&
                    Variable2.Equals(other.Variable2)
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
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (Months != null)
                    hashCode = hashCode * 59 + Months.GetHashCode();
                    if (CurrencyId != null)
                    hashCode = hashCode * 59 + CurrencyId.GetHashCode();
                    if (Variable1 != null)
                    hashCode = hashCode * 59 + Variable1.GetHashCode();
                    if (Variable2 != null)
                    hashCode = hashCode * 59 + Variable2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ComparativeReturnsParameters left, ComparativeReturnsParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ComparativeReturnsParameters left, ComparativeReturnsParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}