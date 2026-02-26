using System;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Control
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	public class GuideControlWindow : ClosableBaseWindow<GuideControlWindow.GuideControlWindowArgs>
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B2")]
		public override string WindowId
		{
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0x6C7E", Offset = "0x6C7E", VA = "0x6C7E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x6C7F", Offset = "0x6C7F", VA = "0x6C7F", Slot = "22")]
		protected override void OnShow(GuideControlWindow.GuideControlWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Tutorial_Guide_View_Control_GuideControlWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5846c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs__OnClose__
		              );
		    DAT_ram_00a5846c = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x6C80", Offset = "0x6C80", VA = "0x6C80", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Tutorial_Guide_View_Control_GuideControlWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5846d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs___ctor__
		              );
		    DAT_ram_00a5846d = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x6C81", Offset = "0x6C81", VA = "0x6C81")]
		public GuideControlWindow()
		{
		}

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Guide/GuideControlWindow";

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GuideControlView _view;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x40")]
		private GuideControlViewMediator _viewMediator;

		// Token: 0x02000473 RID: 1139
		[Token(Token = "0x2000473")]
		public class GuideControlWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0x6C82", Offset = "0x6C82", VA = "0x6C82")]
			public GuideControlWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Tutorial_Guide_View_Control_GuideControlWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  int iVar5;
		  
		  if (DAT_ram_00a5846b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_GuideControlViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5846b = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GuideControlWindow_GuideControlWindowArgs__OnShow__
		              );
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80ef01fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80ef01fe:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar5 + 0x104));
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80ef02c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80ef02c3:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                        (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar5 + 0x114));
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80ef0388;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80ef0388:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x10);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_Tutorial_Guide_GuideControlViewMediator_TypeInfo);
		  Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator___HandleGameOver_b__2_0
		            (piVar3,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x40) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

}
