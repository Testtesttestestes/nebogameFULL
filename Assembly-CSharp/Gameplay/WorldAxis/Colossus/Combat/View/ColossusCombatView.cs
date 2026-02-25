using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.WorldAxis.Colossus.Combat.View
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	public class ColossusCombatView : VortexCombatView
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002EE")]
		public Transform ColossusScoresBlock
		{
			[Token(Token = "0x60012FF")]
			[Address(RVA = "0x64F5", Offset = "0x64F5", VA = "0x64F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002EF")]
		public IconValueRender ColossusScoresReward
		{
			[Token(Token = "0x6001300")]
			[Address(RVA = "0x64F6", Offset = "0x64F6", VA = "0x64F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F0")]
		public TextMeshProUGUI ColossusScoresRewardBlockTitle
		{
			[Token(Token = "0x6001301")]
			[Address(RVA = "0x64F7", Offset = "0x64F7", VA = "0x64F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F1")]
		public TextMeshProUGUI ColossusRewardDescription
		{
			[Token(Token = "0x6001302")]
			[Address(RVA = "0x64F8", Offset = "0x64F8", VA = "0x64F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x64F9", Offset = "0x64F9", VA = "0x64F9", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x64FA", Offset = "0x64FA", VA = "0x64FA", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(VortexCombatPlayer player)
		{
			return null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x64FB", Offset = "0x64FB", VA = "0x64FB", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x64FC", Offset = "0x64FC", VA = "0x64FC")]
		public ColossusCombatView()
		{
		}

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI _colossusRewardDescription;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Transform _colossusScoresBlock;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _colossusScoresRewardBlockTitle;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private IconValueRender _colossusScoresReward;
	}
}
