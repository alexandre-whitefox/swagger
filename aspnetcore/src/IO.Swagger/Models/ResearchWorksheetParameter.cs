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
    public partial class ResearchWorksheetParameter : IEquatable<ResearchWorksheetParameter>
    { 
        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>

        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>

        [DataMember(Name="template")]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>

        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>

        [DataMember(Name="data")]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResearchWorksheetParameter {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResearchWorksheetParameter)obj);
        }

        /// <summary>
        /// Returns true if ResearchWorksheetParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of ResearchWorksheetParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResearchWorksheetParameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
                ) && 
                (
                    Template == other.Template ||
                    Template != null &&
                    Template.Equals(other.Template)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
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
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                    if (Template != null)
                    hashCode = hashCode * 59 + Template.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ResearchWorksheetParameter left, ResearchWorksheetParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResearchWorksheetParameter left, ResearchWorksheetParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
