using System;
using System.Collections.Generic;
using Gameplay.Accounts.Clan.Model;
using Gameplay.Accounts.Clan.View;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Control
{
	// Token: 0x02000DF1 RID: 3569
	[Token(Token = "0x2000DF1")]
	public class ClanAccountViewMediator : AbstractViewMediator<ClanAccountModel, AccountsEvents, ClanAccountController, ClanAccountView>
	{
		// Token: 0x0600571B RID: 22299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571B")]
		[Address(RVA = "0xA497", Offset = "0xA497", VA = "0xA497", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		    DAT_ram_00a588f8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600571C RID: 22300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571C")]
		[Address(RVA = "0xA498", Offset = "0xA498", VA = "0xA498")]
		public ClanAccountViewMediator(ClanAccountModel model, AccountsEvents events, ClanAccountController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a588f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanAccountTabView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleTabSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a588f9 = '\x01';
		  }
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar6 = UnityEngine_Component__GetComponent_object_(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_ClanAccountTabView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleTabSelectedEvent__
		               ,0);
		    if (DAT_ram_00a588ee == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanAccountTabView__TypeInfo);
		      DAT_ram_00a588ee = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x50);
		    do {
		      iVar4 = 0;
		      iVar7 = func_ii_7048(iVar3,uVar5,0);
		      uVar2 = System_Action_ClanAccountTabView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_ClanAccountTabView__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x50,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar6 = UnityEngine_Component__GetComponent_object_(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_ClanAccountTabView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleTabSelectedEvent__
		               ,0);
		    if (DAT_ram_00a588ed == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanAccountTabView__TypeInfo);
		      DAT_ram_00a588ed = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x50);
		    do {
		      iVar4 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar2 = System_Action_ClanAccountTabView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_ClanAccountTabView__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x50,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__HandleTabSelectedEvent(param1,iVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011C3 RID: 4547
		// (set) Token: 0x0600571D RID: 22301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C3")]
		public override ClanAccountView View
		{
			[Token(Token = "0x600571D")]
			[Address(RVA = "0xA499", Offset = "0xA499", VA = "0xA499", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (set) Token: 0x0600571E RID: 22302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C4")]
		public override AccountsEvents Events
		{
			[Token(Token = "0x600571E")]
			[Address(RVA = "0xA49A", Offset = "0xA49A", VA = "0xA49A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571F")]
		[Address(RVA = "0xA49B", Offset = "0xA49B", VA = "0xA49B")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		/* --- GHIDRA: HandleAccountChangedEvent ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__HandleAccountChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a588fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		    DAT_ram_00a588fc = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 100);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(int **)(*(int *)(param1 + 8) + 0x14) = param1_00;
		  Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__SetupView(param1,param1_00,param1);
		  Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__DisplayOptionsButtons
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__DisplayAccountInformation
		            (param1,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005720 RID: 22304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005720")]
		[Address(RVA = "0xA49C", Offset = "0xA49C", VA = "0xA49C")]
		private void HandleTabSelectedEvent(ClanAccountTabView tab)
		{
		/* --- GHIDRA: HandleTabSelectedEvent ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__HandleTabSelectedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a588fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3583);
		    DAT_ram_00a588fd = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x1c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(int **)(iVar2 + 0x28);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4603f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,0);
		code_r0x80f4603f:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(StringLiteral_3583,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(*piVar6 + 0x2d4));
		  func_ii_7511(param1,piVar6);
		  iVar2 = **(int **)(param1[2] + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x160) * 4))
		            (*(int **)(param1[2] + 0x10),&local_4,*(undefined4 *)(iVar2 + 0x164));
		  uVar4 = *(undefined4 *)(local_4 + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x40);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param2_00 = 0;
		  iVar2 = UnityEngine_Mathf__Min(uVar4,*(undefined4 *)(iVar2 + 0xc),0);
		  if (0 < iVar2) {
		    do {
		      iVar5 = System_Linq_Enumerable__ToList_object_
		                        (local_4,param2_00,
		                         Method_System_Collections_Generic_List_IAccountDataDecorator__get_Item__);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Accounts_Clan_View_ClanAccountView__Init(uVar4,param2_00,iVar5,param2_00);
		      if (*(int *)(param1[2] + 0x14) == iVar5) {
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        Gameplay_Accounts_Clan_View_ClanAccountView__SelectTab
		                  (iVar5,*(undefined4 *)(*(int *)(iVar5 + 0x40) + param2_00 * 4 + 0x10),param2_00);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005721 RID: 22305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005721")]
		[Address(RVA = "0xA49D", Offset = "0xA49D", VA = "0xA49D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  ulonglong uVar1;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  int iVar9;
		  uint *puVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  int *piVar13;
		  uint uVar14;
		  int local_24;
		  int **local_20;
		  int *local_1c;
		  float8 local_18;
		  int *local_10;
		  int local_c;
		  int *local_8;
		  int local_4;
		  
		  if (DAT_ram_00a588ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    DAT_ram_00a588ff = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  local_c = 0;
		  local_10 = (int *)0x0;
		  local_18 = 0.0;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar1 = uVar1 & 0xffffffff00000000;
		  local_8 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(iVar3 + 0x38),0);
		  local_1c = &local_c;
		  local_24 = 0;
		  local_20 = &local_8;
		  do {
		    piVar7 = local_8;
		    uVar8 = (undefined4)(uVar1 >> 0x20);
		    iVar3 = *local_8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar4 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80f46f19;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4715c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f47164;
		    }
		code_r0x80f46f19:
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f4715c;
		    if (iVar3 == 0) goto code_r0x80f471ad;
		    iVar3 = *local_8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar4 = (undefined4 *)(piVar13[1] * 8 + iVar3 + 200);
		          goto code_r0x80f46ff6;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4713e:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f47164;
		    }
		code_r0x80f46ff6:
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f4713e;
		    if (piVar7 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar7 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar7 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                   UnityEngine_Transform_TypeInfo);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f47164;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = CONCAT44(uVar8,uVar5);
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		    uVar8 = (undefined4)(uVar1 >> 0x20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f47164:
		  iVar3 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_24 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80f471ad:
		      DAT_ram_009d3e38 = 0;
		      local_c = func_ii_1082(local_8,System_IDisposable_TypeInfo);
		      piVar7 = (int *)*local_1c;
		      if (piVar7 != (int *)0x0) {
		        iVar3 = *piVar7;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8)) {
		              puVar10 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8 + 4) * 8 +
		                                0xc0);
		              goto code_r0x80f4723d;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        puVar10 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80f4723d:
		        uVar2 = CONCAT44(uVar8,puVar10[1]);
		        (**(code **)((ulonglong)*puVar10 * 4))(piVar7,uVar2);
		        uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      }
		      if (local_24 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_24);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x15c));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		      piVar7 = *(int **)(iVar3 + 0x20);
		      uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar5 = Core_Extensions_Dict_AccountDicExt__GetTitleInBanner(*(undefined4 *)(param2 + 8),0);
		      iVar3 = *piVar7;
		      uVar2 = CONCAT44(uVar8,uVar5);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar7,uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		      uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		      piVar7 = *(int **)(iVar3 + 0x24);
		      uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar5 = Core_Extensions_Dict_AccountDicExt__GetDescriptionInBanner
		                        (*(undefined4 *)(param2 + 8),0);
		      iVar3 = *piVar7;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar7,CONCAT44(uVar8,uVar5),*(undefined4 *)(iVar3 + 0x2d4));
		      uVar8 = 0;
		      iVar3 = Gameplay_Clans_Model_ClansModel__TryGetOwnClanIsleInfo
		                        (*(undefined4 *)(param1[2] + 0xc),1,&local_4,0);
		      if (iVar3 != 0) {
		        uVar8 = *(undefined4 *)(local_4 + 0x10);
		      }
		      uVar8 = Gameplay_Accounts_Model_Data_ClanAccount__Init(param2,uVar8,uVar8);
		      uVar5 = Protocol_Common_ResourceSet___ctor(uVar8,0);
		      uVar8 = 0x40590000;
		      uVar5 = Core_Extensions_Dict_ResourceSetExt__Round(uVar5,100.0,0);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      local_10 = (int *)Core_Money_Money__op_Explicit(uVar5,0);
		      local_24 = 0;
		      local_20 = &local_10;
		      do {
		        piVar7 = local_10;
		        iVar3 = *local_10;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar4 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f47440;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f479fa:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		code_r0x80f47440:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        piVar7 = local_10;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f479fa;
		        if (iVar3 == 0) {
		          iVar3 = 0;
		          goto code_r0x80f47a4b;
		        }
		        iVar3 = *local_10;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar13) {
		              puVar4 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f4751a;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                            System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4796e:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		code_r0x80f4751a:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f4796e;
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c))
		        ;
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        uVar5 = *(undefined4 *)(iVar9 + 0x48);
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c))
		        ;
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        uVar11 = *(undefined4 *)(iVar9 + 0x38);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f47a02;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar5,uVar11,
		                           Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        local_18 = *(float8 *)(iVar3 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iii
		                           (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d5,&local_18,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iiii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar11,
		                            StringLiteral_708,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f479aa:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x338,uVar5,uVar11,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f479aa;
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f47a02;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar13) {
		              puVar4 = (undefined4 *)(piVar13[1] * 8 + iVar6 + 0x178);
		              goto code_r0x80f477f2;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Gameplay_IGame_TypeInfo,0x17);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f479be:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		code_r0x80f477f2:
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f479be;
		        DAT_ram_009d3e38 = 0;
		        uVar11 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar11,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        uVar12 = *(undefined4 *)(iVar3 + 8);
		        if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Money_Money_MoneyType_TypeInfo);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f47a02;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar12 = func_ii_7278(uVar12,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,uVar11,uVar12,0)
		        ;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f47a02;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iii
		                           (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d6,uVar11,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x336,uVar5,uVar11,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f47a02:
		      iVar3 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar3 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		code_r0x80f47a4b:
		          piVar7 = local_10;
		          DAT_ram_009d3e38 = 0;
		          if (local_10 != (int *)0x0) {
		            uVar14 = 0;
		            iVar6 = *local_10;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8)) {
		                  puVar10 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8 + 4) * 8 +
		                                    0xc0);
		                  goto code_r0x80f47ac3;
		                }
		                uVar14 = uVar14 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar14);
		            }
		            puVar10 = (uint *)func_ii_1080(local_10,System_IDisposable_TypeInfo,0);
		code_r0x80f47ac3:
		            (**(code **)((ulonglong)*puVar10 * 4))(piVar7,CONCAT44(uVar8,puVar10[1]));
		          }
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d7,&local_24);
		      goto joined_r0x80f47b11;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d4,&local_24);
		joined_r0x80f47b11:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005722 RID: 22306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005722")]
		[Address(RVA = "0x1D58", Offset = "0x1D58", VA = "0x1D58")]
		private void UpdateStatusText()
		{
		/* --- GHIDRA: UpdateStatusText ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__UpdateStatusText
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a588ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BacktimeViewUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11311);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a588ec = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 100);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x28);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x80f44781;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,1);
		code_r0x80f44781:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = Core_GameLocalization__GetValue(uVar3,0);
		    iVar7 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		    uVar3 = *(undefined4 *)(param1 + 0x5c);
		    piVar5 = *(int **)(param1 + 100);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		          goto code_r0x80f44827;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,5);
		code_r0x80f44827:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = Core_Extensions_Dict_NotificationGroupDicExt__GetTitle(uVar4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar4,0);
		    piVar5 = *(int **)(param1 + 100);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)
		           ) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x80f448b8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f448b8:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    piVar5 = *(int **)(param1 + 0x30);
		    if (iVar7 == 0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2d0) * 4))
		                (piVar5,StringLiteral_5,*(undefined4 *)(*piVar5 + 0x2d4));
		      uVar3 = *(undefined4 *)(param1 + 0x60);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar7 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		      if (iVar7 != 0) {
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x60),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,1,0);
		        return;
		      }
		      uVar4 = *(undefined4 *)(param1 + 0x58);
		      uVar3 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(*(undefined4 *)(param1 + 0x30),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar3 = func_ii_6805(uVar4,uVar3,Method_UnityEngine_Object_Instantiate_BacktimeViewUGUI___);
		      *(undefined4 *)(param1 + 0x60) = uVar3;
		      piVar5 = *(int **)(param1 + 100);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Data_Accounts_IAccountData_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		            goto code_r0x80f44a6a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Data_Accounts_IAccountData_TypeInfo,1);
		code_r0x80f44a6a:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,uVar4,0);
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_11311,1,0,1,0,0,0,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2d0) * 4))
		                (piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x2d4));
		      uVar3 = *(undefined4 *)(param1 + 0x60);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar7 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		      if (iVar7 != 0) {
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x60),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,0,0);
		        return;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005723 RID: 22307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005723")]
		[Address(RVA = "0xA49E", Offset = "0xA49E", VA = "0xA49E")]
		private void DisplayAccountInformation(ClanAccount account)
		{
		/* --- GHIDRA: DisplayAccountInformation ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__DisplayAccountInformation
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int iVar7;
		  uint uVar8;
		  int iVar9;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58900 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OptionBuyButtonItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleOptionClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OptionBuyButtonItem__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountOptionData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_OptionBuyButtonItem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58900 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,
		             Method_System_Collections_Generic_List_AccountOptionData__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = local_20;
		  local_28 = 0;
		  local_24 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountOptionData__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    iVar9 = local_28;
		    if (iVar2 == 0) goto code_r0x80f482fd;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_8._4_4_;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) break;
		    uVar4 = *(undefined4 *)(iVar3 + 0x4c);
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    uVar6 = *(undefined4 *)(iVar3 + 0x44);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f482b4;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar4,uVar6,
		                       Method_UnityEngine_Object_Instantiate_OptionBuyButtonItem___);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    *(int *)(iVar3 + 0x28) = iVar2;
		    piVar5 = *(int **)(iVar3 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b2,
		                       *(undefined4 *)(iVar2 + 0x70),0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f48284:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    iVar9 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar9 + 0x2d0),piVar5,uVar4,*(undefined4 *)(iVar9 + 0x2d4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f48284;
		    iVar9 = **(int **)(iVar3 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar9 + 0x2d0),*(int **)(iVar3 + 0x18),
		               *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x18),*(undefined4 *)(iVar9 + 0x2d4));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    piVar5 = *(int **)(iVar3 + 0x20);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = Core_Extensions_Dict_AccountOptionsDicExt__GetTitle(iVar2,0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    local_30 = 0;
		    DAT_ram_009d3e38 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_30,uVar4,Method_System_Nullable_int___ctor__);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f48266:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    iVar9 = *piVar5;
		    local_20 = local_30;
		    DAT_ram_009d3e38 = 0;
		    local_38 = local_30;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar9 + 0x138),piVar5,&local_38,*(undefined4 *)(iVar9 + 0x13c));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f48266;
		    iVar7 = *(int *)(iVar2 + 0x74);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                       *(undefined4 *)(iVar3 + 0x1c),0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar4,(uint)(iVar7 != 0),0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    if (iVar7 != 0) {
		      iVar9 = **(int **)(iVar3 + 0x1c);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (*(undefined4 *)(iVar9 + 0x2d0),*(int **)(iVar3 + 0x1c),
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x74) + 0x18) + 0x18),
		                 *(undefined4 *)(iVar9 + 0x2d4));
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f482b4;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OptionBuyButtonItem__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f48234:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f482b4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleOptionClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f48234;
		    if (DAT_ram_00a58898 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_OptionBuyButtonItem__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f48234;
		      DAT_ram_00a58898 = '\x01';
		    }
		    iVar9 = *(int *)(iVar3 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar9,uVar4,0);
		      uVar6 = System_Action_OptionBuyButtonItem__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f48216:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f482b4;
		      }
		      if (iVar2 == 0) {
		        iVar7 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar2,
		                           System_Action_OptionBuyButtonItem__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f48216;
		        if (iVar7 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar2,uVar6);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f482b4;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = func_ii_4329(iVar3 + 0x24,iVar7,iVar9);
		      iVar2 = Method_System_Collections_Generic_List_OptionBuyButtonItem__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f48216;
		      bVar1 = iVar9 != iVar7;
		      iVar9 = iVar7;
		    } while (bVar1);
		    iVar9 = param1[6];
		    *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar9 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		      *(uint *)(iVar9 + 0xc) = uVar8 + 1;
		      *(int *)(*(int *)(iVar9 + 8) + uVar8 * 4 + 0x10) = iVar3;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar3,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f482b4:
		        iVar9 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar9 == iVar2) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar9 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_28 = iVar9;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x80f482fd:
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 == 0) {
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d8,&local_28);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
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
		  goto code_r0x80f482b4;
		}
		*/

		}

		// Token: 0x06005724 RID: 22308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005724")]
		[Address(RVA = "0xA49F", Offset = "0xA49F", VA = "0xA49F")]
		private void DisplayOptionsButtons(List<AccountOptionData> options)
		{
		/* --- GHIDRA: DisplayOptionsButtons ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__DisplayOptionsButtons
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
		  
		  if (DAT_ram_00a58901 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OptionBuyButtonItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleOptionClickEvent__
		              );
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
		    DAT_ram_00a58901 = '\x01';
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
		code_r0x80f45c30:
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
		code_r0x80f45cdf:
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1cd,&local_20);
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
		    if (iVar2 == 0) goto code_r0x80f45cdf;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = local_8._4_4_;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f45c28:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f45c30;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c28;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c28;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OptionBuyButtonItem__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f45c1e:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f45c30;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleOptionClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c1e;
		    if (DAT_ram_00a58899 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_OptionBuyButtonItem__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c1e;
		      DAT_ram_00a58899 = '\x01';
		    }
		    iVar2 = *(int *)(iVar6 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar4,0);
		      param3_00 = System_Action_OptionBuyButtonItem__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f45c0a:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f45c30;
		      }
		      if (iVar3 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_OptionBuyButtonItem__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c0a;
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
		          goto code_r0x80f45c30;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = func_ii_4329(iVar6 + 0x24,param2_00,iVar2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f45c0a;
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005725")]
		[Address(RVA = "0xA4A0", Offset = "0xA4A0", VA = "0xA4A0")]
		private void RemoveOptionsButtons(List<OptionBuyButtonItem> optionButtons)
		{
		/* --- GHIDRA: RemoveOptionsButtons ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__RemoveOptionsButtons
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a58902 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2486);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2485);
		    DAT_ram_00a58902 = '\x01';
		  }
		  local_4 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = Gameplay_Accounts_Clan_Control_ClanAccountController___ctor
		                    (uVar2,*(undefined4 *)(param1[2] + 0x14),*(undefined4 *)(param2 + 0x28),&local_4
		                     ,auStack_10);
		  if (iVar3 == 0) {
		    if (local_4 == 1) {
		      iVar3 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar3,0);
		      puVar1 = &StringLiteral_2486;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else {
		      if (local_4 != 2) {
		        return;
		      }
		      iVar3 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar3,0);
		      puVar1 = &StringLiteral_2485;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    if (iVar4 == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar3 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005726")]
		[Address(RVA = "0xA4A1", Offset = "0xA4A1", VA = "0xA4A1")]
		private void HandleOptionClickEvent(OptionBuyButtonItem view)
		{
		/* --- GHIDRA: HandleOptionClickEvent ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__HandleOptionClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(param1,0);
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x24),0);
		  if (iVar1 != 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x24),2,0);
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator__HandleOnSelectEvent
		            (param1,0);
		  return;
		}
		*/

		}

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x18")]
		private List<OptionBuyButtonItem> _optionBuyButtonItems;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleAccountChangedEvent__
		              );
		    DAT_ram_00a588fa = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleAccountChangedEvent__
		               ,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_HandleAccountChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
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
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int param2_00;
		  int iVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a588fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    DAT_ram_00a588fb = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar4 = **(int **)(param1[2] + 0x10);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		                    (*(int **)(param1[2] + 0x10),&local_4,*(undefined4 *)(iVar4 + 0x164));
		  if (iVar4 == 0) {
		    return;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_18,local_4,
		             Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                         Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                        );
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f46c29;
		      }
		      iVar3 = local_20;
		      if (iVar1 == 0) goto code_r0x80f46c72;
		    } while (local_10._4_4_ != param2);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d1,param1,iVar4);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f46c29:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar3 = *piVar2;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80f46c72:
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d3,&local_20);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f46c29;
		    }
		    iVar4 = 0;
		    iVar3 = *(int *)(*(int *)(iVar1 + 0x40) + 0xc);
		    if (0 < iVar3) {
		      do {
		        param2_00 = *(int *)(*(int *)(iVar1 + 0x40) + iVar4 * 4 + 0x10);
		        if (param2 == *(int *)(param2_00 + 100)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d2,param2_00,iVar4);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f46c29;
		          }
		          break;
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar3);
		    }
		  } while( true );
		}
		*/

}
