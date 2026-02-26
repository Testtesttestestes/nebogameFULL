using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.AboutClansTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	public class AboutClansViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, AboutClansView>, IHideableMediator
	{
		// Token: 0x06003ED6 RID: 16086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x8D92", Offset = "0x8D92", VA = "0x8D92")]
		public AboutClansViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_AboutClansViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57fcf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_FindClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__AboutClansView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57fcf = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_FindClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_AboutClansViewMediator_FindClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C98 RID: 3224
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C98")]
		public override AboutClansView View
		{
			[Token(Token = "0x6003ED7")]
			[Address(RVA = "0x8D93", Offset = "0x8D93", VA = "0x8D93", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x8D94", Offset = "0x8D94", VA = "0x8D94")]
		private void CreateClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: CreateClanButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_AboutClansViewMediator__CreateClanButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x10),2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x8D95", Offset = "0x8D95", VA = "0x8D95")]
		private void FindClanButtonClickedEventHandler()
		{
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x8D96", Offset = "0x8D96", VA = "0x8D96", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_AboutClansViewMediator__Hide
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57fd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView___ctor__
		              );
		    DAT_ram_00a57fd0 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanCreationView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_AboutClansViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x10),1,0,0);
		  return;
		}
		*/

}
