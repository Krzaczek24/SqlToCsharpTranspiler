﻿namespace SqlToCsharpTranscriptor.ClassDefinitions
{
    internal static class ClassesCommonProperties
    {
        private const string DEFAULT_NAMESPACE = "DatabaseModels";

        private static string @namespace = DEFAULT_NAMESPACE;
        internal static string Namespace
        {
            get => @namespace;
            set => @namespace = GetValueOrDefault(value, DEFAULT_NAMESPACE);
        }

        private static string baseClassName = string.Empty;
        internal static string BaseClassName
        {
            get => baseClassName;
            set => baseClassName = GetValueOrDefault(value);
        }

        private static string baseClassNamespace = DEFAULT_NAMESPACE;
        internal static string BaseClassNamespace
        {
            get => baseClassNamespace;
            set => baseClassNamespace = GetValueOrDefault(value, DEFAULT_NAMESPACE);
        }

        private static string prefix = string.Empty;
        internal static string ClassNamePrefix
        {
            get => prefix;
            set => prefix = GetValueOrDefault(value);
        }

        private static string suffix = string.Empty;
        internal static string ClassNameSuffix
        {
            get => suffix;
            set => suffix = GetValueOrDefault(value);
        }

        private static string GetValueOrDefault(string value, string defaultValue)
        {
            return string.IsNullOrWhiteSpace(value) ? defaultValue : value;
        }

        private static string GetValueOrDefault(string value)
        {
            return GetValueOrDefault(value, string.Empty);
        }
    }
}
