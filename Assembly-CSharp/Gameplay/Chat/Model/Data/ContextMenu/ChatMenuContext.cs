using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using UI.UserContextMenu;

namespace Gameplay.Chat.Model.Data.ContextMenu
{
	// Token: 0x02000B1D RID: 2845
	[Token(Token = "0x2000B1D")]
	public class ChatMenuContext : IChatMenuContext, IUserMenuContext
	{
		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA2")]
		public UserData User
		{
			[Token(Token = "0x60044C0")]
			[Address(RVA = "0x9366", Offset = "0x9366", VA = "0x9366", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60044C1")]
			[Address(RVA = "0x9367", Offset = "0x9367", VA = "0x9367", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA3")]
		public ChatVisitorData Visitor
		{
			[Token(Token = "0x60044C2")]
			[Address(RVA = "0x9368", Offset = "0x9368", VA = "0x9368", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044C3")]
			[Address(RVA = "0x9369", Offset = "0x9369", VA = "0x9369", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA4")]
		public ChatMessageItem MessageItem
		{
			[Token(Token = "0x60044C4")]
			[Address(RVA = "0x936A", Offset = "0x936A", VA = "0x936A", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044C5")]
			[Address(RVA = "0x936B", Offset = "0x936B", VA = "0x936B", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA5")]
		public ChatController Controller
		{
			[Token(Token = "0x60044C6")]
			[Address(RVA = "0x936C", Offset = "0x936C", VA = "0x936C", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044C7")]
			[Address(RVA = "0x936D", Offset = "0x936D", VA = "0x936D", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x936E", Offset = "0x936E", VA = "0x936E")]
		public ChatMenuContext()
		{
		}
	}
}
