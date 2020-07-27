/*
 * White Fox Lana Api
 *
 * Lana Apis
 *
 * OpenAPI spec version: 1.0.0
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
    public partial class Body : IEquatable<Body>
    { 
        /// <summary>
        /// Gets or Sets UserKey
        /// </summary>
        [DataMember(Name="userKey")]
        public string UserKey { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action")]
        public ActionType? Action { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DashboardUpdatedEnum for dashboardUpdated
            /// </summary>
            [EnumMember(Value = "dashboardUpdated")]
            DashboardUpdatedEnum = 0,
            /// <summary>
            /// Enum UserEffortUpdatedEnum for userEffortUpdated
            /// </summary>
            [EnumMember(Value = "userEffortUpdated")]
            UserEffortUpdatedEnum = 1,
            /// <summary>
            /// Enum TransactionExecutedEnum for transactionExecuted
            /// </summary>
            [EnumMember(Value = "transactionExecuted")]
            TransactionExecutedEnum = 2        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  UserKey: ").Append(UserKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Body)obj);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserKey == other.UserKey ||
                    UserKey != null &&
                    UserKey.Equals(other.UserKey)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Entity == other.Entity ||
                    Entity != null &&
                    Entity.Equals(other.Entity)
                ) && 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
                ) && 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
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
                    if (UserKey != null)
                    hashCode = hashCode * 59 + UserKey.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Entity != null)
                    hashCode = hashCode * 59 + Entity.GetHashCode();
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Body left, Body right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Body left, Body right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
