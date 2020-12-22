/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.4
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
    public partial class ActivityRequest : IEquatable<ActivityRequest>
    { 
        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name="actionId")]
        public int? ActionId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Date2
        /// </summary>
        [DataMember(Name="date2")]
        public string Date2 { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name="ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets Months
        /// </summary>
        [DataMember(Name="months")]
        public int? Months { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityRequest {\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Date2: ").Append(Date2).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActivityRequest)obj);
        }

        /// <summary>
        /// Returns true if ActivityRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ActionId == other.ActionId ||
                    ActionId != null &&
                    ActionId.Equals(other.ActionId)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Date2 == other.Date2 ||
                    Date2 != null &&
                    Date2.Equals(other.Date2)
                ) && 
                (
                    Ticker == other.Ticker ||
                    Ticker != null &&
                    Ticker.Equals(other.Ticker)
                ) && 
                (
                    Months == other.Months ||
                    Months != null &&
                    Months.Equals(other.Months)
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
                    if (ActionId != null)
                    hashCode = hashCode * 59 + ActionId.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Date2 != null)
                    hashCode = hashCode * 59 + Date2.GetHashCode();
                    if (Ticker != null)
                    hashCode = hashCode * 59 + Ticker.GetHashCode();
                    if (Months != null)
                    hashCode = hashCode * 59 + Months.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActivityRequest left, ActivityRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivityRequest left, ActivityRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
