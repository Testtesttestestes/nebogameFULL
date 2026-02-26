using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Consts;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	public class ClanCreationViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, ClanCreationView>, IHideableMediator
	{
		// Token: 0x06003EDB RID: 16091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x8D97", Offset = "0x8D97", VA = "0x8D97")]
		public ClanCreationViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a57fd1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_FractionCultClanClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_PlayerCultClanClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57fd1 = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_PlayerCultClanClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f85 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		      DAT_ram_00a57f85 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar7 = System_Action_ClanTypeListElement__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ClanTypeListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x1c,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_FractionCultClanClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f85 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		      DAT_ram_00a57f85 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar7 = System_Action_ClanTypeListElement__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ClanTypeListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x1c,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar4,0);
		  }
		  param1[5] = param2;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_PlayerCultClanClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f84 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		      DAT_ram_00a57f84 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar7 = System_Action_ClanTypeListElement__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ClanTypeListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x1c,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_FractionCultClanClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f84 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		      DAT_ram_00a57f84 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar7 = System_Action_ClanTypeListElement__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ClanTypeListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x1c,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanCreationViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar4,0);
		    iVar5 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,1,0);
		    Gameplay_Clans_Office_Controller_ClanCreationViewMediator__set_View(param1,iVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C99 RID: 3225
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C99")]
		public override ClanCreationView View
		{
			[Token(Token = "0x6003EDC")]
			[Address(RVA = "0x8D98", Offset = "0x8D98", VA = "0x8D98", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x8D99", Offset = "0x8D99", VA = "0x8D99")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x20) + 0x10) + 0x160);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanOfficeController__CancelJoinRequestResultHandler
		            (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x24) + 0x10) + 0x160),
		             param1[6],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x8D9A", Offset = "0x8D9A", VA = "0x8D9A")]
		private void CreateClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: CreateClanButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__CreateClanButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_Controller_ClanCreationViewMediator__PlayerCultClanClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x8D9B", Offset = "0x8D9B", VA = "0x8D9B")]
		private void FractionCultClanClickedEventHandler(ClanTypeListElement element)
		{
		/* --- GHIDRA: FractionCultClanClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__FractionCultClanClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_Controller_ClanCreationViewMediator__SelectFractionClan(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x8D9C", Offset = "0x8D9C", VA = "0x8D9C")]
		private void PlayerCultClanClickedEventHandler(ClanTypeListElement element)
		{
		/* --- GHIDRA: PlayerCultClanClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__PlayerCultClanClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57fd3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView__get_Model__
		              );
		    DAT_ram_00a57fd3 = '\x01';
		  }
		  param1[6] = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Requirements_RequirementsView__get_Data
		            (*(undefined4 *)(iVar1 + 0x10),*(undefined4 *)(param1[2] + 0x28),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x18),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x18),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x8D9D", Offset = "0x8D9D", VA = "0x8D9D")]
		private void SelectFractionClan()
		{
		/* --- GHIDRA: SelectFractionClan ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__SelectFractionClan
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57fd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView__get_Model__
		              );
		    DAT_ram_00a57fd4 = '\x01';
		  }
		  param1[6] = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Requirements_RequirementsView__get_Data
		            (*(undefined4 *)(iVar1 + 0x10),*(undefined4 *)(param1[2] + 0x24),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x18),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x18),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x8D9E", Offset = "0x8D9E", VA = "0x8D9E")]
		private void SelectPlayerClan()
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x8D9F", Offset = "0x8D9F", VA = "0x8D9F", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanInfoModel__ClanInfoEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CommandsRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57fd5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanInfoModel__ClanInfoEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_CommandsRepository_TypeInfo);
		  Utils_ColorUtil__SetRGB(uVar1,3.0,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x18")]
		private ClanFlags _fractionFlag;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanCreationViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57fd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21198);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21199);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21213);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21214);
		    DAT_ram_00a57fd2 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanCreationViewMediator__SelectFractionClan(param1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80e8d656;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e8d656:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar4,StringLiteral_21214,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x24);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80e8d737;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e8d737:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar4,StringLiteral_21199,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x20) + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80e8d81b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e8d81b:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar4,StringLiteral_21213,0);
		  TMPro_TMP_InputField__get_characterLimit(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80e8d8ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e8d8ff:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar4,StringLiteral_21198,0);
		  TMPro_TMP_InputField__get_characterLimit(uVar6,uVar4,0);
		  uVar6 = *(undefined4 *)(*(int *)(param1[2] + 8) + 0x4c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80e8d9d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e8d9d2:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar2 = Core_Gameplay_Managers_ClansManager__GetCultsByClan(uVar4,uVar6,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x14);
		  uVar6 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar6,0);
		  AssetContent_GameImage__get_AssetId(uVar8,uVar6,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar6 = Core_Gameplay_Managers_ClansManager__GetClanCultAssetId
		                    (uVar4,*(undefined4 *)(iVar2 + 0xc),0);
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement___ctor(uVar8,iVar2,uVar6,iVar2);
		  return;
		}
		*/

}
