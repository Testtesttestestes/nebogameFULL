using System;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests;
using Gameplay.Ad.DailyQuestsAd.Controller;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.DailyQuestsAd.View
{
	// Token: 0x02000DAF RID: 3503
	[Token(Token = "0x2000DAF")]
	public class DailyQuestsAdView : MonoBehaviour
	{
		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001162")]
		public Button WatchButton
		{
			[Token(Token = "0x6005593")]
			[Address(RVA = "0xA333", Offset = "0xA333", VA = "0xA333")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001163")]
		public GameObject LoadingGroup
		{
			[Token(Token = "0x6005594")]
			[Address(RVA = "0xA334", Offset = "0xA334", VA = "0xA334")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005595")]
		[Address(RVA = "0xA335", Offset = "0xA335", VA = "0xA335")]
		public void Init(IDailyQuest dailyQuest, DailyQuestsAdPlacementManager manager)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Ad_DailyQuestsAd_View_DailyQuestsAdView__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 0;
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005596")]
		[Address(RVA = "0xA336", Offset = "0xA336", VA = "0xA336")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005597")]
		[Address(RVA = "0xA337", Offset = "0xA337", VA = "0xA337")]
		public DailyQuestsAdView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_DailyQuestsAd_View_DailyQuestsAdView___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a5884a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView___ctor__
		              );
		    DAT_ram_00a5884a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param5;
		  return;
		}
		*/

		}

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _loadingGroup;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x18")]
		private DailyQuestsAdViewMediator _mediator;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x1C")]
		private bool _mvcSetup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LoadingGroup ---
		void Gameplay_Ad_DailyQuestsAd_View_DailyQuestsAdView__get_LoadingGroup
		               (int param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param4_00;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58849 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a58849 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		          goto code_r0x80f3437e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0x12);
		code_r0x80f3437e:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar3 == 1) {
		      *(undefined1 *)(param1 + 0x1c) = 1;
		      param4_00 = *(undefined4 *)(param3 + 0x18);
		      param3_00 = *(undefined4 *)(param3 + 0x20);
		      param2_00 = *(undefined4 *)(param3 + 0x1c);
		      param1_00 = (int *)unnamed_function_1417
		                                   (
		                                   Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_TypeInfo
		                                   );
		      if (DAT_ram_00a5884a == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView___ctor__
		                  );
		        DAT_ram_00a5884a = '\x01';
		      }
		      Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		                (param1_00,param2_00,param3_00,param4_00,
		                 Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView___ctor__
		                );
		      param1_00[8] = (int)param2;
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		                (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		      *(int **)(param1 + 0x18) = param1_00;
		    }
		  }
		  return;
		}
		*/

}
