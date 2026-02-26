using System;
using Gameplay.EndlessPaymentOptionsList.Control;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	[RequireComponent(typeof(IndexButtonBasic))]
	public class EndlessPaymentOptionsListEntryPointView : MonoBehaviour
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C4")]
		public IndexButtonBasic Button
		{
			[Token(Token = "0x600318A")]
			[Address(RVA = "0x81E2", Offset = "0x81E2", VA = "0x81E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C5")]
		public BacktimeViewUGUI BackTimeView
		{
			[Token(Token = "0x600318B")]
			[Address(RVA = "0x81E3", Offset = "0x81E3", VA = "0x81E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C6")]
		public Transform Widget
		{
			[Token(Token = "0x600318C")]
			[Address(RVA = "0x81E4", Offset = "0x81E4", VA = "0x81E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x81E5", Offset = "0x81E5", VA = "0x81E5")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListEntryPointView__OnDestroy
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListEntryPointView__Awake
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x81E6", Offset = "0x81E6", VA = "0x81E6")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListEntryPointView__Awake
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  int iVar5;
		  
		  if (DAT_ram_00a57632 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57632 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x298);
		        goto code_r0x80dbb64f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80dbb64f:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x298);
		        goto code_r0x80dbb714;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80dbb714:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x298);
		        goto code_r0x80dbb7d9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80dbb7d9:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  piVar3 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_TypeInfo
		                            );
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController___HandleRun_b__4_0
		            (piVar3,param2_00,param3,param4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x18) = piVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x81E7", Offset = "0x81E7", VA = "0x81E7")]
		private void SetupMediator()
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x81E8", Offset = "0x81E8", VA = "0x81E8")]
		public EndlessPaymentOptionsListEntryPointView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListEntryPointView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57633 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12615);
		    DAT_ram_00a57633 = '\x01';
		  }
		  return StringLiteral_12615;
		}
		*/

		}

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _backTimeView;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _widget;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x18")]
		private EndlessPaymentOptionsListEntryPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Widget ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListEntryPointView__get_Widget
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		  return;
		}
		*/

}
