﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotvvmAcademy.Steps {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Texts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Texts() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotvvmAcademy.Steps.Texts", typeof(Texts).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} property {1} must contain binding in the following format: {{command: Something()}}.
        /// </summary>
        public static string CommandBindingExpected {
            get {
                return ResourceManager.GetString("CommandBindingExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The constructor of type {0} is not allowed!.
        /// </summary>
        public static string IllegalConstructorCall {
            get {
                return ResourceManager.GetString("IllegalConstructorCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The method {0} is not allowed!.
        /// </summary>
        public static string IllegalMethodCall {
            get {
                return ResourceManager.GetString("IllegalMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} doesn&apos;t specify the {1} property!.
        /// </summary>
        public static string MissingPropertyError {
            get {
                return ResourceManager.GetString("MissingPropertyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} property {1} must contain binding in the following format: {{value: Something}}.
        /// </summary>
        public static string ValueBindingExpected {
            get {
                return ResourceManager.GetString("ValueBindingExpected", resourceCulture);
            }
        }
    }
}