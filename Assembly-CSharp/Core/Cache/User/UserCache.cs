using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using ServicesNamespace;
using Utils;

namespace Core.Cache.User
{
	// Token: 0x02001102 RID: 4354
	[Token(Token = "0x2001102")]
	public class UserCache : AbstractCache<ulong, UserData>
	{
		// Token: 0x060065A8 RID: 26024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0xB131", Offset = "0xB131", VA = "0xB131", Slot = "9")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Cache_User_UserCache__Dispose(int param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60854 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IDisposable___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_IDisposable__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a60854 = '\x01';
		  }
		  Core_Cache_AbstractCache_object__object___set_TokenRepository
		            (param1,param3,Method_Core_Cache_AbstractCache_ulong__UserData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param2;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_IDisposable__TypeInfo);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0xB132", Offset = "0xB132", VA = "0xB132")]
		public UserCache(IUserCache userCache, float ttl)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Cache_User_UserCache___ctor
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int param1_00;
		  int *param1_01;
		  undefined4 uVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a60855 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__UserData___ulong___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_AbstractCache_CacheItem_ulong__UserData___ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_User_UserCache___c__Update_b__6_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_User_UserCache___c__DisplayClass6_0__Update_b__1__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache___c_TypeInfo);
		    DAT_ram_00a60855 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Cache_User_UserCache___c__DisplayClass6_0_TypeInfo);
		  *(int *)(iVar2 + 0xc) = param1;
		  *(undefined4 *)(iVar2 + 8) = param4;
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		  uVar1 = (undefined4)((ulonglong)param2 >> 0x20);
		  uVar4 = *(undefined4 *)(iVar2 + 8);
		  if (*(int *)(Core_Cache_User_UserCache___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Cache_User_UserCache___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Core_Cache_User_UserCache___c_TypeInfo + 0x5c);
		  param1_00 = puVar5[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Cache_User_UserCache___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Cache_User_UserCache___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Core_Cache_User_UserCache___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    param1_00 = unnamed_function_1417
		                          (System_Func_AbstractCache_CacheItem_ulong__UserData___ulong__TypeInfo);
		    func_ii_7542(param1_00,uVar6,Method_Core_Cache_User_UserCache___c__Update_b__6_0__,0);
		    *(int *)(*(int *)(Core_Cache_User_UserCache___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar7 = 0;
		  uVar4 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar4,param1_00,
		                     Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__UserData___ulong___
		                    );
		  uVar4 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar4,Method_System_Linq_Enumerable_ToArray_ulong___);
		  *(undefined4 *)(iVar2 + 0x10) = uVar4;
		  param1_01 = *(int **)(param1 + 0x24);
		  uVar4 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (uVar4,iVar2,Method_Core_Cache_User_UserCache___c__DisplayClass6_0__Update_b__1__,0);
		  uVar6 = *(undefined4 *)(iVar2 + 0x10);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81cee7ce;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x81cee7ce:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar4,CONCAT44(uVar1,uVar6),puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060065AA RID: 26026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0xB133", Offset = "0xB133", VA = "0xB133", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<UserData> completeCallback, params AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		/* --- GHIDRA: Update ---
		int Core_Cache_User_UserCache__Update
		              (undefined4 param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a60856 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		    DAT_ram_00a60856 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param4;
		  *(int *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  if (*(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x34) + 0x40) == 0) {
		    Core_Cache_User_UserCache__RequestClanIsleInfo(param1,param2_00,param2_00);
		    return param2_00;
		  }
		  Core_Cache_User_UserCache__CollectInfo(param1,param2_00,param2_00);
		  return param2_00;
		}
		*/

		}

		// Token: 0x060065AB RID: 26027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0xB134", Offset = "0xB134", VA = "0xB134")]
		private UserCache.CollectInfoInvokerVo CollectInfo(int index, AbstractCache<ulong, UserData>.CacheItem cacheItem, Action<UserCache.CollectInfoInvokerVo> callback)
		{
		/* --- GHIDRA: CollectInfo ---
		void Core_Cache_User_UserCache__CollectInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60857 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_User_UserCache_HandleGetClanIsleInfo__);
		    DAT_ram_00a60857 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		  uVar1 = ServicesNamespace_ClanIsleService__ServerEventHandler
		                    (uVar1,*(undefined8 *)
		                            (*(int *)(*(int *)(*(int *)(*(int *)(param2 + 0xc) + 0x10) + 0x34) +
		                                     0x40) + 0x10),2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Cache_User_UserCache_HandleGetClanIsleInfo__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AC")]
		[Address(RVA = "0xB135", Offset = "0xB135", VA = "0xB135")]
		private void RequestClanIsleInfo(UserCache.CollectInfoInvokerVo invoker)
		{
		/* --- GHIDRA: RequestClanIsleInfo ---
		void Core_Cache_User_UserCache__RequestClanIsleInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60858 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Key__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_User_UserCache_HandleGetUserSkillsService__);
		    DAT_ram_00a60858 = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x28),*(undefined8 *)(*(int *)(param2 + 0xc) + 8),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Cache_User_UserCache_HandleGetUserSkillsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AD")]
		[Address(RVA = "0xB136", Offset = "0xB136", VA = "0xB136")]
		private void RequestUserSkills(UserCache.CollectInfoInvokerVo invoker)
		{
		/* --- GHIDRA: RequestUserSkills ---
		void Core_Cache_User_UserCache__RequestUserSkills(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60859 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Key__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_User_UserCache_HandleGetUserStatsService__);
		    DAT_ram_00a60859 = '\x01';
		  }
		  uVar1 = func_ii_7716(*(undefined4 *)(param1 + 0x28),*(undefined8 *)(*(int *)(param2 + 0xc) + 8),0)
		  ;
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Cache_User_UserCache_HandleGetUserStatsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AE")]
		[Address(RVA = "0xB137", Offset = "0xB137", VA = "0xB137")]
		private void RequestUserStats(UserCache.CollectInfoInvokerVo invoker)
		{
		/* --- GHIDRA: RequestUserStats ---
		void Core_Cache_User_UserCache__RequestUserStats(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6085a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Key__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_User_UserCache_HandleGetUserMedalsService__);
		    DAT_ram_00a6085a = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetUserSkills
		                    (*(undefined4 *)(param1 + 0x28),*(undefined8 *)(*(int *)(param2 + 0xc) + 8),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Cache_User_UserCache_HandleGetUserMedalsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065AF RID: 26031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AF")]
		[Address(RVA = "0xB138", Offset = "0xB138", VA = "0xB138")]
		private void RequestUserMedals(UserCache.CollectInfoInvokerVo invoker)
		{
		/* --- GHIDRA: RequestUserMedals ---
		void Core_Cache_User_UserCache__RequestUserMedals(int param1,uint *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a6085b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    DAT_ram_00a6085b = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  piVar4 = (int *)param2[8];
		  if ((piVar4 != (int *)0x0) && (Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (int *)param2[3];
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)(byte)Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo[0x2e]) ||
		       (param2 = Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo,
		       *(uint **)(*(int *)(*param1_00 + 100) +
		                  (uint)(byte)Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo[0x2e] * 4 + -4
		                 ) != Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (piVar4[4] == 0) {
		    iVar5 = *(int *)(param1_00[3] + 0x10);
		    iVar6 = *(int *)(iVar5 + 0x68);
		    if (iVar6 == 0) {
		      uVar7 = *(undefined4 *)(piVar4[3] + 0x10);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar8;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		            goto code_r0x81ceec61;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81ceec61:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar7 = func_ii_7325(uVar7,uVar3,0);
		      *(undefined4 *)(iVar5 + 0x68) = uVar7;
		    }
		    else {
		      Protocol_Common_ClanInfo__CalculateSize
		                (*(undefined4 *)(iVar6 + 0x1c),*(undefined4 *)(piVar4[3] + 0x10),0);
		    }
		    uVar1 = 0;
		    uVar7 = *(undefined4 *)(piVar4[3] + 0x2c);
		    iVar5 = *(int *)(*(int *)(param1_00[3] + 0x10) + 0x68);
		    piVar8 = *(int **)(param1 + 0x24);
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          param2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81ceed25;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    param2 = (uint *)func_ii_1080(piVar8,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x81ceed25:
		    uVar7 = (**(code **)((ulonglong)*param2 * 4))(piVar8,uVar7,param2[1]);
		    *(undefined4 *)(iVar5 + 0x14) = uVar7;
		    iVar5 = *(int *)(piVar4[3] + 0x20);
		    if (iVar5 != 0) {
		      uVar1 = 0;
		      iVar6 = *(int *)(*(int *)(param1_00[3] + 0x10) + 0x68);
		      piVar4 = *(int **)(param1 + 0x24);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            param2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81ceedc9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      param2 = (uint *)func_ii_1080(piVar4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x81ceedc9:
		      uVar7 = (**(code **)((ulonglong)*param2 * 4))(piVar4,iVar5,param2[1]);
		      *(undefined4 *)(iVar6 + 0x18) = uVar7;
		    }
		  }
		  Core_Cache_User_UserCache__RequestClanIsleInfo(param1,param1_00,param2);
		  return;
		}
		*/

		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B0")]
		[Address(RVA = "0xB139", Offset = "0xB139", VA = "0xB139")]
		private void HandleGetClanIsleInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetClanIsleInfo ---
		void Core_Cache_User_UserCache__HandleGetClanIsleInfo(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int *param1_01;
		  int iVar2;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a6085c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    DAT_ram_00a6085c = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserSkillsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8) * 4
		                + -4) != Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = *(int *)(param1_01[3] + 0x10);
		  iVar1 = Core_Extensions_Dict_ProtoCastExt__ToUserInfo(param1_00,0);
		  param1_02 = *(int *)(iVar2 + 0x44);
		  iVar3 = *(int *)(param1_02 + 8);
		  if (iVar3 == 0) {
		    *(int *)(param1_02 + 8) = iVar1;
		  }
		  else {
		    if (*(int *)(iVar1 + 0xc) != 0) {
		      *(int *)(iVar3 + 0xc) = *(int *)(iVar1 + 0xc);
		    }
		    if (*(int *)(iVar1 + 0x10) != 0) {
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar1 + 0x10);
		    }
		    if (*(int *)(iVar1 + 0x14) != 0) {
		      *(int *)(iVar3 + 0x14) = *(int *)(iVar1 + 0x14);
		    }
		  }
		  Core_Data_UserSkillsData__set_BonusRelativeSkills(param1_02,param1_01);
		  iVar1 = *(int *)(iVar2 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Core_Cache_User_UserCache__RequestUserSkills(param1,param1_01,param1_01);
		  return;
		}
		*/

		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0xB13A", Offset = "0xB13A", VA = "0xB13A")]
		private void HandleGetUserSkillsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserSkillsService ---
		void Core_Cache_User_UserCache__HandleGetUserSkillsService(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int *param1_01;
		  int iVar1;
		  int param1_02;
		  
		  if (DAT_ram_00a6085d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserStatsAns_TypeInfo);
		    DAT_ram_00a6085d = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserStatsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserStatsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8) * 4
		                + -4) != Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = *(int *)(param1_01[3] + 0x10);
		  if (DAT_ram_00a607fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Accumulators_TriggersAccumulator_TypeInfo);
		    DAT_ram_00a607fe = '\x01';
		  }
		  param1_02 = *(int *)(iVar1 + 0x3c);
		  if (param1_02 == 0) {
		    param1_02 = unnamed_function_1417(Utils_Accumulators_TriggersAccumulator_TypeInfo);
		    Utils_Accumulators_CallAccumulator__RunTimer_d__8__SetStateMachine(param1_02,0.1,0);
		    *(int *)(iVar1 + 0x3c) = param1_02;
		  }
		  Utils_Accumulators_AccumulatorBase_int__object___RunTimer
		            (param1_02,param1_00[3],
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		  Core_Cache_User_UserCache__RequestUserStats(param1,param1_01,param1_01);
		  return;
		}
		*/

		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0xB13B", Offset = "0xB13B", VA = "0xB13B")]
		private void HandleGetUserStatsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserStatsService ---
		void Core_Cache_User_UserCache__HandleGetUserStatsService(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a6085e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__UserData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserMedalsAns_TypeInfo);
		    DAT_ram_00a6085e = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserMedalsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserMedalsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo + 0xb8) * 4
		                + -4) != Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Core_Cache_User_UserCache_CollectInfoInvokerVo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = *(int *)(param1_01[3] + 0x10);
		  *(int *)(iVar1 + 0x40) = param1_00[3];
		  *(char *)(iVar1 + 0x48) = (char)param1_00[4];
		  *(undefined1 *)(iVar1 + 0x49) = *(undefined1 *)((int)param1_00 + 0x11);
		  iVar1 = param1_01[4];
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_01,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0xB13C", Offset = "0xB13C", VA = "0xB13C")]
		private void HandleGetUserMedalsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x20")]
		private readonly LinkedList<IDisposable> _collectors;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x24")]
		private IUserCache _userCache;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x28")]
		private MainService _service;

		// Token: 0x02001103 RID: 4355
		[Token(Token = "0x2001103")]
		private class CollectInfoInvokerVo : IDisposable
		{
			// Token: 0x170014A1 RID: 5281
			// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060065B5 RID: 26037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014A1")]
			public AbstractCache<ulong, UserData>.CacheItem Item
			{
				[Token(Token = "0x60065B4")]
				[Address(RVA = "0xB13D", Offset = "0xB13D", VA = "0xB13D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60065B5")]
				[Address(RVA = "0xB13E", Offset = "0xB13E", VA = "0xB13E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060065B6 RID: 26038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B6")]
			[Address(RVA = "0xB13F", Offset = "0xB13F", VA = "0xB13F")]
			public CollectInfoInvokerVo(int index, AbstractCache<ulong, UserData>.CacheItem item, Action<UserCache.CollectInfoInvokerVo> collectCallback)
			{
			}

			// Token: 0x060065B7 RID: 26039 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B7")]
			[Address(RVA = "0xB140", Offset = "0xB140", VA = "0xB140")]
			public void Complete()
			{
			}

			// Token: 0x060065B8 RID: 26040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B8")]
			[Address(RVA = "0xB141", Offset = "0xB141", VA = "0xB141", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04003650 RID: 13904
			[Token(Token = "0x4003650")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Index;

			// Token: 0x04003652 RID: 13906
			[Token(Token = "0x4003652")]
			[FieldOffset(Offset = "0x10")]
			private Action<UserCache.CollectInfoInvokerVo> _collectCallback;
		}
	}
}
