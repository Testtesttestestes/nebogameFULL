using System;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	public class FrescoWindow : ClosableBaseWindow<FrescoWindow.FrescoWindowArgs>
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000965")]
		public override string WindowId
		{
			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0x805D", Offset = "0x805D", VA = "0x805D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x805E", Offset = "0x805E", VA = "0x805E", Slot = "22")]
		protected override void OnShow(FrescoWindow.FrescoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Fresco_View_FrescoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57578 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a57578 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs__OnClose__);
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80daa88e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80daa88e:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x805F", Offset = "0x805F", VA = "0x805F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Fresco_View_FrescoWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57579 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs___ctor__);
		    DAT_ram_00a57579 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x8060", Offset = "0x8060", VA = "0x8060")]
		public FrescoWindow()
		{
		}

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Fresco/FrescoWindow";

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FrescoView _view;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020007FB RID: 2043
		[Token(Token = "0x20007FB")]
		public class FrescoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFB")]
			[Address(RVA = "0x8061", Offset = "0x8061", VA = "0x8061")]
			public FrescoWindowArgs(FrescoController controller, UserData owner)
			{
			}

			// Token: 0x04001A3F RID: 6719
			[Token(Token = "0x4001A3F")]
			[FieldOffset(Offset = "0x18")]
			public readonly FrescoController Controller;

			// Token: 0x04001A40 RID: 6720
			[Token(Token = "0x4001A40")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserData Owner;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Fresco_View_FrescoWindow__get_WindowId(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  int iVar5;
		  
		  if (DAT_ram_00a57577 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a57577 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_FrescoWindow_FrescoWindowArgs__OnShow__);
		  iVar5 = **(int **)(param2 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(param2 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  iVar5 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar5 + 0x114));
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_Fresco_Controller_FrescoViewMediator_TypeInfo);
		  if (DAT_ram_00a575de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    DAT_ram_00a575de = '\x01';
		  }
		  uVar1 = 0;
		  MVC_AbstractController_object__object___set_Model
		            (param1_00,uVar2,param3_00,param4,
		             Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView___ctor__
		            );
		  *(undefined4 *)(param1_00[2] + 0x38) = uVar4;
		  *(int **)(param1 + 0x40) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x80daa78e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x80daa78e:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  return;
		}
		*/

}
