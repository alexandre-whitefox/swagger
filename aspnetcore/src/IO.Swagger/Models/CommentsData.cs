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
    public partial class CommentsData : IEquatable<CommentsData>
    { 
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name="tradeId")]
        public int? TradeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentsData {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommentsData)obj);
        }

        /// <summary>
        /// Returns true if CommentsData instances are equal
        /// </summary>
        /// <param name="other">Instance of CommentsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentsData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    TradeId == other.TradeId ||
                    TradeId != null &&
                    TradeId.Equals(other.TradeId)
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
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (TradeId != null)
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommentsData left, CommentsData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommentsData left, CommentsData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
