using System;
using Core.Data;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Core.Cache.User
{
	// Token: 0x02001107 RID: 4359
	[Token(Token = "0x2001107")]
	public class UserCacheBasicInfo : AbstractCache<ulong, UserData>, IUserCache, ICache<ulong, UserData>, IDisposable, IUserInfoWrapper
	{
		// Token: 0x060065C0 RID: 26048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0xB149", Offset = "0xB149", VA = "0xB149")]
		public UserCacheBasicInfo(float ttl)
		{
		/* --- GHIDRA: .ctor ---
		int * Core_Cache_User_UserCacheBasicInfo___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  int *piVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int iVar3;
		  
		  param3_00 = 0;
		  if (DAT_ram_00a60864 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData___TypeInfo);
		    DAT_ram_00a60864 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Core_Data_UserData___TypeInfo,*(undefined4 *)(param2 + 0xc));
		  iVar3 = *(int *)(param2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      param1_00 = Core_Cache_User_UserCacheBasicInfo__GetData
		                            (param1,*(undefined4 *)(param2 + param3_00 * 4 + 0x10),param3_00);
		      if ((param1_00 != 0) &&
		         (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20)), iVar2 == 0)) {
		        param1_01 = func_ii_1083();
		        func_ii_1050(param1_01,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar1[param3_00 + 4] = param1_00;
		      param3_00 = param3_00 + 1;
		    } while (param3_00 != iVar3);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xB14A", Offset = "0xB14A", VA = "0xB14A", Slot = "14")]
		public UserData[] GetData(params UserInfo[] userInfos)
		{
		/* --- GHIDRA: GetData ---
		void Core_Cache_User_UserCacheBasicInfo__GetData
		               (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a60868 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		    DAT_ram_00a60868 = '\x01';
		  }
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		  Core_Cache_User_UserCacheBasicInfo__Update(param1,param4,param4);
		  return;
		}
		*/

		/* --- GHIDRA: GetData ---
		void Core_Cache_User_UserCacheBasicInfo__GetData
		               (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a60868 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		    DAT_ram_00a60868 = '\x01';
		  }
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		  Core_Cache_User_UserCacheBasicInfo__Update(param1,param4,param4);
		  return;
		}
		*/

		/* --- GHIDRA: GetData ---
		void Core_Cache_User_UserCacheBasicInfo__GetData
		               (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a60868 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		    DAT_ram_00a60868 = '\x01';
		  }
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_ulong__UserData__AddCallback__);
		  Core_Cache_User_UserCacheBasicInfo__Update(param1,param4,param4);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xB14B", Offset = "0xB14B", VA = "0xB14B", Slot = "13")]
		public UserData GetData(UserInfo userInfo)
		{
			return null;
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xB14C", Offset = "0xB14C", VA = "0xB14C", Slot = "12")]
		public UserData GetDataKeepRatings(UserInfo userInfo)
		{
		/* --- GHIDRA: GetDataKeepRatings ---
		int * Core_Cache_User_UserCacheBasicInfo__GetDataKeepRatings
		                (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *piVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a60867 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_RefAccountInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ExtUserInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ExtUserInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData___TypeInfo);
		    DAT_ram_00a60867 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Core_Data_UserData___TypeInfo,*(undefined4 *)(param2 + 0xc));
		  iVar4 = *(int *)(param2 + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ExtUserInfo__get_Item__);
		      param1_00 = Core_Cache_User_UserCacheBasicInfo__GetData
		                            (param1,*(undefined4 *)(iVar2 + 0xc),param2_00);
		      uVar3 = System_Linq_Enumerable__Select_object__object_
		                        (*(undefined4 *)(iVar2 + 0x10),
		                         Method_System_Linq_Enumerable_ToList_RefAccountInfo___);
		      *(undefined4 *)(param1_00 + 0x50) = uVar3;
		      iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar2 == 0) {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar1[param2_00 + 4] = param1_00;
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xB14D", Offset = "0xB14D", VA = "0xB14D")]
		private UserData[] GetData(RepeatedField<ExtUserInfo> extUserInfos)
		{
			return null;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xB14E", Offset = "0xB14E", VA = "0xB14E", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<UserData> completeCallback, params AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		/* --- GHIDRA: Update ---
		void Core_Cache_User_UserCacheBasicInfo__Update(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a60869 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__UserData___ulong___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_AbstractCache_CacheItem_ulong__UserData___ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_User_UserCacheBasicInfo___c__RequestExtUserInfo_b__6_0__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCacheBasicInfo___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_User_UserCacheBasicInfo_HandlerGetShortUserInfoService__);
		    DAT_ram_00a60869 = '\x01';
		  }
		  if (*(int *)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_00 = unnamed_function_1417
		                          (System_Func_AbstractCache_CacheItem_ulong__UserData___ulong__TypeInfo);
		    func_ii_7542(param1_00,uVar1,
		                 Method_Core_Cache_User_UserCacheBasicInfo___c__RequestExtUserInfo_b__6_0__,0);
		    *(int *)(*(int *)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param2,param1_00,
		                     Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__UserData___ulong___
		                    );
		  uVar1 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_ulong___);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__GetUserInfo(uVar2,uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Cache_User_UserCacheBasicInfo_HandlerGetShortUserInfoService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,param2,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xB14F", Offset = "0xB14F", VA = "0xB14F")]
		private void RequestExtUserInfo(AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		/* --- GHIDRA: RequestExtUserInfo ---
		void Core_Cache_User_UserCacheBasicInfo__RequestExtUserInfo(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *param1_00;
		  int param1_01;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a6086a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__Complete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__UserData__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_AbstractCache_CacheItem_ulong__UserData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetExtUsersInfoAns_TypeInfo);
		    DAT_ram_00a6086a = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar1 = Core_Cache_AbstractCache_CacheItem_ulong__UserData____TypeInfo;
		  param1_00 = *(int **)(param2 + 0x20);
		  param1_01 = *(int *)(param2 + 0xc);
		  if ((param1_01 != 0) &&
		     (param2_00 = func_ii_1082(param1_01,
		                               Core_Cache_AbstractCache_CacheItem_ulong__UserData____TypeInfo),
		     param2_00 == 0)) {
		    System_Activator__CreateInstance(param1_01,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if ((param1_00 != (int *)0x0) &&
		     (param1_01 = Protocol_Main_ProtoGetExtUsersInfoAns_TypeInfo,
		     Protocol_Main_ProtoGetExtUsersInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetExtUsersInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = Core_Cache_User_UserCacheBasicInfo__GetDataKeepRatings(param1,param1_00[3],param1_01);
		  Core_Cache_AbstractCache_ulong__object___Cancel
		            (param1,param2_00,uVar1,Method_Core_Cache_AbstractCache_ulong__UserData__Complete__);
		  return;
		}
		*/

		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0xB150", Offset = "0xB150", VA = "0xB150")]
		private void HandlerGetShortUserInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandlerGetShortUserInfoService ---
		void Core_Cache_User_UserCacheBasicInfo__HandlerGetShortUserInfoService(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6086b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCacheBasicInfo___c_TypeInfo);
		    DAT_ram_00a6086b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo);
		  **(undefined4 **)(Core_Cache_User_UserCacheBasicInfo___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
