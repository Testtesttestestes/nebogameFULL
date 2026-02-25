using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Base.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Common;
using Utils;

namespace Gameplay.Isles.Clan.Model
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000CF3")]
	public class ClanIsleModel : BaseIsleModel
	{
		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104E")]
		public ClanData ClanData
		{
			[Token(Token = "0x60050A8")]
			[Address(RVA = "0x9EB7", Offset = "0x9EB7", VA = "0x9EB7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104F")]
		public BackTime GolemRecoveryBacktime
		{
			[Token(Token = "0x60050A9")]
			[Address(RVA = "0x9EB8", Offset = "0x9EB8", VA = "0x9EB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050AA")]
			[Address(RVA = "0x9EB9", Offset = "0x9EB9", VA = "0x9EB9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x17001050")]
		public bool GolemHasShield
		{
			[Token(Token = "0x60050AB")]
			[Address(RVA = "0x9EBA", Offset = "0x9EBA", VA = "0x9EBA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001051")]
		public BaseBuildingData GolemBuildingData
		{
			[Token(Token = "0x60050AC")]
			[Address(RVA = "0x9EBB", Offset = "0x9EBB", VA = "0x9EBB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x9EBC", Offset = "0x9EBC", VA = "0x9EBC")]
		public ClanIsleModel(UserData user, ClanData clanData, IDictProvider dictionaries, IGame game)
		{
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001052")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation IsleInformation
		{
			[Token(Token = "0x60050AE")]
			[Address(RVA = "0x9EBD", Offset = "0x9EBD", VA = "0x9EBD")]
			get
			{
				return null;
			}
			[Token(Token = "0x60050AF")]
			[Address(RVA = "0x9EBE", Offset = "0x9EBE", VA = "0x9EBE")]
			set
			{
			}
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x9EBF", Offset = "0x9EBF", VA = "0x9EBF")]
		public void SetGolemRecoveryBacktime(uint value)
		{
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x9EC0", Offset = "0x9EC0", VA = "0x9EC0")]
		public ResourceSet GetCancelImproveMoneyBack(uint buildingType)
		{
			return null;
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x9EC1", Offset = "0x9EC1", VA = "0x9EC1")]
		public string GetBgAssetId()
		{
			return null;
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x9EC2", Offset = "0x9EC2", VA = "0x9EC2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x17001053")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x60050B4")]
			[Address(RVA = "0x9EC3", Offset = "0x9EC3", VA = "0x9EC3")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x38")]
		private ProtoGetIsleInfoAns.Types.ClanIsleInformation _isleInformation;
	}
}
