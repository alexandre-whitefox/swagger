/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.14
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
    public partial class TemplateRequest : IEquatable<TemplateRequest>
    { 
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>

        [DataMember(Name="templateId")]
        public int? TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>

        [DataMember(Name="currencyId")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>

        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRequest {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TemplateRequest)obj);
        }

        /// <summary>
        /// Returns true if TemplateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TemplateId == other.TemplateId ||
                    TemplateId != null &&
                    TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    CurrencyId == other.CurrencyId ||
                    CurrencyId != null &&
                    CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
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
                    if (TemplateId != null)
                    hashCode = hashCode * 59 + TemplateId.GetHashCode();
                    if (CurrencyId != null)
                    hashCode = hashCode * 59 + CurrencyId.GetHashCode();
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TemplateRequest left, TemplateRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemplateRequest left, TemplateRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
