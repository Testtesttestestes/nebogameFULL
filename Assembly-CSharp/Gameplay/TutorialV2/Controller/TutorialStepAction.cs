using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	public class TutorialStepAction : ICompleteCallback, IDisposable
	{
		// Token: 0x0600199A RID: 6554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x6B38", Offset = "0x6B38", VA = "0x6B38")]
		public TutorialStepAction(StepActionType actionType)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_TutorialStepAction___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICompleteCallback__TypeInfo);
		    DAT_ram_00a583d4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ICompleteCallback__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ICompleteCallback__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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

		// Token: 0x1400011A RID: 282
		// (add) Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600199C RID: 6556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011A")]
		public event Action<ICompleteCallback> CompleteEvent
		{
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x6B39", Offset = "0x6B39", VA = "0x6B39", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x6B3A", Offset = "0x6B3A", VA = "0x6B3A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x6B3B", Offset = "0x6B3B", VA = "0x6B3B")]
		public void Complete()
		{
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x6B3C", Offset = "0x6B3C", VA = "0x6B3C", Slot = "6")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialV2_Controller_TutorialStepAction__Dispose
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a583d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICompleteCallback__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_ICompleteCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialStepsQueueBase_Unsubscribe__);
		    DAT_ram_00a583d7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_ICompleteCallback__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialStepsQueueBase_Unsubscribe__,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_TutorialV2_Controller_ICompleteCallback_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x80edf120;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_TutorialV2_Controller_ICompleteCallback_TypeInfo,1);
		code_r0x80edf120:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x8")]
		public readonly StepActionType ActionType;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_CompleteEvent ---
		void Gameplay_TutorialV2_Controller_TutorialStepAction__add_CompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICompleteCallback__TypeInfo);
		    DAT_ram_00a583d5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ICompleteCallback__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ICompleteCallback__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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
