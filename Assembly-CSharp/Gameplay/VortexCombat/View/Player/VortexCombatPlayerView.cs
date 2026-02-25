using System;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Aprs.View;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Gameplay.VortexCombat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexCombat.View.Player
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public class VortexCombatPlayerView : MonoBehaviour, ICombatPLayerView, IToolTipDataProvider
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003A0")]
		public Transform AnimationParent
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x67B3", Offset = "0x67B3", VA = "0x67B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x67B4", Offset = "0x67B4", VA = "0x67B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F3")]
			[Address(RVA = "0x67B5", Offset = "0x67B5", VA = "0x67B5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x60015F4")]
			[Address(RVA = "0x67B6", Offset = "0x67B6", VA = "0x67B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F5")]
			[Address(RVA = "0x67B7", Offset = "0x67B7", VA = "0x67B7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public CombatPlayer Player
		{
			[Token(Token = "0x60015F6")]
			[Address(RVA = "0x67B8", Offset = "0x67B8", VA = "0x67B8", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x67B9", Offset = "0x67B9", VA = "0x67B9", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003A4")]
		public VortexCombatPlayer VortexCombatPlayer
		{
			[Token(Token = "0x60015F8")]
			[Address(RVA = "0x67BA", Offset = "0x67BA", VA = "0x67BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		public CombatAnimation CombatAnimation
		{
			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x67BB", Offset = "0x67BB", VA = "0x67BB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x67BC", Offset = "0x67BC", VA = "0x67BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x67BD", Offset = "0x67BD", VA = "0x67BD")]
		private void OnDestroy()
		{
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x67BE", Offset = "0x67BE", VA = "0x67BE")]
		private void OnDisable()
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x67BF", Offset = "0x67BF", VA = "0x67BF")]
		private void Awake()
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x67C0", Offset = "0x67C0", VA = "0x67C0", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x67C1", Offset = "0x67C1", VA = "0x67C1")]
		private void SetHealth(long current, long total)
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x67C2", Offset = "0x67C2", VA = "0x67C2")]
		private void SetMana(long current, long total)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x67C3", Offset = "0x67C3", VA = "0x67C3")]
		private void SetCommonMana(long current, long total)
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x67C4", Offset = "0x67C4", VA = "0x67C4", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x67C5", Offset = "0x67C5", VA = "0x67C5")]
		public void UpdateBoostMana()
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x67C6", Offset = "0x67C6", VA = "0x67C6")]
		public void UpdateMana()
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x67C7", Offset = "0x67C7", VA = "0x67C7")]
		public void UpdateHealth()
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x67C8", Offset = "0x67C8", VA = "0x67C8", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x67C9", Offset = "0x67C9", VA = "0x67C9", Slot = "7")]
		public void UpdateLongEffects()
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x1CAF", Offset = "0x1CAF", VA = "0x1CAF")]
		public void UpdateTurn()
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x67CA", Offset = "0x67CA", VA = "0x67CA", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x67CB", Offset = "0x67CB", VA = "0x67CB", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x67CC", Offset = "0x67CC", VA = "0x67CC", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00005328 File Offset: 0x00003528
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public bool IsInit
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x67CD", Offset = "0x67CD", VA = "0x67CD", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x67CE", Offset = "0x67CE", VA = "0x67CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00005340 File Offset: 0x00003540
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		public bool Select
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x67CF", Offset = "0x67CF", VA = "0x67CF", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x67D0", Offset = "0x67D0", VA = "0x67D0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x67D1", Offset = "0x67D1", VA = "0x67D1", Slot = "17")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x67D2", Offset = "0x67D2", VA = "0x67D2")]
		public VortexCombatPlayerView()
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x67D3", Offset = "0x67D3", VA = "0x67D3", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprView _apr;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _myPlayerMarker;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _turnMarker;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _deathStateMarker;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _glow;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffect _longEffect;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private VortexCombatProgressBar _healBar;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VortexCombatProgressBar _manaByTypeBar;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private VortexCombatProgressBar _commonManaBar;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationParent;
	}
}
