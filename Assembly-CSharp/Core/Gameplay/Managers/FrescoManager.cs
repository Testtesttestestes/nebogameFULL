using System;
using System.Runtime.CompilerServices;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001167 RID: 4455
	[Token(Token = "0x2001167")]
	public class FrescoManager : IGameManager, IBaseManager
	{
		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06006921 RID: 26913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001583")]
		public string Name
		{
			[Token(Token = "0x6006921")]
			[Address(RVA = "0xB445", Offset = "0xB445", VA = "0xB445", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000286 RID: 646
		// (add) Token: 0x06006922 RID: 26914 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006923 RID: 26915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000286")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006922")]
			[Address(RVA = "0xB446", Offset = "0xB446", VA = "0xB446", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006923")]
			[Address(RVA = "0xB447", Offset = "0xB447", VA = "0xB447", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000287 RID: 647
		// (add) Token: 0x06006924 RID: 26916 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006925 RID: 26917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000287")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006924")]
			[Address(RVA = "0xB448", Offset = "0xB448", VA = "0xB448", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006925")]
			[Address(RVA = "0xB449", Offset = "0xB449", VA = "0xB449", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006927 RID: 26919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001584")]
		public FrescoController Controller
		{
			[Token(Token = "0x6006926")]
			[Address(RVA = "0xB44A", Offset = "0xB44A", VA = "0xB44A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006927")]
			[Address(RVA = "0xB44B", Offset = "0xB44B", VA = "0xB44B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006928")]
		[Address(RVA = "0xB44C", Offset = "0xB44C", VA = "0xB44C")]
		public FrescoManager(IGame game)
		{
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006929")]
		[Address(RVA = "0xB44D", Offset = "0xB44D", VA = "0xB44D", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692A")]
		[Address(RVA = "0xB44E", Offset = "0xB44E", VA = "0xB44E")]
		private void InitEvent()
		{
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692B")]
		[Address(RVA = "0xB44F", Offset = "0xB44F", VA = "0xB44F", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[FieldOffset(Offset = "0x14")]
		private readonly IGame _game;
	}
}
