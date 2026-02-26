using System;
using Core.MVC.Interfaces;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	public class FrescoEditWindow : ClosableBaseWindow<FrescoEditWindow.FrescoEditWindowArgs>
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000959")]
		public override string WindowId
		{
			[Token(Token = "0x6002FB4")]
			[Address(RVA = "0x801A", Offset = "0x801A", VA = "0x801A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x801B", Offset = "0x801B", VA = "0x801B", Slot = "22")]
		protected override void OnShow(FrescoEditWindow.FrescoEditWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Fresco_View_FrescoEditWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5755b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5755b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs__OnClose__);
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da8487;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80da8487:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x801C", Offset = "0x801C", VA = "0x801C", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Fresco_View_FrescoEditWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5755c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs___ctor__)
		    ;
		    DAT_ram_00a5755c = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x801D", Offset = "0x801D", VA = "0x801D")]
		public FrescoEditWindow()
		{
		}

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Fresco/FrescoEditWindow";

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FrescoEditView _view;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020007EE RID: 2030
		[Token(Token = "0x20007EE")]
		public class FrescoEditWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FB8")]
			[Address(RVA = "0x801E", Offset = "0x801E", VA = "0x801E")]
			public FrescoEditWindowArgs(FrescoController controller)
			{
			}

			// Token: 0x04001A11 RID: 6673
			[Token(Token = "0x4001A11")]
			[FieldOffset(Offset = "0x18")]
			public readonly FrescoController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Fresco_View_FrescoEditWindow__get_WindowId(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a5755a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoEditViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5755a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_FrescoEditWindow_FrescoEditWindowArgs__OnShow__)
		  ;
		  iVar4 = **(int **)(param2 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(param2 + 0x18),*(undefined4 *)(iVar4 + 0x104));
		  iVar4 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar4 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Fresco_Controller_FrescoEditViewMediator_TypeInfo);
		  if (DAT_ram_00a575ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView___ctor__
		              );
		    DAT_ram_00a575ba = '\x01';
		  }
		  uVar1 = 0;
		  MVC_AbstractController_object__object___set_Model
		            (param1_00,uVar2,param3_00,param4,
		             Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView___ctor__
		            );
		  *(int **)(param1 + 0x40) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x80da8399;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x80da8399:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  return;
		}
		*/

}
