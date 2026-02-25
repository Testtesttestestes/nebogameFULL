using System;
using AppsFlyerSDK;
using Il2CppDummyDll;
using UnityEngine;

namespace Platforms.Android.AppsFlyer
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class ConversationDataComponent : MonoBehaviour, IAppsFlyerConversionData
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5B5E", Offset = "0x5B5E", VA = "0x5B5E")]
		public void SetDecorator(IAppsFlyerConversionData value)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x5B5F", Offset = "0x5B5F", VA = "0x5B5F", Slot = "4")]
		public void onConversionDataSuccess(string conversionData)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x5B60", Offset = "0x5B60", VA = "0x5B60", Slot = "5")]
		public void onConversionDataFail(string error)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x5B61", Offset = "0x5B61", VA = "0x5B61", Slot = "6")]
		public void onAppOpenAttribution(string attributionData)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x5B62", Offset = "0x5B62", VA = "0x5B62", Slot = "7")]
		public void onAppOpenAttributionFailure(string error)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x5B63", Offset = "0x5B63", VA = "0x5B63")]
		public ConversationDataComponent()
		{
		}

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x10")]
		private IAppsFlyerConversionData _decorator;
	}
}
