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
		/* --- GHIDRA: SetDecorator ---
		void Platforms_Android_AppsFlyer_ConversationDataComponent__SetDecorator
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b844 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo);
		    DAT_ram_00a5b844 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x813864d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo,0);
		code_r0x813864d7:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x5B5F", Offset = "0x5B5F", VA = "0x5B5F", Slot = "4")]
		public void onConversionDataSuccess(string conversionData)
		{
		/* --- GHIDRA: onConversionDataSuccess ---
		void Platforms_Android_AppsFlyer_ConversationDataComponent__onConversionDataSuccess
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b845 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo);
		    DAT_ram_00a5b845 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x81386580;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo,1);
		code_r0x81386580:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x5B60", Offset = "0x5B60", VA = "0x5B60", Slot = "5")]
		public void onConversionDataFail(string error)
		{
		/* --- GHIDRA: onConversionDataFail ---
		void Platforms_Android_AppsFlyer_ConversationDataComponent__onConversionDataFail
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b846 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo);
		    DAT_ram_00a5b846 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81386629;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo,2);
		code_r0x81386629:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x5B61", Offset = "0x5B61", VA = "0x5B61", Slot = "6")]
		public void onAppOpenAttribution(string attributionData)
		{
		/* --- GHIDRA: onAppOpenAttribution ---
		void Platforms_Android_AppsFlyer_ConversationDataComponent__onAppOpenAttribution
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b847 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo);
		    DAT_ram_00a5b847 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x813866d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,AppsFlyerSDK_IAppsFlyerConversionData_TypeInfo,3);
		code_r0x813866d2:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

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
