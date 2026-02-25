using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players.LongEffects;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	public class CombatPlayerView : MonoBehaviour, ICombatPLayerView
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B15")]
		public SkillsInfo SkillsInfo
		{
			[Token(Token = "0x600383A")]
			[Address(RVA = "0x87F1", Offset = "0x87F1", VA = "0x87F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B16")]
		public LevelView Level
		{
			[Token(Token = "0x600383B")]
			[Address(RVA = "0x87F2", Offset = "0x87F2", VA = "0x87F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B17")]
		public RankView Rank
		{
			[Token(Token = "0x600383C")]
			[Address(RVA = "0x87F3", Offset = "0x87F3", VA = "0x87F3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B18")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x600383D")]
			[Address(RVA = "0x87F4", Offset = "0x87F4", VA = "0x87F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600383E")]
			[Address(RVA = "0x87F5", Offset = "0x87F5", VA = "0x87F5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B19")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x600383F")]
			[Address(RVA = "0x87F6", Offset = "0x87F6", VA = "0x87F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003840")]
			[Address(RVA = "0x87F7", Offset = "0x87F7", VA = "0x87F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1A")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003841")]
			[Address(RVA = "0x87F8", Offset = "0x87F8", VA = "0x87F8", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003842")]
			[Address(RVA = "0x87F9", Offset = "0x87F9", VA = "0x87F9", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x87FA", Offset = "0x87FA", VA = "0x87FA")]
		private void HandlePlayerChanged()
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x87FB", Offset = "0x87FB", VA = "0x87FB")]
		private void SetHealth(long current, long total)
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x87FC", Offset = "0x87FC", VA = "0x87FC")]
		private void SetMana(long current, long total)
		{
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1B")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6003846")]
			[Address(RVA = "0x87FD", Offset = "0x87FD", VA = "0x87FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003847")]
			[Address(RVA = "0x87FE", Offset = "0x87FE", VA = "0x87FE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x87FF", Offset = "0x87FF", VA = "0x87FF")]
		private void ResetPoolObjectDelegate(LongEffect pooledobject)
		{
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x8800", Offset = "0x8800", VA = "0x8800")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x8801", Offset = "0x8801", VA = "0x8801", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x8802", Offset = "0x8802", VA = "0x8802")]
		public void UpdateHealth()
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x8803", Offset = "0x8803", VA = "0x8803")]
		public void UpdateMana()
		{
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x8804", Offset = "0x8804", VA = "0x8804", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x8805", Offset = "0x8805", VA = "0x8805", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x8806", Offset = "0x8806", VA = "0x8806", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x8807", Offset = "0x8807", VA = "0x8807", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1C")]
		public bool IsInit
		{
			[Token(Token = "0x6003851")]
			[Address(RVA = "0x8808", Offset = "0x8808", VA = "0x8808", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x8809", Offset = "0x8809", VA = "0x8809")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1D")]
		public bool Select
		{
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x880A", Offset = "0x880A", VA = "0x880A", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x880B", Offset = "0x880B", VA = "0x880B", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x880C", Offset = "0x880C", VA = "0x880C", Slot = "7")]
		public void UpdateLongEffects()
		{
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x880D", Offset = "0x880D", VA = "0x880D", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x880E", Offset = "0x880E", VA = "0x880E")]
		public CombatPlayerView()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x880F", Offset = "0x880F", VA = "0x880F", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001F19 RID: 7961
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _avatar;

		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelView _level;

		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RankView _rank;

		// Token: 0x04001F1D RID: 7965
		[Token(Token = "0x4001F1D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NickBarCultFiller _cultFiller;

		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LongEffectsView _longEffectsView;

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffect _longEffectPrefab;

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private PetViewV2 _pet;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkillsInfo _skillsInfo;

		// Token: 0x04001F22 RID: 7970
		[Token(Token = "0x4001F22")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithText _healBar;

		// Token: 0x04001F23 RID: 7971
		[Token(Token = "0x4001F23")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressBarWithText _manaBar;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CombatPlayerView.SkillPbTextFormat _skillPbTextFormat;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _gameObjectsForActivate;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x4C")]
		private CombatPlayer _player;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<LongEffect> _currentLongEffects;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		[FieldOffset(Offset = "0x54")]
		private GameObjectPool<LongEffect> _longEffectPool;

		// Token: 0x0200094A RID: 2378
		[Token(Token = "0x200094A")]
		public enum SkillPbTextFormat
		{
			// Token: 0x04001F2F RID: 7983
			[Token(Token = "0x4001F2F")]
			Default,
			// Token: 0x04001F30 RID: 7984
			[Token(Token = "0x4001F30")]
			Shortly
		}
	}
}
