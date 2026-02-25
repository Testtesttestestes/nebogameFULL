using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Billing.PurchaseProcess;
using Gameplay.Billing.Controller;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing
{
	// Token: 0x020011F0 RID: 4592
	[Token(Token = "0x20011F0")]
	public class BillingManager : IGameManager, IBaseManager
	{
		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001632")]
		public string Name
		{
			[Token(Token = "0x6006D14")]
			[Address(RVA = "0xB7FD", Offset = "0xB7FD", VA = "0xB7FD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002CF RID: 719
		// (add) Token: 0x06006D15 RID: 27925 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D16 RID: 27926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CF")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D15")]
			[Address(RVA = "0xB7FE", Offset = "0xB7FE", VA = "0xB7FE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D16")]
			[Address(RVA = "0xB7FF", Offset = "0xB7FF", VA = "0xB7FF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D0 RID: 720
		// (add) Token: 0x06006D17 RID: 27927 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D18 RID: 27928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D0")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D17")]
			[Address(RVA = "0xB800", Offset = "0xB800", VA = "0xB800", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D18")]
			[Address(RVA = "0xB801", Offset = "0xB801", VA = "0xB801", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001633")]
		public BillingEvents Events
		{
			[Token(Token = "0x6006D19")]
			[Address(RVA = "0xB802", Offset = "0xB802", VA = "0xB802")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1A")]
			[Address(RVA = "0xB803", Offset = "0xB803", VA = "0xB803")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001634")]
		public IPurchaseProcess PurchaseProcess
		{
			[Token(Token = "0x6006D1B")]
			[Address(RVA = "0xB804", Offset = "0xB804", VA = "0xB804")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1C")]
			[Address(RVA = "0xB805", Offset = "0xB805", VA = "0xB805")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1E RID: 27934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001635")]
		public AbstractBillingModel Model
		{
			[Token(Token = "0x6006D1D")]
			[Address(RVA = "0xB806", Offset = "0xB806", VA = "0xB806")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1E")]
			[Address(RVA = "0xB807", Offset = "0xB807", VA = "0xB807")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0xB808", Offset = "0xB808", VA = "0xB808")]
		public BillingManager(IGame game, IAuthDataProvider authDataProvider)
		{
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0xB809", Offset = "0xB809", VA = "0xB809", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0xB80A", Offset = "0xB80A", VA = "0xB80A", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0xB80B", Offset = "0xB80B", VA = "0xB80B")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D23")]
		[Address(RVA = "0xB80C", Offset = "0xB80C", VA = "0xB80C")]
		private void SetupMvc()
		{
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0xB80D", Offset = "0xB80D", VA = "0xB80D")]
		public void ConsumePurchasesIfExist()
		{
		}

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		public const string DefaultBillingPlayerPrefsName = "defaultBillingId";

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x1C")]
		private AbstractBillingController _controller;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x20")]
		private readonly IAuthTokenSource _bankTokenSource;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x24")]
		private readonly IAuthDataProvider _authDataProvider;

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0x28")]
		private readonly IGame _game;
	}
}
