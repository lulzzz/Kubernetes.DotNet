/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing Networking_v1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Networking_v1ApiTests
    {
        private Networking_v1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Networking_v1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Networking_v1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Networking_v1Api
            //Assert.IsInstanceOfType(typeof(Networking_v1Api), instance, "instance is a Networking_v1Api");
        }

        
        /// <summary>
        /// Test CreateNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void CreateNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //V1NetworkPolicy body = null;
            //string pretty = null;
            //var response = instance.CreateNamespacedNetworkPolicy(_namespace, body, pretty);
            //Assert.IsInstanceOf<V1NetworkPolicy> (response, "response is V1NetworkPolicy");
        }
        
        /// <summary>
        /// Test DeleteCollectionNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void DeleteCollectionNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.DeleteCollectionNamespacedNetworkPolicy(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test DeleteNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void DeleteNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //V1DeleteOptions body = null;
            //string pretty = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteNamespacedNetworkPolicy(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test GetAPIResources
        /// </summary>
        [Test]
        public void GetAPIResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAPIResources();
            //Assert.IsInstanceOf<V1APIResourceList> (response, "response is V1APIResourceList");
        }
        
        /// <summary>
        /// Test ListNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void ListNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListNamespacedNetworkPolicy(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1NetworkPolicyList> (response, "response is V1NetworkPolicyList");
        }
        
        /// <summary>
        /// Test ListNetworkPolicyForAllNamespaces
        /// </summary>
        [Test]
        public void ListNetworkPolicyForAllNamespacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string pretty = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListNetworkPolicyForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1NetworkPolicyList> (response, "response is V1NetworkPolicyList");
        }
        
        /// <summary>
        /// Test PatchNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void PatchNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.PatchNamespacedNetworkPolicy(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V1NetworkPolicy> (response, "response is V1NetworkPolicy");
        }
        
        /// <summary>
        /// Test ReadNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void ReadNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //string pretty = null;
            //bool? exact = null;
            //bool? export = null;
            //var response = instance.ReadNamespacedNetworkPolicy(name, _namespace, pretty, exact, export);
            //Assert.IsInstanceOf<V1NetworkPolicy> (response, "response is V1NetworkPolicy");
        }
        
        /// <summary>
        /// Test ReplaceNamespacedNetworkPolicy
        /// </summary>
        [Test]
        public void ReplaceNamespacedNetworkPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //V1NetworkPolicy body = null;
            //string pretty = null;
            //var response = instance.ReplaceNamespacedNetworkPolicy(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V1NetworkPolicy> (response, "response is V1NetworkPolicy");
        }
        
    }

}
