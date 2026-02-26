using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E23 RID: 3619
	[Token(Token = "0x2000E23")]
	public class NebogameSiteHelper : IDisposable
	{
		// Token: 0x1400020B RID: 523
		// (add) Token: 0x06005853 RID: 22611 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005854 RID: 22612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020B")]
		public event Action<int> SetEmailErrorEvent
		{
			[Token(Token = "0x6005853")]
			[Address(RVA = "0xA5C2", Offset = "0xA5C2", VA = "0xA5C2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005854")]
			[Address(RVA = "0xA5C3", Offset = "0xA5C3", VA = "0xA5C3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400020C RID: 524
		// (add) Token: 0x06005855 RID: 22613 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005856 RID: 22614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020C")]
		public event Action SetEmailCompleteEvent
		{
			[Token(Token = "0x6005855")]
			[Address(RVA = "0xA5C4", Offset = "0xA5C4", VA = "0xA5C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005856")]
			[Address(RVA = "0xA5C5", Offset = "0xA5C5", VA = "0xA5C5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005857")]
		[Address(RVA = "0xA5C6", Offset = "0xA5C6", VA = "0xA5C6", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_Control_NebogameSiteHelper__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_NebogameSiteHelper__RequestSetEmailAndPass_d__9___
		              );
		    DAT_ram_00a63bad = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param2;
		  local_14 = param3;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_MedalInfoViewMediator__HandleBuyMedalConfirmation_d__18_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_NebogameSiteHelper__RequestSetEmailAndPass_d__9___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005858")]
		[Address(RVA = "0xA5C7", Offset = "0xA5C7", VA = "0xA5C7")]
		private void RequestSetEmailAndPass(string email, string password)
		{
		/* --- GHIDRA: RequestSetEmailAndPass ---
		void Gameplay_AccountLinker_Control_NebogameSiteHelper__RequestSetEmailAndPass
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bae == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1689);
		    DAT_ram_00a63bae = '\x01';
		  }
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_1689,uVar1,0);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  UnityEngine_Application__get_cloudProjectId(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005859 RID: 22617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005859")]
		[Address(RVA = "0xA5C8", Offset = "0xA5C8", VA = "0xA5C8")]
		public void InvokeOAuth(Provider provider)
		{
		/* --- GHIDRA: InvokeOAuth ---
		undefined4
		Gameplay_AccountLinker_Control_NebogameSiteHelper__InvokeOAuth
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63baf == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a63baf = '\x01';
		  }
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  iVar1 = System_Text_RegularExpressions_Regex__IsMatch
		                    (*(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 4),param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param3,0);
		    if (iVar1 == 0) {
		      if (DAT_ram_00a63bad == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_NebogameSiteHelper__RequestSetEmailAndPass_d__9___
		                  );
		        DAT_ram_00a63bad = '\x01';
		      }
		      local_4 = 0;
		      local_c = 0;
		      System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_
		                (&local_3c,0);
		      local_20 = local_34;
		      local_2c = 0xffffffff;
		      local_28 = local_3c;
		      local_18 = param2;
		      local_14 = param3;
		      local_10 = param1;
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_MedalInfoViewMediator__HandleBuyMedalConfirmation_d__18_
		                (&local_28,&local_2c,
		                 Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_NebogameSiteHelper__RequestSetEmailAndPass_d__9___
		                );
		      uVar2 = 1;
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x600585A")]
		[Address(RVA = "0xA5C9", Offset = "0xA5C9", VA = "0xA5C9")]
		public bool TrySetEmailAndPass(string email, string password)
		{
			return default(bool);
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585B")]
		[Address(RVA = "0xA5CA", Offset = "0xA5CA", VA = "0xA5CA")]
		public NebogameSiteHelper()
		{
		}

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		public const string PAGE_FOR_OAUTH = "/bonuses.php?action=set_social_network&sn_ref_id=";

		// Token: 0x02000E24 RID: 3620
		[Token(Token = "0x2000E24")]
		[Serializable]
		public class SetEmailResponse
		{
			// Token: 0x0600585C RID: 22620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600585C")]
			[Address(RVA = "0xA5CB", Offset = "0xA5CB", VA = "0xA5CB")]
			public SetEmailResponse()
			{
			}

			// Token: 0x04002FCD RID: 12237
			[Token(Token = "0x4002FCD")]
			[FieldOffset(Offset = "0x8")]
			public int success;

			// Token: 0x04002FCE RID: 12238
			[Token(Token = "0x4002FCE")]
			[FieldOffset(Offset = "0xC")]
			public int error_code;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SetEmailErrorEvent ---
		void Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63baa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63baa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_SetEmailErrorEvent ---
		void Gameplay_AccountLinker_Control_NebogameSiteHelper__remove_SetEmailErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63bab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_SetEmailCompleteEvent ---
		void Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63bac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
