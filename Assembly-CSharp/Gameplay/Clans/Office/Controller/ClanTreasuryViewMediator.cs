using System;
using System.Runtime.CompilerServices;
using Core.Money;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanTreasuryTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class ClanTreasuryViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanTreasuryView>, IHideableMediator
	{
		// Token: 0x06003F8F RID: 16271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x8E4A", Offset = "0x8E4A", VA = "0x8E4A")]
		public ClanTreasuryViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller, Money deficientResources)
		{
		/* --- GHIDRA: <SubmitToTreasuryButtonClickedEventHandler>g__CheckIfGreaterThanFee|9_0 ---
		uint Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___SubmitToTreasuryButtonClickedEventHandler_g__CheckIfGreaterThanFee_9_0
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  double dVar1;
		  
		  dVar1 = func_ii_6906(*(undefined4 *)(param2 + 8),5,0);
		  if (0.0 < dVar1 != 0) {
		    Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__GetTaxCoeff
		              (param1,*(undefined4 *)(param2 + 8),param2);
		  }
		  return (uint)(0.0 < dVar1);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5768a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__set_View__
		              );
		    DAT_ram_00a5768a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA5 RID: 3237
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA5")]
		public override ClanTreasuryView View
		{
			[Token(Token = "0x6003F90")]
			[Address(RVA = "0x8E4B", Offset = "0x8E4B", VA = "0x8E4B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x8E4C", Offset = "0x8E4C", VA = "0x8E4C")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5768c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_SubmitToTreasuryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ToEventsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25417);
		    DAT_ram_00a5768c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_SubmitToTreasuryButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ToEventsButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar2,StringLiteral_25417,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  uVar4 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x6c) + 0x30),0);
		  Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__Init(param1_00,uVar4,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x14);
		  uVar4 = Core_Money_Money__op_Explicit(*(undefined4 *)(*(int *)(param1[2] + 8) + 0x78),0);
		  Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__GetInputResources
		            (uVar3,uVar2,uVar4,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Price_Price__SetColor(*(undefined4 *)(iVar1 + 0x20),0,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x10);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  UI_Price_ResourceTable__OnDestroy(uVar4,uVar2,*(undefined4 *)(param1[2] + 0x28),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Price_ResourceTable__MarkerClickedEventHandler
		            (*(undefined4 *)(iVar1 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x24) + 0x18) + 8),0);
		  if (DAT_ram_00a57691 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57691 = '\x01';
		  }
		  iVar1 = param1[6];
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar1 = Core_Money_Money__op_Inequality(iVar1,0,0);
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateLowerBound
		              (*(undefined4 *)(iVar1 + 0x14),param1[6],0);
		    param1[6] = 0;
		  }
		  Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ToEventsButtonClickedEventHandler
		            (param1,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x8E4D", Offset = "0x8E4D", VA = "0x8E4D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5768d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5768d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  param2_00 = Core_Money_Money__op_Explicit(param2,0);
		  Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateBounds(param1_00,param2_00,0)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x8E4E", Offset = "0x8E4E", VA = "0x8E4E")]
		private void UserBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: UserBalanceChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__UserBalanceChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  double dVar6;
		  double dVar7;
		  double dVar8;
		  double dVar9;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined1 auStack_30 [8];
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  int *local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5768e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_25417);
		    DAT_ram_00a5768e = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  local_c = param1;
		  uVar1 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  local_4 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar1,StringLiteral_25417,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__Init
		                    (*(undefined4 *)(iVar2 + 0x14),0);
		  local_8 = uVar1;
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(uVar1,0);
		  local_10 = uVar3;
		  iVar2 = Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ShowColossusWarningWindow
		                    (param1,&local_10,auStack_30);
		  if (iVar2 != 0) {
		    param1_00 = *(undefined4 *)(*(int *)(param1[2] + 0x28) + 0x14);
		    param1_01 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x24) + 0x18) + 8);
		    dVar6 = Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__CutInputResourcesByLimit
		                      (param1,auStack_30);
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_20,uVar3,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		    local_28 = 0;
		    local_24 = &local_20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc3afc;
		      }
		      if (iVar4 == 0) goto code_r0x80dc3b63;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = local_18._4_4_;
		      dVar7 = func_ii_6906(param1_00,local_18._4_4_,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc3afc;
		      }
		      DAT_ram_009d3e38 = 0;
		      dVar8 = func_ii_6906(uVar1,uVar3,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc3afc;
		      }
		      DAT_ram_009d3e38 = 0;
		      dVar9 = func_ii_6906(param1_01,uVar3,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc3afc;
		      }
		    } while ((dVar7 <= 0.0) || (dVar6 * dVar8 + dVar9 <= dVar7));
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiiidi
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x348,param1,uVar1,param1_01,
		               param1_00,dVar6,auStack_30);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dc3afc:
		      iVar2 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80dc3b63:
		          DAT_ram_009d3e38 = 0;
		          dVar6 = func_ii_6906(uVar1,5,0);
		          if (dVar6 <= 0.0) {
		            uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x14c));
		            Gameplay_Clans_Office_Controller_ClanInfoController__SetClanStateFlagsResultHandler
		                      (uVar3,uVar1,0);
		            return;
		          }
		          Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__GetTaxCoeff
		                    (param1,uVar1,auStack_30);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x349,&local_28);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x8E4F", Offset = "0x8E4F", VA = "0x8E4F")]
		private void SubmitToTreasuryButtonClickedEventHandler()
		{
		/* --- GHIDRA: SubmitToTreasuryButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__SubmitToTreasuryButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__SetClanStateFlagsResultHandler
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x8E50", Offset = "0x8E50", VA = "0x8E50")]
		private void AddToTreasury(ResourceSet inputResources)
		{
		/* --- GHIDRA: AddToTreasury ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__AddToTreasury
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5768f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5768f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x168);
		        goto code_r0x80dc4791;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x15);
		code_r0x80dc4791:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameEventsManager__SetView(param1_00,4,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x8E51", Offset = "0x8E51", VA = "0x8E51")]
		private void ToEventsButtonClickedEventHandler()
		{
		/* --- GHIDRA: ToEventsButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ToEventsButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param2_00;
		  undefined4 param3;
		  int local_4;
		  
		  if (DAT_ram_00a57690 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
		    DAT_ram_00a57690 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor(param1[7],&local_4,0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 == 0) {
		    Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__SetWarStatus(param1_00,0);
		  }
		  else {
		    param2_00 = *(undefined4 *)(local_4 + 0xc);
		    param3 = *(undefined4 *)(param1[7] + 0x18);
		    param4 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		    Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__get_Price
		              (param1_00,param2_00,param3,param4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x8E52", Offset = "0x8E52", VA = "0x8E52")]
		private void UpdateWarStatus()
		{
		/* --- GHIDRA: UpdateWarStatus ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__UpdateWarStatus
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57691 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57691 = '\x01';
		  }
		  iVar1 = param1[6];
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar1 = Core_Money_Money__op_Inequality(iVar1,0,0);
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateLowerBound
		              (*(undefined4 *)(iVar1 + 0x14),param1[6],0);
		    param1[6] = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x8E53", Offset = "0x8E53", VA = "0x8E53")]
		private void RenderDeficientResources()
		{
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x8E54", Offset = "0x8E54", VA = "0x8E54", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__Hide
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57692 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ResourceSet__ResourceSet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ClanTreasuryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_UserBalanceChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_WarStateChangedEventHandler__
		              );
		    DAT_ram_00a57692 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar5 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ClanTreasuryChangedEventHandler__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar5 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar5 = *(int *)(iVar1 + 0x18);
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar5 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x3c);
		    uVar2 = unnamed_function_1417(System_Action_ResourceSet__ResourceSet__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_UserBalanceChangedEventHandler__
		               ,0);
		    iVar5 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		    if (iVar5 == 0) {
		      *(undefined4 *)(iVar1 + 0x3c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar5,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x3c) = iVar4;
		      uVar2 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		      iVar1 = func_ii_1082(iVar5,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar5,uVar2);
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
		    iVar5 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ClanTreasuryChangedEventHandler__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar5 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x3c);
		    uVar2 = unnamed_function_1417(System_Action_ResourceSet__ResourceSet__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_UserBalanceChangedEventHandler__
		               ,0);
		    iVar5 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		    if (iVar5 == 0) {
		      *(undefined4 *)(iVar1 + 0x3c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar5,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x3c) = iVar4;
		      uVar2 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		      iVar1 = func_ii_1082(iVar5,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar5 = *(int *)(iVar1 + 0x18);
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar5 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA6 RID: 3238
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA6")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F9A")]
			[Address(RVA = "0x8E55", Offset = "0x8E55", VA = "0x8E55", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x8E56", Offset = "0x8E56", VA = "0x8E56")]
		private void WarStateChangedEventHandler()
		{
		/* --- GHIDRA: WarStateChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__WarStateChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57693 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
		    DAT_ram_00a57693 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Price_ResourceTable__MarkerClickedEventHandler
		            (*(undefined4 *)(iVar1 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x24) + 0x18) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x8E57", Offset = "0x8E57", VA = "0x8E57")]
		private void ClanTreasuryChangedEventHandler()
		{
		/* --- GHIDRA: ClanTreasuryChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ClanTreasuryChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,double param5,
		               undefined4 param6)
		
		{
		  undefined4 param2_00;
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  double dVar6;
		  double dVar7;
		  double dVar8;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57694 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57694 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(param2,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(param2,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar2,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    do {
		      uVar2 = uVar1;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc4ecc;
		      }
		      if (iVar3 == 0) goto code_r0x80dc4f22;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = local_8._4_4_;
		      dVar6 = func_ii_6906(param4,local_8._4_4_,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc4ecc;
		      }
		      DAT_ram_009d3e38 = 0;
		      dVar7 = func_ii_6906(param3,param2_00,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc4ecc;
		      }
		      DAT_ram_009d3e38 = 0;
		      dVar8 = func_ii_6906(param2,param2_00,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc4ecc;
		      }
		      uVar1 = uVar2;
		    } while ((dVar6 <= 0.0) || (dVar7 + dVar8 * param5 <= dVar6));
		    DAT_ram_009d3e38 = 0;
		    dVar6 = dVar6 - dVar7;
		    dVar7 = import::env::invoke_dddi
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34c,dVar6,param5,0);
		    iVar5 = DAT_ram_009d3e38;
		    in_register_20000014 = (undefined4)((ulonglong)dVar6 >> 0x20);
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) break;
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dc4ecc;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34d,param2_00,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc4ecc;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiidi
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34e,uVar2,uVar1,dVar7,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dc4ecc:
		      iVar5 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80dc4f22:
		          DAT_ram_009d3e38 = 0;
		          iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)))
		          ;
		          Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateLowerBound
		                    (*(undefined4 *)(iVar5 + 0x14),uVar2,0);
		          return;
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34f,&local_18);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80dc4ecc;
		}
		*/

		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x8E58", Offset = "0x8E58", VA = "0x8E58")]
		private void CutInputResourcesByLimit(ResourceSet inputResources, ResourceSet balance, NullableResourceSet limits, double taxCoeff)
		{
		/* --- GHIDRA: CutInputResourcesByLimit ---
		double Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__CutInputResourcesByLimit
		                 (int param1,undefined4 param2)
		
		{
		  double dVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a57695 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_28319);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28322);
		    DAT_ram_00a57695 = '\x01';
		  }
		  local_4 = 0;
		  dVar1 = 1.0;
		  iVar3 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor
		                    (*(undefined4 *)(param1 + 0x1c),&local_4,0);
		  if (iVar3 != 0) {
		    puVar2 = &StringLiteral_28322;
		    iVar3 = *(int *)(*(int *)(local_4 + 0xc) + 0x1c);
		    if (iVar3 != 1) {
		      if (iVar3 == 2) {
		        puVar2 = &StringLiteral_28319;
		      }
		      else {
		        if (iVar3 == 3) {
		          return 1.0;
		        }
		        if (iVar3 == 4) {
		          return 1.0;
		        }
		        puVar2 = &StringLiteral_28322;
		        if (iVar3 != 5) {
		          return 1.0;
		        }
		      }
		    }
		    param1_00 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor
		                          (*(undefined4 *)(param1 + 8),0);
		    dVar1 = Core_Extensions_Dict_DictExt__GetIntParameter(param1_00,*puVar2,0);
		    dVar1 = 1.0 - dVar1;
		  }
		  return dVar1;
		}
		*/

		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x8E59", Offset = "0x8E59", VA = "0x8E59")]
		private double GetTaxCoeff()
		{
		/* --- GHIDRA: GetTaxCoeff ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__GetTaxCoeff
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57697 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass22_0__ShowColossusWarningWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass22_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2765);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11304);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4303);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4338);
		    DAT_ram_00a57697 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass22_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2765,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4338,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                        (*(undefined4 *)(iVar1 + 0xc),NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4303,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass22_0__ShowColossusWarningWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar3 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11304,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar3 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = iVar3;
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

			return 0.0;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x1B10", Offset = "0x1B10", VA = "0x1B10")]
		private DialogWindow ShowExceedingOperationDialogWindow(ResourceSet inputResources, ResourceSet balance, NullableResourceSet limits, double taxCoeff)
		{
			return null;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x8E5A", Offset = "0x8E5A", VA = "0x8E5A")]
		private DialogWindow ShowColossusWarningWindow(ResourceSet inputResources)
		{
		/* --- GHIDRA: ShowColossusWarningWindow ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ShowColossusWarningWindow
		          (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  double dVar6;
		  double dVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57698 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Count__);
		    DAT_ram_00a57698 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(*param2 + 0xc) == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    func_ii_6929(uVar3,0);
		    return 0;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*param2,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc3e26;
		    }
		    if (uVar2 == 0) goto code_r0x80dc3e01;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = local_8._4_4_;
		    dVar6 = func_ii_6906(param2[2],local_8._4_4_,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc3e26;
		    }
		    DAT_ram_009d3e38 = 0;
		    dVar7 = func_ii_6906(param2[3],uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dc3e26;
		    }
		  } while (dVar7 <= dVar6);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iii
		                    (*(undefined4 *)(*param1 + 0x148),param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34a,uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80dc3e01:
		      DAT_ram_009d3e38 = 0;
		      return uVar2 ^ 1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80dc3e26:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return 1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34b,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
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
		*/

			return null;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x8E5B", Offset = "0x8E5B", VA = "0x8E5B")]
		[CompilerGenerated]
		private bool <SubmitToTreasuryButtonClickedEventHandler>g__CheckIfGreaterThanFee|9_0(ref ClanTreasuryViewMediator.<>c__DisplayClass9_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x8E5C", Offset = "0x8E5C", VA = "0x8E5C")]
		[CompilerGenerated]
		private bool <SubmitToTreasuryButtonClickedEventHandler>g__CheckForColossusFragments|9_1(ref ClanTreasuryViewMediator.<>c__DisplayClass9_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x18")]
		private Money _deficientResources;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsModel _clanWarsModel;

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x20")]
		private ZigguratLevelDic _zigguratLevelDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5768b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_SubmitToTreasuryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ToEventsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5768b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_SubmitToTreasuryButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator_ToEventsButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator__ToEventsButtonClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
