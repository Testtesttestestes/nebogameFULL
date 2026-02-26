using System;
using Il2CppDummyDll;
using Protocol.Boss;
using UI.Rewards;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	public abstract class AbstractBossRewardingSlotView : MonoBehaviour
	{
		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE3")]
		public Image GreenSelectedImage
		{
			[Token(Token = "0x600465E")]
			[Address(RVA = "0x94F6", Offset = "0x94F6", VA = "0x94F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004660 RID: 18016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE4")]
		public virtual GetTeamRewardsAns.Types.BossRewardInfo BossRewardInfo
		{
			[Token(Token = "0x600465F")]
			[Address(RVA = "0x94F7", Offset = "0x94F7", VA = "0x94F7", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004660")]
			[Address(RVA = "0x94F8", Offset = "0x94F8", VA = "0x94F8", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x94F9", Offset = "0x94F9", VA = "0x94F9")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView_ClickHandlerOnOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    DAT_ram_00a579d0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView_ClickHandlerOnOnClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004662")]
		[Address(RVA = "0x94FA", Offset = "0x94FA", VA = "0x94FA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004663")]
		[Address(RVA = "0x94FB", Offset = "0x94FB", VA = "0x94FB")]
		private void ClickHandlerOnOnClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06004664 RID: 18020
		[Token(Token = "0x6004664")]
		protected abstract void HandleClick();

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE5")]
		public virtual bool Interactable
		{
			[Token(Token = "0x6004665")]
			[Address(RVA = "0x94FC", Offset = "0x94FC", VA = "0x94FC", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004666")]
			[Address(RVA = "0x94FD", Offset = "0x94FD", VA = "0x94FD", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x94FE", Offset = "0x94FE", VA = "0x94FE")]
		protected AbstractBossRewardingSlotView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    DAT_ram_00a579d1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _greenSelectedImage;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x1C")]
		private GetTeamRewardsAns.Types.BossRewardInfo _bossRewardInfo;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x20")]
		private bool _interactable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BossRewardInfo ---
		void Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView__get_BossRewardInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a579ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a579ce = '\x01';
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  param1_00 = *(int **)(param1 + 0x10);
		  if (param2 == 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		    return;
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_RewardData___TypeInfo,1);
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  iVar1 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar3,0);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = iVar1;
		  UI_Rewards_AbstractRewardsRender__get_Rewards(param1_00,param2_00,0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xf4));
		  return;
		}
		*/


		/* --- GHIDRA: set_BossRewardInfo ---
		void Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView__set_BossRewardInfo
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView_ClickHandlerOnOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    DAT_ram_00a579cf = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView_ClickHandlerOnOnClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		void Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x20) = (undefined1)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x20),0);
		  return;
		}
		*/

}
