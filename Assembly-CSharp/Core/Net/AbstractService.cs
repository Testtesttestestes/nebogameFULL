using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Net
{
	// Token: 0x02000E86 RID: 3718
	[Token(Token = "0x2000E86")]
	public abstract class AbstractService
	{
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700126B")]
		public ProtocolCommandInfoProvider ProtocolInfoProvider
		{
			[Token(Token = "0x6005A6B")]
			[Address(RVA = "0xA76A", Offset = "0xA76A", VA = "0xA76A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A6C")]
			[Address(RVA = "0xA76B", Offset = "0xA76B", VA = "0xA76B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A6E RID: 23150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700126C")]
		public IConnection Connection
		{
			[Token(Token = "0x6005A6D")]
			[Address(RVA = "0xA76C", Offset = "0xA76C", VA = "0xA76C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A6E")]
			[Address(RVA = "0xA76D", Offset = "0xA76D", VA = "0xA76D")]
			set
			{
			}
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xA76E", Offset = "0xA76E", VA = "0xA76E")]
		private void HandleConnectionChanged()
		{
		/* --- GHIDRA: HandleConnectionChanged ---
		void Core_Net_AbstractService__HandleConnectionChanged(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60581 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__OpToken_IMessage__object___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__OpToken_IMessage__object___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__OpToken_IMessage__object___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__OpToken_IMessage__object___GetEnumerator__
		              );
		    DAT_ram_00a60581 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(param2 + 8) != 0) {
		    return;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__OpToken_IMessage__object___GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__OpToken_IMessage__object___MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca8611;
		    }
		    if (iVar3 == 0) goto code_r0x81ca8667;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*local_8._4_4_ + 0x108),local_8._4_4_,
		               *(undefined4 *)(*local_8._4_4_ + 0x10c));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ca8611:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81ca8667:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 8),
		                 Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Clear__
		                );
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x1e,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xA76F", Offset = "0xA76F", VA = "0xA76F")]
		private void HandleStateChangedEvent(ConnectionState state)
		{
		/* --- GHIDRA: HandleStateChangedEvent ---
		void Core_Net_AbstractService__HandleStateChangedEvent
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60582 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18869);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25484);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18867);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a60582 = '\x01';
		  }
		  puVar1 = &StringLiteral_18867;
		  if (param3 == 0) {
		    puVar1 = &StringLiteral_18869;
		  }
		  uVar2 = *puVar1;
		  param1_00 = unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(param1_00,uVar2,0);
		  uVar2 = Core_Net_SrvCommand__ToString(param2,*(undefined4 *)(param1 + 0xc),param1_00);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,StringLiteral_118,0);
		  func_ii_2010(param1_00,uVar2,0);
		  if (param3 == 0) {
		    if (*(int *)(param2 + 0x30) != 0) {
		      func_ii_2010(param1_00,StringLiteral_25484,0);
		      func_ii_13860(param1_00,*(undefined4 *)(param2 + 0x30),0);
		    }
		  }
		  else {
		    func_ii_2010(param1_00,StringLiteral_25484,0);
		    func_ii_13860(param1_00,param3,0);
		  }
		  func_ii_2010(param1_00,StringLiteral_19094,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06005A71 RID: 23153
		[Token(Token = "0x1700126D")]
		public abstract short ServiceId { [Token(Token = "0x6005A71")] get; }

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A72")]
		protected void LogEvent<T>(T eventId, IMessage message) where T : Enum
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0xA770", Offset = "0xA770", VA = "0xA770")]
		protected void LogCommandAnswer(SrvCommand command, IMessage answerMsg)
		{
		/* --- GHIDRA: LogCommandAnswer ---
		void Core_Net_AbstractService__LogCommandAnswer(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a60583 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    DAT_ram_00a60583 = '\x01';
		  }
		  Core_Net_AbstractService__HandleStateChangedEvent(param1,param2,0,param1);
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x108);
		        goto code_r0x81ca8b97;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Net_Connection_IConnection_TypeInfo,9);
		code_r0x81ca8b97:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0xA771", Offset = "0xA771", VA = "0xA771")]
		protected void PushCommand(SrvCommand command)
		{
		/* --- GHIDRA: PushCommand ---
		undefined4 Core_Net_AbstractService__PushCommand(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60584 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_HandleOpFault__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_KillOpToken__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddFaultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_IMessage__object__TypeInfo);
		    DAT_ram_00a60584 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 8),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    local_4 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    param1_00 = unnamed_function_1417(Utils_OpToken_IMessage__object__TypeInfo);
		    Utils_OpToken___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (param1_00,uVar2,Method_Utils_OpToken_IMessage__object___ctor__);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Core_Net_AbstractService_HandleOpFault__,0);
		    Utils_OpToken_object__object____ctor
		              (param1_00,uVar2,Method_Utils_OpToken_IMessage__object__AddFaultHandler__);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Core_Net_AbstractService_KillOpToken__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		              (*(undefined4 *)(param1 + 8),param2,param1_00,
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Add__);
		  }
		  else {
		    param1_00 = System_Collections_Generic_List_object___get_Item
		                          (*(undefined4 *)(param1 + 8),param2,
		                           Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___get_Item__
		                          );
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0xA772", Offset = "0xA772", VA = "0xA772")]
		protected OpToken<IMessage, object> GetOpToken(uint index)
		{
			return null;
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0xA773", Offset = "0xA773", VA = "0xA773")]
		private void KillOpToken(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: KillOpToken ---
		void Core_Net_AbstractService__KillOpToken(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60585 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Remove__
		              );
		    DAT_ram_00a60585 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x10);
		  if (param1_00 != (int *)0x0) {
		    if (*(int *)(*param1_00 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		      param1_01 = *(undefined4 *)(param1 + 8);
		      puVar1 = (undefined4 *)func_ii_15774(param1_00);
		      System_Collections_Generic_List_Enumerator_uint___MoveNext
		                (param1_01,*puVar1,
		                 Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___Remove__
		                );
		      return;
		    }
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0xA774", Offset = "0xA774", VA = "0xA774")]
		private void HandleOpFault(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleOpFault ---
		void Core_Net_AbstractService__HandleOpFault
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a60586 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_AppScope_AnswerFromServerReceivedEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__Complete__);
		    DAT_ram_00a60586 = '\x01';
		  }
		  Core_Net_AbstractService__HandleStateChangedEvent(param1,param2,param3,param2);
		  uVar1 = Core_Net_AbstractService__PushCommand(param1,*(undefined4 *)(param2 + 0xc),param2);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (uVar1,param3,Method_Utils_OpToken_IMessage__object__Complete__);
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x1c) + 0x20);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_AppScope_AnswerFromServerReceivedEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar1,param3_00,param2,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0xA775", Offset = "0xA775", VA = "0xA775", Slot = "5")]
		protected virtual void CommonCommandCallback(SrvCommand cmd, IMessage msg)
		{
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0xA776", Offset = "0xA776", VA = "0xA776", Slot = "6")]
		protected virtual void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		void Core_Net_AbstractService__ServerEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60587 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___TypeInfo);
		    DAT_ram_00a60587 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object___TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__OpToken_IMessage__object____ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0xA777", Offset = "0xA777", VA = "0xA777")]
		protected AbstractService()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_AbstractService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60588 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PacketParser_Packet__TypeInfo);
		    DAT_ram_00a60588 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_PacketParser_Packet__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PacketParser_Packet__TypeInfo), iVar2 == 0))
		    break;
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

		}

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, OpToken<IMessage, object>> _operationByCmdIndex;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x10")]
		private IConnection _connection;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Connection ---
		void Core_Net_AbstractService__get_Connection(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x10)) {
		    *(int *)(param1 + 0x10) = param2;
		    Core_Net_AbstractService__set_Connection(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Connection ---
		void Core_Net_AbstractService__set_Connection(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a60580 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_HandleStateChangedEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SrvAnswer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    DAT_ram_00a60580 = '\x01';
		  }
		  piVar4 = (int *)param1[4];
		  uVar2 = unnamed_function_1417(System_Action_ConnectionState__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Net_AbstractService_HandleStateChangedEvent__,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf8);
		        goto code_r0x81ca83f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Net_Connection_IConnection_TypeInfo,7);
		code_r0x81ca83f2:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = (int *)param1[4];
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xe4));
		  param1_00 = unnamed_function_1417(System_Action_SrvAnswer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,*(undefined4 *)(*param1 + 0xf4),0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81ca84af;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Net_Connection_IConnection_TypeInfo,10);
		code_r0x81ca84af:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,param1_00,puVar3[1]);
		  return;
		}
		*/


		/* --- GHIDRA: LogEvent<Int32Enum> ---
		void Core_Net_AbstractService__LogEvent_Int32Enum_
		               (int *param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int param3_00;
		  undefined1 local_10 [12];
		  undefined4 local_4;
		  
		  piVar2 = *(int **)(param4 + 0x1c);
		  if (piVar2 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Services_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_432);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1480);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18866);
		    piVar2 = *(int **)(param4 + 0x1c);
		    if (piVar2 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      piVar2 = *(int **)(param4 + 0x1c);
		    }
		  }
		  param3_00 = *(int *)(*piVar2 + 0x84);
		  piVar2 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(piVar2,StringLiteral_18866,0);
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  uVar1 = func_ii_1081(Protocol_Consts_Services_TypeInfo,&local_4);
		  func_ii_13860(piVar2,uVar1,0);
		  func_ii_2010(piVar2,StringLiteral_1480,0);
		  uVar1 = unnamed_function_713(local_10 + -(param3_00 + 0xfU & 0xfffffff0),param2,param3_00);
		  uVar1 = func_ii_1081(**(undefined4 **)(param4 + 0x1c),uVar1);
		  func_ii_13860(piVar2,uVar1,0);
		  func_ii_2010(piVar2,StringLiteral_432,0);
		  func_ii_13860(piVar2,param3,0);
		  func_ii_2010(piVar2,StringLiteral_19094,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xdc));
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: LogEvent<__Il2CppFullySharedGenericStructType> ---
		undefined4
		Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		          (int param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__Add__);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  local_4 = (int *)0x0;
		  iVar2 = func_ii_7485(param1,param2,&local_4,0);
		  piVar3 = local_4;
		  if (iVar2 == 0) {
		    piVar3 = (int *)System_Delegate__Combine(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		    param1_00 = *(int **)(param1 + 0x20);
		    iVar2 = *param1_00;
		    local_4 = piVar3;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x821ea867;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x821ea867:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    uVar1 = 0;
		    uVar6 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		    iVar2 = *piVar3;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf8);
		          goto code_r0x821ea8fc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,7);
		code_r0x821ea8fc:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar3,param2,uVar5,uVar6,puVar4[1]);
		    iVar2 = Method_System_Collections_Generic_List_IAccountDataDecorator__Add__;
		    iVar7 = *(int *)(param1 + 0x18);
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar7 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar1 + 1;
		      *(int **)(*(int *)(iVar7 + 8) + uVar1 * 4 + 0x10) = local_4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar7,local_4,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		    piVar3 = local_4;
		    iVar2 = **(int **)(param3 + 0x1c);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (piVar3 != (int *)0x0) {
		      iVar7 = func_ii_1082(piVar3,iVar2);
		      if (iVar7 != 0) {
		        return iVar7;
		      }
		      System_Activator__CreateInstance(piVar3,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    iVar2 = **(int **)(param3 + 0x1c);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (piVar3 != (int *)0x0) {
		      iVar7 = func_ii_1082(piVar3,iVar2);
		      if (iVar7 != 0) {
		        return iVar7;
		      }
		      System_Activator__CreateInstance(piVar3,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return 0;
		}
		*/

}
