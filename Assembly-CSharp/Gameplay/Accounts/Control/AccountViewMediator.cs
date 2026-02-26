using System;
using System.Collections.Generic;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Gameplay.Accounts.View.Accounts;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE4 RID: 3556
	[Token(Token = "0x2000DE4")]
	public class AccountViewMediator : AbstractCozyViewMediator<AccountsModel, AccountsEvents, AccountsController, DefaultAccountView>
	{
		// Token: 0x060056C9 RID: 22217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0xA448", Offset = "0xA448", VA = "0xA448", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Control_AccountViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		    DAT_ram_00a588cb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0xA449", Offset = "0xA449", VA = "0xA449")]
		public AccountViewMediator(DefaultAccountView view, AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Control_AccountViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountStickerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IList_IAccountDataDecorator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a588cc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountChangedEvent__,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IList_IAccountDataDecorator___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountStickerChangedEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_IList_IAccountDataDecorator___TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar1 + 0x18) = iVar4;
		    uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IList_IAccountDataDecorator___TypeInfo);
		    if (iVar1 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0xA44A", Offset = "0xA44A", VA = "0xA44A", Slot = "21")]
		protected override void ResetEvents(AccountsEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Accounts_Control_AccountViewMediator__ResetEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountStickerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IList_IAccountDataDecorator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a588cd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountChangedEvent__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IList_IAccountDataDecorator___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountViewMediator_HandleAccountStickerChangedEvent__
		             ,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_IList_IAccountDataDecorator___TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar1 + 0x18) = iVar4;
		    uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IList_IAccountDataDecorator___TypeInfo);
		    if (iVar1 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0xA44B", Offset = "0xA44B", VA = "0xA44B", Slot = "22")]
		protected override void SetupEvents(AccountsEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Accounts_Control_AccountViewMediator__SetupEvents
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Accounts_Control_AccountViewMediator__DisplayOptionsButtons
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CD")]
		[Address(RVA = "0xA44C", Offset = "0xA44C", VA = "0xA44C", Slot = "23")]
		protected override void ResetView(DefaultAccountView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Accounts_Control_AccountViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  uint *puVar2;
		  float fVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int param2_00;
		  undefined4 uVar6;
		  int *piVar7;
		  int *piVar8;
		  undefined8 uVar9;
		  double param1_00;
		  uint uVar10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    DAT_ram_00a588ce = '\x01';
		  }
		  local_8 = 0;
		  uVar9 = CONCAT44(in_register_20000004,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 200);
		        goto code_r0x80f3d972;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80f3d972:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar5,piVar7),puVar2[1]);
		  uVar9 = *(undefined8 *)(iVar1 + 0x18);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = Utils_StringUtils___cctor(uVar9,0);
		  param1_00 = (double)fVar3;
		  uVar4 = Utils_TimeUtils__DateFormat(param1_00,0);
		  uVar5 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_22759,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  uVar9 = CONCAT44(uVar5,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x1c);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  piVar8 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar8;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3da6f;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,0
		                               );
		code_r0x80f3da6f:
		  uVar9 = CONCAT44(uVar5,piVar8);
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  iVar1 = *piVar7;
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),piVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))(uVar9,uVar5,*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x20);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar10 = 0;
		  piVar8 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar8;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 200);
		        goto code_r0x80f3db3b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80f3db3b:
		  uVar10 = 0;
		  uVar9 = CONCAT44(uVar5,piVar8);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar4 = Core_Extensions_Dict_AccountDicExt__GetTitleInBanner(uVar4,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar1,0);
		  iVar1 = *piVar7;
		  uVar9 = CONCAT44(uVar5,piVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))(uVar9,uVar4,*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x24);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  piVar8 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar8;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 200);
		        goto code_r0x80f3dc30;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80f3dc30:
		  uVar9 = CONCAT44(uVar5,piVar8);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  iVar1 = Core_Extensions_Dict_AccountDicExt__GetDescriptionInBanner(uVar4,0);
		  if (iVar1 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    param2_00 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    *(undefined8 *)(param2_00 + 0x10) = local_8;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (iVar1,param2_00,0);
		  }
		  iVar1 = *piVar7;
		  uVar9 = CONCAT44(uVar5,piVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))(uVar9,uVar4,*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x38);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 200);
		        goto code_r0x80f3dd2b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80f3dd2b:
		  uVar10 = 0;
		  uVar9 = CONCAT44(uVar5,piVar7);
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar6 = Core_Extensions_Dict_AccountDicExt__GetContentResourceAssetId(uVar6,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar6,0);
		  uVar9 = CONCAT44(uVar5,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  Gameplay_Accounts_Control_AccountViewMediator__HandleAccountChangedEvent
		            (param1,*(undefined4 *)(iVar1 + 0x28),param1);
		  uVar9 = CONCAT44(uVar5,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe0);
		        goto code_r0x80f3ddf5;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4
		                               );
		code_r0x80f3ddf5:
		  uVar9 = CONCAT44(uVar5,piVar7);
		  (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  Gameplay_Accounts_Control_AccountViewMediator__ValidateActivation(param1,param1,param1);
		  uVar9 = CONCAT44(uVar5,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x44);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar10 = 0;
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe8);
		        goto code_r0x80f3deb6;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,5
		                               );
		code_r0x80f3deb6:
		  uVar9 = CONCAT44(uVar5,piVar7);
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(uVar9,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar6 = func_ii_7483(uVar6,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar6,0);
		  piVar7 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (CONCAT44(uVar5,param1),*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))
		                    (piVar7,*(undefined4 *)(*piVar7 + 0x104));
		  *(undefined4 *)(iVar1 + 0x1c) = uVar5;
		  return;
		}
		*/

		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CE")]
		[Address(RVA = "0xA44D", Offset = "0xA44D", VA = "0xA44D", Slot = "24")]
		protected override void SetupView(DefaultAccountView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Accounts_Control_AccountViewMediator__SetupView
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int *piVar10;
		  int iVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a588cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a588cf = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3eb46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo
		                                ,0);
		code_r0x80f3eb46:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar11 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f3ec24;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3ec6c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3f111;
		    }
		code_r0x80f3ec24:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3ec6c;
		    if (iVar11 == 0) {
		      iVar11 = 0;
		      goto code_r0x80f3f15a;
		    }
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar11 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f3ed0f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3efbc:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3f111;
		    }
		code_r0x80f3ed0f:
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3efbc;
		    iVar11 = *piVar7;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar11 + 200);
		          goto code_r0x80f3ede0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3efc6:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3f111;
		    }
		code_r0x80f3ede0:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3efc6;
		    iVar8 = *(int *)(iVar11 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3f111;
		    }
		    piVar9 = *(int **)(iVar6 + 0x28);
		    iVar11 = *piVar9;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar11 + 200);
		          goto code_r0x80f3ef01;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,
		                        Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3efda:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3f111;
		    }
		code_r0x80f3ef01:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar3,piVar9,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3efda;
		  } while (iVar8 != *(int *)(iVar11 + 0xc));
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii
		                    (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    uVar4 = *(undefined4 *)(iVar6 + 0x44);
		    iVar11 = *piVar7;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		          puVar3 = (undefined4 *)
		                   (*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xe8);
		          goto code_r0x80f3f053;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,5);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x80f3f053:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b5,uVar5,0);
		        if (DAT_ram_009d3e38 != 1) {
		          iVar11 = 0;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,uVar4,uVar5,0);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80f3f15a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3f111;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80f3f111:
		  iVar11 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar11 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar11;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80f3f15a:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f3f1d2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f3f1d2:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (iVar11 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b6,&local_c);
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056CF RID: 22223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0xA44E", Offset = "0xA44E", VA = "0xA44E")]
		private void HandleAccountStickerChangedEvent(IList<IAccountDataDecorator> list)
		{
		/* --- GHIDRA: HandleAccountStickerChangedEvent ---
		void Gameplay_Accounts_Control_AccountViewMediator__HandleAccountStickerChangedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param2_00;
		  int param3_00;
		  
		  if (DAT_ram_00a588d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    DAT_ram_00a588d0 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param2 == *(int **)(iVar2 + 0x28)) {
		    param3_00 = *param1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(param3_00 + 0x158) * 4))
		                      (param1,*(undefined4 *)(param3_00 + 0x15c));
		    Gameplay_Accounts_Control_AccountViewMediator__HandleAccountChangedEvent
		              (param1,*(undefined4 *)(iVar2 + 0x28),param3_00);
		    Gameplay_Accounts_Control_AccountViewMediator__DisplayOptionsButtons(param1,param1[6],param3_00)
		    ;
		    uVar1 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x80f3f317;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param2_00 = (uint *)func_ii_1080(param2,
		                                     Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4);
		code_r0x80f3f317:
		    (**(code **)((ulonglong)*param2_00 * 4))(param2,param2_00[1]);
		    Gameplay_Accounts_Control_AccountViewMediator__ValidateActivation(param1,param2_00,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0xA44F", Offset = "0xA44F", VA = "0xA44F")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		/* --- GHIDRA: HandleAccountChangedEvent ---
		void Gameplay_Accounts_Control_AccountViewMediator__HandleAccountChangedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a588d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2478);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2479);
		    DAT_ram_00a588d1 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80f3dfd5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3dfd5:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar3 + 0x30);
		  if (iVar6 == 0) {
		    uVar1 = 0;
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		           ) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x80f3e0e5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Data_Accounts_IAccountData_TypeInfo,1);
		code_r0x80f3e0e5:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar4,param2_00,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar5 = *(int **)(iVar6 + 0x34);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2479,1,0,1,0,0,0,0);
		    iVar6 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar5,uVar4,*(undefined4 *)(iVar6 + 0x2d4));
		  }
		  else {
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar4,0,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar5 = *(int **)(iVar6 + 0x34);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2478,1,0,1,0,0,0,0);
		    iVar6 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar5,uVar4,*(undefined4 *)(iVar6 + 0x2d4));
		  }
		  piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))(piVar5,*(undefined4 *)(*piVar5 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0xA450", Offset = "0xA450", VA = "0xA450")]
		private void ValidateActivation(IAccountDataDecorator account)
		{
		/* --- GHIDRA: ValidateActivation ---
		void Gameplay_Accounts_Control_AccountViewMediator__ValidateActivation
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  int iVar9;
		  uint uVar10;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountViewMediator_HandleOptionClickEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_OptionBuyButtonItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OptionBuyButtonItem__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountOptionData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_OptionBuyButtonItem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a588d2 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x28);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x80f3e290;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4
		                               );
		code_r0x80f3e290:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar4,
		             Method_System_Collections_Generic_List_AccountOptionData__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = local_20;
		  local_28 = 0;
		  local_24 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountOptionData__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    iVar2 = local_28;
		    if (iVar5 == 0) goto code_r0x80f3e9f4;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = local_8._4_4_;
		    iVar6 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) break;
		    uVar4 = *(undefined4 *)(iVar6 + 0x3c);
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    uVar8 = *(undefined4 *)(iVar6 + 0x40);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3e9ab;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar4,uVar8,
		                       Method_UnityEngine_Object_Instantiate_OptionBuyButtonItem___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    *(int *)(iVar6 + 0x28) = iVar5;
		    piVar7 = *(int **)(iVar6 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b2,
		                       *(undefined4 *)(iVar5 + 0x70),0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3e97b:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar2 + 0x2d0),piVar7,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e97b;
		    iVar2 = **(int **)(iVar6 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar2 + 0x2d0),*(int **)(iVar6 + 0x18),
		               *(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x18),*(undefined4 *)(iVar2 + 0x2d4));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    piVar7 = *(int **)(iVar6 + 0x20);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = Core_Extensions_Dict_AccountOptionsDicExt__GetTitle(iVar5,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    local_30 = 0;
		    DAT_ram_009d3e38 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_30,uVar4,Method_System_Nullable_int___ctor__);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3e95d:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    iVar2 = *piVar7;
		    local_20 = local_30;
		    DAT_ram_009d3e38 = 0;
		    local_38 = local_30;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar2 + 0x138),piVar7,&local_38,*(undefined4 *)(iVar2 + 0x13c));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e95d;
		    iVar9 = *(int *)(iVar5 + 0x74);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                       *(undefined4 *)(iVar6 + 0x1c),0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar4,(uint)(iVar9 != 0),0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    if (iVar9 != 0) {
		      iVar2 = **(int **)(iVar6 + 0x1c);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (*(undefined4 *)(iVar2 + 0x2d0),*(int **)(iVar6 + 0x1c),
		                 *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x74) + 0x18) + 0x18),
		                 *(undefined4 *)(iVar2 + 0x2d4));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3e9ab;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OptionBuyButtonItem__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3e92b:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3e9ab;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_Accounts_Control_AccountViewMediator_HandleOptionClickEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e92b;
		    if (DAT_ram_00a58898 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_OptionBuyButtonItem__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e92b;
		      DAT_ram_00a58898 = '\x01';
		    }
		    iVar2 = *(int *)(iVar6 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar2,uVar4,0);
		      uVar8 = System_Action_OptionBuyButtonItem__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3e90d:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3e9ab;
		      }
		      if (iVar5 == 0) {
		        iVar9 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                           System_Action_OptionBuyButtonItem__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e90d;
		        if (iVar9 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,uVar8);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f3e9ab;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = func_ii_4329(iVar6 + 0x24,iVar9,iVar2);
		      iVar5 = Method_System_Collections_Generic_List_OptionBuyButtonItem__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3e90d;
		      bVar1 = iVar2 != iVar9;
		      iVar2 = iVar9;
		    } while (bVar1);
		    iVar2 = param1[6];
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar2 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar10 * 4 + 0x10) = iVar6;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar6,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3e9ab:
		        iVar2 = global_1;
		        iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 == iVar5) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar2 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          local_28 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		code_r0x80f3e9f4:
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 0) {
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b4,&local_28);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80f3e9ab;
		}
		*/

		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0xA451", Offset = "0xA451", VA = "0xA451")]
		private void DisplayOptionsButtons(List<AccountOptionData> options)
		{
		/* --- GHIDRA: DisplayOptionsButtons ---
		void Gameplay_Accounts_Control_AccountViewMediator__DisplayOptionsButtons
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param3_00;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountViewMediator_HandleOptionClickEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_OptionBuyButtonItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionBuyButtonItem__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionBuyButtonItem__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionBuyButtonItem__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a588d3 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,
		             Method_System_Collections_Generic_List_OptionBuyButtonItem__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_OptionBuyButtonItem__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3d784:
		      iVar6 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar2) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f3d833:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = *(int *)(param2 + 0xc);
		          *(undefined4 *)(param2 + 0xc) = 0;
		          *(int *)(param2 + 0x10) = *(int *)(param2 + 0x10) + 1;
		          if (0 < iVar6) {
		            func_ii_2064(*(undefined4 *)(param2 + 8),0,iVar6,0);
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b1,&local_20);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar2 == 0) goto code_r0x80f3d833;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = local_8._4_4_;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3d77c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3d784;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d77c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d77c;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OptionBuyButtonItem__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3d772:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3d784;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_Accounts_Control_AccountViewMediator_HandleOptionClickEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d772;
		    if (DAT_ram_00a58899 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_OptionBuyButtonItem__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d772;
		      DAT_ram_00a58899 = '\x01';
		    }
		    iVar2 = *(int *)(iVar6 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar4,0);
		      param3_00 = System_Action_OptionBuyButtonItem__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3d75e:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3d784;
		      }
		      if (iVar3 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_OptionBuyButtonItem__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d75e;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,param3_00);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f3d784;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = func_ii_4329(iVar6 + 0x24,param2_00,iVar2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3d75e;
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D3")]
		[Address(RVA = "0xA452", Offset = "0xA452", VA = "0xA452")]
		private void RemoveOptionsButtons(List<OptionBuyButtonItem> optionButtons)
		{
		/* --- GHIDRA: RemoveOptionsButtons ---
		void Gameplay_Accounts_Control_AccountViewMediator__RemoveOptionsButtons
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Accounts_Control_AccountsController__BuyAccount
		            (param1_00,*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(param2 + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D4")]
		[Address(RVA = "0xA453", Offset = "0xA453", VA = "0xA453")]
		private void HandleOptionClickEvent(OptionBuyButtonItem optionView)
		{
		/* --- GHIDRA: HandleOptionClickEvent ---
		void Gameplay_Accounts_Control_AccountViewMediator__HandleOptionClickEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AccountsModel__AccountsEvents__Dispose__);
		    DAT_ram_00a588d4 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x1c),0);
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_AccountsModel__AccountsEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		public const string LOCALIZATION_ACTION_TITLE_ACTIVATE = "ACCOUNT/ACTION_TITLE/ACTIVATE";

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		public const string LOCALIZATION_ACTION_TITLE_EXTEND = "ACCOUNT/ACTION_TITLE/EXTEND";

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<OptionBuyButtonItem> _optionBuyButtonItems;
	}
}
