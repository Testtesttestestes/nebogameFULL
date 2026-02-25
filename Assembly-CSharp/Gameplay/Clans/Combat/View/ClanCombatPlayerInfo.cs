using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.LongEffects;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInfo.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class ClanCombatPlayerInfo : MonoBehaviour, ICombatPLayerView
	{
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CC4")]
		public SkillsInfo SkillsInfo
		{
			[Token(Token = "0x60040D8")]
			[Address(RVA = "0x8F8F", Offset = "0x8F8F", VA = "0x8F8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040DA RID: 16602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC5")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60040D9")]
			[Address(RVA = "0x8F90", Offset = "0x8F90", VA = "0x8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040DA")]
			[Address(RVA = "0x8F91", Offset = "0x8F91", VA = "0x8F91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC6")]
		public bool IsInit
		{
			[Token(Token = "0x60040DB")]
			[Address(RVA = "0x8F92", Offset = "0x8F92", VA = "0x8F92", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040DC")]
			[Address(RVA = "0x8F93", Offset = "0x8F93", VA = "0x8F93")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040DE RID: 16606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC7")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x60040DD")]
			[Address(RVA = "0x8F94", Offset = "0x8F94", VA = "0x8F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040DE")]
			[Address(RVA = "0x8F95", Offset = "0x8F95", VA = "0x8F95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040E0 RID: 16608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC8")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x60040DF")]
			[Address(RVA = "0x8F96", Offset = "0x8F96", VA = "0x8F96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040E0")]
			[Address(RVA = "0x8F97", Offset = "0x8F97", VA = "0x8F97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CC9")]
		public LevelView Level
		{
			[Token(Token = "0x60040E1")]
			[Address(RVA = "0x8F98", Offset = "0x8F98", VA = "0x8F98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCA")]
		public RankView Rank
		{
			[Token(Token = "0x60040E2")]
			[Address(RVA = "0x8F99", Offset = "0x8F99", VA = "0x8F99")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040E4 RID: 16612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCB")]
		public CombatPlayer Player
		{
			[Token(Token = "0x60040E3")]
			[Address(RVA = "0x8F9A", Offset = "0x8F9A", VA = "0x8F9A", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60040E4")]
			[Address(RVA = "0x8F9B", Offset = "0x8F9B", VA = "0x8F9B", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x8F9C", Offset = "0x8F9C", VA = "0x8F9C", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x8F9D", Offset = "0x8F9D", VA = "0x8F9D", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x8F9E", Offset = "0x8F9E", VA = "0x8F9E", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x8F9F", Offset = "0x8F9F", VA = "0x8F9F", Slot = "7")]
		public void UpdateLongEffects()
		{
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x8FA0", Offset = "0x8FA0", VA = "0x8FA0", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x8FA1", Offset = "0x8FA1", VA = "0x8FA1", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x8FA2", Offset = "0x8FA2", VA = "0x8FA2", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x0000C810 File Offset: 0x0000AA10
		// (set) Token: 0x060040ED RID: 16621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCC")]
		public bool Select
		{
			[Token(Token = "0x60040EC")]
			[Address(RVA = "0x8FA3", Offset = "0x8FA3", VA = "0x8FA3", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040ED")]
			[Address(RVA = "0x8FA4", Offset = "0x8FA4", VA = "0x8FA4", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x8FA5", Offset = "0x8FA5", VA = "0x8FA5")]
		public void UpdateHealth()
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x8FA6", Offset = "0x8FA6", VA = "0x8FA6")]
		public void UpdateMana()
		{
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x8FA7", Offset = "0x8FA7", VA = "0x8FA7")]
		private void SetHealth(long current, long total)
		{
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x8FA8", Offset = "0x8FA8", VA = "0x8FA8")]
		private void SetMana(long current, long total)
		{
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x8FA9", Offset = "0x8FA9", VA = "0x8FA9")]
		private void HandlePlayerChanged()
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x8FAA", Offset = "0x8FAA", VA = "0x8FAA")]
		private void ResetPoolObjectDelegate(LongEffect pooledobject)
		{
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x8FAB", Offset = "0x8FAB", VA = "0x8FAB")]
		public ClanCombatPlayerInfo()
		{
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x8FAC", Offset = "0x8FAC", VA = "0x8FAC", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CultWhitBackground _cultOnNickView;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelView _level;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RankView _rank;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PetView _pet;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillsInfo _skillsInfo;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffectsView _longEffectsView;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LongEffect _longEffectPrefab;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressBarWithText _healBar;

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithText _manaBar;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CombatPlayerView.SkillPbTextFormat _skillPbTextFormat;

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x4C")]
		private CombatPlayer _player;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<LongEffect> _currentLongEffects;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x54")]
		private GameObjectPool<LongEffect> _longEffectPool;
	}
}
