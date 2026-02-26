using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B66 RID: 2918
	[Token(Token = "0x2000B66")]
	public class BossRatingView : AbstractBossWindowView<BossRatingView, BossRatingViewMediator>
	{
		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E06")]
		public GreenToggle GreenToggle
		{
			[Token(Token = "0x60046C2")]
			[Address(RVA = "0x9558", Offset = "0x9558", VA = "0x9558")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E07")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x60046C3")]
			[Address(RVA = "0x9559", Offset = "0x9559", VA = "0x9559")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E08")]
		public BossRatingListItemView OwnRatingListItemView
		{
			[Token(Token = "0x60046C4")]
			[Address(RVA = "0x955A", Offset = "0x955A", VA = "0x955A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060046C5 RID: 18117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E09")]
		public TextMeshProUGUI OwnRatingLabel
		{
			[Token(Token = "0x60046C5")]
			[Address(RVA = "0x955B", Offset = "0x955B", VA = "0x955B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0A")]
		public BossTopLeaderView TopLeader1
		{
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x955C", Offset = "0x955C", VA = "0x955C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0B")]
		public BossTopLeaderView TopLeader2
		{
			[Token(Token = "0x60046C7")]
			[Address(RVA = "0x955D", Offset = "0x955D", VA = "0x955D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0C")]
		public BossTopLeaderView TopLeader3
		{
			[Token(Token = "0x60046C8")]
			[Address(RVA = "0x955E", Offset = "0x955E", VA = "0x955E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0D")]
		public BossRatingListAdapter ListAdapter
		{
			[Token(Token = "0x60046C9")]
			[Address(RVA = "0x955F", Offset = "0x955F", VA = "0x955F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0E")]
		public TextMeshProUGUI RightTitle
		{
			[Token(Token = "0x60046CA")]
			[Address(RVA = "0x9560", Offset = "0x9560", VA = "0x9560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E0F")]
		public TextMeshProUGUI RightDesc
		{
			[Token(Token = "0x60046CB")]
			[Address(RVA = "0x9561", Offset = "0x9561", VA = "0x9561")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x9562", Offset = "0x9562", VA = "0x9562", Slot = "5")]
		protected override BossRatingViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_RatingTab_BossRatingView__CreateMediator
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossRatingView__BossRatingViewMediator___ctor__
		              );
		    DAT_ram_00a579f7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossRatingView__BossRatingViewMediator___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x9563", Offset = "0x9563", VA = "0x9563")]
		public BossRatingView()
		{
		}

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTopLeaderView _topLeader1;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossTopLeaderView _topLeader2;

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossTopLeaderView _topLeader3;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BossRatingListAdapter _listAdapter;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BossRatingListItemView _ownRatingListItemView;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _ownRatingLabel;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _rightTitle;

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _rightDesc;

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GreenToggle _greenToggle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RightDesc ---
		undefined4 Gameplay_Boss_View_RatingTab_BossRatingView__get_RightDesc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRatingViewMediator_TypeInfo);
		    DAT_ram_00a579f6 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossRatingViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossMinionWindowMediator__MinionCanceledEvent
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
