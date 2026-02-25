using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001195 RID: 4501
	[Token(Token = "0x2001195")]
	public class RequirementsInfoProvider : AbstractUserInformationProvider
	{
		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D9")]
		public IInformationProvider CostProvider
		{
			[Token(Token = "0x6006AF3")]
			[Address(RVA = "0xB5FB", Offset = "0xB5FB", VA = "0xB5FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AF4")]
			[Address(RVA = "0xB5FC", Offset = "0xB5FC", VA = "0xB5FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0xB5FD", Offset = "0xB5FD", VA = "0xB5FD", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0xB5FE", Offset = "0xB5FE", VA = "0xB5FE")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IInformationProvider costProvider, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0xB5FF", Offset = "0xB5FF", VA = "0xB5FF")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IList<RestrictionInfo> restrictionInfos)
		{
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0xB600", Offset = "0xB600", VA = "0xB600")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0xB601", Offset = "0xB601", VA = "0xB601", Slot = "9")]
		protected override void PrepareInformation()
		{
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0xB602", Offset = "0xB602", VA = "0xB602")]
		public List<IInformationRow> GetRestrictions()
		{
			return null;
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0xB603", Offset = "0xB603", VA = "0xB603")]
		public List<IInformationRow> GetMaterials()
		{
			return null;
		}

		// Token: 0x0400388B RID: 14475
		[Token(Token = "0x400388B")]
		public const string REQUIREMENTS_RESTRICTIONS = "REQUIREMENTS/RESTRICTIONS";

		// Token: 0x0400388C RID: 14476
		[Token(Token = "0x400388C")]
		public const string REQUIREMENTS_TARGET_RESTRICTIONS = "REQUIREMENTS/TARGET_RESTRICTIONS";

		// Token: 0x0400388D RID: 14477
		[Token(Token = "0x400388D")]
		public const string REQUIREMENTS_MATERIALS = "REQUIREMENTS/MATERIALS";

		// Token: 0x0400388E RID: 14478
		[Token(Token = "0x400388E")]
		[FieldOffset(Offset = "0x1C")]
		public IList<RestrictionInfo> RestrictionInfos;

		// Token: 0x0400388F RID: 14479
		[Token(Token = "0x400388F")]
		[FieldOffset(Offset = "0x20")]
		public IList<RewardInfo> Materials;

		// Token: 0x04003890 RID: 14480
		[Token(Token = "0x4003890")]
		[FieldOffset(Offset = "0x24")]
		public string RestrictionsTitle;

		// Token: 0x04003891 RID: 14481
		[Token(Token = "0x4003891")]
		[FieldOffset(Offset = "0x28")]
		public string MaterialsTitle;
	}
}
