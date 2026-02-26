using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Consts;
using Utils;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x0200126F RID: 4719
	[Token(Token = "0x200126F")]
	public abstract class AbstractCuratorDataProvider : ICuratorDataProvider, IDisposable
	{
		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FF7 RID: 28663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DA")]
		[CanBeNull]
		public CuratorService Service
		{
			[Token(Token = "0x6006FF6")]
			[Address(RVA = "0xBA44", Offset = "0xBA44", VA = "0xBA44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FF7")]
			[Address(RVA = "0xBA45", Offset = "0xBA45", VA = "0xBA45")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x00014598 File Offset: 0x00012798
		// (set) Token: 0x06006FF9 RID: 28665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DB")]
		public ClientPlatform Platform
		{
			[Token(Token = "0x6006FF8")]
			[Address(RVA = "0xBA46", Offset = "0xBA46", VA = "0xBA46")]
			[CompilerGenerated]
			get
			{
				return ClientPlatform.UnknownClientPlatform;
			}
			[Token(Token = "0x6006FF9")]
			[Address(RVA = "0xBA47", Offset = "0xBA47", VA = "0xBA47")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06006FFA RID: 28666 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FFB RID: 28667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DC")]
		[CanBeNull]
		public CuratorData Data
		{
			[Token(Token = "0x6006FFA")]
			[Address(RVA = "0xBA48", Offset = "0xBA48", VA = "0xBA48", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FFB")]
			[Address(RVA = "0xBA49", Offset = "0xBA49", VA = "0xBA49", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140002F7 RID: 759
		// (add) Token: 0x06006FFC RID: 28668 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006FFD RID: 28669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F7")]
		public event Action<ICuratorDataProvider> CompleteEvent
		{
			[Token(Token = "0x6006FFC")]
			[Address(RVA = "0xBA4A", Offset = "0xBA4A", VA = "0xBA4A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006FFD")]
			[Address(RVA = "0xBA4B", Offset = "0xBA4B", VA = "0xBA4B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0xBA4C", Offset = "0xBA4C", VA = "0xBA4C", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a880 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IOpToken__TypeInfo);
		    DAT_ram_00a5a880 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IOpToken__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IOpToken___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0xBA4D", Offset = "0xBA4D", VA = "0xBA4D")]
		public AbstractCuratorDataProvider(ClientPlatform platform, [NotNull] CuratorService service)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a882 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken__Add__);
		    DAT_ram_00a5a882 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_IOpToken__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a882 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken__Add__);
		    DAT_ram_00a5a882 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_IOpToken__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06007000 RID: 28672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007000")]
		[Address(RVA = "0xBA4E", Offset = "0xBA4E", VA = "0xBA4E")]
		public AbstractCuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007001")]
		[Address(RVA = "0xBA4F", Offset = "0xBA4F", VA = "0xBA4F")]
		protected void AddRequestToken(IOpToken token)
		{
		/* --- GHIDRA: AddRequestToken ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__AddRequestToken
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a883 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken__Remove__);
		    DAT_ram_00a5a883 = '\x01';
		  }
		  func_ii_4876(*(undefined4 *)(param1 + 8),param2,
		               Method_System_Collections_Generic_List_IOpToken__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007002")]
		[Address(RVA = "0xBA50", Offset = "0xBA50", VA = "0xBA50")]
		protected void RemoveRequestToken(IOpToken token)
		{
		/* --- GHIDRA: RemoveRequestToken ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a884 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2837);
		    DAT_ram_00a5a884 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_28663,StringLiteral_2837,*(undefined4 *)(param1 + 0x14),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007003")]
		[Address(RVA = "0xBA51", Offset = "0xBA51", VA = "0xBA51")]
		protected void Complete()
		{
		/* --- GHIDRA: Complete ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__Complete
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007004")]
		[Address(RVA = "0xBA52", Offset = "0xBA52", VA = "0xBA52", Slot = "11")]
		public virtual void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__Run
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a885 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IOpToken__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IOpToken__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IOpToken__get_Current__);
		    Mono_Security_ASN1__get_Item(&Utils_IOpToken_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IOpToken__GetEnumerator__);
		    DAT_ram_00a5a885 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_List_IOpToken__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IOpToken__MoveNext__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812838cf;
		    }
		    if (iVar2 == 0) goto code_r0x81283925;
		    piVar4 = local_8._4_4_;
		    iVar5 = *local_8._4_4_;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (Utils_IOpToken_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(piVar6[1] * 8 + iVar5 + 0xd8);
		          goto code_r0x81283872;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Utils_IOpToken_TypeInfo,3);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81283872:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar3,piVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812838cf:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81283925:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 8);
		      iVar2 = *(int *)(iVar5 + 0xc);
		      *(undefined4 *)(iVar5 + 0xc) = 0;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar2,0);
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x33,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007005")]
		[Address(RVA = "0xBA53", Offset = "0xBA53", VA = "0xBA53")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		undefined4
		Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__Stop
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a5a886 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a5a886 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_00 = func_ii_8783(&local_8,0);
		  if (iVar1 != 0) {
		    param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (param1_00,StringLiteral_19176,
		                           *(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007006 RID: 28678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007006")]
		[Address(RVA = "0xBA54", Offset = "0xBA54", VA = "0xBA54", Slot = "12")]
		public virtual string GetUserId(ulong userId)
		{
			return null;
		}

		// Token: 0x06007007 RID: 28679
		[Token(Token = "0x6007007")]
		public abstract void Commit();

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x8")]
		private List<IOpToken> _tokens;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a87e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICuratorDataProvider__TypeInfo);
		    DAT_ram_00a5a87e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ICuratorDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ICuratorDataProvider__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_CompleteEvent ---
		void Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__add_CompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a87f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICuratorDataProvider__TypeInfo);
		    DAT_ram_00a5a87f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ICuratorDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ICuratorDataProvider__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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
