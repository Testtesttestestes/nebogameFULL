using System;
using DG.Tweening;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Gameplay.Combat.View.Tweens;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x0200091F RID: 2335
	[Token(Token = "0x200091F")]
	public class OneOnOneCombatView : AbstractCombatView
	{
		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADB")]
		public ICombatPLayerView LeftPlayerView
		{
			[Token(Token = "0x6003705")]
			[Address(RVA = "0x86F4", Offset = "0x86F4", VA = "0x86F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADC")]
		public ICombatPLayerView RightPlayerView
		{
			[Token(Token = "0x6003706")]
			[Address(RVA = "0x86F5", Offset = "0x86F5", VA = "0x86F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADD")]
		public SkillsInfoVisibilityHandler SkillsInfoVisibilityHandler
		{
			[Token(Token = "0x6003707")]
			[Address(RVA = "0x86F6", Offset = "0x86F6", VA = "0x86F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADE")]
		public StartCombatBuilder StartupUITweenBuilder
		{
			[Token(Token = "0x6003708")]
			[Address(RVA = "0x86F7", Offset = "0x86F7", VA = "0x86F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADF")]
		public PlayerChatBubble LeftPlayerChat
		{
			[Token(Token = "0x6003709")]
			[Address(RVA = "0x86F8", Offset = "0x86F8", VA = "0x86F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE0")]
		public PlayerChatBubble RightPlayerChat
		{
			[Token(Token = "0x600370A")]
			[Address(RVA = "0x86F9", Offset = "0x86F9", VA = "0x86F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE1")]
		public ICombatSpellDisplay ElixirDisplay
		{
			[Token(Token = "0x600370B")]
			[Address(RVA = "0x86FA", Offset = "0x86FA", VA = "0x86FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x86FB", Offset = "0x86FB", VA = "0x86FB")]
		public CombatSpellButton AddElixir(CombatSpellData spell)
		{
			return null;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x86FC", Offset = "0x86FC", VA = "0x86FC", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x86FD", Offset = "0x86FD", VA = "0x86FD", Slot = "12")]
		protected virtual void HandleHideInstantElements(GameObject[] elements)
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x86FE", Offset = "0x86FE", VA = "0x86FE", Slot = "13")]
		protected virtual void HandleDestroyInstantElements(GameObject[] elements)
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x86FF", Offset = "0x86FF", VA = "0x86FF", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x8700", Offset = "0x8700", VA = "0x8700", Slot = "11")]
		public override void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x8701", Offset = "0x8701", VA = "0x8701", Slot = "14")]
		protected virtual void ShowOpponentDeath(ICombatPLayerView player)
		{
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x8702", Offset = "0x8702", VA = "0x8702")]
		public OneOnOneCombatView()
		{
		}

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject[] _hideInstantElements;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _destroyInstantElements;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject LeftPodium;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject RightPodium;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OneOnOneCombatView.LeftRightPlayerPostionX[] PlayerPodiumPodiumGameOverPositionX;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CombatPlayerView leftPlayerView;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CombatPlayerView rightPlayerView;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkillsInfoVisibilityHandler _skillsInfoVisibilityHandler;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected AbstractCombatSpellsDisplay _elixirs;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StartCombatBuilder _startCombatBuilder;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private PlayerChatBubble _leftPlayerChat;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PlayerChatBubble _rightPlayerChat;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x6C")]
		public SpriteRenderer BackShadeSprite;

		// Token: 0x02000920 RID: 2336
		[Token(Token = "0x2000920")]
		[Serializable]
		public class LeftRightPlayerPostionX
		{
			// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003714")]
			[Address(RVA = "0x8703", Offset = "0x8703", VA = "0x8703")]
			public LeftRightPlayerPostionX()
			{
			}

			// Token: 0x04001E34 RID: 7732
			[Token(Token = "0x4001E34")]
			[FieldOffset(Offset = "0x8")]
			public float LeftX;

			// Token: 0x04001E35 RID: 7733
			[Token(Token = "0x4001E35")]
			[FieldOffset(Offset = "0xC")]
			public float RightX;

			// Token: 0x04001E36 RID: 7734
			[Token(Token = "0x4001E36")]
			[FieldOffset(Offset = "0x10")]
			public float Duration;

			// Token: 0x04001E37 RID: 7735
			[Token(Token = "0x4001E37")]
			[FieldOffset(Offset = "0x14")]
			public Ease Ease;
		}
	}
}
