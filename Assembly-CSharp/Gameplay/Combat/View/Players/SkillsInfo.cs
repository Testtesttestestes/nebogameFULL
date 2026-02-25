using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000952 RID: 2386
	[Token(Token = "0x2000952")]
	public class SkillsInfo : MonoBehaviour
	{
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B23")]
		public Button CloseButton
		{
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x8828", Offset = "0x8828", VA = "0x8828")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B24")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x8829", Offset = "0x8829", VA = "0x8829")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x882A", Offset = "0x882A", VA = "0x882A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B25")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x882B", Offset = "0x882B", VA = "0x882B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x882C", Offset = "0x882C", VA = "0x882C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x882D", Offset = "0x882D", VA = "0x882D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x882E", Offset = "0x882E", VA = "0x882E")]
		private void OnEnable()
		{
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x882F", Offset = "0x882F", VA = "0x882F")]
		public void UpdateInfo()
		{
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x8830", Offset = "0x8830", VA = "0x8830")]
		private void UpdateAntiqInfo()
		{
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x8831", Offset = "0x8831", VA = "0x8831")]
		private string GetEffectResource(Antiq.Types.EffectsDic.Types.EffectID effect)
		{
			return null;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x8832", Offset = "0x8832", VA = "0x8832")]
		private string GetEffectTitle(Antiq.Types.EffectsDic.Types.EffectID effect)
		{
			return null;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x8833", Offset = "0x8833", VA = "0x8833")]
		private string GetEffectValue(long value, uint valueType)
		{
			return null;
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x8834", Offset = "0x8834", VA = "0x8834")]
		public void UpdateBalance()
		{
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x8835", Offset = "0x8835", VA = "0x8835")]
		public bool TryShowLegendStub()
		{
			return default(bool);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x8836", Offset = "0x8836", VA = "0x8836")]
		public SkillsInfo()
		{
		}

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001F3F RID: 7999
		[Token(Token = "0x4001F3F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _antiqContent;

		// Token: 0x04001F40 RID: 8000
		[Token(Token = "0x4001F40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CombatSkillItemRenderer _skillPrefab;

		// Token: 0x04001F41 RID: 8001
		[Token(Token = "0x4001F41")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatUserBalance _balance;

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _legendaryUserStub;

		// Token: 0x04001F44 RID: 8004
		[Token(Token = "0x4001F44")]
		[FieldOffset(Offset = "0x0")]
		public static HashSet<UserSkillsIndexes> RelativeSkillIndexes;

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		[FieldOffset(Offset = "0x30")]
		private List<CombatSkillItemRenderer> _currentItems;
	}
}
