using System;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Application.Managers.Environment
{
	// Token: 0x02001261 RID: 4705
	[Token(Token = "0x2001261")]
	public interface IEnvironment
	{
		// Token: 0x06006F84 RID: 28548
		[Token(Token = "0x6006F84")]
		[CanBeNull]
		T GetUiapWrapper<T>() where T : class, IUiapWrapper, new();
	}
}
