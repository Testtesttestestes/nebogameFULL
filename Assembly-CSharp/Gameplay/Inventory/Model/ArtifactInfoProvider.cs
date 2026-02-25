using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069C RID: 1692
	[Token(Token = "0x200069C")]
	public class ArtifactInfoProvider : AbstractUserInformationProvider, IItemInformationProvider, IInformationProvider, IDisposable
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BE")]
		[CanBeNull]
		public ArtifactData Artifact
		{
			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x79FB", Offset = "0x79FB", VA = "0x79FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x79FC", Offset = "0x79FC", VA = "0x79FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BF")]
		[NotNull]
		public ArtikulData Artikul
		{
			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x79FD", Offset = "0x79FD", VA = "0x79FD", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x79FE", Offset = "0x79FE", VA = "0x79FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00007BA8 File Offset: 0x00005DA8
		// (set) Token: 0x060028E7 RID: 10471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C0")]
		public Color32 UserSkillValuesColor
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x79FF", Offset = "0x79FF", VA = "0x79FF")]
			[CompilerGenerated]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x7A00", Offset = "0x7A00", VA = "0x7A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x7A01", Offset = "0x7A01", VA = "0x7A01", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x7A02", Offset = "0x7A02", VA = "0x7A02")]
		public ArtifactInfoProvider(UserData user, UserData loggedUser, ArtifactData artifact)
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x7A03", Offset = "0x7A03", VA = "0x7A03")]
		public ArtifactInfoProvider(UserData user, UserData loggedUser, ArtikulData artikul)
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x7A04", Offset = "0x7A04", VA = "0x7A04", Slot = "9")]
		protected override void PrepareInformation()
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x7A05", Offset = "0x7A05", VA = "0x7A05", Slot = "11")]
		protected virtual void HandleCollectionRow()
		{
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x7A06", Offset = "0x7A06", VA = "0x7A06")]
		public List<IInformationRow> GetArtikulProps()
		{
			return null;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x7A07", Offset = "0x7A07", VA = "0x7A07")]
		public List<IInformationRow> GetArtifactProps()
		{
			return null;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x7A08", Offset = "0x7A08", VA = "0x7A08")]
		public IInformationRow GetArtifactLevelRow()
		{
			return null;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x7A09", Offset = "0x7A09", VA = "0x7A09")]
		public IInformationRow GetArtifactSellableRow()
		{
			return null;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x7A0A", Offset = "0x7A0A", VA = "0x7A0A")]
		public IInformationRow GetArtifactRepairableRow()
		{
			return null;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x7A0B", Offset = "0x7A0B", VA = "0x7A0B")]
		public IInformationRow GetArtifactDurabilityRow()
		{
			return null;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x7A0C", Offset = "0x7A0C", VA = "0x7A0C")]
		public IInformationRow GetArtifactPriceRow()
		{
			return null;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x7A0D", Offset = "0x7A0D", VA = "0x7A0D")]
		public IInformationRow GetArtifactLifetimeRow()
		{
			return null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x7A0E", Offset = "0x7A0E", VA = "0x7A0E")]
		public IInformationRow GetArtifactLifetimeDescriptionRow()
		{
			return null;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x7A0F", Offset = "0x7A0F", VA = "0x7A0F")]
		public IInformationRow GetCollectionRow()
		{
			return null;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x7A10", Offset = "0x7A10", VA = "0x7A10")]
		public List<IInformationRow> GetSpellProps()
		{
			return null;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x7A11", Offset = "0x7A11", VA = "0x7A11")]
		public List<IInformationRow> GetSpellDescription()
		{
			return null;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x7A12", Offset = "0x7A12", VA = "0x7A12")]
		public List<IInformationRow> GetUserSkills()
		{
			return null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x7A13", Offset = "0x7A13", VA = "0x7A13")]
		public List<IInformationRow> GetUserSkillsMods()
		{
			return null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x7A14", Offset = "0x7A14", VA = "0x7A14")]
		public List<IInformationRow> GetSpellMods()
		{
			return null;
		}

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 GREEN_COLOR;

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 RED_COLOR;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		public const string ARTIFACT_PROPERTIES = "ARTIFACT/PROPERTIES";

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		public const string ARTIFACT_SKILLS = "ARTIFACT/SKILLS";

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		public const string ARTIFACT_SKILLS_MODS = "ARTIFACT/SKILLS_MODS";

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		public const string ARTIFACT_SPELL_MODS = "ARTIFACT/SPELL_MODS";

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		public const string ARTIFACT_TYPE = "ARTIFACT/TYPE";

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		public const string ARTIFACT_QUALITY = "ARTIFACT/QUALITY";

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		public const string ARTIFACT_LEVEL = "ARTIFACT/LEVEL";

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		public const string ARTIFACT_MASTERY = "ARTIFACT/MASTERY";

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		public const string ARTIFACT_CHARGES = "ARTIFACT/CHARGES";

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		public const string ARTIFACT_DURAB = "ARTIFACT/DURAB";

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		public const string ARTIFACT_PRICE = "ARTIFACT/PRICE";

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		public const string ARTIFACT_LIFETIME = "ARTIFACT/LIFETIME";

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		public const string ARTIFACT_PRICE_OF_USE = "ARTIFACT/PRICE_OF_USE";

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		public const string RESTORE_ITEM_HINT_DESC = "RESTORE_ITEM_HINT_DESC";

		// Token: 0x040016A3 RID: 5795
		[Token(Token = "0x40016A3")]
		public const string ARTIFACT_SPELL_DESCRIPTION = "ARTIFACT/SPELL/DESCRIPTION";

		// Token: 0x040016A4 RID: 5796
		[Token(Token = "0x40016A4")]
		public const string ARTIFACT_INDESTRUCTIBLE_VALUE = "ARTIFACT/INDESTRUCTIBLE";

		// Token: 0x040016A5 RID: 5797
		[Token(Token = "0x40016A5")]
		public const string ARTIFACT_SALE_STATUS = "ARTIFACT/SALE_STATUS";

		// Token: 0x040016A6 RID: 5798
		[Token(Token = "0x40016A6")]
		public const string ARTIFACT_NOT_SALE_STATUS_VALUE = "ARTIFACT/NOT_SALE_STATUS";

		// Token: 0x040016A7 RID: 5799
		[Token(Token = "0x40016A7")]
		public const string ARTIFACT_REPAIR_STATUS = "ARTIFACT/REPAIR_STATUS";

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		public const string ARTIFACT_NOT_REPAIR_STATUS_VALUE = "ARTIFACT/NOT_REPAIR_STATUS";

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		public const string ARTIFACT_PROPS = "ARTIFACT/PROPS";

		// Token: 0x040016AA RID: 5802
		[Token(Token = "0x40016AA")]
		public const string ARTIFACT_PROPS_VALUE = "ARTIFACT/PROPS_CLASS";

		// Token: 0x040016AB RID: 5803
		[Token(Token = "0x40016AB")]
		public const string ARTIFACT_COLLECTION = "ARTIFACT/COLLECTION";

		// Token: 0x040016AC RID: 5804
		[Token(Token = "0x40016AC")]
		public const string ARTIFACT_COLLECTION_ANNOTATION = "ARTIFACT/COLLECTION_ANNOTATION";
	}
}
