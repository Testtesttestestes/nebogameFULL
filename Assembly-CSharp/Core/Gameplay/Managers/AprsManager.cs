using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Discounts;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113F RID: 4415
	[Token(Token = "0x200113F")]
	public class AprsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001531")]
		public string Name
		{
			[Token(Token = "0x6006781")]
			[Address(RVA = "0xB2AD", Offset = "0xB2AD", VA = "0xB2AD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400025A RID: 602
		// (add) Token: 0x06006782 RID: 26498 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006783 RID: 26499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006782")]
			[Address(RVA = "0xB2AE", Offset = "0xB2AE", VA = "0xB2AE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006783")]
			[Address(RVA = "0xB2AF", Offset = "0xB2AF", VA = "0xB2AF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025B RID: 603
		// (add) Token: 0x06006784 RID: 26500 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006785 RID: 26501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006784")]
			[Address(RVA = "0xB2B0", Offset = "0xB2B0", VA = "0xB2B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006785")]
			[Address(RVA = "0xB2B1", Offset = "0xB2B1", VA = "0xB2B1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001532")]
		public AprsController Controller
		{
			[Token(Token = "0x6006786")]
			[Address(RVA = "0xB2B2", Offset = "0xB2B2", VA = "0xB2B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001533")]
		public AprsModel Model
		{
			[Token(Token = "0x6006787")]
			[Address(RVA = "0xB2B3", Offset = "0xB2B3", VA = "0xB2B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001534")]
		public AprsEvents Events
		{
			[Token(Token = "0x6006788")]
			[Address(RVA = "0xB2B4", Offset = "0xB2B4", VA = "0xB2B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001535")]
		public IGame Game
		{
			[Token(Token = "0x6006789")]
			[Address(RVA = "0xB2B5", Offset = "0xB2B5", VA = "0xB2B5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600678A")]
			[Address(RVA = "0xB2B6", Offset = "0xB2B6", VA = "0xB2B6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001536")]
		public AprDicGroupStorage AprDicGroupStorage
		{
			[Token(Token = "0x600678B")]
			[Address(RVA = "0xB2B7", Offset = "0xB2B7", VA = "0xB2B7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600678C")]
			[Address(RVA = "0xB2B8", Offset = "0xB2B8", VA = "0xB2B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678D")]
		[Address(RVA = "0xB2B9", Offset = "0xB2B9", VA = "0xB2B9")]
		public AprsManager(IGame game)
		{
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678E")]
		[Address(RVA = "0xB2BA", Offset = "0xB2BA", VA = "0xB2BA", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678F")]
		[Address(RVA = "0xB2BB", Offset = "0xB2BB", VA = "0xB2BB")]
		private void ResolveDiscountsProvider()
		{
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006790")]
		[Address(RVA = "0xB2BC", Offset = "0xB2BC", VA = "0xB2BC")]
		private void SetupMvc()
		{
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006791")]
		[Address(RVA = "0xB2BD", Offset = "0xB2BD", VA = "0xB2BD")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006792")]
		[Address(RVA = "0xB2BE", Offset = "0xB2BE", VA = "0xB2BE")]
		private void ControllerInitEvent()
		{
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006793")]
		[Address(RVA = "0xB2BF", Offset = "0xB2BF", VA = "0xB2BF")]
		private void HandleDictProviderChanged()
		{
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006794")]
		[Address(RVA = "0xB2C0", Offset = "0xB2C0", VA = "0xB2C0", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006795")]
		[Address(RVA = "0xB2C1", Offset = "0xB2C1", VA = "0xB2C1")]
		public void ShowOwnAprInfoWindow(uint medalId, AprDic dict)
		{
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006796")]
		[Address(RVA = "0xB2C2", Offset = "0xB2C2", VA = "0xB2C2")]
		public void ShowOwnAprInfoWindow(AprDic aprDic)
		{
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006797")]
		[Address(RVA = "0xB2C3", Offset = "0xB2C3", VA = "0xB2C3")]
		public void ShowAprInfoWindow(AprData aprData, List<AprData> currentAprListList, AprsController controller, AprsEvents events, AprsModel model)
		{
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006798")]
		[Address(RVA = "0xB2C4", Offset = "0xB2C4", VA = "0xB2C4")]
		public void ShowAprsWindow()
		{
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006799")]
		[Address(RVA = "0xB2C5", Offset = "0xB2C5", VA = "0xB2C5")]
		public void ShowAprsWindow(Predicate<AprData> customFilter)
		{
		}

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x10")]
		private AprsController _controller;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x14")]
		private AprsModel _model;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x18")]
		private AprsEvents _events;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x1C")]
		private Discounts _discounts;
	}
}
