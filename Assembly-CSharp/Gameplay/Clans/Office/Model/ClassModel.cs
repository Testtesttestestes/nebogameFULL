using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Data;
using Core.Data.Skills;
using Core.Gameplay.Managers;
using Gameplay.School.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Main;
using Protocol.School;
using UI.Elements.Buildings;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x2000A51")]
	public class ClassModel : AbstractModel
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C87")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E86")]
			[Address(RVA = "0x8D45", Offset = "0x8D45", VA = "0x8D45")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x8D46", Offset = "0x8D46", VA = "0x8D46")]
		public ClassModel(UserData user, WorldAxisManager worldAxisManager)
		{
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E89 RID: 16009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C88")]
		public Dictionary<ulong, SpellListArgs> SpellsByDollById
		{
			[Token(Token = "0x6003E88")]
			[Address(RVA = "0x8D47", Offset = "0x8D47", VA = "0x8D47")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E89")]
			[Address(RVA = "0x8D48", Offset = "0x8D48", VA = "0x8D48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C89")]
		public Dictionary<uint, SchoolSpellData> SpellsById
		{
			[Token(Token = "0x6003E8A")]
			[Address(RVA = "0x8D49", Offset = "0x8D49", VA = "0x8D49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8B")]
			[Address(RVA = "0x8D4A", Offset = "0x8D4A", VA = "0x8D4A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8A")]
		public Dictionary<int, ArtifactData> ArtifactsBySlotId
		{
			[Token(Token = "0x6003E8C")]
			[Address(RVA = "0x8D4B", Offset = "0x8D4B", VA = "0x8D4B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8D")]
			[Address(RVA = "0x8D4C", Offset = "0x8D4C", VA = "0x8D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8B")]
		public SubFilterListElement.SubFilterData[] SubFilterData
		{
			[Token(Token = "0x6003E8E")]
			[Address(RVA = "0x8D4D", Offset = "0x8D4D", VA = "0x8D4D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8F")]
			[Address(RVA = "0x8D4E", Offset = "0x8D4E", VA = "0x8D4E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E91 RID: 16017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8C")]
		public Dictionary<ulong, ClassModel.DollData> DollDataById
		{
			[Token(Token = "0x6003E90")]
			[Address(RVA = "0x8D4F", Offset = "0x8D4F", VA = "0x8D4F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E91")]
			[Address(RVA = "0x8D50", Offset = "0x8D50", VA = "0x8D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x8D51", Offset = "0x8D51", VA = "0x8D51")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x8D52", Offset = "0x8D52", VA = "0x8D52")]
		public void ParseSlotChanges(IList<UserArtifact> artifacts)
		{
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x8D53", Offset = "0x8D53", VA = "0x8D53")]
		public void PopulateSpells(ProtoGetSchoolInfoAns msg, ulong dollId)
		{
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x8D54", Offset = "0x8D54", VA = "0x8D54")]
		private SubFilterListElement.SubFilterData CreateSubFilters(DollsInfoDic dic)
		{
			return null;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x1C80", Offset = "0x1C80", VA = "0x1C80")]
		private void SetArtifact(int slotId, ArtifactInfo artifactInfo)
		{
		}

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0xC")]
		private readonly ArtifactCache _cache;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x10")]
		public readonly UserData GolemUserData;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x14")]
		public readonly WorldAxisManager WorldAxisManager;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x18")]
		public readonly HashSet<uint> CustomSkillIds;

		// Token: 0x02000A52 RID: 2642
		[Token(Token = "0x2000A52")]
		public class DollData
		{
			// Token: 0x06003E99 RID: 16025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E99")]
			[Address(RVA = "0x8D57", Offset = "0x8D57", VA = "0x8D57")]
			public DollData(UserData user, Dictionaries dict)
			{
			}

			// Token: 0x04002336 RID: 9014
			[Token(Token = "0x4002336")]
			[FieldOffset(Offset = "0x8")]
			public readonly UserData UserData;

			// Token: 0x04002337 RID: 9015
			[Token(Token = "0x4002337")]
			[FieldOffset(Offset = "0xC")]
			public SkillCollection Skills;

			// Token: 0x04002338 RID: 9016
			[Token(Token = "0x4002338")]
			[FieldOffset(Offset = "0x10")]
			public bool IsDirty;

			// Token: 0x04002339 RID: 9017
			[Token(Token = "0x4002339")]
			[FieldOffset(Offset = "0x14")]
			public DollsInfoDic Dic;
		}
	}
}
