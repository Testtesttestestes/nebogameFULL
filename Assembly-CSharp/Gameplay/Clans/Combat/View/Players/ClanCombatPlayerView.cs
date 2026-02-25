using System;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Aprs.View;
using Gameplay.Clans.Combat.Model;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class ClanCombatPlayerView : MonoBehaviour, ICombatPLayerView, IToolTipDataProvider
	{
		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD8")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x6004127")]
			[Address(RVA = "0x8FDE", Offset = "0x8FDE", VA = "0x8FDE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004128")]
			[Address(RVA = "0x8FDF", Offset = "0x8FDF", VA = "0x8FDF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD9")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x6004129")]
			[Address(RVA = "0x8FE0", Offset = "0x8FE0", VA = "0x8FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600412A")]
			[Address(RVA = "0x8FE1", Offset = "0x8FE1", VA = "0x8FE1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x8FE2", Offset = "0x8FE2", VA = "0x8FE2", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x8FE3", Offset = "0x8FE3", VA = "0x8FE3")]
		private void SetHealth(long current, long total)
		{
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x8FE4", Offset = "0x8FE4", VA = "0x8FE4")]
		private void SetMana(long current, long total)
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x8FE5", Offset = "0x8FE5", VA = "0x8FE5")]
		private void UpdateMana()
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x8FE6", Offset = "0x8FE6", VA = "0x8FE6")]
		private void UpdateHealth()
		{
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x8FE7", Offset = "0x8FE7", VA = "0x8FE7", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x8FE8", Offset = "0x8FE8", VA = "0x8FE8", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x8FE9", Offset = "0x8FE9", VA = "0x8FE9", Slot = "7")]
		public void UpdateLongEffects()
		{
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x8FEA", Offset = "0x8FEA", VA = "0x8FEA", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x8FEB", Offset = "0x8FEB", VA = "0x8FEB", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x8FEC", Offset = "0x8FEC", VA = "0x8FEC", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDA")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6004136")]
			[Address(RVA = "0x8FED", Offset = "0x8FED", VA = "0x8FED", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004137")]
			[Address(RVA = "0x8FEE", Offset = "0x8FEE", VA = "0x8FEE", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004138")]
		[Address(RVA = "0x8FEF", Offset = "0x8FEF", VA = "0x8FEF")]
		private void HandlePlayerChanged()
		{
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDB")]
		public bool IsInit
		{
			[Token(Token = "0x6004139")]
			[Address(RVA = "0x8FF0", Offset = "0x8FF0", VA = "0x8FF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600413A")]
			[Address(RVA = "0x8FF1", Offset = "0x8FF1", VA = "0x8FF1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDC")]
		public bool Select
		{
			[Token(Token = "0x600413B")]
			[Address(RVA = "0x8FF2", Offset = "0x8FF2", VA = "0x8FF2", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600413C")]
			[Address(RVA = "0x8FF3", Offset = "0x8FF3", VA = "0x8FF3", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x8FF4", Offset = "0x8FF4", VA = "0x8FF4", Slot = "17")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x8FF5", Offset = "0x8FF5", VA = "0x8FF5")]
		public ClanCombatPlayerView()
		{
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x8FF6", Offset = "0x8FF6", VA = "0x8FF6", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AprViewSmall _avatar;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI[] _nicks;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _myPlayerbackground;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _background;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _transformsOfMirror;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBar _healthBar;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ProgressBar _manaBar;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x34")]
		private ClanCombatPlayer _player;
	}
}
