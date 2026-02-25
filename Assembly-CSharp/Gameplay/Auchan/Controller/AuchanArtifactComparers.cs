using System;
using System.Collections.Generic;
using Core.Money;
using Core.Sorting;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class AuchanArtifactComparers
	{
		// Token: 0x06004E7C RID: 20092 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x9CAD", Offset = "0x9CAD", VA = "0x9CAD")]
		private static int CompareQualities(AuchanArtifactData x, AuchanArtifactData y)
		{
			return 0;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x9CAE", Offset = "0x9CAE", VA = "0x9CAE")]
		private static int CompareResourceTypes(Money x, Money y)
		{
			return 0;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x9CAF", Offset = "0x9CAF", VA = "0x9CAF")]
		private static int CompareResourceAmount(Money x, Money y)
		{
			return 0;
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x9CB0", Offset = "0x9CB0", VA = "0x9CB0")]
		private static int CompareArtifactId(AuchanArtifactData x, AuchanArtifactData y)
		{
			return 0;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x9CB1", Offset = "0x9CB1", VA = "0x9CB1")]
		private static int CompareDiscount(AuchanArtifactData x, AuchanArtifactData y)
		{
			return 0;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x9CB2", Offset = "0x9CB2", VA = "0x9CB2")]
		public AuchanArtifactComparers()
		{
		}

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Resources, int> _sortOrder;

		// Token: 0x02000C99 RID: 3225
		[Token(Token = "0x2000C99")]
		public class ByCost : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E83 RID: 20099 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
			[Token(Token = "0x6004E83")]
			[Address(RVA = "0x9CB4", Offset = "0x9CB4", VA = "0x9CB4", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06004E84 RID: 20100 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE6")]
			public override string Title
			{
				[Token(Token = "0x6004E84")]
				[Address(RVA = "0x9CB5", Offset = "0x9CB5", VA = "0x9CB5", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E85")]
			[Address(RVA = "0x9CB6", Offset = "0x9CB6", VA = "0x9CB6")]
			public ByCost()
			{
			}
		}

		// Token: 0x02000C9A RID: 3226
		[Token(Token = "0x2000C9A")]
		public class ByQuality : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E86 RID: 20102 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
			[Token(Token = "0x6004E86")]
			[Address(RVA = "0x9CB7", Offset = "0x9CB7", VA = "0x9CB7", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06004E87 RID: 20103 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE7")]
			public override string Title
			{
				[Token(Token = "0x6004E87")]
				[Address(RVA = "0x9CB8", Offset = "0x9CB8", VA = "0x9CB8", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E88")]
			[Address(RVA = "0x9CB9", Offset = "0x9CB9", VA = "0x9CB9")]
			public ByQuality()
			{
			}
		}

		// Token: 0x02000C9B RID: 3227
		[Token(Token = "0x2000C9B")]
		public class ByDiscount : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E89 RID: 20105 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
			[Token(Token = "0x6004E89")]
			[Address(RVA = "0x9CBA", Offset = "0x9CBA", VA = "0x9CBA", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06004E8A RID: 20106 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE8")]
			public override string Title
			{
				[Token(Token = "0x6004E8A")]
				[Address(RVA = "0x9CBB", Offset = "0x9CBB", VA = "0x9CBB", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E8B RID: 20107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E8B")]
			[Address(RVA = "0x9CBC", Offset = "0x9CBC", VA = "0x9CBC")]
			public ByDiscount()
			{
			}
		}
	}
}
