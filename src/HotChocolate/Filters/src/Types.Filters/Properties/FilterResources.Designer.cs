﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Types.Filters.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FilterResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FilterResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Types.Filters.Properties.FilterResources", typeof(FilterResources).Assembly);
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
        ///   Looks up a localized string similar to Cannot handle the specified type..
        /// </summary>
        internal static string FilterArrayFieldDescriptor_InvalidType {
            get {
                return ResourceManager.GetString("FilterArrayFieldDescriptor_InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation descriptor type {0} does not match the requested type {1}..
        /// </summary>
        internal static string FilterFieldOperationDescriptor_InvalidDescriptorType {
            get {
                return ResourceManager.GetString("FilterFieldOperationDescriptor_InvalidDescriptorType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only properties are allowed for input types..
        /// </summary>
        internal static string FilterInputTypeDescriptor_OnlyProperties {
            get {
                return ResourceManager.GetString("FilterInputTypeDescriptor_OnlyProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot handle the specified type..
        /// </summary>
        internal static string FilterObjectFieldDescriptor_InvalidType {
            get {
                return ResourceManager.GetString("FilterObjectFieldDescriptor_InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filter type cannot be infered from `System.Object`..
        /// </summary>
        internal static string FilterObjectFieldDescriptor_InvalidType_Msg {
            get {
                return ResourceManager.GetString("FilterObjectFieldDescriptor_InvalidType_Msg", resourceCulture);
            }
        }
    }
}
