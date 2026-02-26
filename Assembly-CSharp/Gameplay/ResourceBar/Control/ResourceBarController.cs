using System;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.ResourceBar.Control
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	public class ResourceBarController : AbstractController<ResourceBarModel, ResourceBarEvents>
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x7244", Offset = "0x7244", VA = "0x7244")]
		public ResourceBarController(ResourceBarModel model, ResourceBarEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ResourceBar_Control_ResourceBarController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58341 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarController_PopupControllerOnOnChangeStateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarController_UserOnOnUserBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a58341 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar2,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarController_UserOnOnUserBalanceChangedEvent__
		             ,0);
		  Core_Data_UserData__add_BalanceChangedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar2,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarController_PopupControllerOnOnChangeStateEvent__
		             ,0);
		  UI_Windows_PopupController__add_OnChangeStateEvent(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x7245", Offset = "0x7245", VA = "0x7245", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_ResourceBar_Control_ResourceBarController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58342 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarController_PopupControllerOnOnChangeStateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarController_UserOnOnUserBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a58342 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar2,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarController_UserOnOnUserBalanceChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserInfoChangedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar2,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarController_PopupControllerOnOnChangeStateEvent__
		             ,0);
		  UI_Windows_Layer___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x7246", Offset = "0x7246", VA = "0x7246", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ResourceBar_Control_ResourceBarController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x7247", Offset = "0x7247", VA = "0x7247")]
		private void PopupControllerOnOnChangeStateEvent(int visibleFullscreenWndCount)
		{
		/* --- GHIDRA: PopupControllerOnOnChangeStateEvent ---
		void Gameplay_ResourceBar_Control_ResourceBarController__PopupControllerOnOnChangeStateEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x7248", Offset = "0x7248", VA = "0x7248")]
		private void UserOnOnUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: UserOnOnUserBalanceChangedEvent ---
		void Gameplay_ResourceBar_Control_ResourceBarController__UserOnOnUserBalanceChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58343 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView___ctor__
		              );
		    DAT_ram_00a58343 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
