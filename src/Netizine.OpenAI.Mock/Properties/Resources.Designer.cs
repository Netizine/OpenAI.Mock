//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenAI.Mock.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenAI.Mock.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;id&quot;: &quot;ft-xhrpBbvVUzYGo8oUO1FY4nI7&quot;,
        ///	&quot;object&quot;: &quot;fine-tune&quot;,
        ///	&quot;model&quot;: &quot;curie&quot;,
        ///	&quot;created_at&quot;: 1614807770,
        ///	&quot;events&quot;: [
        ///		{}
        ///	],
        ///	&quot;fine_tuned_model&quot;: null,
        ///	&quot;hyperparams&quot;: {},
        ///	&quot;organization_id&quot;: &quot;org-...&quot;,
        ///	&quot;result_files&quot;: [],
        ///	&quot;status&quot;: &quot;cancelled&quot;,
        ///	&quot;validation_files&quot;: [],
        ///	&quot;training_files&quot;: [
        ///		{
        ///			&quot;id&quot;: &quot;file-XGinujblHPwGLSztz8cPS8XY&quot;,
        ///			&quot;object&quot;: &quot;file&quot;,
        ///			&quot;bytes&quot;: 1547276,
        ///			&quot;created_at&quot;: 1610062281,
        ///			&quot;filename&quot;: &quot;my-data-train.jsonl&quot;,
        ///			&quot;purpose&quot;: &quot;fine-tune-train&quot;
        ///		 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultCancelFineTuneResponse {
            get {
                return ResourceManager.GetString("DefaultCancelFineTuneResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;object&quot;: &quot;list&quot;,
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;object&quot;: &quot;embedding&quot;,
        ///      &quot;index&quot;: 0,
        ///      &quot;embedding&quot;: [
        ///        0.0028667077,
        ///        0.018867997,
        ///        -0.030135695,
        ///        -0.004034549,
        ///        0.024676088,
        ///        -0.0030139843,
        ///        -0.012645043,
        ///        0.0063681565,
        ///        0.007314046,
        ///        -0.021091666,
        ///        -0.004127893,
        ///        0.019979833,
        ///        0.020792965,
        ///        0.030384613,
        ///        0.01447874,
        ///        -0.013682202,
        ///        -0.007085871,
        ///        -0.02 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultEmbeddingsJson {
            get {
                return ResourceManager.GetString("DefaultEmbeddingsJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;id&quot;: &quot;file-ccdDZrC3iZVNiQVeEA6Z66wf&quot;,
        ///      &quot;object&quot;: &quot;file&quot;,
        ///      &quot;bytes&quot;: 175,
        ///      &quot;created_at&quot;: 1613677385,
        ///	  &quot;status&quot;: &quot;processed&quot;,
        ///      &quot;filename&quot;: &quot;train.jsonl&quot;,
        ///      &quot;purpose&quot;: &quot;search&quot;
        ///    },
        ///    {
        ///      &quot;id&quot;: &quot;file-XjGxS3KTG0uNmNOK362iJua3&quot;,
        ///      &quot;object&quot;: &quot;file&quot;,
        ///      &quot;bytes&quot;: 140,
        ///      &quot;created_at&quot;: 1613779121,
        ///	  &quot;status&quot;: &quot;processed&quot;,
        ///      &quot;filename&quot;: &quot;puppy.jsonl&quot;,
        ///      &quot;purpose&quot;: &quot;search&quot;
        ///    }
        ///  ],
        ///  &quot;object&quot;: &quot;list&quot;
        ///}.
        /// </summary>
        internal static string DefaultFilesJson {
            get {
                return ResourceManager.GetString("DefaultFilesJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;object&quot;: &quot;list&quot;,
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;object&quot;: &quot;fine-tune-event&quot;,
        ///      &quot;created_at&quot;: 1614807352,
        ///      &quot;level&quot;: &quot;info&quot;,
        ///      &quot;message&quot;: &quot;Job enqueued. Waiting for jobs ahead to complete. Queue number: 0.&quot;
        ///    },
        ///    {
        ///      &quot;object&quot;: &quot;fine-tune-event&quot;,
        ///      &quot;created_at&quot;: 1614807356,
        ///      &quot;level&quot;: &quot;info&quot;,
        ///      &quot;message&quot;: &quot;Job started.&quot;
        ///    },
        ///    {
        ///      &quot;object&quot;: &quot;fine-tune-event&quot;,
        ///      &quot;created_at&quot;: 1614807861,
        ///      &quot;level&quot;: &quot;info&quot;,
        ///      &quot;message&quot;: &quot;Uploaded snapshot: cu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultFineTuneEventsResponse {
            get {
                return ResourceManager.GetString("DefaultFineTuneEventsResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;object&quot;: &quot;list&quot;,
        ///	&quot;data&quot;: [
        ///		{
        ///			&quot;object&quot;: &quot;fine-tune&quot;,
        ///			&quot;id&quot;: &quot;ft-Z4ci33sHCHpDpm72YNqDhanJ&quot;,
        ///			&quot;hyperparams&quot;: {
        ///				&quot;n_epochs&quot;: 4,
        ///				&quot;batch_size&quot;: null,
        ///				&quot;prompt_loss_weight&quot;: 0.01,
        ///				&quot;learning_rate_multiplier&quot;: null
        ///			},
        ///			&quot;organization_id&quot;: &quot;org-iWOFXcZRTmmvaXG4CNW8JnAF&quot;,
        ///			&quot;model&quot;: &quot;curie&quot;,
        ///			&quot;training_files&quot;: [
        ///				{
        ///					&quot;object&quot;: &quot;file&quot;,
        ///					&quot;id&quot;: &quot;file-1ts0lcqQNyLKepAFEJUISevZ&quot;,
        ///					&quot;purpose&quot;: &quot;fine-tune&quot;,
        ///					&quot;filename&quot;: &quot;gpt3_train.jsonl&quot;,
        ///					&quot;bytes&quot;: 7 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultFineTuneListResponse {
            get {
                return ResourceManager.GetString("DefaultFineTuneListResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;id&quot;: &quot;ft-AF1WoRqd3aJAHsqc9NY7iL8F&quot;,
        ///	&quot;object&quot;: &quot;fine-tune&quot;,
        ///	&quot;model&quot;: &quot;curie&quot;,
        ///	&quot;created_at&quot;: 1614807352,
        ///	&quot;events&quot;: [
        ///		{
        ///			&quot;object&quot;: &quot;fine-tune-event&quot;,
        ///			&quot;created_at&quot;: 1614807352,
        ///			&quot;level&quot;: &quot;info&quot;,
        ///			&quot;message&quot;: &quot;Job enqueued. Waiting for jobs ahead to complete. Queue number: 0.&quot;
        ///		}
        ///	],
        ///	&quot;fine_tuned_model&quot;: null,
        ///	&quot;hyperparams&quot;: {
        ///		&quot;batch_size&quot;: 4,
        ///		&quot;learning_rate_multiplier&quot;: 0.1,
        ///		&quot;n_epochs&quot;: 4,
        ///		&quot;prompt_loss_weight&quot;: 0.1
        ///	},
        ///	&quot;organization_id&quot;: &quot;org-...&quot;,
        ///	&quot;result_file [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultFineTuningJson {
            get {
                return ResourceManager.GetString("DefaultFineTuningJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;id&quot;: &quot;ft-AF1WoRqd3aJAHsqc9NY7iL8F&quot;,
        ///	&quot;object&quot;: &quot;fine-tune&quot;,
        ///	&quot;model&quot;: &quot;curie&quot;,
        ///	&quot;created_at&quot;: 1614807352,
        ///	&quot;events&quot;: [
        ///		{
        ///			&quot;object&quot;: &quot;fine-tune-event&quot;,
        ///			&quot;created_at&quot;: 1614807352,
        ///			&quot;level&quot;: &quot;info&quot;,
        ///			&quot;message&quot;: &quot;Job enqueued. Waiting for jobs ahead to complete. Queue number: 0.&quot;
        ///		},
        ///		{
        ///			&quot;object&quot;: &quot;fine-tune-event&quot;,
        ///			&quot;created_at&quot;: 1614807356,
        ///			&quot;level&quot;: &quot;info&quot;,
        ///			&quot;message&quot;: &quot;Job started.&quot;
        ///		},
        ///		{
        ///			&quot;object&quot;: &quot;fine-tune-event&quot;,
        ///			&quot;created_at&quot;: 1614807861,
        ///			&quot;level&quot;: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultFineTuningResponse {
            get {
                return ResourceManager.GetString("DefaultFineTuningResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;object&quot;: &quot;list&quot;,
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;object&quot;: &quot;fine-tune&quot;,
        ///      &quot;id&quot;: &quot;ft-Z4ci33sHCHpDpm72YNqDhanJ&quot;,
        ///      &quot;hyperparams&quot;: {
        ///        &quot;n_epochs&quot;: 4,
        ///        &quot;batch_size&quot;: null,
        ///        &quot;prompt_loss_weight&quot;: 0.01,
        ///        &quot;learning_rate_multiplier&quot;: null
        ///      },
        ///      &quot;organization_id&quot;: &quot;org-iWOFXcZRTmmvaXG4CNW8JnAF&quot;,
        ///      &quot;model&quot;: &quot;curie&quot;,
        ///      &quot;training_files&quot;: [
        ///        {
        ///          &quot;object&quot;: &quot;file&quot;,
        ///          &quot;id&quot;: &quot;file-1ts0lcqQNyLKepAFEJUISevZ&quot;,
        ///          &quot;purpose&quot;: &quot;fine-t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultListFineTuningEventsJson {
            get {
                return ResourceManager.GetString("DefaultListFineTuningEventsJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;object&quot;: &quot;list&quot;,
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;id&quot;: &quot;babbage&quot;,
        ///      &quot;object&quot;: &quot;model&quot;,
        ///      &quot;created&quot;: 1649358449,
        ///      &quot;owned_by&quot;: &quot;openai&quot;,
        ///      &quot;permission&quot;: [
        ///        {
        ///          &quot;id&quot;: &quot;modelperm-49FUp5v084tBB49tC4z8LPH5&quot;,
        ///          &quot;object&quot;: &quot;model_permission&quot;,
        ///          &quot;created&quot;: 1669085501,
        ///          &quot;allow_create_engine&quot;: false,
        ///          &quot;allow_sampling&quot;: true,
        ///          &quot;allow_logprobs&quot;: true,
        ///          &quot;allow_search_indices&quot;: false,
        ///          &quot;allow_view&quot;: true,
        ///          &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultModelJson {
            get {
                return ResourceManager.GetString("DefaultModelJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;id&quot;: &quot;modr-6XtvDvY1WSQRW0IMMW2WvY0730k1X&quot;,
        ///  &quot;model&quot;: &quot;text-moderation-004&quot;,
        ///  &quot;results&quot;: [
        ///    {
        ///      &quot;categories&quot;: {
        ///        &quot;hate&quot;: false,
        ///        &quot;hate/threatening&quot;: false,
        ///        &quot;self-harm&quot;: false,
        ///        &quot;sexual&quot;: false,
        ///        &quot;sexual/minors&quot;: false,
        ///        &quot;violence&quot;: true,
        ///        &quot;violence/graphic&quot;: false
        ///      },
        ///      &quot;category_scores&quot;: {
        ///        &quot;hate&quot;: 0.18252533674240112,
        ///        &quot;hate/threatening&quot;: 0.0032941880635917187,
        ///        &quot;self-harm&quot;: 1.9077321944394043e-09 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultModerationResponse {
            get {
                return ResourceManager.GetString("DefaultModerationResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ImageOne {
            get {
                object obj = ResourceManager.GetObject("ImageOne", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ImageTwo {
            get {
                object obj = ResourceManager.GetObject("ImageTwo", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] OtterResponseOne {
            get {
                object obj = ResourceManager.GetObject("OtterResponseOne", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] OtterResponseTwo {
            get {
                object obj = ResourceManager.GetObject("OtterResponseTwo", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Sample {
            get {
                object obj = ResourceManager.GetObject("Sample", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
