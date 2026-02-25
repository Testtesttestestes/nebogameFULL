using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Discounts.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;
using Protocol.Main;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D65 RID: 3429
	[Token(Token = "0x2000D65")]
	public class AprsModel : AbstractModel
	{
		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005410 RID: 21520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111A")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600540F")]
			[Address(RVA = "0xA1C6", Offset = "0xA1C6", VA = "0xA1C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005410")]
			[Address(RVA = "0xA1C7", Offset = "0xA1C7", VA = "0xA1C7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111B")]
		public IGame Game
		{
			[Token(Token = "0x6005411")]
			[Address(RVA = "0xA1C8", Offset = "0xA1C8", VA = "0xA1C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005412")]
			[Address(RVA = "0xA1C9", Offset = "0xA1C9", VA = "0xA1C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111C")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6005413")]
			[Address(RVA = "0xA1CA", Offset = "0xA1CA", VA = "0xA1CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005414")]
			[Address(RVA = "0xA1CB", Offset = "0xA1CB", VA = "0xA1CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700111D")]
		public AprDicGroupStorage AprDicGroupStorage
		{
			[Token(Token = "0x6005415")]
			[Address(RVA = "0xA1CC", Offset = "0xA1CC", VA = "0xA1CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111E")]
		public Dictionary<uint, AprData> AprDataByMedalId
		{
			[Token(Token = "0x6005416")]
			[Address(RVA = "0xA1CD", Offset = "0xA1CD", VA = "0xA1CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005417")]
			[Address(RVA = "0xA1CE", Offset = "0xA1CE", VA = "0xA1CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111F")]
		public List<MedalCategoryDic> VisibleCategories
		{
			[Token(Token = "0x6005418")]
			[Address(RVA = "0xA1CF", Offset = "0xA1CF", VA = "0xA1CF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005419")]
			[Address(RVA = "0xA1D0", Offset = "0xA1D0", VA = "0xA1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001120")]
		public Dictionary<uint, List<AprData>> VisibleAprs
		{
			[Token(Token = "0x600541A")]
			[Address(RVA = "0xA1D1", Offset = "0xA1D1", VA = "0xA1D1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541B")]
			[Address(RVA = "0xA1D2", Offset = "0xA1D2", VA = "0xA1D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001121")]
		public List<AprData> AllVisibleAprs
		{
			[Token(Token = "0x600541C")]
			[Address(RVA = "0xA1D3", Offset = "0xA1D3", VA = "0xA1D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541D")]
			[Address(RVA = "0xA1D4", Offset = "0xA1D4", VA = "0xA1D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001122")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x600541E")]
			[Address(RVA = "0xA1D5", Offset = "0xA1D5", VA = "0xA1D5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541F")]
			[Address(RVA = "0xA1D6", Offset = "0xA1D6", VA = "0xA1D6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001123")]
		public int BuyProcessCount
		{
			[Token(Token = "0x6005420")]
			[Address(RVA = "0xA1D7", Offset = "0xA1D7", VA = "0xA1D7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005421")]
			[Address(RVA = "0xA1D8", Offset = "0xA1D8", VA = "0xA1D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005422")]
		[Address(RVA = "0xA1D9", Offset = "0xA1D9", VA = "0xA1D9", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005423")]
		[Address(RVA = "0xA1DA", Offset = "0xA1DA", VA = "0xA1DA")]
		public AprsModel(UserData user, UserData loggedUser, IGame game, IDictProvider dictProvider, AprDicGroupStorage aprDicGroupStorage)
		{
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6005424")]
		[Address(RVA = "0xA1DB", Offset = "0xA1DB", VA = "0xA1DB")]
		public bool TryGetAprDataByAprId(uint aprId, out AprData data)
		{
			return default(bool);
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6005425")]
		[Address(RVA = "0xA1DC", Offset = "0xA1DC", VA = "0xA1DC")]
		public bool TryGetAprDataByAprId(uint medalId, uint aprId, out AprData data)
		{
			return default(bool);
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005426")]
		[Address(RVA = "0xA1DD", Offset = "0xA1DD", VA = "0xA1DD")]
		public void SetMedals(RepeatedField<MedalInfo> medalInfos)
		{
		}

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x18")]
		private AprDicGroupStorage _aprDicGroupStorage;
	}
}
