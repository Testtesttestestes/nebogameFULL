using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Discounts.Controller;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001164 RID: 4452
	[Token(Token = "0x2001164")]
	public class DiscountsManager : IGameManager, IBaseManager, IDiscountHandler
	{
		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700157B")]
		public string Name
		{
			[Token(Token = "0x60068F6")]
			[Address(RVA = "0xB41A", Offset = "0xB41A", VA = "0xB41A", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000280 RID: 640
		// (add) Token: 0x060068F7 RID: 26871 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068F8 RID: 26872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000280")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068F7")]
			[Address(RVA = "0xB41B", Offset = "0xB41B", VA = "0xB41B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068F8")]
			[Address(RVA = "0xB41C", Offset = "0xB41C", VA = "0xB41C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000281 RID: 641
		// (add) Token: 0x060068F9 RID: 26873 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068FA RID: 26874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000281")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068F9")]
			[Address(RVA = "0xB41D", Offset = "0xB41D", VA = "0xB41D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068FA")]
			[Address(RVA = "0xB41E", Offset = "0xB41E", VA = "0xB41E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700157C")]
		public IDiscountsProvider DiscountsProvider
		{
			[Token(Token = "0x60068FB")]
			[Address(RVA = "0xB41F", Offset = "0xB41F", VA = "0xB41F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x060068FC RID: 26876 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068FD RID: 26877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157D")]
		public DiscountsModel Model
		{
			[Token(Token = "0x60068FC")]
			[Address(RVA = "0xB420", Offset = "0xB420", VA = "0xB420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068FD")]
			[Address(RVA = "0xB421", Offset = "0xB421", VA = "0xB421")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x060068FE RID: 26878 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068FF RID: 26879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157E")]
		public DiscountsController Controller
		{
			[Token(Token = "0x60068FE")]
			[Address(RVA = "0xB422", Offset = "0xB422", VA = "0xB422")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068FF")]
			[Address(RVA = "0xB423", Offset = "0xB423", VA = "0xB423")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157F")]
		public DiscountsEvents Events
		{
			[Token(Token = "0x6006900")]
			[Address(RVA = "0xB424", Offset = "0xB424", VA = "0xB424")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006901")]
			[Address(RVA = "0xB425", Offset = "0xB425", VA = "0xB425")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006902")]
		[Address(RVA = "0xB426", Offset = "0xB426", VA = "0xB426")]
		public DiscountsManager(IGame game)
		{
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006903")]
		[Address(RVA = "0xB427", Offset = "0xB427", VA = "0xB427", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006904")]
		[Address(RVA = "0xB428", Offset = "0xB428", VA = "0xB428")]
		private void ResolveDiscountsProvider()
		{
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006905")]
		[Address(RVA = "0xB429", Offset = "0xB429", VA = "0xB429", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006906")]
		[Address(RVA = "0xB42A", Offset = "0xB42A", VA = "0xB42A", Slot = "11")]
		public void Handle(IDiscountTarget target)
		{
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x6006907")]
		[Address(RVA = "0xB42B", Offset = "0xB42B", VA = "0xB42B")]
		public static bool AllowShowDiscounts(UserData userData)
		{
			return default(bool);
		}

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		private const int MIN_LEVEL_TO_SHOW_DISCOUNTS = 4;

		// Token: 0x040037C1 RID: 14273
		[Token(Token = "0x40037C1")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IGame _game;

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		[FieldOffset(Offset = "0x20")]
		private readonly DiscountsProviderDecorator _discountsProviderDecorator;
	}
}
