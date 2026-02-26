using System;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Core.Cache.Clan
{
	// Token: 0x02001109 RID: 4361
	[Token(Token = "0x2001109")]
	public class ClanCache : AbstractCache<ulong, ClanShortInfo>
	{
		// Token: 0x060065CB RID: 26059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0xB154", Offset = "0xB154", VA = "0xB154", Slot = "9")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Cache_Clan_ClanCache__Dispose(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6086e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__ClanShortInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6086e = '\x01';
		  }
		  Core_Cache_AbstractCache_object__object___set_TokenRepository
		            (param1,param2,Method_Core_Cache_AbstractCache_ulong__ClanShortInfo___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0xB155", Offset = "0xB155", VA = "0xB155")]
		public ClanCache(float ttl)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Cache_Clan_ClanCache___ctor
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6086f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__AddCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_Clan_ClanCache_HandleGetShortClansInfoService__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__ClanShortInfo___ulong___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_AbstractCache_CacheItem_ulong__ClanShortInfo___ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_Clan_ClanCache___c__Update_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_Clan_ClanCache___c_TypeInfo);
		    DAT_ram_00a6086f = '\x01';
		  }
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__AddCallback__);
		  if (*(int *)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Cache_Clan_ClanCache___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Cache_Clan_ClanCache___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417
		                          (
		                          System_Func_AbstractCache_CacheItem_ulong__ClanShortInfo___ulong__TypeInfo
		                          );
		    func_ii_7542(param1_01,uVar1,Method_Core_Cache_Clan_ClanCache___c__Update_b__3_0__,0);
		    *(int *)(*(int *)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param4,param1_01,
		                     Method_System_Linq_Enumerable_Select_AbstractCache_CacheItem_ulong__ClanShortInfo___ulong___
		                    );
		  uVar1 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_ulong___);
		  uVar1 = ServicesNamespace_ClansService__GetOwnClanInfo(*(undefined4 *)(param1 + 0x20),uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Cache_Clan_ClanCache_HandleGetShortClansInfoService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param4,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0xB156", Offset = "0xB156", VA = "0xB156", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<ClanShortInfo> completeCallback, params AbstractCache<ulong, ClanShortInfo>.CacheItem[] cacheItems)
		{
		/* --- GHIDRA: Update ---
		void Core_Cache_Clan_ClanCache__Update(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param2_00;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  uint uVar4;
		  int param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a60870 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__Complete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__get_TokenRepository__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Cache_AbstractCache_CacheItem_ulong__ClanShortInfo____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_ulong__ClanShortInfo__get_Key__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ClanShortInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ClanShortInfo___);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanShortInfo__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanShortInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5458);
		    DAT_ram_00a60870 = '\x01';
		  }
		  local_8 = 0;
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = Core_Cache_AbstractCache_CacheItem_ulong__ClanShortInfo____TypeInfo;
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = *(int *)(param2 + 0xc);
		  if ((iVar3 != 0) &&
		     (param2_00 = func_ii_1082(iVar3,
		                               Core_Cache_AbstractCache_CacheItem_ulong__ClanShortInfo____TypeInfo),
		     param2_00 == 0)) {
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = param1_00[3];
		  iVar3 = *(int *)(iVar5 + 0xc);
		  uVar4 = *(int *)(param2_00 + 0xc) - iVar3;
		  if (0 < (int)uVar4) {
		    do {
		      local_8 = *(undefined8 *)(*(int *)(param2_00 + iVar3 * 4 + 0x10) + 8);
		      param1_01 = param1_00[3];
		      iVar5 = unnamed_function_1417(Protocol_Common_ClanShortInfo_TypeInfo);
		      Protocol_Common_ClanShortInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar5,0);
		      *(undefined8 *)(iVar5 + 0x10) = local_8;
		      uVar2 = func_ii_8783(&local_8,0);
		      uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_5458,uVar2,0);
		      Protocol_Common_ClanShortInfo__get_ClanName(iVar5,uVar2,0);
		      func_ii_6441(param1_01,iVar5,
		                   Method_Google_Protobuf_Collections_RepeatedField_ClanShortInfo__Add__);
		      iVar3 = iVar3 + 1;
		      bVar1 = 1 < uVar4;
		      uVar4 = uVar4 - 1;
		    } while (bVar1);
		    iVar5 = param1_00[3];
		  }
		  uVar2 = func_ii_6295(iVar5,Method_System_Linq_Enumerable_ToArray_ClanShortInfo___);
		  Core_Cache_AbstractCache_ulong__object___Cancel
		            (param1,param2_00,uVar2,Method_Core_Cache_AbstractCache_ulong__ClanShortInfo__Complete__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0xB157", Offset = "0xB157", VA = "0xB157")]
		private void HandleGetShortClansInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetShortClansInfoService ---
		void Core_Cache_Clan_ClanCache__HandleGetShortClansInfoService(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a8d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_Clan_ClanCache___c_TypeInfo);
		    DAT_ram_00a5a8d5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Cache_Clan_ClanCache___c_TypeInfo);
		  **(undefined4 **)(Core_Cache_Clan_ClanCache___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x20")]
		private ClansService _clansService;
	}
}
