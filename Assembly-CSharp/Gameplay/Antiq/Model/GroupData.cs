using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	internal class GroupData
	{
		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114F")]
		[CanBeNull]
		public ArtifactData CurrentAchieved
		{
			[Token(Token = "0x6005506")]
			[Address(RVA = "0xA2AB", Offset = "0xA2AB", VA = "0xA2AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005507")]
			[Address(RVA = "0xA2AC", Offset = "0xA2AC", VA = "0xA2AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005508")]
		[Address(RVA = "0xA2AD", Offset = "0xA2AD", VA = "0xA2AD")]
		public GroupData(int index, Antiq.Types.ArtifactGroupsDic artifactGroupsDic, ReadOnlyCollection<ArtifactData> artifacts, CategoryData category)
		{
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005509")]
		[Address(RVA = "0xA2AE", Offset = "0xA2AE", VA = "0xA2AE")]
		public ArtifactData GetArtifact()
		{
			return null;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x600550A")]
		[Address(RVA = "0xA2AF", Offset = "0xA2AF", VA = "0xA2AF")]
		public ulong GetLevel()
		{
			return 0UL;
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x1D29", Offset = "0x1D29", VA = "0x1D29")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x600550C")]
		[Address(RVA = "0xA2B0", Offset = "0xA2B0", VA = "0xA2B0")]
		public bool IsAchieved()
		{
			return default(bool);
		}

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x8")]
		public readonly ReadOnlyCollection<ArtifactData> Artifacts;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.ArtifactGroupsDic ArtifactGroupsDic;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x10")]
		public readonly CategoryData Category;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Index;
	}
}
