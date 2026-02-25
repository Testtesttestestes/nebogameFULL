using System;
using System.Runtime.CompilerServices;
using Gameplay.Battles.Controller;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001143 RID: 4419
	[Token(Token = "0x2001143")]
	public class BattlesManager : IGameManager, IBaseManager
	{
		// Token: 0x14000262 RID: 610
		// (add) Token: 0x060067D0 RID: 26576 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067D1 RID: 26577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000262")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067D0")]
			[Address(RVA = "0xB2FC", Offset = "0xB2FC", VA = "0xB2FC", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067D1")]
			[Address(RVA = "0xB2FD", Offset = "0xB2FD", VA = "0xB2FD", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000263 RID: 611
		// (add) Token: 0x060067D2 RID: 26578 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067D3 RID: 26579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000263")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067D2")]
			[Address(RVA = "0xB2FE", Offset = "0xB2FE", VA = "0xB2FE", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067D3")]
			[Address(RVA = "0xB2FF", Offset = "0xB2FF", VA = "0xB2FF", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001543")]
		public BattlesModel Model
		{
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0xB300", Offset = "0xB300", VA = "0xB300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001544")]
		public BattlesEvents Events
		{
			[Token(Token = "0x60067D5")]
			[Address(RVA = "0xB301", Offset = "0xB301", VA = "0xB301")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001545")]
		public BattlesController Controller
		{
			[Token(Token = "0x60067D6")]
			[Address(RVA = "0xB302", Offset = "0xB302", VA = "0xB302")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D7")]
		[Address(RVA = "0xB303", Offset = "0xB303", VA = "0xB303", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D8")]
		[Address(RVA = "0xB304", Offset = "0xB304", VA = "0xB304", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D9")]
		[Address(RVA = "0xB305", Offset = "0xB305", VA = "0xB305")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001546")]
		public string Name
		{
			[Token(Token = "0x60067DA")]
			[Address(RVA = "0xB306", Offset = "0xB306", VA = "0xB306", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DB")]
		[Address(RVA = "0xB307", Offset = "0xB307", VA = "0xB307")]
		public BattlesManager()
		{
		}

		// Token: 0x0400375D RID: 14173
		[Token(Token = "0x400375D")]
		[FieldOffset(Offset = "0x10")]
		private BattlesModel _model;

		// Token: 0x0400375E RID: 14174
		[Token(Token = "0x400375E")]
		[FieldOffset(Offset = "0x14")]
		private BattlesEvents _events;

		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x18")]
		private BattlesController _controller;

		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x1C")]
		private BattlesEntryPointViewMediator _entryPointViewMediator;
	}
}
