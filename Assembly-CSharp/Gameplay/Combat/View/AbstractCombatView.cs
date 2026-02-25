using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Combat.View.VFX;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000914 RID: 2324
	[Token(Token = "0x2000914")]
	public abstract class AbstractCombatView : MonoBehaviour
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC7")]
		public GameFieldMono GameField
		{
			[Token(Token = "0x60036AC")]
			[Address(RVA = "0x869C", Offset = "0x869C", VA = "0x869C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC8")]
		public virtual ITurnStatePointer TurnStatePointer
		{
			[Token(Token = "0x60036AD")]
			[Address(RVA = "0x869D", Offset = "0x869D", VA = "0x869D", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC9")]
		public Transform ScreenAnimationContainer
		{
			[Token(Token = "0x60036AE")]
			[Address(RVA = "0x869E", Offset = "0x869E", VA = "0x869E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACA")]
		public CombatEventsToast CombatEventsToast
		{
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x869F", Offset = "0x869F", VA = "0x869F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACB")]
		public CombatGameOverView GameOverView
		{
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x86A0", Offset = "0x86A0", VA = "0x86A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACC")]
		public Dictionary<CombatSpellData, CombatSpellButton> Spells
		{
			[Token(Token = "0x60036B1")]
			[Address(RVA = "0x86A1", Offset = "0x86A1", VA = "0x86A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACD")]
		public ICombatSpellDisplay SpellsDisplay
		{
			[Token(Token = "0x60036B2")]
			[Address(RVA = "0x86A2", Offset = "0x86A2", VA = "0x86A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000174 RID: 372
		// (add) Token: 0x060036B3 RID: 14003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036B4 RID: 14004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000174")]
		public event Action<CombatSpellData> OnSpellClick
		{
			[Token(Token = "0x60036B3")]
			[Address(RVA = "0x86A3", Offset = "0x86A3", VA = "0x86A3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036B4")]
			[Address(RVA = "0x86A4", Offset = "0x86A4", VA = "0x86A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x86A5", Offset = "0x86A5", VA = "0x86A5", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0x86A6", Offset = "0x86A6", VA = "0x86A6", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x86A7", Offset = "0x86A7", VA = "0x86A7")]
		private void HandleSpellOnclickEvent(CombatSpellData spell)
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x86A8", Offset = "0x86A8", VA = "0x86A8")]
		private void RemoveSpellEventHandlers()
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x86A9", Offset = "0x86A9", VA = "0x86A9", Slot = "7")]
		public virtual void ResetSpells()
		{
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x86AA", Offset = "0x86AA", VA = "0x86AA")]
		public CombatSpellButton AddSpell(CombatSpellData spell)
		{
			return null;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x86AB", Offset = "0x86AB", VA = "0x86AB")]
		protected CombatSpellButton AddSpell(CombatSpellData spell, ICombatSpellDisplay accordion)
		{
			return null;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x86AC", Offset = "0x86AC", VA = "0x86AC", Slot = "8")]
		protected virtual CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x86AD", Offset = "0x86AD", VA = "0x86AD")]
		public CombatSpellButton GetSpell(CombatSpellData value)
		{
			return null;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x86AE", Offset = "0x86AE", VA = "0x86AE", Slot = "9")]
		public virtual ICombatPLayerView GetPlayer(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x86AF", Offset = "0x86AF", VA = "0x86AF", Slot = "10")]
		public virtual void HideHint()
		{
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x86B0", Offset = "0x86B0", VA = "0x86B0", Slot = "11")]
		public virtual void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x1CE3", Offset = "0x1CE3", VA = "0x1CE3")]
		protected int PointToFieldIndex(Point point)
		{
			return 0;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x86B1", Offset = "0x86B1", VA = "0x86B1")]
		public bool TryGetVFX(List<StoneMono> stones, bool isMyTurn, out CombatAnimation.IContent content)
		{
			return default(bool);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x86B2", Offset = "0x86B2", VA = "0x86B2")]
		public void SetVFXThemeSkin(Sprite skin, Sprite glow)
		{
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x86B3", Offset = "0x86B3", VA = "0x86B3")]
		protected AbstractCombatView()
		{
		}

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		public const int FIELD_SIZE = 6;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected GameObject Cells;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameFieldMono gameField;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MonoBehaviour _turnStatePointer;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected AbstractCombatSpellsDisplay _spells;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _screenAnimationContainer;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected CombatEventsToast _combatEventsToast;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected CombatGameOverView _gameOverView;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private StoneDestroyVFX _stoneDestroyVFX;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x30")]
		private ITurnStatePointer _turnStatePointerComponent;
	}
}
