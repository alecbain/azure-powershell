// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// This activity executes inner activities until the specified boolean
    /// expression results to true or timeout is reached, whichever is earlier.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Until")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class UntilActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the UntilActivity class.
        /// </summary>
        public UntilActivity()
        {
            this.Expression = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UntilActivity class.
        /// </summary>

        /// <param name="additionalProperties">A pipeline activity.
        /// </param>

        /// <param name="name">Activity name.
        /// </param>

        /// <param name="description">Activity description.
        /// </param>

        /// <param name="state">Activity state. This is an optional property and if not provided, the state
        /// will be Active by default.
        /// Possible values include: &#39;Active&#39;, &#39;Inactive&#39;</param>

        /// <param name="onInactiveMarkAs">Status result of the activity when the state is set to Inactive. This is an
        /// optional property and if not provided when the activity is inactive, the
        /// status will be Succeeded by default.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Skipped&#39;</param>

        /// <param name="dependsOn">Activity depends on condition.
        /// </param>

        /// <param name="userProperties">Activity user properties.
        /// </param>

        /// <param name="expression">An expression that would evaluate to Boolean. The loop will continue until
        /// this expression evaluates to true
        /// </param>

        /// <param name="timeout">Specifies the timeout for the activity to run. If there is no value
        /// specified, it takes the value of TimeSpan.FromDays(7) which is 1 week as
        /// default. Type: string (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="activities">List of activities to execute.
        /// </param>
        public UntilActivity(string name, Expression expression, System.Collections.Generic.IList<Activity> activities, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), System.Collections.Generic.IList<ActivityDependency> dependsOn = default(System.Collections.Generic.IList<ActivityDependency>), System.Collections.Generic.IList<UserProperty> userProperties = default(System.Collections.Generic.IList<UserProperty>), object timeout = default(object))

        : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties)
        {
            this.Expression = expression;
            this.Timeout = timeout;
            this.Activities = activities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets an expression that would evaluate to Boolean. The loop will
        /// continue until this expression evaluates to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.expression")]
        public Expression Expression {get; set; }

        /// <summary>
        /// Gets or sets specifies the timeout for the activity to run. If there is no
        /// value specified, it takes the value of TimeSpan.FromDays(7) which is 1 week
        /// as default. Type: string (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.timeout")]
        public object Timeout {get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.activities")]
        public System.Collections.Generic.IList<Activity> Activities {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Expression == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Expression");
            }
            if (this.Activities == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Activities");
            }
            if (this.Expression != null)
            {
                this.Expression.Validate();
            }

            if (this.Activities != null)
            {
                foreach (var element in this.Activities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}