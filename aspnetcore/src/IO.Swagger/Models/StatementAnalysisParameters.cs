/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.1
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
    public partial class StatementAnalysisParameters : IEquatable<StatementAnalysisParameters>
    { 
        /// <summary>
        /// Gets or Sets SecurityId
        /// </summary>
        [DataMember(Name="securityId")]
        public int? SecurityId { get; set; }

        /// <summary>
        /// Gets or Sets StatementId
        /// </summary>
        [DataMember(Name="statementId")]
        public int? StatementId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementAnalysisParameters {\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  StatementId: ").Append(StatementId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StatementAnalysisParameters)obj);
        }

        /// <summary>
        /// Returns true if StatementAnalysisParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of StatementAnalysisParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementAnalysisParameters other)
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
                    StatementId == other.StatementId ||
                    StatementId != null &&
                    StatementId.Equals(other.StatementId)
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
                    if (StatementId != null)
                    hashCode = hashCode * 59 + StatementId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StatementAnalysisParameters left, StatementAnalysisParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StatementAnalysisParameters left, StatementAnalysisParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
