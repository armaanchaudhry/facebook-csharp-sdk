// <copyright file="DictionaryExtensionsTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for DictionaryExtensions</summary>
    [PexClass(typeof(DictionaryUtils))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DictionaryExtensionsTest
    {
        /// <summary>Test stub for Merge(IDictionary`2&lt;String,Object&gt;, IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        internal IDictionary<string, object> Merge(IDictionary<string, object> first, IDictionary<string, object> second)
        {
            IDictionary<string, object> result = DictionaryUtils.Merge(first, second);
            return result;
            // TODO: add assertions to method DictionaryExtensionsTest.Merge(IDictionary`2<String,Object>, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for ToJsonQueryString(IDictionary`2&lt;String,String&gt;)</summary>
        [PexMethod]
        internal string ToJsonQueryString(IDictionary<string, string> dictionary)
        {
            string result = DictionaryUtils.ToJsonQueryString(dictionary);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString(IDictionary`2<String,String>)
        }

        /// <summary>Test stub for ToJsonQueryString(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        internal string ToJsonQueryString01(IDictionary<string, object> dictionary)
        {
            string result = DictionaryUtils.ToJsonQueryString(dictionary);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString01(IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for ToJsonQueryString(NameValueCollection)</summary>
        [PexMethod]
        internal string ToJsonQueryString02(NameValueCollection collection)
        {
            string result = DictionaryUtils.ToJsonQueryString(collection);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString02(NameValueCollection)
        }
    }
}
