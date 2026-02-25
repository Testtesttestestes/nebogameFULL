using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D8A RID: 3466
	[Token(Token = "0x2000D8A")]
	internal class AntiqModel : AbstractModel
	{
		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001147")]
		public IList<GroupData> Groups
		{
			[Token(Token = "0x60054D1")]
			[Address(RVA = "0xA27C", Offset = "0xA27C", VA = "0xA27C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001148")]
		public GroupData CurrentGroup
		{
			[Token(Token = "0x60054D2")]
			[Address(RVA = "0xA27D", Offset = "0xA27D", VA = "0xA27D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054D3")]
			[Address(RVA = "0xA27E", Offset = "0xA27E", VA = "0xA27E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001149")]
		public ArtifactData CurrentArtifact
		{
			[Token(Token = "0x60054D4")]
			[Address(RVA = "0xA27F", Offset = "0xA27F", VA = "0xA27F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054D5")]
			[Address(RVA = "0xA280", Offset = "0xA280", VA = "0xA280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0xA281", Offset = "0xA281", VA = "0xA281")]
		public AntiqModel(CategoryData defaultCategory, Filter filter, IDictProvider dictProvider, PopupController popupController, UserData user)
		{
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0xA282", Offset = "0xA282", VA = "0xA282")]
		public bool GetIsGroupsScrollEnabled()
		{
			return default(bool);
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0xA283", Offset = "0xA283", VA = "0xA283")]
		public bool GetIsArtifactsScrollEnabled()
		{
			return default(bool);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0xA284", Offset = "0xA284", VA = "0xA284")]
		[NotNull]
		public ReadOnlyCollection<CategoryData> GetCategories()
		{
			return null;
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0xA285", Offset = "0xA285", VA = "0xA285")]
		public void SetArtifacts(IList<ArtifactData> value)
		{
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x1D20", Offset = "0x1D20", VA = "0x1D20")]
		public ArtifactData GetArtifact(ulong id)
		{
			return null;
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0xA286", Offset = "0xA286", VA = "0xA286")]
		public static bool TryGetEffectValue(Antiq.Types.EffectsDic.Types.EffectID effectID, IDictProvider dictProvider, UserData user, out TriggerValue trigger)
		{
			return default(bool);
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0xA287", Offset = "0xA287", VA = "0xA287")]
		public static List<Antiq.Types.EffectsDic.Types.EffectID> GetAntiqEffectsIndexes(UserData user, CombatTypes combatType, UserTypes opponentType)
		{
			return null;
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x1E23", Offset = "0x1E23", VA = "0x1E23")]
		private static bool HasEffectValue(UserData user, Antiq.Types.EffectsDic.Types.EffectID effectID, CombatTypes combatType, UserTypes opponentType)
		{
			return default(bool);
		}

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0xC")]
		private ReadOnlyCollection<CategoryData> _categories;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList<ArtifactData> _artifacts;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x18")]
		public readonly Filter Filter;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x1C")]
		public readonly CategoryData DefaultCategory;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x20")]
		public readonly PopupController PopupController;
	}
}
