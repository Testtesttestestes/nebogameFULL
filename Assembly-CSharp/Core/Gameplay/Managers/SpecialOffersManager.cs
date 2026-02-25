using System;
using System.Runtime.CompilerServices;
using Gameplay.SpecialOffers.Controller;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117A RID: 4474
	[Token(Token = "0x200117A")]
	public class SpecialOffersManager : IGameManager, IBaseManager
	{
		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x060069E6 RID: 27110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015AB")]
		public string Name
		{
			[Token(Token = "0x60069E6")]
			[Address(RVA = "0xB506", Offset = "0xB506", VA = "0xB506", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A0 RID: 672
		// (add) Token: 0x060069E7 RID: 27111 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069E8 RID: 27112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069E7")]
			[Address(RVA = "0xB507", Offset = "0xB507", VA = "0xB507", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069E8")]
			[Address(RVA = "0xB508", Offset = "0xB508", VA = "0xB508", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A1 RID: 673
		// (add) Token: 0x060069E9 RID: 27113 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069EA RID: 27114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069E9")]
			[Address(RVA = "0xB509", Offset = "0xB509", VA = "0xB509", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069EA")]
			[Address(RVA = "0xB50A", Offset = "0xB50A", VA = "0xB50A", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AC")]
		public SpecialOffersController Controller
		{
			[Token(Token = "0x60069EB")]
			[Address(RVA = "0xB50B", Offset = "0xB50B", VA = "0xB50B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069EC")]
			[Address(RVA = "0xB50C", Offset = "0xB50C", VA = "0xB50C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AD")]
		public SpecialOffersEvents Events
		{
			[Token(Token = "0x60069ED")]
			[Address(RVA = "0xB50D", Offset = "0xB50D", VA = "0xB50D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069EE")]
			[Address(RVA = "0xB50E", Offset = "0xB50E", VA = "0xB50E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AE")]
		public SpecialOffersModel Model
		{
			[Token(Token = "0x60069EF")]
			[Address(RVA = "0xB50F", Offset = "0xB50F", VA = "0xB50F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069F0")]
			[Address(RVA = "0xB510", Offset = "0xB510", VA = "0xB510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F1")]
		[Address(RVA = "0xB511", Offset = "0xB511", VA = "0xB511")]
		public SpecialOffersManager(IGame game)
		{
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F2")]
		[Address(RVA = "0xB512", Offset = "0xB512", VA = "0xB512", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F3")]
		[Address(RVA = "0xB513", Offset = "0xB513", VA = "0xB513", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0xB514", Offset = "0xB514", VA = "0xB514")]
		private void SpecialOffersRequestedEventHandler()
		{
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0xB515", Offset = "0xB515", VA = "0xB515")]
		public void ShowSpecialOffersWindowScheduled()
		{
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F6")]
		[Address(RVA = "0xB516", Offset = "0xB516", VA = "0xB516")]
		public void ShowSpecialOffersWindow(WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0xB517", Offset = "0xB517", VA = "0xB517")]
		private void SetupMVC()
		{
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0xB518", Offset = "0xB518", VA = "0xB518")]
		private void DestroyMVC()
		{
		}

		// Token: 0x04003826 RID: 14374
		[Token(Token = "0x4003826")]
		[FieldOffset(Offset = "0x1C")]
		private IGame _game;
	}
}
