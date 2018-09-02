using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace UnityTest
{
	public static class DependencyResolver
	{
		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<ICreditCard, MasterCard>("MasterCard", new HierarchicalLifetimeManager());
			container.RegisterType<ICreditCard, Visa>("Visa", new HierarchicalLifetimeManager());
		}
	}
}


//public static void RegisterTypes(IUnityContainer container)
//{
//	var storageAccountType = typeof(StorageAccount);
//	var retryPolicyFactoryType = typeof(IRetryPolicyFactory);

//	// Instance registration
//	StorageAccount account =
//	  ApplicationConfiguration.GetStorageAccount("DataConnectionString");
//	container.RegisterInstance(account);

//	// Register factories
//	container
//	  .RegisterInstance<IRetryPolicyFactory>(
//		new ConfiguredRetryPolicyFactory())
//	  .RegisterType<ISurveyAnswerContainerFactory,
//		SurveyAnswerContainerFactory>(
//		  new ContainerControlledLifetimeManager());

//	// Register table types
//	container
//	  .RegisterType<IDataTable<SurveyRow>, DataTable<SurveyRow>>(
//		new InjectionConstructor(storageAccountType,
//		  retryPolicyFactoryType, Constants.SurveysTableName))
//	  ...

//	// Register message queue type, use typeof with open generics
//	container
//	  .RegisterType(
//		  typeof(IMessageQueue<>),
//		  typeof(MessageQueue<>),
//		  new InjectionConstructor(storageAccountType,
//			retryPolicyFactoryType, typeof(String)));

//    ...

//    // Register store types
//    container
//	  .RegisterType<ISurveyStore, SurveyStore>()
//	  .RegisterType<ITenantStore, TenantStore>()
//	  .RegisterType<ISurveyAnswerStore, SurveyAnswerStore>(
//		new InjectionFactory((c, t, s) => new SurveyAnswerStore(
//		  container.Resolve<ITenantStore>(),
//		  container.Resolve<ISurveyAnswerContainerFactory>(),
//		  container.Resolve<IMessageQueue<SurveyAnswerStoredMessage>>(
//			new ParameterOverride(
//			  "queueName", Constants.StandardAnswerQueueName)),
//		  container.Resolve<IMessageQueue<SurveyAnswerStoredMessage>>(
//			new ParameterOverride(
//			  "queueName", Constants.PremiumAnswerQueueName)),
//		  container.Resolve<IBlobContainer<List<String>>>())));
//}
//}