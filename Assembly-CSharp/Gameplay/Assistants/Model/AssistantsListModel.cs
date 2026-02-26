using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Assistants.Model
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class AssistantsListModel : AbstractModel
	{
		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF2")]
		public RepeatedField<AssistantsDic> AssistantsDicts
		{
			[Token(Token = "0x6004EC4")]
			[Address(RVA = "0x9CED", Offset = "0x9CED", VA = "0x9CED")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EC5")]
			[Address(RVA = "0x9CEE", Offset = "0x9CEE", VA = "0x9CEE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF3")]
		public List<BaseAssistant> Assistants
		{
			[Token(Token = "0x6004EC6")]
			[Address(RVA = "0x9CEF", Offset = "0x9CEF", VA = "0x9CEF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EC7")]
			[Address(RVA = "0x9CF0", Offset = "0x9CF0", VA = "0x9CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x9CF1", Offset = "0x9CF1", VA = "0x9CF1", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Assistants_Model_AssistantsListModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58972 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BaseAssistant__TypeInfo);
		    DAT_ram_00a58972 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BaseAssistant__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BaseAssistant___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x9CF2", Offset = "0x9CF2", VA = "0x9CF2")]
		public AssistantsListModel(Dictionary<AssistantsDic.Types.Assistants, Type> availAssistants, RepeatedField<AssistantsDic> assistantsDicts, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Assistants_Model_AssistantsListModel___ctor
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2_01;
		  
		  param2_01 = 0;
		  param2_00 = 0;
		  if (DAT_ram_00a58973 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__);
		    DAT_ram_00a58973 = '\x01';
		  }
		  *param3 = 0;
		  iVar3 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x14),param2_00,
		                         Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		      if (param2 == *(int *)(*(int *)(iVar1 + 8) + 0x10)) {
		        *param3 = iVar1;
		        return 1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x10),param2_01,
		                         Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__)
		      ;
		      if (param2 == *(int *)(iVar1 + 0x10)) {
		        if (DAT_ram_00a58975 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Count__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		          DAT_ram_00a58975 = '\x01';
		        }
		        iVar4 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		        if (0 < iVar4) {
		          param2_00 = 0;
		          do {
		            iVar2 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x14),param2_00,
		                               Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		            if (*(int *)(*(int *)(iVar2 + 8) + 0xc) == *(int *)(iVar1 + 0xc)) goto code_r0x80f50105;
		            param2_00 = param2_00 + 1;
		          } while (param2_00 != iVar4);
		        }
		        iVar2 = func_ii_7529(param1,iVar1,param2_00);
		code_r0x80f50105:
		        *param3 = iVar2;
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar3);
		  }
		  return (uint)(*param3 != 0);
		}
		*/

		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6004ECA")]
		[Address(RVA = "0x9CF3", Offset = "0x9CF3", VA = "0x9CF3")]
		public bool TryGetAssistantByAccount(uint accountId, out BaseAssistant assistant)
		{
		/* --- GHIDRA: TryGetAssistantByAccount ---
		undefined4
		Gameplay_Assistants_Model_AssistantsListModel__TryGetAssistantByAccount
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58975 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		    DAT_ram_00a58975 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x14),param2_00,
		                         Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		      if (*(int *)(*(int *)(iVar1 + 8) + 0xc) == *(int *)(param2 + 0xc)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  uVar2 = func_ii_7529(param1,param2,param2_00);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECB")]
		[Address(RVA = "0x1D6A", Offset = "0x1D6A", VA = "0x1D6A")]
		public BaseAssistant Create(AssistantsDic dic)
		{
			return null;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECC")]
		[Address(RVA = "0x9CF4", Offset = "0x9CF4", VA = "0x9CF4")]
		public BaseAssistant GetAssistant(AssistantsDic dic)
		{
		/* --- GHIDRA: GetAssistant ---
		undefined4
		Gameplay_Assistants_Model_AssistantsListModel__GetAssistant(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58976 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__);
		    DAT_ram_00a58976 = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (0 < iVar6) {
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x14),iVar1,
		                         Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		      if (*(int *)(*(int *)(iVar2 + 8) + 0xc) == param2) {
		        return iVar2;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar6);
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar1) {
		    iVar6 = 0;
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x10),iVar6,
		                         Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__)
		      ;
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        iVar1 = 0;
		        if (DAT_ram_00a58975 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Count__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		          DAT_ram_00a58975 = '\x01';
		        }
		        iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		        if (0 < iVar6) {
		          do {
		            iVar3 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x14),iVar1,
		                               Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		            if (*(int *)(*(int *)(iVar3 + 8) + 0xc) == *(int *)(iVar2 + 0xc)) {
		              return iVar3;
		            }
		            iVar1 = iVar1 + 1;
		          } while (iVar1 != iVar6);
		        }
		        uVar4 = func_ii_7529(param1,iVar2,iVar1);
		        return uVar4;
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar1);
		  }
		  local_4 = param2;
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar5 = unnamed_function_2232(&StringLiteral_3347);
		  uVar4 = func_ii_4419(uVar5,uVar4,0);
		  uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar5 = unnamed_function_1417(uVar5);
		  System_String__Concat(uVar5,uVar4,0);
		  uVar4 = unnamed_function_2232
		                    (&Method_Gameplay_Assistants_Model_AssistantsListModel_GetAssistant__);
		  func_ii_1050(uVar5,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: GetAssistant ---
		undefined4
		Gameplay_Assistants_Model_AssistantsListModel__GetAssistant(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58976 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__);
		    DAT_ram_00a58976 = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (0 < iVar6) {
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x14),iVar1,
		                         Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		      if (*(int *)(*(int *)(iVar2 + 8) + 0xc) == param2) {
		        return iVar2;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar6);
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar1) {
		    iVar6 = 0;
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x10),iVar6,
		                         Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__get_Item__)
		      ;
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        iVar1 = 0;
		        if (DAT_ram_00a58975 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Count__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		          DAT_ram_00a58975 = '\x01';
		        }
		        iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		        if (0 < iVar6) {
		          do {
		            iVar3 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x14),iVar1,
		                               Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		            if (*(int *)(*(int *)(iVar3 + 8) + 0xc) == *(int *)(iVar2 + 0xc)) {
		              return iVar3;
		            }
		            iVar1 = iVar1 + 1;
		          } while (iVar1 != iVar6);
		        }
		        uVar4 = func_ii_7529(param1,iVar2,iVar1);
		        return uVar4;
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar1);
		  }
		  local_4 = param2;
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar5 = unnamed_function_2232(&StringLiteral_3347);
		  uVar4 = func_ii_4419(uVar5,uVar4,0);
		  uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar5 = unnamed_function_1417(uVar5);
		  System_String__Concat(uVar5,uVar4,0);
		  uVar4 = unnamed_function_2232
		                    (&Method_Gameplay_Assistants_Model_AssistantsListModel_GetAssistant__);
		  func_ii_1050(uVar5,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECD")]
		[Address(RVA = "0x9CF5", Offset = "0x9CF5", VA = "0x9CF5")]
		public BaseAssistant GetAssistant(uint id)
		{
			return null;
		}

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<AssistantsDic.Types.Assistants, Type> AvailAssistants;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Assistants ---
		void Gameplay_Assistants_Model_AssistantsListModel__set_Assistants(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0xc) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
