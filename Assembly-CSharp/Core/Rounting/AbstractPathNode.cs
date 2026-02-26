using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Utils;

namespace Core.Rounting
{
	// Token: 0x02000E79 RID: 3705
	[Token(Token = "0x2000E79")]
	public abstract class AbstractPathNode
	{
		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001260")]
		public string Name
		{
			[Token(Token = "0x6005A36")]
			[Address(RVA = "0xA740", Offset = "0xA740", VA = "0xA740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A37")]
			[Address(RVA = "0xA741", Offset = "0xA741", VA = "0xA741")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001261")]
		public LinkedListNode<AbstractPathNode> Owner
		{
			[Token(Token = "0x6005A38")]
			[Address(RVA = "0xA742", Offset = "0xA742", VA = "0xA742")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A39")]
			[Address(RVA = "0xA743", Offset = "0xA743", VA = "0xA743")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A3B RID: 23099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001262")]
		public IGame Game
		{
			[Token(Token = "0x6005A3A")]
			[Address(RVA = "0xA744", Offset = "0xA744", VA = "0xA744")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A3B")]
			[Address(RVA = "0xA745", Offset = "0xA745", VA = "0xA745")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001263")]
		public OpTokenRepository TokenRepository
		{
			[Token(Token = "0x6005A3C")]
			[Address(RVA = "0xA746", Offset = "0xA746", VA = "0xA746")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A3D")]
			[Address(RVA = "0xA747", Offset = "0xA747", VA = "0xA747")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0xA748", Offset = "0xA748", VA = "0xA748")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Rounting_AbstractPathNode__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6056c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AbstractPathNode___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_LinkedListNode_AbstractPathNode__TypeInfo);
		    DAT_ram_00a6056c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_LinkedListNode_AbstractPathNode__TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title
		            (param1_00,param1,
		             Method_System_Collections_Generic_LinkedListNode_AbstractPathNode___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0xA749", Offset = "0xA749", VA = "0xA749")]
		protected AbstractPathNode()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Rounting_AbstractPathNode___ctor(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int param1_03;
		  
		  if (DAT_ram_00a6056d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Rounting_AbstractPathNode_HandleCancel__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Rounting_AbstractPathNode_HandleFault__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Rounting_AbstractPathNode_HandleResult__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_LocatorPayload__AbstractPathNode___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__AddHandlers__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__SetCancelHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo);
		    DAT_ram_00a6056d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo)
		  ;
		  Utils_OpToken___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,Method_Utils_OpToken_LocatorPayload__AbstractPathNode___ctor__);
		  param1_01 = unnamed_function_1417
		                        (System_Action_OpToken_LocatorPayload__AbstractPathNode___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Core_Rounting_AbstractPathNode_HandleResult__,0);
		  param1_02 = unnamed_function_1417
		                        (System_Action_OpToken_LocatorPayload__AbstractPathNode___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,Method_Core_Rounting_AbstractPathNode_HandleFault__,0);
		  Gameplay_FeedbackForm_Service_FeedbackFormService__SubmitFormInternal
		            (param1_00,param1_01,param1_02,
		             Method_Utils_OpToken_LocatorPayload__AbstractPathNode__AddHandlers__);
		  param1_03 = unnamed_function_1417
		                        (System_Action_OpToken_LocatorPayload__AbstractPathNode___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_03,param1,Method_Core_Rounting_AbstractPathNode_HandleCancel__,0);
		  param1_00[7] = param1_03;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  Utils_OpTokenRepository__TryGet(param1[5],param1_00,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,param1[4],param1_00,param2,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0xA74A", Offset = "0xA74A", VA = "0xA74A")]
		public void Execute(LocatorPayload payload)
		{
		/* --- GHIDRA: Execute ---
		void Core_Rounting_AbstractPathNode__Execute(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6056e == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19187);
		    DAT_ram_00a6056e = '\x01';
		  }
		  param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_12324,param1[2],StringLiteral_19187,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  Utils_OpTokenRepository__Add(param1[5],param2,0);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,*(undefined4 *)(*param2 + 0x10c));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A41")]
		[Address(RVA = "0xA74B", Offset = "0xA74B", VA = "0xA74B")]
		private void HandleCancel(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		/* --- GHIDRA: HandleCancel ---
		void Core_Rounting_AbstractPathNode__HandleCancel(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int iVar3;
		  
		  unnamed_function_2232(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__get_Fault__);
		  iVar3 = *(int *)param2[9];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xd8) * 4))
		                    ((int *)param2[9],*(undefined4 *)(iVar3 + 0xdc));
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x14),param2,0);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,*(undefined4 *)(*param2 + 0x10c));
		  param2_00 = *(undefined4 *)(param1 + 8);
		  uVar2 = unnamed_function_2232(&StringLiteral_12323);
		  param3_00 = unnamed_function_2232(&StringLiteral_1240);
		  uVar1 = System_Int32__ToString(uVar2,param2_00,param3_00,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  System_String__Concat(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_Core_Rounting_AbstractPathNode_HandleFault__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A42")]
		[Address(RVA = "0xA74C", Offset = "0xA74C", VA = "0xA74C")]
		private void HandleFault(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		/* --- GHIDRA: HandleFault ---
		void Core_Rounting_AbstractPathNode__HandleFault(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6056f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AbstractPathNode__get_Next__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AbstractPathNode__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__get_Result__);
		    DAT_ram_00a6056f = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x14),param2,0);
		  iVar1 = System_Net_Sockets_Socket__Bind
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_LinkedListNode_AbstractPathNode__get_Next__);
		  if (iVar1 != 0) {
		    Core_Rounting_AbstractPathNode___ctor(*(undefined4 *)(iVar1 + 0x14),param2[8],param2);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,*(undefined4 *)(*param2 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A43")]
		[Address(RVA = "0xA74D", Offset = "0xA74D", VA = "0xA74D")]
		private void HandleResult(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		/* --- GHIDRA: HandleResult ---
		undefined4 Core_Rounting_AbstractPathNode__HandleResult(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60570 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a60570 = '\x01';
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                    (StringLiteral_1618,*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0xA74E", Offset = "0xA74E", VA = "0xA74E", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x6005A45")]
		[Address(RVA = "0xA74F", Offset = "0xA74F", VA = "0xA74F", Slot = "4")]
		public virtual bool Check()
		{
		/* --- GHIDRA: Check ---
		int Core_Rounting_AbstractPathNode__Check(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60571 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a60571 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,2);
		  if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Uri_TypeInfo);
		  }
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(*(int *)(System_Uri_TypeInfo + 0x5c) + 0xc);
		  *(undefined4 *)(iVar1 + 0x14) = *(undefined4 *)(*(int *)(System_Uri_TypeInfo + 0x5c) + 0x10);
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A46 RID: 23110
		[Token(Token = "0x6005A46")]
		protected abstract void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload);

		// Token: 0x06005A47 RID: 23111
		[Token(Token = "0x6005A47")]
		protected abstract void TransitionCanceled();
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_TokenRepository ---
		void Core_Rounting_AbstractPathNode__set_TokenRepository(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0xc) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

}
