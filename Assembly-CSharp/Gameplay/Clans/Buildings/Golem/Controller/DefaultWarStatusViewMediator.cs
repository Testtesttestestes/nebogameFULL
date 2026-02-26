using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	public class DefaultWarStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x060042D5 RID: 17109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x9189", Offset = "0x9189", VA = "0x9189")]
		public DefaultWarStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57866 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_View__
		              );
		    DAT_ram_00a57866 = '\x01';
		  }
		  param1[5] = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D34 RID: 3380
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D34")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042D6")]
			[Address(RVA = "0x918A", Offset = "0x918A", VA = "0x918A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x918B", Offset = "0x918B", VA = "0x918B")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator__Init
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 0x14);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57867 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4256);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4255);
		    DAT_ram_00a57867 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x48),4,
		             Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x48) + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x240);
		        goto code_r0x80de9420;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80de9420:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (uVar3,*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x18),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = StringLiteral_4255;
		  iVar2 = *(int *)(iVar2 + 0x48);
		  if (DAT_ram_00a5784e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5784e = '\x01';
		  }
		  uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4256,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar5,0);
		  return;
		}
		*/

}
