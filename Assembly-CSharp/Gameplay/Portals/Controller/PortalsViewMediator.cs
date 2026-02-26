using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	public class PortalsViewMediator : AbstractViewMediator<PortalsModel, PortalsEvents, PortalsController, PortalsWindow>
	{
		// Token: 0x0600248B RID: 9355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x75D9", Offset = "0x75D9", VA = "0x75D9")]
		public PortalsViewMediator(PortalsModel model, PortalsEvents events, PortalsController controller)
		{
		/* --- GHIDRA: <Dispose>g__DisposeMediator|58_0 ---
		void Gameplay_Portals_Controller_PortalsViewMediator___Dispose_g__DisposeMediator_58_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a57d5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d5a = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <Init>b__20_0 ---
		void Gameplay_Portals_Controller_PortalsViewMediator___Init_b__20_0(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57d59 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a57d59 = '\x01';
		  }
		  if (param1 != (int *)0x0) {
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		          goto code_r0x80e52955;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,Core_MVC_Interfaces_IViewMediator_TypeInfo,5);
		code_r0x80e52955:
		    uVar1 = 0;
		    param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x80e529d5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,Core_MVC_Interfaces_IViewMediator_TypeInfo,1);
		code_r0x80e529d5:
		    uVar1 = 0;
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    MVC_AbstractController__Run(param1_00,0);
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))(piVar3,*(undefined4 *)(*piVar3 + 0xec));
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e52a8b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80e52a8b:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Portals_Controller_PortalsViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  return *(undefined4 *)(iVar1 + 0x3c);
		}
		*/

		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D8")]
		private PortalsView PortalsView
		{
			[Token(Token = "0x600248C")]
			[Address(RVA = "0x75DA", Offset = "0x75DA", VA = "0x75DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D9")]
		private PortalsRewardView PortalsRewardView
		{
			[Token(Token = "0x600248D")]
			[Address(RVA = "0x75DB", Offset = "0x75DB", VA = "0x75DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DA")]
		private PortalsMonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x75DC", Offset = "0x75DC", VA = "0x75DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DB")]
		public override PortalsWindow View
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x75DD", Offset = "0x75DD", VA = "0x75DD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170006DC RID: 1756
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DC")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x75DE", Offset = "0x75DE", VA = "0x75DE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x75DF", Offset = "0x75DF", VA = "0x75DF")]
		public void ShowNavigation()
		{
		/* --- GHIDRA: ShowNavigation ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ShowNavigation(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d3a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_AttackButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_BattleButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_DecreasePortalTarget__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_IncreasePortalTarget__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_MyBetsButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalInfoButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_RatingButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_RegisterButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_ReturnButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_ShopButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalizatorInfoButtonHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57d3a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x7c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalizatorInfoButtonHandler__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x34) + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_AttackButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x34) + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_ReturnButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x58) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_RegisterButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x78) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalInfoButtonHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x5c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_IncreasePortalTarget__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 100) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_RatingButtonHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x74) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_BattleButtonHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x6c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_MyBetsButtonHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x60) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_DecreasePortalTarget__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x68) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalButtonHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x70) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Portals_Controller_PortalsViewMediator_ShopButtonHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x75E0", Offset = "0x75E0", VA = "0x75E0")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d3b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_AttackButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_BattleButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_DecreasePortalTarget__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_IncreasePortalTarget__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_MyBetsButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalInfoButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_RatingButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_RegisterButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_ReturnButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_ShopButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalButtonHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalizatorInfoButtonHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57d3b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x7c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalizatorInfoButtonHandler__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x34) + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_AttackButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x34) + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_ReturnButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x58) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_RegisterButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x78) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalInfoButtonHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x5c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_IncreasePortalTarget__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 100) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_RatingButtonHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x74) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_BattleButtonHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x6c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_MyBetsButtonHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x60) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_DecreasePortalTarget__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x68) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TotalButtonHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x70) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Portals_Controller_PortalsViewMediator_ShopButtonHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x75E1", Offset = "0x75E1", VA = "0x75E1")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Portals_Controller_PortalsViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_PortalsWindow_PortalsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator__Init_b__20_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a57d3c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x54);
		  uVar3 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                    (*(undefined4 *)(param1[2] + 0x3c),0xbe,0);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar3 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                    (*(undefined4 *)(param1[2] + 0x3c),0xbd,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x4c);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x50);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x3c),4,
		             Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7357(*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x30),1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x3c),1,
		             Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7357(*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x2c),1,0);
		  piVar6 = *(int **)(param1[2] + 0x24);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x148);
		        goto code_r0x80e4f83f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80e4f83f:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (*(char *)(*(int *)(iVar2 + 0x10) + 0xc) == '\0') {
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param1,Method_Gameplay_Portals_Controller_PortalsViewMediator__Init_b__20_0__,0
		              );
		    DG_Tweening_DOVirtual__EasedValue(0.05,uVar3,1,0);
		  }
		  iVar2 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync(param1[2],0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 == 0) {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar5 + 0x3c) + 0x60),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x5c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(int *)(iVar5 + 0x3c),6,
		             Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x28);
		  uVar3 = Gameplay_Portals_Model_PortalsModel__set_CurrentJackpot(param1[2],0);
		  UI_Tabs_TabBar__HandleSelected(param1_00,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar5 = param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar3,
		                       Method_UI_Windows_BaseWindow_PortalsWindow_PortalsWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar5 + 0x34) = *(undefined4 *)(iVar2 + 0x18);
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x1c),0,
		             Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Combat_View_RewardToBalanceTweener_Balance__SetValue(uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__RegisterUser(uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x75E2", Offset = "0x75E2", VA = "0x75E2")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Portals_Controller_PortalsViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x38),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x75E3", Offset = "0x75E3", VA = "0x75E3")]
		private void DeInit()
		{
		/* --- GHIDRA: DeInit ---
		void Gameplay_Portals_Controller_PortalsViewMediator__DeInit(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d3d = '\x01';
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x34) = 1;
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x75E4", Offset = "0x75E4", VA = "0x75E4")]
		private void RatingButtonHandler()
		{
		/* --- GHIDRA: RatingButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__RatingButtonHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d3e = '\x01';
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x34) = 3;
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x75E5", Offset = "0x75E5", VA = "0x75E5")]
		private void MyBetsButtonHandler()
		{
		/* --- GHIDRA: MyBetsButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__MyBetsButtonHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d3f = '\x01';
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x34) = 2;
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x75E6", Offset = "0x75E6", VA = "0x75E6")]
		private void TotalButtonHandler()
		{
		/* --- GHIDRA: TotalButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__TotalButtonHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d40 = '\x01';
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x34) = 4;
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x75E7", Offset = "0x75E7", VA = "0x75E7")]
		private void ShopButtonHandler()
		{
		/* --- GHIDRA: ShopButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ShopButtonHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57d41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d41 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1[2] + 0x20) + 0x18) + 0xc) == 2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Core_Extensions_Dict_MonsterDictExt__GetTitle
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x34),
		               **(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__GetStageInfo(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x75E8", Offset = "0x75E8", VA = "0x75E8")]
		private void BattleButtonHandler()
		{
		/* --- GHIDRA: BattleButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__BattleButtonHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsViewMediator__ReturnButtonClickHandler(param1,param1);
		  Gameplay_Portals_Controller_PortalsViewMediator__StageInfoChangedHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x75E9", Offset = "0x75E9", VA = "0x75E9")]
		private void CurrentMonsterReceivedHandler()
		{
		/* --- GHIDRA: CurrentMonsterReceivedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__CurrentMonsterReceivedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__get_CurrentState__);
		    DAT_ram_00a57d42 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) - 3U < 3) {
		    Gameplay_Portals_Controller_PortalsViewMediator__ReturnButtonClickHandler(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x75EA", Offset = "0x75EA", VA = "0x75EA")]
		private void CurrentMonsterChangedHandler()
		{
		/* --- GHIDRA: CurrentMonsterChangedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__CurrentMonsterChangedHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a57d43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57d43 = '\x01';
		  }
		  if (*(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0x18) + 0x10) != 0) {
		    uVar7 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80e50df1;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e50df1:
		    uVar7 = 0;
		    uVar1 = CONCAT44(in_register_20000014,puVar2[1]);
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar5 = UI_Elements_GenericList_SelectableListElementArgs_object____ctor
		                      (param1_00,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0xc),
		                       *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0xc),0);
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x80e50e94;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e50e94:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(uVar3,puVar2[1]));
		    iVar6 = Core_Extensions_Dict_DictExt__GetPartyInfoDic
		                      (uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0xc),0);
		    if (iVar6 <= iVar5) {
		      Gameplay_Portals_Model_PortalsModel__SetPortalStageInfo
		                (*(int *)(param1 + 8),
		                 *(undefined8 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0x18) + 0x10),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x75EB", Offset = "0x75EB", VA = "0x75EB")]
		private void SetStageBackTimeOnLastStage()
		{
		/* --- GHIDRA: SetStageBackTimeOnLastStage ---
		void Gameplay_Portals_Controller_PortalsViewMediator__SetStageBackTimeOnLastStage
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57d44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_PortalsTargets__Func_IHideableMediator___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_PortalsTargets__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetSelectedItem_PortalsTargets___);
		    DAT_ram_00a57d44 = '\x01';
		  }
		  param1_00 = (int *)param1[0xb];
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (MVC_Interfaces_IHideableMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e51644;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80e51644:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__GetSelectedItem_UInt32Enum_
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x28),
		                     Method_UI_Tabs_TabBar_GetSelectedItem_PortalsTargets___);
		  if (iVar3 != 0) {
		    iVar4 = param1[2];
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = UI_Tabs_TabBar__GetSelectedItem_UInt32Enum_
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x28),
		                       Method_UI_Tabs_TabBar_GetSelectedItem_PortalsTargets___);
		    *(undefined4 *)(iVar4 + 0x34) = *(undefined4 *)(iVar3 + 0x20);
		    iVar3 = System_Collections_Generic_Dictionary_UInt32Enum__object___get_Count
		                      (param1[10],*(undefined4 *)(param1[2] + 0x34),
		                       Method_System_Collections_Generic_Dictionary_PortalsTargets__Func_IHideableMediator___get_Item__
		                      );
		    iVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                      (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    param1[0xb] = iVar4;
		    Gameplay_Portals_Controller_PortalsViewMediator__ShowLastPortalTarget(param1,iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x75EC", Offset = "0x75EC", VA = "0x75EC")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__TabChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsViewMediator__RenderMonster(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x75ED", Offset = "0x75ED", VA = "0x75ED")]
		private void PortalStateChangedHandler()
		{
		/* --- GHIDRA: PortalStateChangedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__PortalStateChangedHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__GetBetPoolInfo(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x75EE", Offset = "0x75EE", VA = "0x75EE")]
		private void PortalInfoButtonHandler()
		{
		/* --- GHIDRA: PortalInfoButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__PortalInfoButtonHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57d45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13835);
		    DAT_ram_00a57d45 = '\x01';
		  }
		  param4 = Gameplay_Portals_Controller_PortalsViewMediator__BetPoolInfoReceivedHandler
		                     (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x4c),param1);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_13835,1,0,1,0,0,0,0);
		  Gameplay_Portals_Controller_PortalsViewMediator__GetDiamondValue(param1,0xc4,param3,param4,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x75EF", Offset = "0x75EF", VA = "0x75EF")]
		private void JackpotInfoReceivedHandler()
		{
		/* --- GHIDRA: JackpotInfoReceivedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__JackpotInfoReceivedHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__ComebackToStage(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x75F0", Offset = "0x75F0", VA = "0x75F0")]
		private void TotalizatorInfoButtonHandler()
		{
		/* --- GHIDRA: TotalizatorInfoButtonHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__TotalizatorInfoButtonHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57d46 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12159);
		    DAT_ram_00a57d46 = '\x01';
		  }
		  param4 = Gameplay_Portals_Controller_PortalsViewMediator__BetPoolInfoReceivedHandler
		                     (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x48),param1);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_12159,1,0,1,0,0,0,0);
		  Gameplay_Portals_Controller_PortalsViewMediator__GetDiamondValue(param1,0xc5,param3,param4,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x75F1", Offset = "0x75F1", VA = "0x75F1")]
		private void BetPoolInfoReceivedHandler()
		{
		/* --- GHIDRA: BetPoolInfoReceivedHandler ---
		undefined4
		Gameplay_Portals_Controller_PortalsViewMediator__BetPoolInfoReceivedHandler
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 param3_00;
		  double param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10775);
		    DAT_ram_00a57d47 = '\x01';
		  }
		  param1_00 = func_ii_6906(param2,2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_10775,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  param3_00 = UI_SimpleIconValue__set_IconAssetId(param1_00,StringLiteral_28780,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_28217,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,param2_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x75F2", Offset = "0x75F2", VA = "0x75F2")]
		private string GetDiamondValue(ResourceSet rs)
		{
		/* --- GHIDRA: GetDiamondValue ---
		void Gameplay_Portals_Controller_PortalsViewMediator__GetDiamondValue
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param3_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57d48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_PortalsInfoWindow___);
		    Mono_Security_ASN1__get_Item(&UI_PortalsInfoWindow_PortalsInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12658);
		    DAT_ram_00a57d48 = '\x01';
		  }
		  param3_00 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0x3c),param2,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param2_00 = *(undefined4 *)(param1 + 8);
		  param1_00 = unnamed_function_1417(UI_PortalsInfoWindow_PortalsInfoWindowArgs_TypeInfo);
		  UI_PortalsInfoWindow_PortalsInfoWindowArgs__get_CounterValue
		            (param1_00,param2_00,param3_00,param3,param4,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12658,param1_00,
		             Method_UI_Windows_PopupController_Show_PortalsInfoWindow___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x75F3", Offset = "0x75F3", VA = "0x75F3")]
		private void ShowPortalsInfoWindow(PortalDic.Types.ContentString descriptionContentString, string counterTitle, string counterValue)
		{
		/* --- GHIDRA: ShowPortalsInfoWindow ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ShowPortalsInfoWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__UpdateStageDic(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x75F4", Offset = "0x75F4", VA = "0x75F4")]
		private void RegisterButtonClickHandler()
		{
		/* --- GHIDRA: RegisterButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__RegisterButtonClickHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x75F5", Offset = "0x75F5", VA = "0x75F5")]
		private void UserRegisteredHandler()
		{
		/* --- GHIDRA: UserRegisteredHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__UserRegisteredHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsViewMediator__UpdateProgress(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x75F6", Offset = "0x75F6", VA = "0x75F6")]
		private void UserInfoChangedHandler()
		{
		/* --- GHIDRA: UserInfoChangedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__UserInfoChangedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__get_CurrentState__);
		    DAT_ram_00a57d49 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) - 3U < 3) {
		    Gameplay_Portals_Controller_PortalsViewMediator__StageInfoChangedHandler(param1,param1);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) != 2) {
		      return;
		    }
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__UpdateCurrentState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x75F7", Offset = "0x75F7", VA = "0x75F7")]
		private void StageInfoChangedHandler()
		{
		/* --- GHIDRA: StageInfoChangedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__StageInfoChangedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  float fVar3;
		  uint param2_00;
		  
		  if (DAT_ram_00a57d4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    DAT_ram_00a57d4a = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1[2] + 0x20) + 0x18) + 0xc) - 1U < 2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x3c),4,
		               Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		  }
		  else {
		    iVar1 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(param1[2],0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar1 == 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar2 + 0x3c),5,
		                 Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    }
		    else {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar2 + 0x3c),3,
		                 Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x34) + 0x30),0);
		  if (*(int *)(*(int *)(*(int *)(param1[2] + 0x20) + 0x18) + 0xc) == 0) {
		    iVar1 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(param1[2],0);
		    if (iVar1 == 0) {
		      param2_00 = (uint)(*(char *)(*(int *)(param1[2] + 0x40) + 0x25) != '\0');
		    }
		    else {
		      param2_00 = 0;
		    }
		  }
		  else {
		    param2_00 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  Gameplay_Portals_Controller_PortalsViewMediator__CurrentMonsterChangedHandler(param1,param1);
		  iVar1 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(param1[2],0);
		  if (((iVar1 != 0) && (fVar3 = func_ii_7103(*(undefined4 *)(param1[2] + 0x28),0), 0.0 < fVar3)) &&
		     (*(char *)(*(int *)(param1[2] + 0x40) + 0x24) == '\0')) {
		    Gameplay_Portals_Controller_PortalsViewMediator__StageInfoReceivedHandler(param1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x1c),4,
		               Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x75F8", Offset = "0x75F8", VA = "0x75F8")]
		private void UpdateCurrentState()
		{
		/* --- GHIDRA: UpdateCurrentState ---
		void Gameplay_Portals_Controller_PortalsViewMediator__UpdateCurrentState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d4b = '\x01';
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__UpdateProgress(param1,param1);
		  Gameplay_Portals_Controller_PortalsViewMediator__StageInfoReceivedHandler(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x38),*(undefined4 *)(param1[2] + 0x28),0);
		  if (*(int *)(param1[2] + 0x34) == 10) {
		    *(undefined4 *)(param1[2] + 0x34) = 0;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Portals_Controller_PortalsController__GetStageInfo(param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x75F9", Offset = "0x75F9", VA = "0x75F9")]
		private void StageInfoReceivedHandler()
		{
		/* --- GHIDRA: StageInfoReceivedHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__StageInfoReceivedHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int param2_00;
		  undefined4 param2_01;
		  float fVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  ulonglong param3;
		  undefined8 param2_02;
		  uint uVar11;
		  int local_24;
		  undefined8 local_20;
		  undefined4 local_14;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a57d4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_StageProgressView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12151);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12147);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12165);
		    DAT_ram_00a57d4c = '\x01';
		  }
		  iVar6 = param1[2];
		  uVar7 = *(undefined4 *)(*(int *)(iVar6 + 0x20) + 0xc);
		  uVar8 = *(undefined4 *)(*(int *)(iVar6 + 0x10) + 0xc);
		  piVar9 = *(int **)(iVar6 + 0xc);
		  iVar6 = *piVar9;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e51008;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e51008:
		  uVar11 = 0;
		  uVar1 = CONCAT44(in_register_20000014,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,uVar1);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar6 = UI_Elements_GenericList_SelectableListElementArgs_object____ctor(uVar3,uVar7,uVar8,0);
		  piVar9 = *(int **)(param1[2] + 0xc);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + iVar10 + 0xd0);
		        goto code_r0x80e5109a;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e5109a:
		  uVar1 = CONCAT44(uVar4,puVar2[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar8 = Core_Extensions_Dict_DictExt__GetPartyInfoDic(uVar4,uVar8,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar10 = *(int *)(*(int *)(iVar10 + 0x3c) + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = func_ii_7508(StringLiteral_12147,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  uVar3 = StringLiteral_28579;
		  uVar4 = StringLiteral_22118;
		  local_4 = (iVar6 + 1) - (uint)(iVar10 == 4);
		  param2_01 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar3 = func_ii_4419(uVar3,param2_01,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,uVar4,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_10;
		  local_14 = uVar8;
		  uVar8 = func_ii_1081(DAT_ram_00a66954,&local_14);
		  uVar8 = func_ii_4419(StringLiteral_28579,uVar8,0);
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,StringLiteral_27779,uVar8,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x18) = local_20;
		  uVar8 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,param2_00,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetIcon
		            (*(undefined4 *)(*(int *)(iVar10 + 0x3c) + 0x1c),uVar8,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = func_ii_7508(StringLiteral_12151,1,0,1,0,0,0,0);
		  local_24 = iVar6 + 1;
		  uVar4 = func_ii_1081(DAT_ram_00a66954,&local_24);
		  uVar8 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28637,uVar8,uVar4,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetIcon
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20),uVar8,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetIcon
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24),uVar8,0);
		  uVar4 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                    (*(undefined4 *)(param1[2] + 0x3c),0xc3,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetStageWaitTitle
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20),uVar4,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetStageWaitTitle
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24),uVar4,0);
		  uVar4 = func_ii_7508(StringLiteral_12165,1,0,1,0,0,0,0);
		  uVar8 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar8,StringLiteral_2004,uVar4,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetStageTitle
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20),uVar8,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Portals_View_StageProgressView__SetStageTitle
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24),uVar8,0);
		  param3 = (ulonglong)*(uint *)(*(int *)(param1[2] + 0x40) + 0x18);
		  param2_02 = *(undefined8 *)(*(int *)(param1[2] + 0x20) + 0x10);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar8 = Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon64(*(undefined4 *)(param1[2] + 0x3c),0);
		  Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs___ctor(uVar4,uVar8,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar8 = Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon64(*(undefined4 *)(param1[2] + 0x3c),0);
		  Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs___ctor(uVar4,uVar8,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c)));
		  Gameplay_Portals_View_StageProgressView__SetToolTip
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20),param2_02,param3,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Portals_View_StageProgressView__SetToolTip
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24),param2_02,param3,0);
		  uVar7 = (undefined4)((ulonglong)param2_02 >> 0x20);
		  fVar5 = func_ii_7103(*(undefined4 *)(param1[2] + 0x28),0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = 2;
		  if (fVar5 <= 0.0) {
		    uVar7 = 1;
		  }
		  uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x20),uVar7,
		             Method_UI_MonoBehaviourWithStates_StageProgressView_State__set_CurrentState__);
		  uVar1 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x24),uVar7,
		             Method_UI_MonoBehaviourWithStates_StageProgressView_State__set_CurrentState__);
		  iVar6 = *(int *)(*(int *)(param1[2] + 0x18) + 0x28);
		  if ((iVar6 != 0) && (iVar6 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar6 == 0))
		  {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x15c)));
		    uVar7 = Gameplay_Portals_View_PortalsMonsterInfoView__get_ReturnButton
		                      (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x34),0);
		    uVar8 = *(undefined4 *)(param1[2] + 8);
		    uVar4 = *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x28);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		    UI_Price_Price__SetColor(uVar7,uVar8,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x75FA", Offset = "0x75FA", VA = "0x75FA")]
		private void UpdateProgress()
		{
		/* --- GHIDRA: UpdateProgress ---
		void Gameplay_Portals_Controller_PortalsViewMediator__UpdateProgress(int *param1,undefined4 param2)
		
		{
		  uint param2_00;
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint param3;
		  undefined4 uVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    DAT_ram_00a57d4d = '\x01';
		  }
		  fVar1 = func_ii_7103(*(undefined4 *)(param1[2] + 0x28),0);
		  iVar3 = param1[2];
		  if (0.0 < fVar1) {
		    iVar4 = *(int *)(iVar3 + 0x44);
		    param3 = *(uint *)(iVar4 + 0x14);
		    param2_00 = param3;
		  }
		  else {
		    iVar4 = *(int *)(iVar3 + 0x40);
		    param3 = *(uint *)(iVar4 + 0x14);
		    param2_00 = *(uint *)(*(int *)(iVar3 + 0x18) + 0x18);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Portals_View_PortalsRewardView__Start
		            (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c),param2_00,param3,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c);
		  local_4 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar2 = func_ii_4419(StringLiteral_28579,uVar2,0);
		  Gameplay_Portals_View_StageProgressView__SetStageTitle(uVar5,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c);
		  uVar2 = Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon64(*(undefined4 *)(param1[2] + 0x3c),0);
		  Gameplay_Portals_View_PortalsRewardView__SetTitle(uVar5,uVar2,0);
		  iVar3 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(param1[2],0);
		  if (iVar3 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c),3,
		               Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__);
		  }
		  else if (*(char *)(*(int *)(param1[2] + 0x40) + 0x24) == '\0') {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c);
		    if (param2_00 < param3) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar2,1,
		                 Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__
		                );
		    }
		    else if (0.0 < fVar1) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar2,4,
		                 Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__
		                );
		    }
		    else {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar2,2,
		                 Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__
		                );
		    }
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c),5,
		               Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState__set_CurrentState__);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x75FB", Offset = "0x75FB", VA = "0x75FB")]
		private void UpdateRewardView()
		{
		/* --- GHIDRA: UpdateRewardView ---
		void Gameplay_Portals_Controller_PortalsViewMediator__UpdateRewardView(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57d4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d4e = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x34);
		  if ((4 < iVar2) || (iVar1 = iVar2, iVar2 != 4)) {
		    *(int *)(*(int *)(param1 + 8) + 0x34) = iVar1 + 1;
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x75FC", Offset = "0x75FC", VA = "0x75FC")]
		private void IncreasePortalTarget()
		{
		/* --- GHIDRA: IncreasePortalTarget ---
		void Gameplay_Portals_Controller_PortalsViewMediator__IncreasePortalTarget
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d4f = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 8) + 0x34);
		  if (iVar1 != 0) {
		    *(int *)(*(int *)(param1 + 8) + 0x34) = iVar1 + -1;
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x75FD", Offset = "0x75FD", VA = "0x75FD")]
		private void DecreasePortalTarget()
		{
		/* --- GHIDRA: DecreasePortalTarget ---
		void Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    DAT_ram_00a57d50 = '\x01';
		  }
		  iVar1 = Gameplay_Portals_Controller_PortalsViewMediator__ShowLastPortalTarget(param1,param1);
		  iVar3 = *(int *)(param1[2] + 0x34);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		  if (iVar3 == 10) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1_00,3,
		               Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    return;
		  }
		  if (iVar1 != 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1_00,2,
		               Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,6,
		             Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(param1[2] + 0x34) + -1;
		  if (iVar2 < 1) {
		    iVar2 = 0;
		  }
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x28),iVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x75FE", Offset = "0x75FE", VA = "0x75FE")]
		private void ShowLastPortalTarget()
		{
		/* --- GHIDRA: ShowLastPortalTarget ---
		uint Gameplay_Portals_Controller_PortalsViewMediator__ShowLastPortalTarget
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a57d51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    DAT_ram_00a57d51 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x7c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(int *)(param1[2] + 0x34) == 2),0);
		  iVar3 = *(int *)(param1[2] + 0x34);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x60),0);
		  uVar4 = (uint)(iVar3 == 0 || iVar3 == 10);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(uVar4 == 0),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar3 != 4),0);
		  return uVar4;
		}
		*/

		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x75FF", Offset = "0x75FF", VA = "0x75FF")]
		private bool LastPortalTargetChangeHandler()
		{
		/* --- GHIDRA: LastPortalTargetChangeHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__LastPortalTargetChangeHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__GetPortalInfo(param1_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x7600", Offset = "0x7600", VA = "0x7600")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__AttackButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__AttackMonster(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x7601", Offset = "0x7601", VA = "0x7601")]
		private void ReturnButtonClickHandler()
		{
		/* --- GHIDRA: ReturnButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ReturnButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int param1_00;
		  int iVar6;
		  undefined4 uVar7;
		  int *param1_01;
		  
		  if (DAT_ram_00a57d52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57d52 = '\x01';
		  }
		  param1_00 = *(int *)(param1[2] + 0x14);
		  if ((param1_00 != 0) && (*(int *)(param1_00 + 8) != 0)) {
		    iVar6 = *(int *)(*(int *)(param1_00 + 0x10) + 0x14);
		    if ((iVar6 != 0) && (iVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar2 == 0)
		       ) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = Gameplay_Isles_User_View_MonsterInfoView2__get_KickButton
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x34),0);
		      uVar7 = *(undefined4 *)(param1[2] + 8);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar5 = Core_Money_Money__op_Explicit(iVar6,0);
		      UI_Price_Price__SetColor(uVar3,uVar7,uVar5,0);
		    }
		    uVar1 = 0;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x34);
		    uVar3 = Core_Extensions_Dict_AprDicExt__GetImageIsleAssetId
		                      (*(undefined4 *)(*(int *)(param1_00 + 0xc) + 0x10),0);
		    Gameplay_Isles_User_View_MonsterInfoView2__get_KickPrice(uVar7,uVar3,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x34);
		    uVar3 = AssetContent_GameAssetViewRawImage__set_AssetId(*(undefined4 *)(param1_00 + 8),0);
		    Core_Extensions_Dict_MonsterDictExt__GetTitle(uVar7,uVar3,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Portals_View_PortalsMonsterInfoView__get_ReturnPrice
		              (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x34),
		               *(undefined4 *)(*(int *)(param1_00 + 8) + 0x14),0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x34);
		    uVar7 = *(undefined4 *)(param1[2] + 8);
		    param1_01 = *(int **)(param1[2] + 0x24);
		    iVar6 = *param1_01;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		          goto code_r0x80e50b83;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e50b83:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		    uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		    uVar7 = Gameplay_Portals_Model_PortalMonsterData__Create(param1_00,uVar7,uVar5,0);
		    Gameplay_Isles_User_View_MonsterInfoView2__get_Rewards(uVar3,uVar7,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x7602", Offset = "0x7602", VA = "0x7602")]
		private void RenderMonster()
		{
		/* --- GHIDRA: RenderMonster ---
		void Gameplay_Portals_Controller_PortalsViewMediator__RenderMonster(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57d53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d53 = '\x01';
		  }
		  if ((*(int *)(param1 + 8) == 0) ||
		     (piVar3 = *(int **)(*(int *)(param1 + 8) + 0x24), piVar3 == (int *)0x0)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  }
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80e517db;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e517db:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80e51859;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x80e51859:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  func_ii_8753(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x7603", Offset = "0x7603", VA = "0x7603")]
		private void CloseAll()
		{
		/* --- GHIDRA: CloseAll ---
		int Gameplay_Portals_Controller_PortalsViewMediator__CloseAll(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57d54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsRatingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsRatingModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsRatingViewMediator_TypeInfo);
		    DAT_ram_00a57d54 = '\x01';
		  }
		  piVar5 = (int *)param1[7];
		  if (piVar5 == (int *)0x0) {
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1[2] + 8);
		    piVar5 = *(int **)(param1[2] + 0x24);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		          goto code_r0x80e52082;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e52082:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar6 = *(undefined4 *)(iVar4 + 0x14);
		    param1_00 = unnamed_function_1417(Gameplay_Portals_Model_PortalsRatingModel_TypeInfo);
		    Gameplay_Portals_Model_PortalsRatingModel__set_IsAwaitReceivingData
		              (param1_00,10.0,uVar3,piVar5,uVar6,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsRatingController_TypeInfo);
		    Gameplay_Portals_Controller_PortalsMyBetsViewMediator__AllBetsButtonClickHandler
		              (uVar6,param1_00,uVar3,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar4 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsRatingViewMediator_TypeInfo);
		    Gameplay_Portals_Controller_PortalsRatingViewMediator__Hide(iVar4,param1_00,uVar3,uVar6,0);
		    param1[7] = iVar4;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Portals_View_RatingTab_PortalsRatingView__get_MyRatingView
		              (*(undefined4 *)(*(int *)(iVar4 + 0x3c) + 0x40),0);
		    MVC_AbstractController__Dispose(uVar6,0);
		    piVar5 = (int *)param1[7];
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x140) * 4))
		            (piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x144));
		  piVar5 = (int *)param1[7];
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x160) * 4))
		            (piVar5,*(undefined4 *)(*(int *)(iVar4 + 0x3c) + 0x40),*(undefined4 *)(iVar7 + 0x164));
		  return param1[7];
		}
		*/

		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x7604", Offset = "0x7604", VA = "0x7604")]
		private IHideableMediator ShowRatingTab()
		{
		/* --- GHIDRA: ShowRatingTab ---
		int Gameplay_Portals_Controller_PortalsViewMediator__ShowRatingTab(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57d55 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsTotalizatorModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_TypeInfo);
		    DAT_ram_00a57d55 = '\x01';
		  }
		  piVar5 = (int *)param1[6];
		  if (piVar5 == (int *)0x0) {
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1[2] + 8);
		    piVar5 = *(int **)(param1[2] + 0x24);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		          goto code_r0x80e52283;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e52283:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar6 = *(undefined4 *)(iVar4 + 0x14);
		    param1_00 = unnamed_function_1417(Gameplay_Portals_Model_PortalsTotalizatorModel_TypeInfo);
		    Gameplay_Portals_Model_PortalsTotalizatorModel__set_CurrentBetList
		              (param1_00,uVar3,piVar5,uVar6,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x18);
		    iVar4 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsTotalizatorController_TypeInfo)
		    ;
		    if (DAT_ram_00a57d1c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_PortalsTotalizatorModel__PortalsEvents___ctor__);
		      DAT_ram_00a57d1c = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar4,param1_00,uVar3,
		               Method_MVC_AbstractController_PortalsTotalizatorModel__PortalsEvents___ctor__);
		    *(undefined4 *)(iVar4 + 0x18) = uVar6;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar7 = unnamed_function_1417
		                      (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_TypeInfo);
		    if (DAT_ram_00a57d23 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView___ctor__
		                );
		      DAT_ram_00a57d23 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (iVar7,param1_00,uVar3,iVar4,
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView___ctor__
		              );
		    param1[6] = iVar7;
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorView__get_BetNumber
		              (*(undefined4 *)(*(int *)(iVar7 + 0x3c) + 0x44),param1[2],0);
		    MVC_AbstractController__Dispose(iVar4,0);
		    piVar5 = (int *)param1[6];
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x140) * 4))
		            (piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x144));
		  piVar5 = (int *)param1[6];
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x160) * 4))
		            (piVar5,*(undefined4 *)(*(int *)(iVar4 + 0x3c) + 0x44),*(undefined4 *)(iVar7 + 0x164));
		  return param1[6];
		}
		*/

			return null;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x7605", Offset = "0x7605", VA = "0x7605")]
		private IHideableMediator ShowTotalizatorTab()
		{
		/* --- GHIDRA: ShowTotalizatorTab ---
		int Gameplay_Portals_Controller_PortalsViewMediator__ShowTotalizatorTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param4;
		  int iVar6;
		  
		  if (DAT_ram_00a57d56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsMyBetsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsMyBetsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsMyBetsViewMediator_TypeInfo);
		    DAT_ram_00a57d56 = '\x01';
		  }
		  piVar3 = (int *)param1[9];
		  if (piVar3 == (int *)0x0) {
		    uVar4 = *(undefined4 *)(param1[2] + 0x24);
		    uVar5 = *(undefined4 *)(param1[2] + 8);
		    uVar1 = unnamed_function_1417(Gameplay_Portals_Model_PortalsMyBetsModel_TypeInfo);
		    Gameplay_Portals_Model_PortalsMyBetsModel__get_Game(uVar1,uVar5,uVar4,0);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    param4 = *(undefined4 *)(iVar2 + 0x18);
		    uVar5 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsMyBetsController_TypeInfo);
		    Gameplay_Portals_Controller_PortalsController__ValidateInit(uVar5,uVar1,uVar4,param4,0);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsMyBetsViewMediator_TypeInfo);
		    Gameplay_Portals_Controller_PortalsMyBetsController__OnGetBetList(iVar2,uVar1,uVar4,uVar5,0);
		    param1[9] = iVar2;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Portals_View_MyBetsTab_PortalsMyBetsView__get_MyBetsElementPrefab
		              (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x48),param1[2],0);
		    MVC_AbstractController__Dispose(uVar5,0);
		    piVar3 = (int *)param1[9];
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[9];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x48),*(undefined4 *)(iVar6 + 0x164));
		  return param1[9];
		}
		*/

			return null;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x7606", Offset = "0x7606", VA = "0x7606")]
		private IHideableMediator ShowMyBetsTab()
		{
		/* --- GHIDRA: ShowMyBetsTab ---
		int Gameplay_Portals_Controller_PortalsViewMediator__ShowMyBetsTab(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57d57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsShopController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsShopModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsShopViewMediator_TypeInfo);
		    DAT_ram_00a57d57 = '\x01';
		  }
		  piVar3 = (int *)param1[8];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar4 = *(undefined4 *)(iVar2 + 0x24);
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar1 = unnamed_function_1417(Gameplay_Portals_Model_PortalsShopModel_TypeInfo);
		    Gameplay_Portals_Model_PortalsShopModel__get_PortalsModel(uVar1,uVar5,uVar4,iVar2,0);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    iVar2 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsShopController_TypeInfo);
		    if (DAT_ram_00a57d0c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_PortalsShopModel__PortalsEvents___ctor__);
		      DAT_ram_00a57d0c = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar2,uVar1,uVar4,
		               Method_MVC_AbstractController_PortalsShopModel__PortalsEvents___ctor__);
		    *(undefined4 *)(iVar2 + 0x18) = uVar5;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar6 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsShopViewMediator_TypeInfo);
		    if (DAT_ram_00a57d12 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView___ctor__
		                );
		      DAT_ram_00a57d12 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (iVar6,uVar1,uVar4,iVar2,
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView___ctor__
		              );
		    param1[8] = iVar6;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Competition_View_Sections_Shop_CompetitionShopView__get_Description
		              (*(undefined4 *)(*(int *)(iVar6 + 0x3c) + 0x3c),0);
		    MVC_AbstractController__Dispose(iVar2,0);
		    piVar3 = (int *)param1[8];
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[8];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x3c),*(undefined4 *)(iVar6 + 0x164));
		  return param1[8];
		}
		*/

			return null;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x7607", Offset = "0x7607", VA = "0x7607")]
		private IHideableMediator ShowShopTab()
		{
		/* --- GHIDRA: ShowShopTab ---
		void Gameplay_Portals_Controller_PortalsViewMediator__ShowShopTab(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a57d58 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__Dispose__
		              );
		    DAT_ram_00a57d58 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsController__Subscribe(uVar1,0);
		  if (param1[7] == 0) {
		    iVar2 = 0;
		  }
		  else {
		    Gameplay_Portals_Controller_PortalsRatingViewMediator__Dispose(param1[7],0);
		    iVar2 = param1[7];
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator___Init_b__20_0(iVar2,param1);
		  param1[7] = 0;
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = 0;
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		              (piVar3,0,*(undefined4 *)(*piVar3 + 0x144));
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x158) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = param1[6];
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator___Init_b__20_0(iVar2,param1);
		  param1[6] = 0;
		  if (param1[9] == 0) {
		    iVar2 = 0;
		  }
		  else {
		    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryViewMediator__ValidateWarButton
		              (param1[9],0);
		    iVar2 = param1[9];
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator___Init_b__20_0(iVar2,param1);
		  param1[9] = 0;
		  if (param1[8] == 0) {
		    iVar2 = 0;
		  }
		  else {
		    Gameplay_Portals_Controller_PortalsShopViewMediator__set_View(param1[8],param1);
		    iVar2 = param1[8];
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator___Init_b__20_0(iVar2,param1);
		  param1[8] = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x7608", Offset = "0x7608", VA = "0x7608", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Portals_Controller_PortalsViewMediator__Dispose(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Animations_GameSpineUiAnimation__Stop(*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x760A", Offset = "0x760A", VA = "0x760A")]
		[CompilerGenerated]
		internal static void <Dispose>g__DisposeMediator|58_0(IViewMediator mediator)
		{
		}

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x18")]
		private PortalsTotalizatorViewMediator _portalsTotalizatorViewMediator;

		// Token: 0x04001409 RID: 5129
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0x1C")]
		private PortalsRatingViewMediator _portalsRatingViewMediator;

		// Token: 0x0400140A RID: 5130
		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x20")]
		private PortalsShopViewMediator _portalsShopViewMediator;

		// Token: 0x0400140B RID: 5131
		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0x24")]
		private PortalsMyBetsViewMediator _portalsMyBetsViewMediator;

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<PortalsTargets, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x2C")]
		private IHideableMediator _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PortalsView ---
		undefined4
		Gameplay_Portals_Controller_PortalsViewMediator__get_PortalsView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  return *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x1c);
		}
		*/


		/* --- GHIDRA: get_PortalsRewardView ---
		undefined4
		Gameplay_Portals_Controller_PortalsViewMediator__get_PortalsRewardView
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  return *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x34);
		}
		*/


		/* --- GHIDRA: get_MonsterInfoView ---
		void Gameplay_Portals_Controller_PortalsViewMediator__get_MonsterInfoView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57d37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__set_View__
		              );
		    DAT_ram_00a57d37 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsViewMediator__ShowNavigation(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x38),0,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsViewMediator__ResetView(param1,param1);
		    Gameplay_Portals_Controller_PortalsViewMediator__SetupView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Portals_Controller_PortalsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57d38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_BetPoolInfoReceivedHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Portals_Controller_PortalsViewMediator_CloseAll__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterChangedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterReceivedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_JackpotInfoReceivedHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalStateChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoReceivedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_UserInfoChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsViewMediator_UserRegisteredHandler__);
		    DAT_ram_00a57d38 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterReceivedHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterChangedHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x58);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_JackpotInfoReceivedHandler__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x58) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x58) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x54);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_BetPoolInfoReceivedHandler__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x54) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x54) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalStateChangedHandler__,0)
		    ;
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x50) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x50) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoReceivedHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoChangedHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_UserInfoChangedHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_UserRegisteredHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Portals_Controller_PortalsViewMediator_CloseAll__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterReceivedHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_CurrentMonsterChangedHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x58);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_JackpotInfoReceivedHandler__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x58) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x58) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x54);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_BetPoolInfoReceivedHandler__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x54) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x54) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_PortalStateChangedHandler__,0)
		    ;
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x50) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x50) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoReceivedHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_StageInfoChangedHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_UserInfoChangedHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsViewMediator_UserRegisteredHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Portals_Controller_PortalsViewMediator_CloseAll__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Controller_PortalsViewMediator__set_Events(int param1,undefined4 param2)
		
		{
		  uint *param2_00;
		  int *param1_00;
		  int iVar1;
		  
		  param2_00 = (uint *)0x0;
		  if (DAT_ram_00a57d39 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a57d39 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x2c);
		  if (param1_00 != (int *)0x0) {
		    iVar1 = *param1_00;
		    if ((uint *)(uint)*(ushort *)(iVar1 + 0xb6) != (uint *)0x0) {
		      do {
		        if (MVC_Interfaces_IHideableMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar1 + 0x58) + (int)param2_00 * 8)) {
		          param2_00 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + (int)param2_00 * 8 + 4) * 8
		                              + 0xc0);
		          goto code_r0x80e5072c;
		        }
		        param2_00 = (uint *)((int)param2_00 + 1);
		      } while ((uint *)(uint)*(ushort *)(iVar1 + 0xb6) != param2_00);
		    }
		    param2_00 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80e5072c:
		    (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param2_00[1]);
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x34) = 0;
		  Gameplay_Portals_Controller_PortalsViewMediator__DecreasePortalTarget(param1,param2_00);
		  return;
		}
		*/

}
