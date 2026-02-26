using System;
using Core.Data;
using Core.Dict;
using Cysharp.Threading.Tasks;
using Gameplay.Antiq.Control;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Antiq
{
	// Token: 0x02000D7C RID: 3452
	[Token(Token = "0x2000D7C")]
	internal class Launch : IDisposable
	{
		// Token: 0x0600548E RID: 21646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548E")]
		[Address(RVA = "0xA241", Offset = "0xA241", VA = "0xA241", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Antiq_Launch__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar2;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5947c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_Launch_HandleInitEvent__);
		    DAT_ram_00a5947c = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) ||
		     (iVar1 = Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(*(int *)(param1 + 0x14),0),
		     iVar1 != 0)) {
		    iVar2 = *(int *)(param1 + 0xc);
		    param1_02 = *(undefined4 *)(iVar2 + 8);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Gameplay_Antiq_Launch_HandleInitEvent__,0);
		    param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		    iVar1 = System_Action_TypeInfo;
		    if (param1_01 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *param1_01) ||
		       (*(int **)(iVar2 + 8) = param1_01, *param1_01 != iVar1)) {
		      System_Activator__CreateInstance(param1_01,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x1E5B", Offset = "0x1E5B", VA = "0x1E5B")]
		public Launch(UserData user, IDictProvider dictProvider, PopupController popupController)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_Launch___ctor(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5947d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_Launch_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5947d = '\x01';
		  }
		  if (*(char *)(param2 + 0x18) == '\0') {
		    if (*(char *)(*(int *)(param2 + 8) + 9) == '\0') {
		      uVar1 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		      *(undefined4 *)(param2 + 0x14) = uVar1;
		      iVar3 = *(int *)(param2 + 0xc);
		      uVar2 = *(undefined4 *)(iVar3 + 8);
		      uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar1,param2,Method_Gameplay_Antiq_Launch_HandleInitEvent__,0);
		      param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		      param2_00 = System_Action_TypeInfo;
		      if (param1_00 == (int *)0x0) {
		        *(undefined4 *)(iVar3 + 8) = 0;
		      }
		      else if ((System_Action_TypeInfo != *param1_00) ||
		              (*(int **)(iVar3 + 8) = param1_00, *param1_00 != param2_00)) {
		        System_Activator__CreateInstance(param1_00,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      MVC_AbstractController__Dispose(*(undefined4 *)(param2 + 8),0);
		      Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		                (&local_8,*(undefined4 *)(param2 + 0x14),0);
		      *param1 = local_8;
		    }
		    else {
		      if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		      }
		      *param1 = *(undefined8 *)(*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x5c) + 8);
		    }
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_10376);
		  func_ii_11454(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_Antiq_Launch_Run__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005490")]
		[Address(RVA = "0xA242", Offset = "0xA242", VA = "0xA242")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x6005491")]
		[Address(RVA = "0x1E5C", Offset = "0x1E5C", VA = "0x1E5C")]
		public UniTask Run()
		{
			return default(UniTask);
		}

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x8")]
		public readonly AntiqController Controller;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0xC")]
		public readonly AntiqEvents Events;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x10")]
		public readonly AntiqModel Model;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x14")]
		private UniTaskCompletionSource _tcs;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x18")]
		private bool _isDisposed;
	}
}
