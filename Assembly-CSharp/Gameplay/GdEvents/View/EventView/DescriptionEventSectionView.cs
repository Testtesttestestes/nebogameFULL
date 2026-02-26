using System;
using AssetContent;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	public class DescriptionEventSectionView : AbstractEventSectionView
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086C")]
		public GameAssetViewRawImage ArtRender
		{
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x7CDD", Offset = "0x7CDD", VA = "0x7CDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086D")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x7CDE", Offset = "0x7CDE", VA = "0x7CDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086E")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x7CDF", Offset = "0x7CDF", VA = "0x7CDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086F")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x7CE0", Offset = "0x7CE0", VA = "0x7CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000870")]
		public BackTimeView Timer
		{
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x7CE1", Offset = "0x7CE1", VA = "0x7CE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000871")]
		public Button AprsButton
		{
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x7CE2", Offset = "0x7CE2", VA = "0x7CE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000872")]
		public Button MedalsButton
		{
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x7CE3", Offset = "0x7CE3", VA = "0x7CE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000873")]
		public Button CollectionsButton
		{
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x7CE4", Offset = "0x7CE4", VA = "0x7CE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000874")]
		public Button ItemsButton
		{
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0x7CE5", Offset = "0x7CE5", VA = "0x7CE5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000875")]
		public BattlePassGroupView BattlePassGroupView
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x7CE6", Offset = "0x7CE6", VA = "0x7CE6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x7CE7", Offset = "0x7CE7", VA = "0x7CE7", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x7CE8", Offset = "0x7CE8", VA = "0x7CE8")]
		public DescriptionEventSectionView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_GdEvents_View_EventView_DescriptionEventSectionView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2ba == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12622);
		    DAT_ram_00a5a2ba = '\x01';
		  }
		  return StringLiteral_12622;
		}
		*/

		}

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewRawImage _artRender;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BackTimeView _timer;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _aprsButton;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _medalsButton;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _collectionsButton;

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _itemsButton;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BattlePassGroupView _battlePassGroupView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BattlePassGroupView ---
		void Gameplay_GdEvents_View_EventView_DescriptionEventSectionView__get_BattlePassGroupView
		               (undefined4 param1,undefined4 *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2b9 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x104));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x110) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x114));
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a5a31a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView___ctor__
		              );
		    DAT_ram_00a5a31a = '\x01';
		  }
		  uVar1 = 0;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param3,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView___ctor__
		            );
		  *param2 = param1_00;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x811f5aff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f5aff:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

}
